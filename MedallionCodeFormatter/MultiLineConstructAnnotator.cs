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
    class MultiLineConstructAnnotator : CSharpSyntaxRewriter
    {
        private MultiLineConstructAnnotator() { }

        public SyntaxNode Annotate(SyntaxNode node)
        {
            return new MultiLineConstructAnnotator().Visit(node);
        }

        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.ConstraintClauses.Count > 1)
            {
                node = node.WithAdditionalAnnotations(LayoutAnnotations.MultiLineConstructAnnotation);
            }

            return base.VisitMethodDeclaration(node);
        }

        public override SyntaxNode VisitBlock(BlockSyntax node)
        {
            if (node.Statements.Count > 2)
            {
                node = node.WithAdditionalAnnotations(LayoutAnnotations.MultiLineConstructAnnotation);
            }

            return base.VisitBlock(node);
        }

        public override SyntaxNode VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
        {
            if (node.ToString().IndexOf('\n') >= 0)
            {
                node = node.WithAdditionalAnnotations(LayoutAnnotations.MultiLineConstructAnnotation);
            }

            return base.VisitInterpolatedStringText(node);
        }

        public override SyntaxNode VisitLiteralExpression(LiteralExpressionSyntax node)
        {
            if (node.IsKind(SyntaxKind.StringLiteralExpression)
                && node.ToString().IndexOf('\n') >= 0)
            {
                node = node.WithAdditionalAnnotations(LayoutAnnotations.MultiLineConstructAnnotation);
            }

            return base.VisitLiteralExpression(node);
        }

        public override SyntaxNode VisitCompilationUnit(CompilationUnitSyntax node)
        {
            if (node.Usings.Any() || node.Externs.Any())
            {
                node = node.WithAdditionalAnnotations(LayoutAnnotations.MultiLineConstructAnnotation);
            }

            return base.VisitCompilationUnit(node);
        }

        public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            if (node.Usings.Any() || node.Externs.Any())
            {
                node = node.WithAdditionalAnnotations(LayoutAnnotations.MultiLineConstructAnnotation);
            }

            return base.VisitNamespaceDeclaration(node);
        }
    }
}
