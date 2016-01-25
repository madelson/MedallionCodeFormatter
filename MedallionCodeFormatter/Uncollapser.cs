using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MedallionCodeFormatter
{
    internal sealed partial class Uncollapser : CSharpSyntaxIncrementalRewriter
    {
        private readonly LayoutOptions options;
        private readonly DropAndVisitVisitor cachedDropAndVisitVisitor;
        private readonly Func<SyntaxToken, SyntaxToken> cachedDropAndVisitTokenFunc;
        private int indentLevel;

        private Uncollapser(LayoutOptions options)
        {
            this.options = options;
            this.cachedDropAndVisitVisitor = new DropAndVisitVisitor(this);
            this.cachedDropAndVisitTokenFunc = this.DropAndVisit;
        }

        public static SyntaxNode Uncollapse(SyntaxNode node, LayoutOptions options)
        {
            return new Uncollapser(options).Visit(node);
        }
        
        public override SyntaxToken VisitToken(SyntaxToken token)
        {
            if (token.HasAnnotations(LayoutAnnotations.HasMultiLineLeadingTriviaKind))
            {
                // todo
            }

            return token;
        }

        #region ---- DropAndVisit Methods ----
        private TNode DropAndVisit<TNode>(TNode node)
            where TNode : SyntaxNode
        {
            var firstToken = node.GetFirstToken();
            var visitedToken = this.DropAndVisit(firstToken);
            node = node.ReplaceToken(firstToken, visitedToken);
        
            return this.TypedVisit(node);
        }

        private SyntaxToken DropAndVisit(SyntaxToken token)
        {
            var visited = this.VisitToken(token);
            if (IsMultiLine(visited.LeadingTrivia))
            {
                // visit already added some newlines... we don't have to add more
                return visited;
            }

            // add a leading newline, gobbling any non-unecessary whitespace
            return visited.WithLeadingTrivia(
                this.GetNewLineWithIndentation()
                    .AddRange(visited.LeadingTrivia.SkipWhile(s => s.IsKind(SyntaxKind.WhitespaceTrivia)))
            );
        }

        private TNode MaybeDropAndVisit<TNode>(TNode node, bool force)
            where TNode : SyntaxNode
        {
            return force ? this.DropAndVisit(node) : this.TypedVisit(node);
        }

        private SyntaxToken MaybeDropAndVisit(SyntaxToken token, bool force)
        {
            return force ? this.DropAndVisit(token) : this.VisitToken(token);
        }
        
        private TNode MaybeDropAndVisit<TNode, TElement>(
            TNode node, 
            Func<TNode, SyntaxList<TElement>> getList, 
            Func<TNode, SyntaxList<TElement>, TNode> withList, 
            bool force)
            where TNode : SyntaxNode
            where TElement : SyntaxNode
        {
            return this.IncrementalVisitSyntaxList(node, getList, withList, force ? this.cachedDropAndVisitVisitor : null);
        }

        private TNode MaybeDropAndVisit<TNode, TElement>(
            TNode node,
            Func<TNode, SeparatedSyntaxList<TElement>> getList,
            Func<TNode, SeparatedSyntaxList<TElement>, TNode> withList,
            bool force)
            where TNode : SyntaxNode
            where TElement : SyntaxNode
        {
            return this.IncrementalVisitSeparatedSyntaxList(
                node, 
                getList, 
                withList, 
                force ? this.cachedDropAndVisitVisitor : null,
                force ? this.cachedDropAndVisitTokenFunc : null
            );
        }

        private TNode MaybeDropAndVisit<TNode>(
            TNode node,
            Func<TNode, SyntaxTokenList> getList,
            Func<TNode, SyntaxTokenList, TNode> withList,
            bool force)
            where TNode : SyntaxNode
        {
            return this.IncrementalVisitSyntaxTokenList(node, getList, withList, force ? this.cachedDropAndVisitTokenFunc : null);
        }

        private sealed class DropAndVisitVisitor : CSharpSyntaxVisitor<SyntaxNode>
        {
            private readonly Uncollapser uncollapser;

            public DropAndVisitVisitor(Uncollapser uncollapser) { this.uncollapser = uncollapser; }

            public override SyntaxNode Visit(SyntaxNode node)
            {
                return this.uncollapser.DropAndVisit(node);
            }
        }
        #endregion

        #region ---- Indentation ----
        private IndentationScope Indent()
        {
            ++this.indentLevel;
            return new IndentationScope(this);
        }

        private struct IndentationScope : IDisposable
        {
            private readonly Uncollapser engine;

            public IndentationScope(Uncollapser engine) { this.engine = engine; }

            public void Dispose()
            {
                --this.engine.indentLevel;
            }
        }

        private List<SyntaxTriviaList> newLineAndIndentationCache = new List<SyntaxTriviaList>();

        private SyntaxTriviaList GetNewLineWithIndentation()
        {
            for (var i = this.newLineAndIndentationCache.Count; i <= this.indentLevel; ++i)
            {
                var trivia = SyntaxFactory.TriviaList(SyntaxFactory.LineFeed, SyntaxFactory.Whitespace(new string('\t', i)));
                this.newLineAndIndentationCache.Add(trivia);
            }

            return this.newLineAndIndentationCache[this.indentLevel];
        }
        #endregion

        #region ---- Measurement ----
        private bool IsTooLongOrHasMultiLineAnnotations(SyntaxNode node)
        {
            return node.ContainsMultiLineLayoutAnnotations() || this.IsTooLong(node);
        }

        private bool IsTooLong(SyntaxNode node)
        {
            // TODO dynamic programming cache
            // TODO handle verbatim strings/$verbatim strings

            // assumes: (1) all tabs replaced with spaces
            // (2) no \r characters (or other weird 0-length things)
            // TODO normalize these away and put them back later

            // first, measure the line up until this point
            var firstToken = node.GetFirstToken();
            var previousLength = 0;
            if (!IsMultiLine(firstToken.LeadingTrivia))
            {
                var previousToken = firstToken.GetPreviousToken();
                while (true)
                {
                    if (IsMultiLine(previousToken.LeadingTrivia))
                    {
                        var leadingTriviaString = previousToken.LeadingTrivia.ToFullString();
                        var leadingLength = leadingTriviaString.Length - leadingTriviaString.LastIndexOf('\n');
                        previousLength += (leadingLength + previousToken.Span.Length + previousToken.TrailingTrivia.FullSpan.Length);
                        break;
                    }
                    else
                    {
                        previousLength += previousToken.FullSpan.Length;
                        previousToken = previousToken.GetPreviousToken();
                    }
                }
            }

            if (previousLength > this.options.MaxLineWidth) { return true; }

            var currentLineLength = previousLength;
            foreach (var token in node.DescendantTokens())
            {
                if (IsMultiLine(token.LeadingTrivia))
                {
                    var leadingTriviaString = token.LeadingTrivia.ToFullString();
                    var trailingLength = leadingTriviaString.IndexOf('\n');
                    if (currentLineLength + trailingLength > this.options.MaxLineWidth) { return true; }

                    var leadingLength = leadingTriviaString.Length - leadingTriviaString.LastIndexOf('\n');
                    currentLineLength = leadingLength + token.Span.Length + token.TrailingTrivia.FullSpan.Length;
                }
                else
                {
                    currentLineLength += token.FullSpan.Length;
                }

                if (currentLineLength > this.options.MaxLineWidth) { return true; }
            }

            return false;
        }

        private static bool IsMultiLine(SyntaxTriviaList triviaList)
        {
            foreach (var trivia in triviaList)
            {
                switch (trivia.Kind())
                {
                    case SyntaxKind.EndOfLineTrivia:
                        return true;
                    case SyntaxKind.WhitespaceTrivia:
                    case SyntaxKind.SingleLineCommentTrivia:
                        // todo others?
                        return false;
                    default:
                        return trivia.ToFullString().IndexOf('\n') >= 0; 
                }
            }

            return false;
        }
        #endregion
    }
}
