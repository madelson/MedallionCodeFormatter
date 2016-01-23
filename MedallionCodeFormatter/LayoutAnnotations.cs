using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    public static class LayoutAnnotations
    {
        public const string HasMultiLineLeadingTriviaKind = "HasMultiLineLeadingTrivia";
        public static readonly SyntaxAnnotation MultiLineConstructAnnotation = new SyntaxAnnotation("MultiLineConstruct");
        
        public static SyntaxAnnotation CreateMultiLineTriviaAnnotation(IEnumerable<SyntaxTrivia> trivia)
        {
            return new SyntaxAnnotation(HasMultiLineLeadingTriviaKind, SyntaxFactory.TriviaList(trivia).ToFullString());
        }

        public static bool ContainsMultiLineLayoutAnnotations(this SyntaxNode node)
        {
            return node.DescendantNodesAndTokensAndSelf(
                    descendIntoChildren: child => child.ContainsAnnotations
                )
                .Any(not => not.HasAnnotations(not.IsToken ? HasMultiLineLeadingTriviaKind : MultiLineConstructAnnotation.Kind));    
        }

        public static bool ContainsMultiLineLayoutAnnotations(this SyntaxToken token)
        {
            return token.HasAnnotations(HasMultiLineLeadingTriviaKind);
        }
    }
}
