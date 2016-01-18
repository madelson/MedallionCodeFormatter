using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter.SyntaxRules
{
    internal sealed class IfElseBraceRule : ISyntaxRule
    {
        SyntaxNode ISyntaxRule.Process(SyntaxNode root)
        {
            root.DescendantNodesAndSelf()
                .Where(n => n.IsKind(SyntaxKind.IfStatement) || n.IsKind(SyntaxKind.ElseClause));
            return root;
        }
    }
}
