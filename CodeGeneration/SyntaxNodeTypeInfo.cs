using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    sealed class SyntaxNodeTypeInfo
    {
        private static IReadOnlyList<SyntaxNodeTypeInfo> all;

        public static IReadOnlyList<SyntaxNodeTypeInfo> All
        {
            get
            {
                if (all == null)
                {
                    var nodeAssembly = typeof(CompilationUnitSyntax).Assembly;
                    all = nodeAssembly.GetTypes()
                        .Where(t => !t.IsAbstract && t.IsPublic && typeof(SyntaxNode).IsAssignableFrom(t))
                        .Select(t => new SyntaxNodeTypeInfo(t))
                        .OrderBy(t => t.NodeType.Name)
                        .ToArray();
                }

                return all;
            }
        }

        public SyntaxNodeTypeInfo(Type nodeType)
        {
            this.NodeType = nodeType;
            
            var properties = nodeType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var methods = nodeType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            var updateMethod = nodeType.GetMethod("Update", BindingFlags.Public | BindingFlags.Instance);
            var indexedUpdateParameters = updateMethod.GetParameters()
                .Select((param, index) => new { param, index });

            this.Properties = (from property in properties
                              where property.DeclaringType != typeof(SyntaxNode) && property.DeclaringType != typeof(CSharpSyntaxNode)
                              join method in methods on "With" + property.Name equals method.Name
                              join param in indexedUpdateParameters
                                on property.Name.ToUpperInvariant() equals param.param.Name.ToUpperInvariant()
                              orderby param.index
                              select new SyntaxNodePropertyInfo(property))
                              .ToArray(); 
        }

        public Type NodeType { get; }
        public IReadOnlyList<SyntaxNodePropertyInfo> Properties { get; }
    }

    enum SyntaxNodePropertyKind
    {
        Token,
        Node,
        TokenList,
        NodeList,
        SeparatedNodeList,
        NonSyntactic,
    }

    sealed class SyntaxNodePropertyInfo
    {
        public SyntaxNodePropertyInfo(PropertyInfo property)
        {
            this.Property = property;
            this.Kind = property.PropertyType == typeof(SyntaxToken) ? SyntaxNodePropertyKind.Token
                : property.PropertyType == typeof(SyntaxTokenList) ? SyntaxNodePropertyKind.TokenList
                : typeof(SyntaxNode).IsAssignableFrom(property.PropertyType) ? SyntaxNodePropertyKind.Node
                : property.PropertyType.IsGenericType 
                    && property.PropertyType.GetGenericTypeDefinition() == typeof(SyntaxList<>) ? SyntaxNodePropertyKind.NodeList
                : property.PropertyType.IsGenericType 
                    && property.PropertyType.GetGenericTypeDefinition() == typeof(SeparatedSyntaxList<>) ? SyntaxNodePropertyKind.SeparatedNodeList
                : SyntaxNodePropertyKind.NonSyntactic;
            this.Wither = property.DeclaringType.GetMethod("With" + property.Name, BindingFlags.Instance | BindingFlags.Public);
        }
        
        public SyntaxNodePropertyKind Kind { get; }
        public PropertyInfo Property { get; }
        public MethodInfo Wither { get; }
    }
}
