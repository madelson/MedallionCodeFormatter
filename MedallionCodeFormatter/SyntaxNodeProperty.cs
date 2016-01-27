using MedallionCodeFormatter;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedallionCodeFormatter
{
    public interface ISyntaxNodeProperty
    {
        string Name { get; }
        Type PropertyType { get; }
        Type NodeType { get; }
        SyntaxNodeOrTokenList GetNodesOrTokens(SyntaxNode node);
        SyntaxNode WithNodesOrTokens(SyntaxNode node, SyntaxNodeOrTokenList nodesOrTokens);
    }

    public interface ISyntaxNodePropertyWithTypedNode<TNode> : ISyntaxNodeProperty
        where TNode : SyntaxNode
    {
        SyntaxNodeOrTokenList GetNodesOrTokens(TNode node);
        TNode WithNodesOrTokens(TNode node, SyntaxNodeOrTokenList nodesOrTokens);
    }

    public interface ISyntaxNodePropertyWithTypedProperty<TProperty> : ISyntaxNodeProperty
    {
        TProperty Get(SyntaxNode node);
        SyntaxNode With(SyntaxNode node, TProperty value);
    }

    public abstract class SyntaxNodeProperty<TNode, TProperty> : ISyntaxNodePropertyWithTypedNode<TNode>, ISyntaxNodePropertyWithTypedProperty<TProperty>
        where TNode : SyntaxNode
    {
        public abstract string Name { get; }
        public abstract TProperty Get(TNode node);
        public abstract TNode With(TNode node, TProperty value);
        protected abstract TProperty FromNodesOrTokens(SyntaxNodeOrTokenList nodesOrTokens);
        protected abstract SyntaxNodeOrTokenList ToNodesOrTokens(TProperty value);

        public SyntaxNodeOrTokenList GetNodesOrTokens(TNode node) => this.ToNodesOrTokens(this.Get(node));

        public TNode WithNodesOrTokens(TNode node, SyntaxNodeOrTokenList nodesOrTokens) => this.With(node, this.FromNodesOrTokens(nodesOrTokens));

        Type ISyntaxNodeProperty.NodeType => typeof(TNode);
        Type ISyntaxNodeProperty.PropertyType => typeof(TProperty);

        SyntaxNodeOrTokenList ISyntaxNodeProperty.GetNodesOrTokens(SyntaxNode node) => this.GetNodesOrTokens((TNode)node);

        SyntaxNode ISyntaxNodeProperty.WithNodesOrTokens(SyntaxNode node, SyntaxNodeOrTokenList nodesOrTokens) => this.WithNodesOrTokens((TNode)node, nodesOrTokens);

        TProperty ISyntaxNodePropertyWithTypedProperty<TProperty>.Get(SyntaxNode node) => this.Get((TNode)node);

        SyntaxNode ISyntaxNodePropertyWithTypedProperty<TProperty>.With(SyntaxNode node, TProperty value) => this.With((TNode)node, value);
    }

    #region ---- TokenProperty ----
    public sealed class TokenProperty<TNode> : SyntaxNodeProperty<TNode, SyntaxToken>
        where TNode : SyntaxNode
    {
        private readonly string name;
        private readonly Func<TNode, SyntaxToken> get;
        private readonly Func<TNode, SyntaxToken, TNode> with;

        public TokenProperty(string name, Func<TNode, SyntaxToken> get, Func<TNode, SyntaxToken, TNode> with)
        {
            this.name = name;
            this.get = get;
            this.with = with;
        }

        public override string Name => this.name;

        public override SyntaxToken Get(TNode node) => this.get(node);

        public override TNode With(TNode node, SyntaxToken value) => this.with(node, value);

        protected override SyntaxToken FromNodesOrTokens(SyntaxNodeOrTokenList nodesOrTokens)
        {
            if (nodesOrTokens.Count != 1) { throw new ArgumentException("expected singleton list", nameof(nodesOrTokens)); }

            return nodesOrTokens[0].GetToken();
        }

        protected override SyntaxNodeOrTokenList ToNodesOrTokens(SyntaxToken value) => SyntaxFactory.NodeOrTokenList(value);
    }
    #endregion

    #region ---- ListProperty ----
    public sealed class TokenListProperty<TNode> : SyntaxNodeProperty<TNode, SyntaxTokenList>
        where TNode : SyntaxNode
    {
        private readonly string name;
        private readonly Func<TNode, SyntaxTokenList> get;
        private readonly Func<TNode, SyntaxTokenList, TNode> with;

        public TokenListProperty(string name, Func<TNode, SyntaxTokenList> get, Func<TNode, SyntaxTokenList, TNode> with)
        {
            this.name = name;
            this.get = get;
            this.with = with;
        }

        public override string Name => this.name;

        public override SyntaxTokenList Get(TNode node) => this.get(node);

        public override TNode With(TNode node, SyntaxTokenList value) => this.with(node, value);

        protected override SyntaxTokenList FromNodesOrTokens(SyntaxNodeOrTokenList nodesOrTokens) => SyntaxFactory.TokenList(nodesOrTokens.Select(RoslynHelpers.GetToken));

        protected override SyntaxNodeOrTokenList ToNodesOrTokens(SyntaxTokenList value) => SyntaxFactory.NodeOrTokenList(value.Select(n => (SyntaxNodeOrToken)n));
    }
    #endregion

    #region ---- NodeProperty ----
    public sealed class NodeProperty<TNode, TPropertyNode> : SyntaxNodeProperty<TNode, TPropertyNode>
        where TNode : SyntaxNode
        where TPropertyNode : SyntaxNode
    {
        private readonly string name;
        private readonly Func<TNode, TPropertyNode> get;
        private readonly Func<TNode, TPropertyNode, TNode> with;

        public NodeProperty(string name, Func<TNode, TPropertyNode> get, Func<TNode, TPropertyNode, TNode> with)
        {
            this.name = name;
            this.get = get;
            this.with = with;
        }

        public override string Name => this.name;

        public override TPropertyNode Get(TNode node) => this.get(node);

        public override TNode With(TNode node, TPropertyNode value) => this.with(node, value);

        protected override TPropertyNode FromNodesOrTokens(SyntaxNodeOrTokenList nodesOrTokens)
        {
            if (nodesOrTokens.Count != 1) { throw new ArgumentException("expected singleton list", nameof(nodesOrTokens)); }

            return (TPropertyNode)nodesOrTokens[0].GetNode();
        }

        protected override SyntaxNodeOrTokenList ToNodesOrTokens(TPropertyNode value) => SyntaxFactory.NodeOrTokenList(value);
    }
    #endregion

    #region ---- ListProperty ----
    public sealed class ListProperty<TNode, TElementNode> : SyntaxNodeProperty<TNode, SyntaxList<TElementNode>>
        where TNode : SyntaxNode
        where TElementNode : SyntaxNode
    {
        private readonly string name;
        private readonly Func<TNode, SyntaxList<TElementNode>> get;
        private readonly Func<TNode, SyntaxList<TElementNode>, TNode> with;

        public ListProperty(string name, Func<TNode, SyntaxList<TElementNode>> get, Func<TNode, SyntaxList<TElementNode>, TNode> with)
        {
            this.name = name;
            this.get = get;
            this.with = with;
        }

        public override string Name => this.name;

        public override SyntaxList<TElementNode> Get(TNode node) => this.get(node);

        public override TNode With(TNode node, SyntaxList<TElementNode> value) => this.with(node, value);

        protected override SyntaxList<TElementNode> FromNodesOrTokens(SyntaxNodeOrTokenList nodesOrTokens)
            => SyntaxFactory.List(nodesOrTokens.Select(not => (TElementNode)not.GetNode()));

        protected override SyntaxNodeOrTokenList ToNodesOrTokens(SyntaxList<TElementNode> value) => SyntaxFactory.NodeOrTokenList(value.Select(n => (SyntaxNodeOrToken)n));
    }
    #endregion

    #region ---- SeparatedListProperty ----
    public sealed class SeparatedListProperty<TNode, TElementNode> : SyntaxNodeProperty<TNode, SeparatedSyntaxList<TElementNode>>
        where TNode : SyntaxNode
        where TElementNode : SyntaxNode
    {
        private readonly string name;
        private readonly Func<TNode, SeparatedSyntaxList<TElementNode>> get;
        private readonly Func<TNode, SeparatedSyntaxList<TElementNode>, TNode> with;

        public SeparatedListProperty(string name, Func<TNode, SeparatedSyntaxList<TElementNode>> get, Func<TNode, SeparatedSyntaxList<TElementNode>, TNode> with)
        {
            this.name = name;
            this.get = get;
            this.with = with;
        }

        public override string Name => this.name;

        public override SeparatedSyntaxList<TElementNode> Get(TNode node) => this.get(node);

        public override TNode With(TNode node, SeparatedSyntaxList<TElementNode> value) => this.with(node, value);

        protected override SeparatedSyntaxList<TElementNode> FromNodesOrTokens(SyntaxNodeOrTokenList nodesOrTokens) => SyntaxFactory.SeparatedList<TElementNode>(nodesOrTokens);

        protected override SyntaxNodeOrTokenList ToNodesOrTokens(SeparatedSyntaxList<TElementNode> value) => value.GetWithSeparators();
    }
    #endregion
}
