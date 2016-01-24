using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    class CSharpSyntaxIncrementalRewriterGenerator
    {
        private readonly TextWriter writer;

        public CSharpSyntaxIncrementalRewriterGenerator(TextWriter writer)
        {
            this.writer = writer;
        }

        public void Generate()
        {
            var namespaces = new[] { typeof(SyntaxNode).Namespace, typeof(CompilationUnitSyntax).Namespace, typeof(CSharpSyntaxVisitor<>).Namespace }
                .Distinct();
            foreach (var @namespace in namespaces)
            {
                this.writer.WriteLine($"using {@namespace};");
            }
            this.writer.WriteLine();

            this.writer.WriteLine("namespace MedallionCodeFormatter");
            this.writer.WriteLine("{");
            this.writer.WriteLine("\tinternal partial class CSharpSyntaxIncrementalRewriter : CSharpSyntaxVisitor<SyntaxNode>");
            this.writer.WriteLine("\t{");

            for (var i = 0; i < SyntaxNodeTypeInfo.All.Count; ++i)
            {
                if (i != 0) { this.writer.WriteLine(); }
                this.GenerateVisitMethod(SyntaxNodeTypeInfo.All[i]);
            }

            this.writer.WriteLine("\t}");
            this.writer.WriteLine("}");
        }

        private void GenerateVisitMethod(SyntaxNodeTypeInfo type)
        {
            this.writer.WriteLine($"\t\tpublic override SyntaxNode Visit{type.NodeType.Name.Replace("Syntax", string.Empty)}({type.NodeType.Name} node)");
            this.writer.WriteLine("\t\t{");
            
            foreach (var property in type.Properties.Where(p => p.Kind != SyntaxNodePropertyKind.NonSyntactic))
            {
                this.writer.Write("\t\t\tnode = ");
                switch (property.Kind)
                {
                    case SyntaxNodePropertyKind.Node:
                    case SyntaxNodePropertyKind.Token:
                        var visitMethod = property.Kind == SyntaxNodePropertyKind.Node ? "TypedVisit" : "VisitToken";
                        this.writer.WriteLine($"node.{property.Wither.Name}(this.{visitMethod}(node.{property.Property.Name}));");
                        break;
                    case SyntaxNodePropertyKind.NodeList:
                    case SyntaxNodePropertyKind.SeparatedNodeList:
                    case SyntaxNodePropertyKind.TokenList:
                        var listName = property.Kind == SyntaxNodePropertyKind.NodeList ? "Syntax"
                            : property.Kind == SyntaxNodePropertyKind.SeparatedNodeList ? "SeparatedSyntax"
                            : "SyntaxToken";
                        this.writer.WriteLine($"this.IncrementalVisit{listName}List(node, n => n.{property.Property.Name}, (n, list) => n.{property.Wither.Name}(list));");
                        break;
                }
            }

            this.writer.WriteLine("\t\t\treturn node;");
            this.writer.WriteLine("\t\t}");
        }
    }
}
