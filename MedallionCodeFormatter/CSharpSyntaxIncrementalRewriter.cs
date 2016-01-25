using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    internal partial class CSharpSyntaxIncrementalRewriter
    {
        private readonly Func<SyntaxToken, SyntaxToken> cachedVisitTokenFunc;

        public CSharpSyntaxIncrementalRewriter()
        {
            this.cachedVisitTokenFunc = this.VisitToken;
        }

        public virtual SyntaxToken VisitToken(SyntaxToken token) => token;

        public TNode IncrementalVisitSyntaxList<TNode, TElement>(
            TNode node, 
            Func<TNode, SyntaxList<TElement>> getList, 
            Func<TNode, SyntaxList<TElement>, TNode> withList,
            CSharpSyntaxVisitor<SyntaxNode> elementVisitor = null)
            where TNode : SyntaxNode
            where TElement : SyntaxNode
        {
            elementVisitor = elementVisitor ?? this;

            var count = getList(node).Count;
            for (var i = 0; i < count; ++i)
            {
                var list = getList(node);
                var element = list[i];
                var visited = elementVisitor.TypedVisit(element);
                node = withList(node, list.Replace(element, visited));
            }

            return node;
        }

        public TNode IncrementalVisitSeparatedSyntaxList<TNode, TElement>(
            TNode node,
            Func<TNode, SeparatedSyntaxList<TElement>> getList,
            Func<TNode, SeparatedSyntaxList<TElement>, TNode> withList,
            CSharpSyntaxVisitor<SyntaxNode> elementVisitor = null,
            Func<SyntaxToken, SyntaxToken> separatorVisitor = null)
            where TNode : SyntaxNode
            where TElement : SyntaxNode
        {
            elementVisitor = elementVisitor ?? this;
            separatorVisitor = separatorVisitor ?? this.cachedVisitTokenFunc;

            var count = getList(node).Count;
            for (var i = 0; i < count; ++i)
            {
                var list = getList(node);
                var element = list[i];
                var visitedNode = elementVisitor.TypedVisit(element);
                node = withList(node, list.Replace(element, visitedNode));

                list = getList(node);
                var separator = list.GetSeparator(i);
                var visitedSeparator = separatorVisitor(separator);
                node = withList(node, list.ReplaceSeparator(separator, visitedSeparator));
            }

            return node;
        }

        public TNode IncrementalVisitSyntaxTokenList<TNode>(
            TNode node,
            Func<TNode, SyntaxTokenList> getList,
            Func<TNode, SyntaxTokenList, TNode> withList,
            Func<SyntaxToken, SyntaxToken> elementVisitor = null)
        {
            elementVisitor = elementVisitor ?? this.cachedVisitTokenFunc;

            var count = getList(node).Count;
            for (var i = 0; i < count; ++i)
            {
                var list = getList(node);
                var element = list[i];
                var visited = elementVisitor(element);
                node = withList(node, list.Replace(element, visited));
            }

            return node;
        }
    }

    internal static class VisitorHelpers
    {
        public static TNode TypedVisit<TNode>(this CSharpSyntaxVisitor<SyntaxNode> visitor, TNode node)
            where TNode : SyntaxNode
        {
            return (TNode)visitor.Visit(node);
        }
    }
}
