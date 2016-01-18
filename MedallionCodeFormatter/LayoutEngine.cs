﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MedallionCodeFormatter
{
    class LayoutEngine : CSharpSyntaxRewriter
    {
        private readonly int maxLength = 120;
        private readonly int tabLength = 4;
        private int indentLevel;

        private static readonly SyntaxTriviaList NewLineList = SyntaxFactory.TriviaList(SyntaxFactory.LineFeed);

        public const string MultiLineLeadingTriviaAnnotationKind = "MultiLineLeadingTrivia";

        public override SyntaxNode VisitBlock(BlockSyntax node)
        {
            // todo the statement-#-based force-split rule should be wrapped in an annotation
            var force = this.IsTooLong(node) 
                || ContainsMultiLineAnnotation(node);

            node = node.WithOpenBraceToken(this.VisitAndMaybePlaceOnNewLine(node.OpenBraceToken, force));
            using (this.Indent())
            {
                node = node.WithSyntaxList(b => b.Statements, s => this.VisitAndMaybePlaceOnNewLine(s, force), (b, list) => b.WithStatements(list));
            }
            node = node.WithCloseBraceToken(this.VisitAndMaybePlaceOnNewLine(node.CloseBraceToken, force));

            return node;
        }
        
        private TNode VisitAndMaybePlaceOnNewLine<TNode>(TNode node, bool force)
            where TNode : SyntaxNode
        {
            var firstToken = node.GetFirstToken();
            var visitedToken = this.VisitAndMaybePlaceOnNewLine(firstToken, force);
            if (firstToken != visitedToken)
            {
                node = node.ReplaceToken(firstToken, visitedToken);
            }

            return this.TypedVisit(node);
        }

        private SyntaxToken VisitAndMaybePlaceOnNewLine(SyntaxToken token, bool force)
        {
            var visited = this.VisitToken(token);
            if (IsMultiLine(visited.LeadingTrivia))
            {
                // visit already added some newlines... we don't have to add more
                return visited;
            }

            // add a leading newline, gobbling any non-unecessary whitespace
            return visited.WithLeadingTrivia(
                NewLineList.AddRange(visited.LeadingTrivia.SkipWhile(s => s.IsKind(SyntaxKind.WhitespaceTrivia)))
            );
        }

        // todo extension
        private TNode TypedVisit<TNode>(TNode node) where TNode : SyntaxNode
        {
            return (TNode)this.Visit(node);
        }

        private IndentationScope Indent()
        {
            ++this.indentLevel;
            return new IndentationScope(this);
        }

        private struct IndentationScope : IDisposable
        {
            private readonly LayoutEngine engine;

            public IndentationScope(LayoutEngine engine) { this.engine = engine; }

            public void Dispose()
            {
                --this.engine.indentLevel;
            }
        }

        private static bool ContainsMultiLineAnnotation(SyntaxNode node)
        {
            return node.ContainsAnnotations 
                && node.DescendantTokens().Any(t => t.HasAnnotations(MultiLineLeadingTriviaAnnotationKind));
        }

        private bool IsTooLong(SyntaxNode node)
        {
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

            if (previousLength > this.maxLength) { return true; }

            var currentLineLength = previousLength;
            foreach (var token in node.DescendantTokens())
            {
                if (IsMultiLine(token.LeadingTrivia))
                {
                    var leadingTriviaString = token.LeadingTrivia.ToFullString();
                    var trailingLength = leadingTriviaString.IndexOf('\n');
                    if (currentLineLength + trailingLength > this.maxLength) { return true; }

                    var leadingLength = leadingTriviaString.Length - leadingTriviaString.LastIndexOf('\n');
                    currentLineLength = leadingLength + token.Span.Length + token.TrailingTrivia.FullSpan.Length;
                }
                else
                {
                    currentLineLength += token.FullSpan.Length;
                }

                if (currentLineLength > this.maxLength) { return true; }
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
    }

    public static class Extensions
    {
        public static TNode WithSyntaxList<TNode, TElementNode>(
            this TNode node,
            Func<TNode, SyntaxList<TElementNode>> getList,
            Func<TElementNode, TElementNode> transformElement,
            Func<TNode, SyntaxList<TElementNode>, TNode> withList)
            where TNode : SyntaxNode
            where TElementNode : SyntaxNode
        {
            var listCount = getList(node).Count;
            for (var i = 0; i < listCount; ++i)
            {
                var list = getList(node);
                var element = list[i];
                var transformed = transformElement(element);
                if (transformed != element)
                {
                    node = withList(node, list.Replace(element, transformed));
                }
            }

            return node;
        }
    }
}