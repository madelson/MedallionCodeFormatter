using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter.SyntaxRules
{
    /// <summary>
    /// Empty line must not follow open brace or preceed closing brace
    /// </summary>
    internal sealed class BraceNewlineRule : ISyntaxRule
    {
        SyntaxNode ISyntaxRule.Process(SyntaxNode root)
        {
            var braceTokenNeighbors = root.DescendantTokens()
                .Where(t => 
                    t.IsKind(SyntaxKind.OpenBraceToken) 
                    || (t.IsKind(SyntaxKind.CloseBraceToken) && t.GetPreviousToken().IsKind(SyntaxKind.OpenBraceToken))
                )
                .ToDictionary(
                    t => t.IsKind(SyntaxKind.OpenBraceToken) ? t.GetNextToken() : t.GetPreviousToken(),
                    t => t.Kind()
                );

            var processed = root.ReplaceTokens(
                braceTokenNeighbors.Keys,
                (orig, t) => braceTokenNeighbors[orig] == SyntaxKind.OpenBraceToken
                    ? ProcessTokenAfterOpenBrace(t)
                    : ProcessTokenBeforeCloseBrace(t)
            );
            return processed;
        }

        private static SyntaxToken ProcessTokenAfterOpenBrace(SyntaxToken token)
        {
            if (!token.HasLeadingTrivia) { return token; }

            
            var nextToken = token.GetNextToken();
            return token;
        }

        private static SyntaxToken ProcessTokenBeforeCloseBrace(SyntaxToken token)
        {
            return token;
        }
    }
}
