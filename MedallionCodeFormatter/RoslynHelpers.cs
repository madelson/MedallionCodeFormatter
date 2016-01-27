using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    static class RoslynHelpers
    {
        public static bool IsMultiLine(SyntaxTrivia trivia)
        {
            switch (trivia.Kind())
            {
                case SyntaxKind.EndOfLineTrivia:
                    return true;
                case SyntaxKind.WhitespaceTrivia:
                case SyntaxKind.SingleLineCommentTrivia:
                    return false;
                // todo could possibly optimize for structured trivia
                default:
                    return trivia.ToFullString().IndexOf('\n') >= 0;
            }
        }

        public static SyntaxToken GetToken(this SyntaxNodeOrToken nodeOrToken)
        {
            if (!nodeOrToken.IsToken) { throw new ArgumentException("expected token", nameof(nodeOrToken)); }

            return nodeOrToken.AsToken();
        }

        public static SyntaxNode GetNode(this SyntaxNodeOrToken nodeOrToken)
        {
            if (!nodeOrToken.IsNode) { throw new ArgumentException("expected node", nameof(nodeOrToken)); }

            return nodeOrToken.AsNode();
        }
    }
}
