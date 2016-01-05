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
    internal sealed class SyntaxLevelRewriter : CSharpSyntaxRewriter
    {
        private int indentLevel = 0;

        public SyntaxLevelRewriter() : base(visitIntoStructuredTrivia: false) { }

        public override SyntaxNode Visit(SyntaxNode node)
        {
            var visited = base.Visit(node);

            var statement = visited as StatementSyntax;
            if (statement != null)
            {
                // check parent from node, not visited in case we got replaced
                var parent = node.Parent;
                if (parent != null
                    && (
                        parent.IsKind(SyntaxKind.IfStatement)
                        || parent.IsKind(SyntaxKind.ElseClause)
                        || parent.IsKind(SyntaxKind.ForStatement)
                        || parent.IsKind(SyntaxKind.ForEachStatement)
                        || parent.IsKind(SyntaxKind.WhileStatement)
                        || parent.IsKind(SyntaxKind.CheckedStatement)
                        || parent.IsKind(SyntaxKind.UncheckedStatement)
                    ))
                {
                    return this.EnsureBlock(statement);
                }
            }

            return visited;
        }

        private SyntaxTrivia GetIndentTrivia()
        {
            return SyntaxFactory.Whitespace(new string('\t', this.indentLevel));
        }

        public override SyntaxNode VisitCompilationUnit(CompilationUnitSyntax node)
        {
            return base.VisitCompilationUnit(
                node.WithUsings(this.SortUsings(node.Usings))
            );
        }

        public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            return base.VisitNamespaceDeclaration(
                node.WithUsings(this.SortUsings(node.Usings))
            );
        }

        public override SyntaxTrivia VisitTrivia(SyntaxTrivia trivia)
        {
            return trivia.IsKind(SyntaxKind.EndOfLineTrivia)
                ? SyntaxFactory.CarriageReturnLineFeed
                : base.VisitTrivia(trivia);
        }

        private StatementSyntax EnsureBlock(StatementSyntax statement)
        {
            return statement.IsKind(SyntaxKind.Block)
                ? statement
                : SyntaxFactory.Block(statement);
        }

        #region ---- Sorting Usings ----
        private SyntaxList<UsingDirectiveSyntax> SortUsings(SyntaxList<UsingDirectiveSyntax> usings)
        {
            // first check if already in order
            var inOrder = true;
            for (var i = 0; i < usings.Count - 1; ++i)
            {
                if (UsingDirectiveComparer.Instance.Compare(usings[i], usings[i + 1]) > 0)
                {
                    inOrder = false;
                    break;
                }
            }

            return inOrder
                ? usings
                : new SyntaxList<UsingDirectiveSyntax>().AddRange(usings.OrderBy(n => n, UsingDirectiveComparer.Instance));
        }

        private sealed class UsingDirectiveComparer : IComparer<UsingDirectiveSyntax>
        {
            public static IComparer<UsingDirectiveSyntax> Instance = new UsingDirectiveComparer();

            int IComparer<UsingDirectiveSyntax>.Compare(UsingDirectiveSyntax @this, UsingDirectiveSyntax that)
            {
                var hasAliasComparison = (@this.Alias != null).CompareTo(that.Alias != null);
                if (hasAliasComparison != 0)
                {
                    return hasAliasComparison;
                }

                if (@this.Alias != null)
                {
                    var aliasComparison = StringComparer.Ordinal.Compare(@this.Alias.Name.ToString(), that.Alias.Name.ToString());
                    if (aliasComparison != 0)
                    {
                        return aliasComparison;
                    }
                }

                return StringComparer.Ordinal.Compare(@this.Name.ToString(), that.Name.ToString());
            }
        }
        #endregion
    }
}
