using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    internal partial class CSharpSyntaxIncrementalRewriter
    {
        public virtual SyntaxToken VisitToken(SyntaxToken token) => token;
    
        public virtual TNode TypedVisit<TNode>(TNode node) where TNode : SyntaxNode
        {
            return (TNode)this.Visit(node);
        }

        public TNode IncrementalVisitSyntaxList<TNode, TElement>(
            TNode node, 
            Func<TNode, SyntaxList<TElement>> getList, 
            Func<TNode, SyntaxList<TElement>, TNode> withList,
            Func<CSharpSyntaxIncrementalRewriter, TElement, TElement> visit = null)
            where TNode : SyntaxNode
            where TElement : SyntaxNode
        {
            var visitFunc = visit ?? ((rewriter, e) => rewriter.TypedVisit(e));

            var count = getList(node).Count;
            for (var i = 0; i < count; ++i)
            {
                var list = getList(node);
                var element = list[i];
                var visited = visitFunc(this, element);
                node = withList(node, list.Replace(element, visited));
            }

            return node;
        }

        public TNode IncrementalVisitSeparatedSyntaxList<TNode, TElement>(
            TNode node,
            Func<TNode, SeparatedSyntaxList<TElement>> getList,
            Func<TNode, SeparatedSyntaxList<TElement>, TNode> withList,
            Func<CSharpSyntaxIncrementalRewriter, TElement, TElement> visitNode = null,
            Func<CSharpSyntaxIncrementalRewriter, SyntaxToken, SyntaxToken> visitToken = null)
            where TNode : SyntaxNode
            where TElement : SyntaxNode
        {
            var visitNodeFunc = visitNode ?? ((rewriter, e) => rewriter.TypedVisit(e));
            var visitTokenFunc = visitToken ?? ((rewriter, t) => rewriter.VisitToken(t));

            var count = getList(node).Count;
            for (var i = 0; i < count; ++i)
            {
                var list = getList(node);
                var element = list[i];
                var visitedNode = visitNodeFunc(this, element);
                node = withList(node, list.Replace(element, visitedNode));

                list = getList(node);
                var separator = list.GetSeparator(i);
                var visitedSeparator = visitTokenFunc(this, separator);
                node = withList(node, list.ReplaceSeparator(separator, visitedSeparator));
            }

            return node;
        }

        public TNode IncrementalVisitSyntaxTokenList<TNode>(
            TNode node,
            Func<TNode, SyntaxTokenList> getList,
            Func<TNode, SyntaxTokenList, TNode> withList,
            Func<CSharpSyntaxIncrementalRewriter, SyntaxToken, SyntaxToken> visit = null)
        {
            var visitFunc = visit ?? ((rewriter, e) => rewriter.VisitToken(e));

            var count = getList(node).Count;
            for (var i = 0; i < count; ++i)
            {
                var list = getList(node);
                var element = list[i];
                var visited = visitFunc(this, element);
                node = withList(node, list.Replace(element, visited));
            }

            return node;
        }
    }
}
