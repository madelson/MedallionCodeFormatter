using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.CodeAnalysis.CSharp;

namespace MedallionCodeFormatter
{
    internal sealed partial class Uncollapser
    {
        //accessorlist
        //anonymousobjectcreationexpression
        //argumentlist
        //arrayrankspecifier
        //assignment(there are a few other things like this, e.g.attributeargument, although only assignment really has the option of breaking the left side)
        //attributeargumentlist
        //attributelist
        //binaryexpression
        //block
        //bracketedargumentlist
        //bracketedparameterlist
        //catchclause(for filter)
        //checkedexpression
        //classdecl, interfacedecl, structdecl
        //compilationunit
        //conditionalaccess/memberaccess
        //conditionalexpression
        //constructordeclaration, methoddeclaration,propertydeclaration, conversionoperatordeclaration,  (for attr lists, initializer)
        //delegatedeclaration(constraint clauses)
        //destructordeclaration
        //dostatement(to drop the while)
        //enumdeclaration
        //eventdeclaration(attribute lists)
        //eventfielddeclaration
        //fielddeclaration
        //incompletemember
        //indexerdeclaration
        //initializer
        //interpolation(for long interps)?
        //joinclause
        //joinintoclause
        //memberaccessexpression
        //namespacedeclaration
        //objectcreationexpression(to do initializer first)
        //operatordeclaration
        //orderbyclause(list of orderings)
        //parameterlist
        //parenthesizedexpression
        //parenthesizedlambda
        //propertydeclaration
        //queryexpression
        //switchstatement
        //trystatement(catches/finally on new lines if any are)
        //ifstatement, usingstatement, forstatement, foreachstatement(because of the parens!!)
        //variabledeclaration
        //variabledeclarator
        //whilestatement

        public override SyntaxNode VisitBlock(BlockSyntax node)
        {
            return this.VisitBlockLike<BlockSyntax, StatementSyntax>(
                node,
                b => b.OpenBraceToken,
                (b, t) => b.WithOpenBraceToken(t),
                b => b.Statements,
                (b, s) => b.WithStatements(s.List),
                b => b.CloseBraceToken,
                (b, t) => b.WithCloseBraceToken(t)
            );
        }

        public override SyntaxNode VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            return this.VisitBlockLike<ParenthesizedExpressionSyntax, ExpressionSyntax>(
                node,
                n => n.OpenParenToken,
                (n, t) => n.WithOpenParenToken(t),
                n => n.Expression,
                (n, e) => n.WithExpression(e.Node),
                n => n.CloseParenToken,
                (n, t) => n.WithCloseParenToken(t),
                canDropOpenToken: true,
                canDropCloseToken: true
            );
        }

        private TNode VisitBlockLike<TNode, TElement>(
            TNode node,
            Func<TNode, SyntaxToken> getOpenToken,
            Func<TNode, SyntaxToken, TNode> withOpenToken,
            Func<TNode, TElement> getBody,
            Func<TNode, TElement, TNode> withBody,
            Func<TNode, SyntaxToken> getCloseToken,
            Func<TNode, SyntaxToken, TNode> withCloseToken,
            bool? canDropOpenToken = null,
            bool? canDropCloseToken = null)
            where TNode : SyntaxNode
            where TElement : SyntaxNode
        {
            bool forceBody;
            node = this.VisitTokensOfBlockLike(
                node,
                getOpenToken,
                withOpenToken,
                n => SyntaxFactory.NodeOrTokenList(getBody(n)),
                getCloseToken,
                withCloseToken,
                canDropOpenToken,
                canDropCloseToken,
                out forceBody
            );

            using (this.Indent())
            {
                node = withBody(node, this.MaybeDropAndVisit(getBody(node), forceBody));
            }

            return node;
        }

