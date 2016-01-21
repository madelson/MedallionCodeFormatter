using Microsoft.CodeAnalysis.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter.Tests
{
    [TestClass]
    public class CollapserTest
    {
        [TestMethod]
        public void SimpleTest() 
        {
            var parsed = SyntaxFactory.ParseCompilationUnit(@"
                using Foo;

                namespace Bar
                {
                    public class Baz
                    {
                    }
                }"
            );

            var collapsed = Collapser.Collapse(parsed);
            Console.WriteLine(collapsed.ToFullString());
        }
    }
}
