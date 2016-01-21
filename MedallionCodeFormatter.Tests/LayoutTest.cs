using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter.Tests
{
    [TestClass]
    public class LayoutTest
    {
        [TestMethod]
        public void BlockTest()
        {
            var block = SyntaxFactory.ParseExpression("() => { foo(); bar(); baz(); }")
                .DescendantNodes()
                .Single(n => n.Kind() == SyntaxKind.Block);

            var result = new LayoutEngine(LayoutOptions.Default).PerformLayout(block);

            Console.WriteLine(result.ToFullString().Replace("\t", @"\t"));
        }
    }
}