        // TODO break up into three methods for each of single node body, separated body, and list body
        private TNode VisitBlockLike<TNode, TElement>(
            TNode node,
            Func<TNode, SyntaxToken> getOpenToken,
            Func<TNode, SyntaxToken, TNode> withOpenToken,
            Func<TNode, Nodes<TElement>> getBody,
            Func<TNode, Nodes<TElement>, TNode> withBody,
            Func<TNode, SyntaxToken> getCloseToken,
            Func<TNode, SyntaxToken, TNode> withCloseToken,
            bool? canDropOpenToken = null,
            bool? canDropCloseToken = null)
            where TNode : SyntaxNode
            where TElement : SyntaxNode
        {
            bool forceBody;
            node = this.VisitTokensOfBlockLike(
                node,
                getOpenToken,
                withOpenToken,
                n => SyntaxFactory.NodeOrTokenList(getBody(n)),
                getCloseToken,
                withCloseToken,
                canDropOpenToken,
                canDropCloseToken,
                out forceBody
            );

            var body = getBody(node);
            using (this.Indent())
            {
                TElement singleNode;
                SyntaxList<TElement> list;
                SeparatedSyntaxList<TElement> separatedList;
                if (body.TryGetNode(out singleNode))
                {
                    node = withBody(node, this.MaybeDropAndVisit(singleNode, forceBody));
                }
                else if (body.TryGetList(out list))
                {
                    node = this.MaybeDropAndVisit(node, n => getBody(n).List, (n, l) => withBody(n, l), forceBody);
                }
                else if (body.TryGetSeparatedList(out separatedList))
                {
                    node = this.MaybeDropAndVisit(node, n => getBody(n).SeparatedList, (n, l) => withBody(n, l), forceBody);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

            return node;
        }

        private TNode VisitTokensOfBlockLike<TNode>(
            TNode node,
            Func<TNode, SyntaxToken> getOpenToken,
            Func<TNode, SyntaxToken, TNode> withOpenToken,
            Func<TNode, SyntaxNodeOrTokenList> getBody,
            Func<TNode, SyntaxToken> getCloseToken,
            Func<TNode, SyntaxToken, TNode> withCloseToken,
            bool? canDropOpenToken,
            bool? canDropCloseToken,
            out bool forceBody)
            where TNode : SyntaxNode
        {
            var forceTokens = this.IsTooLongOrHasMultiLineAnnotations(node);

            // first, we visit the open and close tokens to see if they drop

            var openToken = getOpenToken(node);
            var visitedOpenToken = canDropOpenToken ?? openToken.IsKind(SyntaxKind.OpenBraceToken)
                ? this.MaybeDropAndVisit(openToken, forceTokens)
                : this.VisitToken(openToken);
            node = withOpenToken(node, visitedOpenToken);

            var closeToken = getCloseToken(node);
            var visitedCloseToken = canDropCloseToken ?? true
                ? this.MaybeDropAndVisit(closeToken, forceTokens)
                : this.VisitToken(closeToken);
            node = withCloseToken(node, visitedCloseToken);
            
            // we force the body to drop if: 
            forceBody =
                // the close token dropped
                IsMultiLine(getCloseToken(node).LeadingTrivia)
                // or the top level node is a multi-line construct (e. g. block with 2+ statements)
                || node.HasMultiLineConstructAnnotation()
                // or any part of the body is is multi-line
                || getBody(node).Any(not => not.IsNode ? not.AsNode().ContainsMultiLineLayoutAnnotations() : not.AsToken().ContainsMultiLineLayoutAnnotations())
                // or the node is still too long
                || this.IsTooLong(node);

            return node;
        }

        private struct Nodes<TNode> : IEnumerable<SyntaxNodeOrToken>
            where TNode : SyntaxNode
        {
            private enum Kind : byte { SingleNode, SyntaxList, SeparatedSyntaxList };

            private Kind kind;
            private TNode node;
            private SyntaxList<TNode> list;
            private SeparatedSyntaxList<TNode> separatedList;

            public TNode Node
            {
                get
                {
                    TNode node;
                    if (!this.TryGetNode(out node)) { throw new InvalidOperationException("not a node"); }
                    return node;
                }
            }

            public SyntaxList<TNode> List
            {
                get
                {
                    SyntaxList<TNode> list;
                    if (!this.TryGetList(out list)) { throw new InvalidOperationException("not a list"); }
                    return list;
                }
            }

            public SeparatedSyntaxList<TNode> SeparatedList
            {
                get
                {
                    SeparatedSyntaxList<TNode> separatedList;
                    if (!this.TryGetSeparatedList(out separatedList)) { throw new InvalidOperationException("not a separated list"); }
                    return separatedList;
                }
            }

            public bool TryGetNode(out TNode node)
            {
                node = this.node;
                return this.kind == Kind.SingleNode;
            }

            public bool TryGetList(out SyntaxList<TNode> list)
            {
                list = this.list;
                return this.kind == Kind.SyntaxList;
            }

            public bool TryGetSeparatedList(out SeparatedSyntaxList<TNode> separatedList)
            {
                separatedList = this.separatedList;
                return this.kind == Kind.SeparatedSyntaxList;
            }

            public Enumerator GetEnumerator() => new Enumerator(this);
            IEnumerator<SyntaxNodeOrToken> IEnumerable<SyntaxNodeOrToken>.GetEnumerator() => this.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

            public static implicit operator Nodes<TNode>(TNode node) => new Nodes<TNode> { kind = Kind.SingleNode, node = node };
            public static implicit operator Nodes<TNode>(SyntaxList<TNode> list) => new Nodes<TNode> { kind = Kind.SyntaxList, list = list };
            public static implicit operator Nodes<TNode>(SeparatedSyntaxList<TNode> separatedList) => new Nodes<TNode> { kind = Kind.SeparatedSyntaxList, separatedList = separatedList };

            public struct Enumerator : IEnumerator<SyntaxNodeOrToken>
            {
                private readonly Nodes<TNode> nodes;
                private int index;

                internal Enumerator(Nodes<TNode> nodes)
                {
                    this.nodes = nodes;
                    this.index = -1;
                }

                public SyntaxNodeOrToken Current
                {
                    get
                    {
                        switch (this.nodes.kind)
                        {
                            case Kind.SingleNode: return this.index == 0 ? this.nodes.node : null;
                            case Kind.SyntaxList: return this.nodes.list[this.index];
                            case Kind.SeparatedSyntaxList: return this.nodes.separatedList.GetWithSeparators()[this.index];
                            default: throw new InvalidOperationException();
                        }
                    }
                }

                object IEnumerator.Current => this.Current;

                public void Dispose()
                {
                }

                public bool MoveNext()
                {
                    ++this.index;
                    switch (this.nodes.kind)
                    {
                        case Kind.SingleNode: return this.index == 0;
                        case Kind.SyntaxList: return this.index < this.nodes.list.Count;
                        case Kind.SeparatedSyntaxList: return this.index < this.nodes.separatedList.GetWithSeparators().Count;
                        default: throw new InvalidOperationException();
                    }
                }

                public void Reset()
                {
                    this.index = -1;
                }
            }
        }
    }
}
