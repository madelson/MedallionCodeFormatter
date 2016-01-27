using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGeneration
{
    internal class SyntaxInfoGenerator
    {
        private readonly TextWriter writer;

        public SyntaxInfoGenerator(TextWriter writer)
        {
            this.writer = writer;
        }

        public void Generate()
        {
            var namespaces = new[] { typeof(SyntaxNode).Namespace, typeof(CompilationUnitSyntax).Namespace, typeof(CSharpSyntaxNode).Namespace, typeof(IReadOnlyList<>).Namespace, }
                .Distinct();
            foreach (var @namespace in namespaces)
            {
                this.writer.WriteLine($"using {@namespace};");
            }
            this.writer.WriteLine();

            this.writer.WriteLine("namespace MedallionCodeFormatter");
            this.writer.WriteLine("{");

            for (var i = 0; i < SyntaxNodeTypeInfo.All.Count; ++i)
            {
                if (i > 0) { this.writer.WriteLine(); }
                this.Generate(SyntaxNodeTypeInfo.All[i]);
            }
            
            this.writer.WriteLine("}");
        }

        private void Generate(SyntaxNodeTypeInfo typeInfo)
        {
            this.writer.WriteLine($"\t#region ---- {typeInfo.NodeType.Name} ----");
            this.writer.WriteLine($"\tinternal static class {typeInfo.NodeType.Name.Replace("Syntax", string.Empty)}Info");
            this.writer.WriteLine("\t{");

            var properties = typeInfo.Properties.Where(p => p.Kind != SyntaxNodePropertyKind.NonSyntactic);
            foreach (var property in properties)
            {
                var fieldAndPropertyType = $"SyntaxNodeProperty<{typeInfo.NodeType.Name}, {GetName(property.Property.PropertyType)}>";

                string propertyImplementationType;
                switch (property.Kind)
                {
                    case SyntaxNodePropertyKind.Node:
                        propertyImplementationType = $"NodeProperty<{typeInfo.NodeType.Name}, {property.Property.PropertyType.Name}>";
                        break;
                    case SyntaxNodePropertyKind.NodeList:
                        propertyImplementationType = $"ListProperty<{typeInfo.NodeType.Name}, {property.Property.PropertyType.GetGenericArguments().Single().Name}>";
                        break;
                    case SyntaxNodePropertyKind.SeparatedNodeList:
                        propertyImplementationType = $"SeparatedListProperty<{typeInfo.NodeType.Name}, {property.Property.PropertyType.GetGenericArguments().Single().Name}>";
                        break;
                    case SyntaxNodePropertyKind.Token:
                        propertyImplementationType = $"TokenProperty<{typeInfo.NodeType.Name}>";
                        break;
                    case SyntaxNodePropertyKind.TokenList:
                        propertyImplementationType = $"TokenListProperty<{typeInfo.NodeType.Name}>";
                        break;
                    default:
                        throw new InvalidOperationException();
                }

                this.writer.WriteLine(
                    $"\t\tprivate static readonly {fieldAndPropertyType} {property.Property.Name}Property = new {propertyImplementationType}(\"{property.Property.Name}\", n => n.{property.Property.Name}, (n, v) => n.{property.Wither.Name}(v));"
                );
                this.writer.WriteLine();
                this.writer.WriteLine($"\t\tpublic static {fieldAndPropertyType} {property.Property.Name} => {property.Property.Name}Property;");
                this.writer.WriteLine();
            }

            var propertiesListElementType = $"ISyntaxNodePropertyWithTypedNode<{typeInfo.NodeType.Name}>";
            this.writer.WriteLine($"\t\tprivate static readonly {propertiesListElementType}[] PropertiesArray = new {propertiesListElementType}[] {{ {string.Join(", ", properties.Select(p => p.Property.Name))} }};");
            this.writer.WriteLine();
            this.writer.WriteLine($"\t\tpublic static IReadOnlyList<{propertiesListElementType}> Properties => PropertiesArray;");

            this.writer.WriteLine("\t}");
            this.writer.WriteLine("\t#endregion");
        }

        private static string GetName(Type type)
        {
            var name = type.Name;
            var nameWithGenerics = Regex.Replace(name, @"`\d+", _ => $"<{string.Join(", ", type.GetGenericArguments().Select(GetName))}>");
            return nameWithGenerics;
        }
    }
}
