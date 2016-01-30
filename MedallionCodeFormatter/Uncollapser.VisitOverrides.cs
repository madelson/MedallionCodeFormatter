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
            return this.VisitBlockLike(
                node,
                BlockInfo.OpenBraceToken,
                BlockInfo.Statements,
                BlockInfo.CloseBraceToken
            );
        }

        public override SyntaxNode VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            return this.VisitBlockLike(
                node,
                ParenthesizedExpressionInfo.OpenParenToken,
                ParenthesizedExpressionInfo.Expression,
                ParenthesizedExpressionInfo.CloseParenToken,
                canDropOpenToken: true,
                canDropCloseToken: true
            );
        } 

        private TNode VisitBlockLike<TNode>(
            TNode node,
            SyntaxNodeProperty<TNode, SyntaxToken> openToken,
            ISyntaxNodePropertyWithTypedNode<TNode> body,
            SyntaxNodeProperty<TNode, SyntaxToken> closeToken,
            bool? canDropOpenToken = null,
            bool? canDropCloseToken = null)
            where TNode : SyntaxNode
        {
            var forceTokens = this.IsTooLongOrHasMultiLineAnnotations(node);

            // first, we visit the open and close tokens to see if they drop

            var openTokenValue = openToken.Get(node);
            var visitedOpenToken = canDropOpenToken ?? openTokenValue.IsKind(SyntaxKind.OpenBraceToken)
                ? this.MaybeDropAndVisit(openTokenValue, forceTokens)
                : this.VisitToken(openTokenValue);
            node = openToken.With(node, visitedOpenToken);

            var closeTokenValue = closeToken.Get(node);
            var visitedCloseToken = canDropCloseToken ?? true
                ? this.MaybeDropAndVisit(closeTokenValue, forceTokens)
                : this.VisitToken(closeTokenValue);
            node = closeToken.With(node, visitedCloseToken);

            var bodyNodesOrTokens = body.GetNodesOrTokens(node);

            // we force the body to drop if: 
            var forceBody =
                // the close token dropped
                IsMultiLine(closeToken.Get(node).LeadingTrivia)
                // or the top level node is a multi-line construct (e. g. block with 2+ statements)
                || node.HasMultiLineConstructAnnotation()
                // or any part of the body is is multi-line
                || bodyNodesOrTokens
                    .Any(not => not.IsNode ? not.AsNode().ContainsMultiLineLayoutAnnotations() : not.AsToken().ContainsMultiLineLayoutAnnotations())
                // or the node is still too long
                || this.IsTooLong(node);

            using (this.Indent())
            {
                var count = bodyNodesOrTokens.Count;
                for (var i = 0; i < count; ++i)
                {
                    var nodesOrTokens = body.GetNodesOrTokens(node);
                    var nodeOrToken = nodesOrTokens[i];
                    var visited = nodeOrToken.IsToken
                        ? (SyntaxNodeOrToken)this.VisitToken(nodeOrToken.AsToken())
                        : this.MaybeDropAndVisit(nodeOrToken.AsNode(), forceBody);
                    if (visited != nodeOrToken)
                    {
                        node = body.WithNodesOrTokens(node, nodesOrTokens.Replace(nodeOrToken, visited));
                    }
                }
            }

            return node;
        }
    }
}
