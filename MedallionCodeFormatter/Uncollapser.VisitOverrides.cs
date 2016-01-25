using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        // todo

        public override SyntaxNode VisitBlock(BlockSyntax node)
        {
            var forceBraces = this.IsTooLongOrHasMultiLineAnnotations(node);
            
            node = node.WithOpenBraceToken(this.MaybeDropAndVisit(node.OpenBraceToken, forceBraces));
            node = node.WithCloseBraceToken(this.MaybeDropAndVisit(node.CloseBraceToken, forceBraces));

            var forceStatements = node.HasMultiLineConstructAnnotation()
                || node.Statements.Any(LayoutAnnotations.ContainsMultiLineLayoutAnnotations)
                || this.IsTooLong(node);
            using (this.Indent())
            {
                node = this.MaybeDropAndVisit(node, b => b.Statements, (b, s) => b.WithStatements(s), forceStatements);
            }
            
            return node;
        }

        public override SyntaxNode VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            var forceParens = this.IsTooLongOrHasMultiLineAnnotations(node);

            node = node.WithOpenParenToken(this.MaybeDropAndVisit(node.OpenParenToken, forceParens));
            node = node.WithCloseParenToken(this.MaybeDropAndVisit(node.CloseParenToken, forceParens));

            var forceExpression = node.HasMultiLineConstructAnnotation()
                || node.Expression.ContainsMultiLineLayoutAnnotations()
                || this.IsTooLong(node);
            using (this.Indent())
            {
                node = node.WithExpression(this.MaybeDropAndVisit(node.Expression, forceExpression));
            }

            return node;
        }

    }
}
