using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    class SyntaxLister
    {
        public void PrintSyntax(TextWriter writer)
        {
            foreach (var node in SyntaxNodeTypeInfo.All)
            {
                writer.WriteLine($"{node.NodeType.Name}: {string.Join(", ", node.Properties.Select(p => p.Property.Name))}");
            }
        }
    }
}
