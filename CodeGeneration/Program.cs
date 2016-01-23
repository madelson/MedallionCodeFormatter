using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            //new SyntaxLister().PrintSyntax(Console.Out);
            new CSharpSyntaxIncrementalRewriterGenerator(Console.Out).Generate();

            Console.ReadKey();
        }
    }
}
