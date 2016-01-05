using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.CodeAnalysis.Text;
using System.IO;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace MedallionCodeFormatter.Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Printer()
        {
            var kinds = Enum.GetValues(typeof(SyntaxKind))
                .Cast<SyntaxKind>()
                .Where(t => t.ToString().Contains("Token"))
                .Select(t => string.Format("case SyntaxKind.{0}:", t));
            File.WriteAllLines(@"c:\users\mikea_000\Desktop\output.txt", kinds);
        }

        [TestMethod]
        public void TryIt()
        {
            Console.WriteLine(default(SyntaxToken).LeadingTrivia.Count);
        }

        [TestMethod]
        public void BasicTest()
        {
            var path = @"C:\Users\mikea_000\Documents\Interests\CS\MedallionCodeFormatter\MedallionCodeFormatter.Tests\Test.cs";
            var sourceText = SourceText.From(File.OpenRead(path));
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(sourceText, path: path);
        }

        [TestMethod]
        public void RewriterTest()
        {
            var source = @"
using System;
using Abc;
using Foo = Bar;
using Bar = Foo;

namespace Foo
{
    using A.Foo;
    using A.Bar;

    public class Bar
    {
        public void Baz()
        {
            if (a) return;
        }
    }
}";

            var sourceText = SourceText.From(source);
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(sourceText);
            var rewriter = new SyntaxLevelRewriter();
            var result = rewriter.Visit(syntaxTree.GetRoot());

            Console.WriteLine(result.ToFullString());
        }
    }
}
