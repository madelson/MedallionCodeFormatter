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

        public static SyntaxAnnotation CreateMultiLineTriviaAnnotation(IEnumerable<SyntaxTrivia> trivia)
        {
            return new SyntaxAnnotation(HasMultiLineLeadingTriviaKind, SyntaxFactory.TriviaList(trivia).ToFullString());
        }

        public static readonly SyntaxAnnotation MultiLineConstructAnnotation = new SyntaxAnnotation("MultiLineConstruct");
    }
}
