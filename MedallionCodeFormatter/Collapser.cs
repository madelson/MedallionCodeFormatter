using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    public sealed class Collapser
    {
        private readonly Dictionary<SyntaxToken, KeyValuePair<SyntaxTriviaList, SyntaxAnnotation>> remappedLeadingTriviaAndAnnotation =
            new Dictionary<SyntaxToken, KeyValuePair<SyntaxTriviaList, SyntaxAnnotation>>();
        private readonly Dictionary<SyntaxToken, SyntaxTriviaList> remappedTrailingTrivia = 
            new Dictionary<SyntaxToken, SyntaxTriviaList>();

        private static readonly SyntaxTriviaList SingleWhitespaceList = SyntaxFactory.TriviaList(SyntaxFactory.Space);
        
        private List<SyntaxTrivia> cachedTriviaBuffer = new List<SyntaxTrivia>();

        private Collapser()
        {
        }

        public static SyntaxNode Collapse(SyntaxNode node)
        {
            return new Collapser().InternalCollapse(node);
        }

        private SyntaxNode InternalCollapse(SyntaxNode node)
        {
            var tokens = node.DescendantTokens()
                .ToList();

            for (var i = 0; i <= tokens.Count; ++i)
            {
                if (i == 0) { ProcessAdjacentTokens(default(SyntaxToken), tokens[i]); }
                else if (i == tokens.Count) { ProcessAdjacentTokens(tokens[i - 1], default(SyntaxToken)); }
                else { ProcessAdjacentTokens(tokens[i - 1], tokens[i]); }
            }

            var replaced = node.ReplaceTokens(
                this.remappedLeadingTriviaAndAnnotation.Keys
                    .Union(this.remappedTrailingTrivia.Keys),
                (token, _) =>
                {
                    var result = token;

                    SyntaxTriviaList trailingTrivia;
                    if (this.remappedTrailingTrivia.TryGetValue(token, out trailingTrivia))
                    {
                        result = result.WithTrailingTrivia(trailingTrivia);
                    }
                    KeyValuePair<SyntaxTriviaList, SyntaxAnnotation> leadingTriviaAndAnnotation;
                    if (this.remappedLeadingTriviaAndAnnotation.TryGetValue(token, out leadingTriviaAndAnnotation))
                    {
                        result = result.WithLeadingTrivia(leadingTriviaAndAnnotation.Key);
                        if (leadingTriviaAndAnnotation.Value != null)
                        {
                            result = result.WithAdditionalAnnotations(leadingTriviaAndAnnotation.Value);
                        }
                    }

                    return result;
                }
            );
            
            return replaced;
        }

        private void ProcessAdjacentTokens(SyntaxToken previous, SyntaxToken next)
        {
            var triviaBuffer = this.cachedTriviaBuffer;
            triviaBuffer.Clear();

            foreach (var previousTrailing in previous.TrailingTrivia)
            {
                this.BufferTrivia(triviaBuffer, previousTrailing);
            }

            foreach (var nextLeading in next.LeadingTrivia)
            {
                this.BufferTrivia(triviaBuffer, nextLeading);
            }

            var spacingPolicy = GetSpacingPolicy(previous, next);
            
            // check for trailing trivia. A single line comment is ok; everything else is not
            var hasTrailingTrivia = triviaBuffer.Count > 0
                && (
                    triviaBuffer[0].IsKind(SyntaxKind.SingleLineCommentTrivia)
                    || (triviaBuffer[0].IsKind(SyntaxKind.MultiLineCommentTrivia) && triviaBuffer[0].ToFullString().IndexOf('\n') < 0)
                );
            if (hasTrailingTrivia)
            {
                this.remappedTrailingTrivia.Add(previous, SingleWhitespaceList.Add(triviaBuffer[0]));
                triviaBuffer.RemoveAt(0);
                // TODO having a trailing comment like this should block the ban newlines policy, but at the same time { and (
                // shouldn't even be allowed trailing comments...
            }
            else if (previous.TrailingTrivia.Any())
            {
                this.remappedTrailingTrivia.Add(previous, SyntaxTriviaList.Empty);
            }

            // now calculate leading trivia

            // get trivial into canonical form
            this.MergeSingleLineComments(triviaBuffer);
            this.MergeNewLines(triviaBuffer, spacingPolicy, hadTrailingTrivia: hasTrailingTrivia);

            // split into annotation and trailing
            SyntaxAnnotation multiLineAnnotation;
            SyntaxTriviaList leadingTrivia;
            this.SplitOutMultiLineTriviaAndAddSpacing(triviaBuffer, spacingPolicy, out multiLineAnnotation, out leadingTrivia);

            this.remappedLeadingTriviaAndAnnotation.Add(
                next,
                new KeyValuePair<SyntaxTriviaList, SyntaxAnnotation>(leadingTrivia, multiLineAnnotation)
            );
        }

        private void BufferTrivia(List<SyntaxTrivia> buffer, SyntaxTrivia trivia)
        {
            if (trivia.IsKind(SyntaxKind.WhitespaceTrivia))
            {
                return; // skip whitespace
            }
            if (trivia.IsKind(SyntaxKind.EndOfLineTrivia))
            {
                // swap out \r\n for \n to simplify line measurements later
                buffer.Add(SyntaxFactory.LineFeed);
            }

            if (trivia.HasStructure)
            {
                // break out structured trivia

                var node = (StructuredTriviaSyntax)trivia.GetStructure();
                foreach (var leading in node.GetLeadingTrivia())
                {
                    buffer.Add(leading);
                }

                buffer.Add(SyntaxFactory.Trivia(node.WithLeadingTrivia(SyntaxTriviaList.Empty).WithTrailingTrivia(SyntaxTriviaList.Empty)));

                foreach (var trailing in node.GetTrailingTrivia())
                {
                    buffer.Add(trailing);
                }
            }
        }

        private void MergeSingleLineComments(List<SyntaxTrivia> buffer)
        {
            var state = SingleLineCommentMergeState.None;
            var singleLineCommentStart = -1;
            for (var i = 0; i <= buffer.Count; ++i)
            {
                if (i == buffer.Count)
                {
                    state = SingleLineCommentMergeState.None;
                }
                else if (buffer[i].IsKind(SyntaxKind.EndOfLineTrivia))
                {
                    if (state == SingleLineCommentMergeState.SawSingleLineComment)
                    {
                        state = SingleLineCommentMergeState.SawSingleLineCommentAndNewLine;
                    }
                    else if (state == SingleLineCommentMergeState.SawCommentedOutCode)
                    {
                        state = SingleLineCommentMergeState.SawCommentedOutCodeAndNewLine;
                    }
                    else
                    {
                        state = SingleLineCommentMergeState.None;
                    }
                }
                else if (buffer[i].IsKind(SyntaxKind.SingleLineCommentTrivia))
                {
                    var commentText = buffer[i].ToFullString();
                    // not // or //fdafd but // fdsfsd
                    var isNormalSingleLineComment = commentText.Length > 3
                        && char.IsWhiteSpace(commentText[2])
                        && !char.IsWhiteSpace(commentText[3]);
                    if ( state == SingleLineCommentMergeState.SawSingleLineCommentAndNewLine && isNormalSingleLineComment)
                    {
                        state = SingleLineCommentMergeState.SawSingleLineComment;
                    }
                    else if (state == SingleLineCommentMergeState.SawCommentedOutCodeAndNewLine || !isNormalSingleLineComment)
                    {
                        state = SingleLineCommentMergeState.SawCommentedOutCode;
                    }
                    else
                    {
                        singleLineCommentStart = i;
                        state = SingleLineCommentMergeState.SawSingleLineComment;
                    }
                }
                else
                {
                    state = SingleLineCommentMergeState.None;
                }

                // if we just finished a comment, merge it
                if (singleLineCommentStart >= 0
                    && state != SingleLineCommentMergeState.SawSingleLineComment
                    && state != SingleLineCommentMergeState.SawSingleLineCommentAndNewLine)
                {
                    var count = i - singleLineCommentStart;
                    var newCommentText = Enumerable.Range(singleLineCommentStart, count: count)
                        .Aggregate(new StringBuilder("//"), (sb, index) => sb.Append(' ').Append(buffer[index].ToFullString().Trim()))
                        .ToString();
                    if (count > 1)
                    {
                        buffer.RemoveRange(singleLineCommentStart + 1, count - 1);
                    }
                    buffer[singleLineCommentStart] = SyntaxFactory.Comment(newCommentText);
                    i = singleLineCommentStart + 1;
                    singleLineCommentStart = -1;
                }
            }
        }

        private void MergeNewLines(List<SyntaxTrivia> buffer, TokenSpacingPolicy spacingPolicy, bool hadTrailingTrivia)
        {
            // if we have only one trivia entry, either:
            // (1) it's a newline, in which case we can remove it unless it followed some trailing trivia
            // (2) it's not a newline, in which case nothing will be removed so just return
            if (buffer.Count == 1)
            {
                if (!hadTrailingTrivia && buffer[0].IsKind(SyntaxKind.EndOfLineTrivia))
                {
                    buffer.Clear();
                }
                return;
            }

            var newLineStart = -1;
            for (var i = 0; i <= buffer.Count; ++i)
            {
                if (i < buffer.Count && buffer[i].IsKind(SyntaxKind.EndOfLineTrivia))
                {
                    if (newLineStart < 0) { newLineStart = i; }
                }
                else if (newLineStart >= 0)
                {
                    // if we find more than the allowed # of newlines in a row, remove all but the first # allowed
                    var allowedNewLines = (newLineStart == 0 && (spacingPolicy | TokenSpacingPolicy.BanMultipleTrailingNewLines) == TokenSpacingPolicy.BanMultipleTrailingNewLines) ? 1
                        : (i == buffer.Count && (spacingPolicy | TokenSpacingPolicy.BanMultipleLeadingNewLines) == TokenSpacingPolicy.BanMultipleLeadingNewLines) ? 1
                        : 2;

                    var count = i - newLineStart;
                    if (count > allowedNewLines)
                    {
                        buffer.RemoveRange(newLineStart + allowedNewLines, count: count - allowedNewLines);
                        i = newLineStart + allowedNewLines;
                    }
                    newLineStart = -1;
                }
            }
        }

        private void SplitOutMultiLineTriviaAndAddSpacing(
            IReadOnlyList<SyntaxTrivia> trivia,
            TokenSpacingPolicy spacingPolicy,
            out SyntaxAnnotation multiLineAnnotation,
            out SyntaxTriviaList leadingTrivia)
        {
            for (var i = trivia.Count - 1; i >= 0; --i)
            {
                if (RoslynHelpers.IsMultiLine(trivia[i]))
                {
                    multiLineAnnotation = LayoutAnnotations.CreateMultiLineTriviaAnnotation(trivia.Take(i + 1));
                    // if we have no more trivia after the multi-line trivia, then leading is empty. If we have
                    // additional trivial, leading is that trivia plus a space
                    leadingTrivia = trivia.Count > i + 1
                        ? SyntaxFactory.TriviaList(trivia.Skip(i + 1).Concat(SingleWhitespaceList))
                        : SyntaxTriviaList.Empty;
                    return;
                }
            }

            multiLineAnnotation = null;
            leadingTrivia = trivia.Count > 0 ? SyntaxFactory.TriviaList(trivia.Concat(SingleWhitespaceList))
                : (spacingPolicy & TokenSpacingPolicy.NeedsWhitespace) == TokenSpacingPolicy.NeedsWhitespace ? SingleWhitespaceList
                : SyntaxTriviaList.Empty;
        }

        private enum SingleLineCommentMergeState
        {
            None,
            SawCommentedOutCode,
            SawCommentedOutCodeAndNewLine,
            SawSingleLineComment,
            SawSingleLineCommentAndNewLine,
        }
        
        [Flags]
        private enum TokenSpacingPolicy : byte
        {
            None = 0,
            NeedsWhitespace = 1 << 0,
            BanMultipleTrailingNewLines = 1 << 1,
            BanMultipleLeadingNewLines = 1 << 2,
        }

        private static TokenSpacingPolicy GetSpacingPolicy(SyntaxToken previous, SyntaxToken next)
        {
            var result = TokenSpacingPolicy.None;
            
            switch (previous.Kind())
            {
                case SyntaxKind.OpenBraceToken:
                case SyntaxKind.OpenParenToken:
                case SyntaxKind.OpenBracketToken:
                    result |= TokenSpacingPolicy.BanMultipleTrailingNewLines;
                    break;
            }

            switch (next.Kind())
            {
                case SyntaxKind.CloseBraceToken:
                case SyntaxKind.CloseParenToken:
                case SyntaxKind.CloseBracketToken:
                    result |= TokenSpacingPolicy.BanMultipleLeadingNewLines;
                    break;
            }

            return result;
        }
    }

    public static class ListExtensions
    {
        public static T ListLast<T>(this IReadOnlyList<T> list)
        {
            return list[list.Count - 1];
        }

        public static T Pop<T>(this IList<T> list)
        {
            if (list.Count == 0) { throw new InvalidOperationException("list is empty!"); }
            var last = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return last;
        }
    }
}
