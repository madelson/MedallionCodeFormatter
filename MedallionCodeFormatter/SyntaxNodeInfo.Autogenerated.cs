using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;

namespace MedallionCodeFormatter
{
	internal static class AccessorDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<AccessorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<AccessorDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<AccessorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<AccessorDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<AccessorDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<AccessorDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<AccessorDeclarationSyntax, SyntaxToken> KeywordProperty = new TokenProperty<AccessorDeclarationSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<AccessorDeclarationSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<AccessorDeclarationSyntax, BlockSyntax> BodyProperty = new NodeProperty<AccessorDeclarationSyntax, BlockSyntax>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<AccessorDeclarationSyntax, BlockSyntax> Body => BodyProperty;

		private static readonly SyntaxNodeProperty<AccessorDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<AccessorDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<AccessorDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AccessorDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AccessorDeclarationSyntax>[] { AttributeLists, Modifiers, Keyword, Body, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AccessorDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class AccessorListInfo
	{
		private static readonly SyntaxNodeProperty<AccessorListSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<AccessorListSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<AccessorListSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<AccessorListSyntax, SyntaxList<AccessorDeclarationSyntax>> AccessorsProperty = new ListProperty<AccessorListSyntax, AccessorDeclarationSyntax>("Accessors", n => n.Accessors, (n, v) => n.WithAccessors(v));

		public static SyntaxNodeProperty<AccessorListSyntax, SyntaxList<AccessorDeclarationSyntax>> Accessors => AccessorsProperty;

		private static readonly SyntaxNodeProperty<AccessorListSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<AccessorListSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<AccessorListSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AccessorListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AccessorListSyntax>[] { OpenBraceToken, Accessors, CloseBraceToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AccessorListSyntax>> Properties => PropertiesArray;
	}

	internal static class AliasQualifiedNameInfo
	{
		private static readonly SyntaxNodeProperty<AliasQualifiedNameSyntax, IdentifierNameSyntax> AliasProperty = new NodeProperty<AliasQualifiedNameSyntax, IdentifierNameSyntax>("Alias", n => n.Alias, (n, v) => n.WithAlias(v));

		public static SyntaxNodeProperty<AliasQualifiedNameSyntax, IdentifierNameSyntax> Alias => AliasProperty;

		private static readonly SyntaxNodeProperty<AliasQualifiedNameSyntax, SyntaxToken> ColonColonTokenProperty = new TokenProperty<AliasQualifiedNameSyntax>("ColonColonToken", n => n.ColonColonToken, (n, v) => n.WithColonColonToken(v));

		public static SyntaxNodeProperty<AliasQualifiedNameSyntax, SyntaxToken> ColonColonToken => ColonColonTokenProperty;

		private static readonly SyntaxNodeProperty<AliasQualifiedNameSyntax, SimpleNameSyntax> NameProperty = new NodeProperty<AliasQualifiedNameSyntax, SimpleNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<AliasQualifiedNameSyntax, SimpleNameSyntax> Name => NameProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AliasQualifiedNameSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AliasQualifiedNameSyntax>[] { Alias, ColonColonToken, Name };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AliasQualifiedNameSyntax>> Properties => PropertiesArray;
	}

	internal static class AnonymousMethodExpressionInfo
	{
		private static readonly SyntaxNodeProperty<AnonymousMethodExpressionSyntax, SyntaxToken> AsyncKeywordProperty = new TokenProperty<AnonymousMethodExpressionSyntax>("AsyncKeyword", n => n.AsyncKeyword, (n, v) => n.WithAsyncKeyword(v));

		public static SyntaxNodeProperty<AnonymousMethodExpressionSyntax, SyntaxToken> AsyncKeyword => AsyncKeywordProperty;

		private static readonly SyntaxNodeProperty<AnonymousMethodExpressionSyntax, SyntaxToken> DelegateKeywordProperty = new TokenProperty<AnonymousMethodExpressionSyntax>("DelegateKeyword", n => n.DelegateKeyword, (n, v) => n.WithDelegateKeyword(v));

		public static SyntaxNodeProperty<AnonymousMethodExpressionSyntax, SyntaxToken> DelegateKeyword => DelegateKeywordProperty;

		private static readonly SyntaxNodeProperty<AnonymousMethodExpressionSyntax, ParameterListSyntax> ParameterListProperty = new NodeProperty<AnonymousMethodExpressionSyntax, ParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<AnonymousMethodExpressionSyntax, ParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<AnonymousMethodExpressionSyntax, CSharpSyntaxNode> BodyProperty = new NodeProperty<AnonymousMethodExpressionSyntax, CSharpSyntaxNode>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<AnonymousMethodExpressionSyntax, CSharpSyntaxNode> Body => BodyProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AnonymousMethodExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AnonymousMethodExpressionSyntax>[] { AsyncKeyword, DelegateKeyword, ParameterList, Body };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AnonymousMethodExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class AnonymousObjectCreationExpressionInfo
	{
		private static readonly SyntaxNodeProperty<AnonymousObjectCreationExpressionSyntax, SyntaxToken> NewKeywordProperty = new TokenProperty<AnonymousObjectCreationExpressionSyntax>("NewKeyword", n => n.NewKeyword, (n, v) => n.WithNewKeyword(v));

		public static SyntaxNodeProperty<AnonymousObjectCreationExpressionSyntax, SyntaxToken> NewKeyword => NewKeywordProperty;

		private static readonly SyntaxNodeProperty<AnonymousObjectCreationExpressionSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<AnonymousObjectCreationExpressionSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<AnonymousObjectCreationExpressionSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<AnonymousObjectCreationExpressionSyntax, SeparatedSyntaxList<AnonymousObjectMemberDeclaratorSyntax>> InitializersProperty = new SeparatedListProperty<AnonymousObjectCreationExpressionSyntax, AnonymousObjectMemberDeclaratorSyntax>("Initializers", n => n.Initializers, (n, v) => n.WithInitializers(v));

		public static SyntaxNodeProperty<AnonymousObjectCreationExpressionSyntax, SeparatedSyntaxList<AnonymousObjectMemberDeclaratorSyntax>> Initializers => InitializersProperty;

		private static readonly SyntaxNodeProperty<AnonymousObjectCreationExpressionSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<AnonymousObjectCreationExpressionSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<AnonymousObjectCreationExpressionSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AnonymousObjectCreationExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AnonymousObjectCreationExpressionSyntax>[] { NewKeyword, OpenBraceToken, Initializers, CloseBraceToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AnonymousObjectCreationExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class AnonymousObjectMemberDeclaratorInfo
	{
		private static readonly SyntaxNodeProperty<AnonymousObjectMemberDeclaratorSyntax, NameEqualsSyntax> NameEqualsProperty = new NodeProperty<AnonymousObjectMemberDeclaratorSyntax, NameEqualsSyntax>("NameEquals", n => n.NameEquals, (n, v) => n.WithNameEquals(v));

		public static SyntaxNodeProperty<AnonymousObjectMemberDeclaratorSyntax, NameEqualsSyntax> NameEquals => NameEqualsProperty;

		private static readonly SyntaxNodeProperty<AnonymousObjectMemberDeclaratorSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<AnonymousObjectMemberDeclaratorSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<AnonymousObjectMemberDeclaratorSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AnonymousObjectMemberDeclaratorSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AnonymousObjectMemberDeclaratorSyntax>[] { NameEquals, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AnonymousObjectMemberDeclaratorSyntax>> Properties => PropertiesArray;
	}

	internal static class ArgumentListInfo
	{
		private static readonly SyntaxNodeProperty<ArgumentListSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<ArgumentListSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<ArgumentListSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<ArgumentListSyntax, SeparatedSyntaxList<ArgumentSyntax>> ArgumentsProperty = new SeparatedListProperty<ArgumentListSyntax, ArgumentSyntax>("Arguments", n => n.Arguments, (n, v) => n.WithArguments(v));

		public static SyntaxNodeProperty<ArgumentListSyntax, SeparatedSyntaxList<ArgumentSyntax>> Arguments => ArgumentsProperty;

		private static readonly SyntaxNodeProperty<ArgumentListSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<ArgumentListSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<ArgumentListSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ArgumentListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ArgumentListSyntax>[] { OpenParenToken, Arguments, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ArgumentListSyntax>> Properties => PropertiesArray;
	}

	internal static class ArgumentInfo
	{
		private static readonly SyntaxNodeProperty<ArgumentSyntax, NameColonSyntax> NameColonProperty = new NodeProperty<ArgumentSyntax, NameColonSyntax>("NameColon", n => n.NameColon, (n, v) => n.WithNameColon(v));

		public static SyntaxNodeProperty<ArgumentSyntax, NameColonSyntax> NameColon => NameColonProperty;

		private static readonly SyntaxNodeProperty<ArgumentSyntax, SyntaxToken> RefOrOutKeywordProperty = new TokenProperty<ArgumentSyntax>("RefOrOutKeyword", n => n.RefOrOutKeyword, (n, v) => n.WithRefOrOutKeyword(v));

		public static SyntaxNodeProperty<ArgumentSyntax, SyntaxToken> RefOrOutKeyword => RefOrOutKeywordProperty;

		private static readonly SyntaxNodeProperty<ArgumentSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ArgumentSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ArgumentSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ArgumentSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ArgumentSyntax>[] { NameColon, RefOrOutKeyword, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ArgumentSyntax>> Properties => PropertiesArray;
	}

	internal static class ArrayCreationExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ArrayCreationExpressionSyntax, SyntaxToken> NewKeywordProperty = new TokenProperty<ArrayCreationExpressionSyntax>("NewKeyword", n => n.NewKeyword, (n, v) => n.WithNewKeyword(v));

		public static SyntaxNodeProperty<ArrayCreationExpressionSyntax, SyntaxToken> NewKeyword => NewKeywordProperty;

		private static readonly SyntaxNodeProperty<ArrayCreationExpressionSyntax, ArrayTypeSyntax> TypeProperty = new NodeProperty<ArrayCreationExpressionSyntax, ArrayTypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<ArrayCreationExpressionSyntax, ArrayTypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<ArrayCreationExpressionSyntax, InitializerExpressionSyntax> InitializerProperty = new NodeProperty<ArrayCreationExpressionSyntax, InitializerExpressionSyntax>("Initializer", n => n.Initializer, (n, v) => n.WithInitializer(v));

		public static SyntaxNodeProperty<ArrayCreationExpressionSyntax, InitializerExpressionSyntax> Initializer => InitializerProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ArrayCreationExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ArrayCreationExpressionSyntax>[] { NewKeyword, Type, Initializer };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ArrayCreationExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ArrayRankSpecifierInfo
	{
		private static readonly SyntaxNodeProperty<ArrayRankSpecifierSyntax, SyntaxToken> OpenBracketTokenProperty = new TokenProperty<ArrayRankSpecifierSyntax>("OpenBracketToken", n => n.OpenBracketToken, (n, v) => n.WithOpenBracketToken(v));

		public static SyntaxNodeProperty<ArrayRankSpecifierSyntax, SyntaxToken> OpenBracketToken => OpenBracketTokenProperty;

		private static readonly SyntaxNodeProperty<ArrayRankSpecifierSyntax, SeparatedSyntaxList<ExpressionSyntax>> SizesProperty = new SeparatedListProperty<ArrayRankSpecifierSyntax, ExpressionSyntax>("Sizes", n => n.Sizes, (n, v) => n.WithSizes(v));

		public static SyntaxNodeProperty<ArrayRankSpecifierSyntax, SeparatedSyntaxList<ExpressionSyntax>> Sizes => SizesProperty;

		private static readonly SyntaxNodeProperty<ArrayRankSpecifierSyntax, SyntaxToken> CloseBracketTokenProperty = new TokenProperty<ArrayRankSpecifierSyntax>("CloseBracketToken", n => n.CloseBracketToken, (n, v) => n.WithCloseBracketToken(v));

		public static SyntaxNodeProperty<ArrayRankSpecifierSyntax, SyntaxToken> CloseBracketToken => CloseBracketTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ArrayRankSpecifierSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ArrayRankSpecifierSyntax>[] { OpenBracketToken, Sizes, CloseBracketToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ArrayRankSpecifierSyntax>> Properties => PropertiesArray;
	}

	internal static class ArrayTypeInfo
	{
		private static readonly SyntaxNodeProperty<ArrayTypeSyntax, TypeSyntax> ElementTypeProperty = new NodeProperty<ArrayTypeSyntax, TypeSyntax>("ElementType", n => n.ElementType, (n, v) => n.WithElementType(v));

		public static SyntaxNodeProperty<ArrayTypeSyntax, TypeSyntax> ElementType => ElementTypeProperty;

		private static readonly SyntaxNodeProperty<ArrayTypeSyntax, SyntaxList<ArrayRankSpecifierSyntax>> RankSpecifiersProperty = new ListProperty<ArrayTypeSyntax, ArrayRankSpecifierSyntax>("RankSpecifiers", n => n.RankSpecifiers, (n, v) => n.WithRankSpecifiers(v));

		public static SyntaxNodeProperty<ArrayTypeSyntax, SyntaxList<ArrayRankSpecifierSyntax>> RankSpecifiers => RankSpecifiersProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ArrayTypeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ArrayTypeSyntax>[] { ElementType, RankSpecifiers };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ArrayTypeSyntax>> Properties => PropertiesArray;
	}

	internal static class ArrowExpressionClauseInfo
	{
		private static readonly SyntaxNodeProperty<ArrowExpressionClauseSyntax, SyntaxToken> ArrowTokenProperty = new TokenProperty<ArrowExpressionClauseSyntax>("ArrowToken", n => n.ArrowToken, (n, v) => n.WithArrowToken(v));

		public static SyntaxNodeProperty<ArrowExpressionClauseSyntax, SyntaxToken> ArrowToken => ArrowTokenProperty;

		private static readonly SyntaxNodeProperty<ArrowExpressionClauseSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ArrowExpressionClauseSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ArrowExpressionClauseSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ArrowExpressionClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ArrowExpressionClauseSyntax>[] { ArrowToken, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ArrowExpressionClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class AssignmentExpressionInfo
	{
		private static readonly SyntaxNodeProperty<AssignmentExpressionSyntax, ExpressionSyntax> LeftProperty = new NodeProperty<AssignmentExpressionSyntax, ExpressionSyntax>("Left", n => n.Left, (n, v) => n.WithLeft(v));

		public static SyntaxNodeProperty<AssignmentExpressionSyntax, ExpressionSyntax> Left => LeftProperty;

		private static readonly SyntaxNodeProperty<AssignmentExpressionSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<AssignmentExpressionSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<AssignmentExpressionSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly SyntaxNodeProperty<AssignmentExpressionSyntax, ExpressionSyntax> RightProperty = new NodeProperty<AssignmentExpressionSyntax, ExpressionSyntax>("Right", n => n.Right, (n, v) => n.WithRight(v));

		public static SyntaxNodeProperty<AssignmentExpressionSyntax, ExpressionSyntax> Right => RightProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AssignmentExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AssignmentExpressionSyntax>[] { Left, OperatorToken, Right };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AssignmentExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class AttributeArgumentListInfo
	{
		private static readonly SyntaxNodeProperty<AttributeArgumentListSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<AttributeArgumentListSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<AttributeArgumentListSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<AttributeArgumentListSyntax, SeparatedSyntaxList<AttributeArgumentSyntax>> ArgumentsProperty = new SeparatedListProperty<AttributeArgumentListSyntax, AttributeArgumentSyntax>("Arguments", n => n.Arguments, (n, v) => n.WithArguments(v));

		public static SyntaxNodeProperty<AttributeArgumentListSyntax, SeparatedSyntaxList<AttributeArgumentSyntax>> Arguments => ArgumentsProperty;

		private static readonly SyntaxNodeProperty<AttributeArgumentListSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<AttributeArgumentListSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<AttributeArgumentListSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AttributeArgumentListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AttributeArgumentListSyntax>[] { OpenParenToken, Arguments, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AttributeArgumentListSyntax>> Properties => PropertiesArray;
	}

	internal static class AttributeArgumentInfo
	{
		private static readonly SyntaxNodeProperty<AttributeArgumentSyntax, NameEqualsSyntax> NameEqualsProperty = new NodeProperty<AttributeArgumentSyntax, NameEqualsSyntax>("NameEquals", n => n.NameEquals, (n, v) => n.WithNameEquals(v));

		public static SyntaxNodeProperty<AttributeArgumentSyntax, NameEqualsSyntax> NameEquals => NameEqualsProperty;

		private static readonly SyntaxNodeProperty<AttributeArgumentSyntax, NameColonSyntax> NameColonProperty = new NodeProperty<AttributeArgumentSyntax, NameColonSyntax>("NameColon", n => n.NameColon, (n, v) => n.WithNameColon(v));

		public static SyntaxNodeProperty<AttributeArgumentSyntax, NameColonSyntax> NameColon => NameColonProperty;

		private static readonly SyntaxNodeProperty<AttributeArgumentSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<AttributeArgumentSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<AttributeArgumentSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AttributeArgumentSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AttributeArgumentSyntax>[] { NameEquals, NameColon, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AttributeArgumentSyntax>> Properties => PropertiesArray;
	}

	internal static class AttributeListInfo
	{
		private static readonly SyntaxNodeProperty<AttributeListSyntax, SyntaxToken> OpenBracketTokenProperty = new TokenProperty<AttributeListSyntax>("OpenBracketToken", n => n.OpenBracketToken, (n, v) => n.WithOpenBracketToken(v));

		public static SyntaxNodeProperty<AttributeListSyntax, SyntaxToken> OpenBracketToken => OpenBracketTokenProperty;

		private static readonly SyntaxNodeProperty<AttributeListSyntax, AttributeTargetSpecifierSyntax> TargetProperty = new NodeProperty<AttributeListSyntax, AttributeTargetSpecifierSyntax>("Target", n => n.Target, (n, v) => n.WithTarget(v));

		public static SyntaxNodeProperty<AttributeListSyntax, AttributeTargetSpecifierSyntax> Target => TargetProperty;

		private static readonly SyntaxNodeProperty<AttributeListSyntax, SeparatedSyntaxList<AttributeSyntax>> AttributesProperty = new SeparatedListProperty<AttributeListSyntax, AttributeSyntax>("Attributes", n => n.Attributes, (n, v) => n.WithAttributes(v));

		public static SyntaxNodeProperty<AttributeListSyntax, SeparatedSyntaxList<AttributeSyntax>> Attributes => AttributesProperty;

		private static readonly SyntaxNodeProperty<AttributeListSyntax, SyntaxToken> CloseBracketTokenProperty = new TokenProperty<AttributeListSyntax>("CloseBracketToken", n => n.CloseBracketToken, (n, v) => n.WithCloseBracketToken(v));

		public static SyntaxNodeProperty<AttributeListSyntax, SyntaxToken> CloseBracketToken => CloseBracketTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AttributeListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AttributeListSyntax>[] { OpenBracketToken, Target, Attributes, CloseBracketToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AttributeListSyntax>> Properties => PropertiesArray;
	}

	internal static class AttributeInfo
	{
		private static readonly SyntaxNodeProperty<AttributeSyntax, NameSyntax> NameProperty = new NodeProperty<AttributeSyntax, NameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<AttributeSyntax, NameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<AttributeSyntax, AttributeArgumentListSyntax> ArgumentListProperty = new NodeProperty<AttributeSyntax, AttributeArgumentListSyntax>("ArgumentList", n => n.ArgumentList, (n, v) => n.WithArgumentList(v));

		public static SyntaxNodeProperty<AttributeSyntax, AttributeArgumentListSyntax> ArgumentList => ArgumentListProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AttributeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AttributeSyntax>[] { Name, ArgumentList };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AttributeSyntax>> Properties => PropertiesArray;
	}

	internal static class AttributeTargetSpecifierInfo
	{
		private static readonly SyntaxNodeProperty<AttributeTargetSpecifierSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<AttributeTargetSpecifierSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<AttributeTargetSpecifierSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<AttributeTargetSpecifierSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<AttributeTargetSpecifierSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<AttributeTargetSpecifierSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AttributeTargetSpecifierSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AttributeTargetSpecifierSyntax>[] { Identifier, ColonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AttributeTargetSpecifierSyntax>> Properties => PropertiesArray;
	}

	internal static class AwaitExpressionInfo
	{
		private static readonly SyntaxNodeProperty<AwaitExpressionSyntax, SyntaxToken> AwaitKeywordProperty = new TokenProperty<AwaitExpressionSyntax>("AwaitKeyword", n => n.AwaitKeyword, (n, v) => n.WithAwaitKeyword(v));

		public static SyntaxNodeProperty<AwaitExpressionSyntax, SyntaxToken> AwaitKeyword => AwaitKeywordProperty;

		private static readonly SyntaxNodeProperty<AwaitExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<AwaitExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<AwaitExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<AwaitExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<AwaitExpressionSyntax>[] { AwaitKeyword, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<AwaitExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class BadDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<BadDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<BadDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<BadDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<BadDirectiveTriviaSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<BadDirectiveTriviaSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<BadDirectiveTriviaSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<BadDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<BadDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<BadDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<BadDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<BadDirectiveTriviaSyntax>[] { HashToken, Identifier, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<BadDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class BaseExpressionInfo
	{
		private static readonly SyntaxNodeProperty<BaseExpressionSyntax, SyntaxToken> TokenProperty = new TokenProperty<BaseExpressionSyntax>("Token", n => n.Token, (n, v) => n.WithToken(v));

		public static SyntaxNodeProperty<BaseExpressionSyntax, SyntaxToken> Token => TokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<BaseExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<BaseExpressionSyntax>[] { Token };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<BaseExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class BaseListInfo
	{
		private static readonly SyntaxNodeProperty<BaseListSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<BaseListSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<BaseListSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly SyntaxNodeProperty<BaseListSyntax, SeparatedSyntaxList<BaseTypeSyntax>> TypesProperty = new SeparatedListProperty<BaseListSyntax, BaseTypeSyntax>("Types", n => n.Types, (n, v) => n.WithTypes(v));

		public static SyntaxNodeProperty<BaseListSyntax, SeparatedSyntaxList<BaseTypeSyntax>> Types => TypesProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<BaseListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<BaseListSyntax>[] { ColonToken, Types };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<BaseListSyntax>> Properties => PropertiesArray;
	}

	internal static class BinaryExpressionInfo
	{
		private static readonly SyntaxNodeProperty<BinaryExpressionSyntax, ExpressionSyntax> LeftProperty = new NodeProperty<BinaryExpressionSyntax, ExpressionSyntax>("Left", n => n.Left, (n, v) => n.WithLeft(v));

		public static SyntaxNodeProperty<BinaryExpressionSyntax, ExpressionSyntax> Left => LeftProperty;

		private static readonly SyntaxNodeProperty<BinaryExpressionSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<BinaryExpressionSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<BinaryExpressionSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly SyntaxNodeProperty<BinaryExpressionSyntax, ExpressionSyntax> RightProperty = new NodeProperty<BinaryExpressionSyntax, ExpressionSyntax>("Right", n => n.Right, (n, v) => n.WithRight(v));

		public static SyntaxNodeProperty<BinaryExpressionSyntax, ExpressionSyntax> Right => RightProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<BinaryExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<BinaryExpressionSyntax>[] { Left, OperatorToken, Right };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<BinaryExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class BlockInfo
	{
		private static readonly SyntaxNodeProperty<BlockSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<BlockSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<BlockSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<BlockSyntax, SyntaxList<StatementSyntax>> StatementsProperty = new ListProperty<BlockSyntax, StatementSyntax>("Statements", n => n.Statements, (n, v) => n.WithStatements(v));

		public static SyntaxNodeProperty<BlockSyntax, SyntaxList<StatementSyntax>> Statements => StatementsProperty;

		private static readonly SyntaxNodeProperty<BlockSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<BlockSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<BlockSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<BlockSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<BlockSyntax>[] { OpenBraceToken, Statements, CloseBraceToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<BlockSyntax>> Properties => PropertiesArray;
	}

	internal static class BracketedArgumentListInfo
	{
		private static readonly SyntaxNodeProperty<BracketedArgumentListSyntax, SyntaxToken> OpenBracketTokenProperty = new TokenProperty<BracketedArgumentListSyntax>("OpenBracketToken", n => n.OpenBracketToken, (n, v) => n.WithOpenBracketToken(v));

		public static SyntaxNodeProperty<BracketedArgumentListSyntax, SyntaxToken> OpenBracketToken => OpenBracketTokenProperty;

		private static readonly SyntaxNodeProperty<BracketedArgumentListSyntax, SeparatedSyntaxList<ArgumentSyntax>> ArgumentsProperty = new SeparatedListProperty<BracketedArgumentListSyntax, ArgumentSyntax>("Arguments", n => n.Arguments, (n, v) => n.WithArguments(v));

		public static SyntaxNodeProperty<BracketedArgumentListSyntax, SeparatedSyntaxList<ArgumentSyntax>> Arguments => ArgumentsProperty;

		private static readonly SyntaxNodeProperty<BracketedArgumentListSyntax, SyntaxToken> CloseBracketTokenProperty = new TokenProperty<BracketedArgumentListSyntax>("CloseBracketToken", n => n.CloseBracketToken, (n, v) => n.WithCloseBracketToken(v));

		public static SyntaxNodeProperty<BracketedArgumentListSyntax, SyntaxToken> CloseBracketToken => CloseBracketTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<BracketedArgumentListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<BracketedArgumentListSyntax>[] { OpenBracketToken, Arguments, CloseBracketToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<BracketedArgumentListSyntax>> Properties => PropertiesArray;
	}

	internal static class BracketedParameterListInfo
	{
		private static readonly SyntaxNodeProperty<BracketedParameterListSyntax, SyntaxToken> OpenBracketTokenProperty = new TokenProperty<BracketedParameterListSyntax>("OpenBracketToken", n => n.OpenBracketToken, (n, v) => n.WithOpenBracketToken(v));

		public static SyntaxNodeProperty<BracketedParameterListSyntax, SyntaxToken> OpenBracketToken => OpenBracketTokenProperty;

		private static readonly SyntaxNodeProperty<BracketedParameterListSyntax, SeparatedSyntaxList<ParameterSyntax>> ParametersProperty = new SeparatedListProperty<BracketedParameterListSyntax, ParameterSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<BracketedParameterListSyntax, SeparatedSyntaxList<ParameterSyntax>> Parameters => ParametersProperty;

		private static readonly SyntaxNodeProperty<BracketedParameterListSyntax, SyntaxToken> CloseBracketTokenProperty = new TokenProperty<BracketedParameterListSyntax>("CloseBracketToken", n => n.CloseBracketToken, (n, v) => n.WithCloseBracketToken(v));

		public static SyntaxNodeProperty<BracketedParameterListSyntax, SyntaxToken> CloseBracketToken => CloseBracketTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<BracketedParameterListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<BracketedParameterListSyntax>[] { OpenBracketToken, Parameters, CloseBracketToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<BracketedParameterListSyntax>> Properties => PropertiesArray;
	}

	internal static class BreakStatementInfo
	{
		private static readonly SyntaxNodeProperty<BreakStatementSyntax, SyntaxToken> BreakKeywordProperty = new TokenProperty<BreakStatementSyntax>("BreakKeyword", n => n.BreakKeyword, (n, v) => n.WithBreakKeyword(v));

		public static SyntaxNodeProperty<BreakStatementSyntax, SyntaxToken> BreakKeyword => BreakKeywordProperty;

		private static readonly SyntaxNodeProperty<BreakStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<BreakStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<BreakStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<BreakStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<BreakStatementSyntax>[] { BreakKeyword, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<BreakStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class CaseSwitchLabelInfo
	{
		private static readonly SyntaxNodeProperty<CaseSwitchLabelSyntax, SyntaxToken> KeywordProperty = new TokenProperty<CaseSwitchLabelSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<CaseSwitchLabelSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<CaseSwitchLabelSyntax, ExpressionSyntax> ValueProperty = new NodeProperty<CaseSwitchLabelSyntax, ExpressionSyntax>("Value", n => n.Value, (n, v) => n.WithValue(v));

		public static SyntaxNodeProperty<CaseSwitchLabelSyntax, ExpressionSyntax> Value => ValueProperty;

		private static readonly SyntaxNodeProperty<CaseSwitchLabelSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<CaseSwitchLabelSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<CaseSwitchLabelSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CaseSwitchLabelSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CaseSwitchLabelSyntax>[] { Keyword, Value, ColonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CaseSwitchLabelSyntax>> Properties => PropertiesArray;
	}

	internal static class CastExpressionInfo
	{
		private static readonly SyntaxNodeProperty<CastExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<CastExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<CastExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<CastExpressionSyntax, TypeSyntax> TypeProperty = new NodeProperty<CastExpressionSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<CastExpressionSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<CastExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<CastExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<CastExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<CastExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<CastExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<CastExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CastExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CastExpressionSyntax>[] { OpenParenToken, Type, CloseParenToken, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CastExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class CatchClauseInfo
	{
		private static readonly SyntaxNodeProperty<CatchClauseSyntax, SyntaxToken> CatchKeywordProperty = new TokenProperty<CatchClauseSyntax>("CatchKeyword", n => n.CatchKeyword, (n, v) => n.WithCatchKeyword(v));

		public static SyntaxNodeProperty<CatchClauseSyntax, SyntaxToken> CatchKeyword => CatchKeywordProperty;

		private static readonly SyntaxNodeProperty<CatchClauseSyntax, CatchDeclarationSyntax> DeclarationProperty = new NodeProperty<CatchClauseSyntax, CatchDeclarationSyntax>("Declaration", n => n.Declaration, (n, v) => n.WithDeclaration(v));

		public static SyntaxNodeProperty<CatchClauseSyntax, CatchDeclarationSyntax> Declaration => DeclarationProperty;

		private static readonly SyntaxNodeProperty<CatchClauseSyntax, CatchFilterClauseSyntax> FilterProperty = new NodeProperty<CatchClauseSyntax, CatchFilterClauseSyntax>("Filter", n => n.Filter, (n, v) => n.WithFilter(v));

		public static SyntaxNodeProperty<CatchClauseSyntax, CatchFilterClauseSyntax> Filter => FilterProperty;

		private static readonly SyntaxNodeProperty<CatchClauseSyntax, BlockSyntax> BlockProperty = new NodeProperty<CatchClauseSyntax, BlockSyntax>("Block", n => n.Block, (n, v) => n.WithBlock(v));

		public static SyntaxNodeProperty<CatchClauseSyntax, BlockSyntax> Block => BlockProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CatchClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CatchClauseSyntax>[] { CatchKeyword, Declaration, Filter, Block };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CatchClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class CatchDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<CatchDeclarationSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<CatchDeclarationSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<CatchDeclarationSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<CatchDeclarationSyntax, TypeSyntax> TypeProperty = new NodeProperty<CatchDeclarationSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<CatchDeclarationSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<CatchDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<CatchDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<CatchDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<CatchDeclarationSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<CatchDeclarationSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<CatchDeclarationSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CatchDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CatchDeclarationSyntax>[] { OpenParenToken, Type, Identifier, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CatchDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class CatchFilterClauseInfo
	{
		private static readonly SyntaxNodeProperty<CatchFilterClauseSyntax, SyntaxToken> WhenKeywordProperty = new TokenProperty<CatchFilterClauseSyntax>("WhenKeyword", n => n.WhenKeyword, (n, v) => n.WithWhenKeyword(v));

		public static SyntaxNodeProperty<CatchFilterClauseSyntax, SyntaxToken> WhenKeyword => WhenKeywordProperty;

		private static readonly SyntaxNodeProperty<CatchFilterClauseSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<CatchFilterClauseSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<CatchFilterClauseSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<CatchFilterClauseSyntax, ExpressionSyntax> FilterExpressionProperty = new NodeProperty<CatchFilterClauseSyntax, ExpressionSyntax>("FilterExpression", n => n.FilterExpression, (n, v) => n.WithFilterExpression(v));

		public static SyntaxNodeProperty<CatchFilterClauseSyntax, ExpressionSyntax> FilterExpression => FilterExpressionProperty;

		private static readonly SyntaxNodeProperty<CatchFilterClauseSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<CatchFilterClauseSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<CatchFilterClauseSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CatchFilterClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CatchFilterClauseSyntax>[] { WhenKeyword, OpenParenToken, FilterExpression, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CatchFilterClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class CheckedExpressionInfo
	{
		private static readonly SyntaxNodeProperty<CheckedExpressionSyntax, SyntaxToken> KeywordProperty = new TokenProperty<CheckedExpressionSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<CheckedExpressionSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<CheckedExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<CheckedExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<CheckedExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<CheckedExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<CheckedExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<CheckedExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<CheckedExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<CheckedExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<CheckedExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CheckedExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CheckedExpressionSyntax>[] { Keyword, OpenParenToken, Expression, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CheckedExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class CheckedStatementInfo
	{
		private static readonly SyntaxNodeProperty<CheckedStatementSyntax, SyntaxToken> KeywordProperty = new TokenProperty<CheckedStatementSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<CheckedStatementSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<CheckedStatementSyntax, BlockSyntax> BlockProperty = new NodeProperty<CheckedStatementSyntax, BlockSyntax>("Block", n => n.Block, (n, v) => n.WithBlock(v));

		public static SyntaxNodeProperty<CheckedStatementSyntax, BlockSyntax> Block => BlockProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CheckedStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CheckedStatementSyntax>[] { Keyword, Block };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CheckedStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class ClassDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<ClassDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<ClassDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> KeywordProperty = new TokenProperty<ClassDeclarationSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<ClassDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, TypeParameterListSyntax> TypeParameterListProperty = new NodeProperty<ClassDeclarationSyntax, TypeParameterListSyntax>("TypeParameterList", n => n.TypeParameterList, (n, v) => n.WithTypeParameterList(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, TypeParameterListSyntax> TypeParameterList => TypeParameterListProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, BaseListSyntax> BaseListProperty = new NodeProperty<ClassDeclarationSyntax, BaseListSyntax>("BaseList", n => n.BaseList, (n, v) => n.WithBaseList(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, BaseListSyntax> BaseList => BaseListProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClausesProperty = new ListProperty<ClassDeclarationSyntax, TypeParameterConstraintClauseSyntax>("ConstraintClauses", n => n.ConstraintClauses, (n, v) => n.WithConstraintClauses(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClauses => ConstraintClausesProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<ClassDeclarationSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> MembersProperty = new ListProperty<ClassDeclarationSyntax, MemberDeclarationSyntax>("Members", n => n.Members, (n, v) => n.WithMembers(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> Members => MembersProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<ClassDeclarationSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<ClassDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<ClassDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ClassDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ClassDeclarationSyntax>[] { AttributeLists, Modifiers, Keyword, Identifier, TypeParameterList, BaseList, ConstraintClauses, OpenBraceToken, Members, CloseBraceToken, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ClassDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class ClassOrStructConstraintInfo
	{
		private static readonly SyntaxNodeProperty<ClassOrStructConstraintSyntax, SyntaxToken> ClassOrStructKeywordProperty = new TokenProperty<ClassOrStructConstraintSyntax>("ClassOrStructKeyword", n => n.ClassOrStructKeyword, (n, v) => n.WithClassOrStructKeyword(v));

		public static SyntaxNodeProperty<ClassOrStructConstraintSyntax, SyntaxToken> ClassOrStructKeyword => ClassOrStructKeywordProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ClassOrStructConstraintSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ClassOrStructConstraintSyntax>[] { ClassOrStructKeyword };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ClassOrStructConstraintSyntax>> Properties => PropertiesArray;
	}

	internal static class CompilationUnitInfo
	{
		private static readonly SyntaxNodeProperty<CompilationUnitSyntax, SyntaxList<ExternAliasDirectiveSyntax>> ExternsProperty = new ListProperty<CompilationUnitSyntax, ExternAliasDirectiveSyntax>("Externs", n => n.Externs, (n, v) => n.WithExterns(v));

		public static SyntaxNodeProperty<CompilationUnitSyntax, SyntaxList<ExternAliasDirectiveSyntax>> Externs => ExternsProperty;

		private static readonly SyntaxNodeProperty<CompilationUnitSyntax, SyntaxList<UsingDirectiveSyntax>> UsingsProperty = new ListProperty<CompilationUnitSyntax, UsingDirectiveSyntax>("Usings", n => n.Usings, (n, v) => n.WithUsings(v));

		public static SyntaxNodeProperty<CompilationUnitSyntax, SyntaxList<UsingDirectiveSyntax>> Usings => UsingsProperty;

		private static readonly SyntaxNodeProperty<CompilationUnitSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<CompilationUnitSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<CompilationUnitSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<CompilationUnitSyntax, SyntaxList<MemberDeclarationSyntax>> MembersProperty = new ListProperty<CompilationUnitSyntax, MemberDeclarationSyntax>("Members", n => n.Members, (n, v) => n.WithMembers(v));

		public static SyntaxNodeProperty<CompilationUnitSyntax, SyntaxList<MemberDeclarationSyntax>> Members => MembersProperty;

		private static readonly SyntaxNodeProperty<CompilationUnitSyntax, SyntaxToken> EndOfFileTokenProperty = new TokenProperty<CompilationUnitSyntax>("EndOfFileToken", n => n.EndOfFileToken, (n, v) => n.WithEndOfFileToken(v));

		public static SyntaxNodeProperty<CompilationUnitSyntax, SyntaxToken> EndOfFileToken => EndOfFileTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CompilationUnitSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CompilationUnitSyntax>[] { Externs, Usings, AttributeLists, Members, EndOfFileToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CompilationUnitSyntax>> Properties => PropertiesArray;
	}

	internal static class ConditionalAccessExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ConditionalAccessExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ConditionalAccessExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ConditionalAccessExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<ConditionalAccessExpressionSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<ConditionalAccessExpressionSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<ConditionalAccessExpressionSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly SyntaxNodeProperty<ConditionalAccessExpressionSyntax, ExpressionSyntax> WhenNotNullProperty = new NodeProperty<ConditionalAccessExpressionSyntax, ExpressionSyntax>("WhenNotNull", n => n.WhenNotNull, (n, v) => n.WithWhenNotNull(v));

		public static SyntaxNodeProperty<ConditionalAccessExpressionSyntax, ExpressionSyntax> WhenNotNull => WhenNotNullProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ConditionalAccessExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ConditionalAccessExpressionSyntax>[] { Expression, OperatorToken, WhenNotNull };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ConditionalAccessExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ConditionalExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ConditionalExpressionSyntax, ExpressionSyntax> ConditionProperty = new NodeProperty<ConditionalExpressionSyntax, ExpressionSyntax>("Condition", n => n.Condition, (n, v) => n.WithCondition(v));

		public static SyntaxNodeProperty<ConditionalExpressionSyntax, ExpressionSyntax> Condition => ConditionProperty;

		private static readonly SyntaxNodeProperty<ConditionalExpressionSyntax, SyntaxToken> QuestionTokenProperty = new TokenProperty<ConditionalExpressionSyntax>("QuestionToken", n => n.QuestionToken, (n, v) => n.WithQuestionToken(v));

		public static SyntaxNodeProperty<ConditionalExpressionSyntax, SyntaxToken> QuestionToken => QuestionTokenProperty;

		private static readonly SyntaxNodeProperty<ConditionalExpressionSyntax, ExpressionSyntax> WhenTrueProperty = new NodeProperty<ConditionalExpressionSyntax, ExpressionSyntax>("WhenTrue", n => n.WhenTrue, (n, v) => n.WithWhenTrue(v));

		public static SyntaxNodeProperty<ConditionalExpressionSyntax, ExpressionSyntax> WhenTrue => WhenTrueProperty;

		private static readonly SyntaxNodeProperty<ConditionalExpressionSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<ConditionalExpressionSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<ConditionalExpressionSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly SyntaxNodeProperty<ConditionalExpressionSyntax, ExpressionSyntax> WhenFalseProperty = new NodeProperty<ConditionalExpressionSyntax, ExpressionSyntax>("WhenFalse", n => n.WhenFalse, (n, v) => n.WithWhenFalse(v));

		public static SyntaxNodeProperty<ConditionalExpressionSyntax, ExpressionSyntax> WhenFalse => WhenFalseProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ConditionalExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ConditionalExpressionSyntax>[] { Condition, QuestionToken, WhenTrue, ColonToken, WhenFalse };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ConditionalExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ConstructorConstraintInfo
	{
		private static readonly SyntaxNodeProperty<ConstructorConstraintSyntax, SyntaxToken> NewKeywordProperty = new TokenProperty<ConstructorConstraintSyntax>("NewKeyword", n => n.NewKeyword, (n, v) => n.WithNewKeyword(v));

		public static SyntaxNodeProperty<ConstructorConstraintSyntax, SyntaxToken> NewKeyword => NewKeywordProperty;

		private static readonly SyntaxNodeProperty<ConstructorConstraintSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<ConstructorConstraintSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<ConstructorConstraintSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<ConstructorConstraintSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<ConstructorConstraintSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<ConstructorConstraintSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ConstructorConstraintSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ConstructorConstraintSyntax>[] { NewKeyword, OpenParenToken, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ConstructorConstraintSyntax>> Properties => PropertiesArray;
	}

	internal static class ConstructorDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<ConstructorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<ConstructorDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<ConstructorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<ConstructorDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<ConstructorDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<ConstructorDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<ConstructorDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<ConstructorDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<ConstructorDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<ConstructorDeclarationSyntax, ParameterListSyntax> ParameterListProperty = new NodeProperty<ConstructorDeclarationSyntax, ParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<ConstructorDeclarationSyntax, ParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<ConstructorDeclarationSyntax, ConstructorInitializerSyntax> InitializerProperty = new NodeProperty<ConstructorDeclarationSyntax, ConstructorInitializerSyntax>("Initializer", n => n.Initializer, (n, v) => n.WithInitializer(v));

		public static SyntaxNodeProperty<ConstructorDeclarationSyntax, ConstructorInitializerSyntax> Initializer => InitializerProperty;

		private static readonly SyntaxNodeProperty<ConstructorDeclarationSyntax, BlockSyntax> BodyProperty = new NodeProperty<ConstructorDeclarationSyntax, BlockSyntax>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<ConstructorDeclarationSyntax, BlockSyntax> Body => BodyProperty;

		private static readonly SyntaxNodeProperty<ConstructorDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<ConstructorDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<ConstructorDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ConstructorDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ConstructorDeclarationSyntax>[] { AttributeLists, Modifiers, Identifier, ParameterList, Initializer, Body, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ConstructorDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class ConstructorInitializerInfo
	{
		private static readonly SyntaxNodeProperty<ConstructorInitializerSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<ConstructorInitializerSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<ConstructorInitializerSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly SyntaxNodeProperty<ConstructorInitializerSyntax, SyntaxToken> ThisOrBaseKeywordProperty = new TokenProperty<ConstructorInitializerSyntax>("ThisOrBaseKeyword", n => n.ThisOrBaseKeyword, (n, v) => n.WithThisOrBaseKeyword(v));

		public static SyntaxNodeProperty<ConstructorInitializerSyntax, SyntaxToken> ThisOrBaseKeyword => ThisOrBaseKeywordProperty;

		private static readonly SyntaxNodeProperty<ConstructorInitializerSyntax, ArgumentListSyntax> ArgumentListProperty = new NodeProperty<ConstructorInitializerSyntax, ArgumentListSyntax>("ArgumentList", n => n.ArgumentList, (n, v) => n.WithArgumentList(v));

		public static SyntaxNodeProperty<ConstructorInitializerSyntax, ArgumentListSyntax> ArgumentList => ArgumentListProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ConstructorInitializerSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ConstructorInitializerSyntax>[] { ColonToken, ThisOrBaseKeyword, ArgumentList };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ConstructorInitializerSyntax>> Properties => PropertiesArray;
	}

	internal static class ContinueStatementInfo
	{
		private static readonly SyntaxNodeProperty<ContinueStatementSyntax, SyntaxToken> ContinueKeywordProperty = new TokenProperty<ContinueStatementSyntax>("ContinueKeyword", n => n.ContinueKeyword, (n, v) => n.WithContinueKeyword(v));

		public static SyntaxNodeProperty<ContinueStatementSyntax, SyntaxToken> ContinueKeyword => ContinueKeywordProperty;

		private static readonly SyntaxNodeProperty<ContinueStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<ContinueStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<ContinueStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ContinueStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ContinueStatementSyntax>[] { ContinueKeyword, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ContinueStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class ConversionOperatorDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<ConversionOperatorDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<ConversionOperatorDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxToken> ImplicitOrExplicitKeywordProperty = new TokenProperty<ConversionOperatorDeclarationSyntax>("ImplicitOrExplicitKeyword", n => n.ImplicitOrExplicitKeyword, (n, v) => n.WithImplicitOrExplicitKeyword(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxToken> ImplicitOrExplicitKeyword => ImplicitOrExplicitKeywordProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxToken> OperatorKeywordProperty = new TokenProperty<ConversionOperatorDeclarationSyntax>("OperatorKeyword", n => n.OperatorKeyword, (n, v) => n.WithOperatorKeyword(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxToken> OperatorKeyword => OperatorKeywordProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, TypeSyntax> TypeProperty = new NodeProperty<ConversionOperatorDeclarationSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, ParameterListSyntax> ParameterListProperty = new NodeProperty<ConversionOperatorDeclarationSyntax, ParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, ParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, BlockSyntax> BodyProperty = new NodeProperty<ConversionOperatorDeclarationSyntax, BlockSyntax>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, BlockSyntax> Body => BodyProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBodyProperty = new NodeProperty<ConversionOperatorDeclarationSyntax, ArrowExpressionClauseSyntax>("ExpressionBody", n => n.ExpressionBody, (n, v) => n.WithExpressionBody(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBody => ExpressionBodyProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<ConversionOperatorDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<ConversionOperatorDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ConversionOperatorDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ConversionOperatorDeclarationSyntax>[] { AttributeLists, Modifiers, ImplicitOrExplicitKeyword, OperatorKeyword, Type, ParameterList, Body, ExpressionBody, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ConversionOperatorDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class ConversionOperatorMemberCrefInfo
	{
		private static readonly SyntaxNodeProperty<ConversionOperatorMemberCrefSyntax, SyntaxToken> ImplicitOrExplicitKeywordProperty = new TokenProperty<ConversionOperatorMemberCrefSyntax>("ImplicitOrExplicitKeyword", n => n.ImplicitOrExplicitKeyword, (n, v) => n.WithImplicitOrExplicitKeyword(v));

		public static SyntaxNodeProperty<ConversionOperatorMemberCrefSyntax, SyntaxToken> ImplicitOrExplicitKeyword => ImplicitOrExplicitKeywordProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorMemberCrefSyntax, SyntaxToken> OperatorKeywordProperty = new TokenProperty<ConversionOperatorMemberCrefSyntax>("OperatorKeyword", n => n.OperatorKeyword, (n, v) => n.WithOperatorKeyword(v));

		public static SyntaxNodeProperty<ConversionOperatorMemberCrefSyntax, SyntaxToken> OperatorKeyword => OperatorKeywordProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorMemberCrefSyntax, TypeSyntax> TypeProperty = new NodeProperty<ConversionOperatorMemberCrefSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<ConversionOperatorMemberCrefSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<ConversionOperatorMemberCrefSyntax, CrefParameterListSyntax> ParametersProperty = new NodeProperty<ConversionOperatorMemberCrefSyntax, CrefParameterListSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<ConversionOperatorMemberCrefSyntax, CrefParameterListSyntax> Parameters => ParametersProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ConversionOperatorMemberCrefSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ConversionOperatorMemberCrefSyntax>[] { ImplicitOrExplicitKeyword, OperatorKeyword, Type, Parameters };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ConversionOperatorMemberCrefSyntax>> Properties => PropertiesArray;
	}

	internal static class CrefBracketedParameterListInfo
	{
		private static readonly SyntaxNodeProperty<CrefBracketedParameterListSyntax, SyntaxToken> OpenBracketTokenProperty = new TokenProperty<CrefBracketedParameterListSyntax>("OpenBracketToken", n => n.OpenBracketToken, (n, v) => n.WithOpenBracketToken(v));

		public static SyntaxNodeProperty<CrefBracketedParameterListSyntax, SyntaxToken> OpenBracketToken => OpenBracketTokenProperty;

		private static readonly SyntaxNodeProperty<CrefBracketedParameterListSyntax, SeparatedSyntaxList<CrefParameterSyntax>> ParametersProperty = new SeparatedListProperty<CrefBracketedParameterListSyntax, CrefParameterSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<CrefBracketedParameterListSyntax, SeparatedSyntaxList<CrefParameterSyntax>> Parameters => ParametersProperty;

		private static readonly SyntaxNodeProperty<CrefBracketedParameterListSyntax, SyntaxToken> CloseBracketTokenProperty = new TokenProperty<CrefBracketedParameterListSyntax>("CloseBracketToken", n => n.CloseBracketToken, (n, v) => n.WithCloseBracketToken(v));

		public static SyntaxNodeProperty<CrefBracketedParameterListSyntax, SyntaxToken> CloseBracketToken => CloseBracketTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CrefBracketedParameterListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CrefBracketedParameterListSyntax>[] { OpenBracketToken, Parameters, CloseBracketToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CrefBracketedParameterListSyntax>> Properties => PropertiesArray;
	}

	internal static class CrefParameterListInfo
	{
		private static readonly SyntaxNodeProperty<CrefParameterListSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<CrefParameterListSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<CrefParameterListSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<CrefParameterListSyntax, SeparatedSyntaxList<CrefParameterSyntax>> ParametersProperty = new SeparatedListProperty<CrefParameterListSyntax, CrefParameterSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<CrefParameterListSyntax, SeparatedSyntaxList<CrefParameterSyntax>> Parameters => ParametersProperty;

		private static readonly SyntaxNodeProperty<CrefParameterListSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<CrefParameterListSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<CrefParameterListSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CrefParameterListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CrefParameterListSyntax>[] { OpenParenToken, Parameters, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CrefParameterListSyntax>> Properties => PropertiesArray;
	}

	internal static class CrefParameterInfo
	{
		private static readonly SyntaxNodeProperty<CrefParameterSyntax, SyntaxToken> RefOrOutKeywordProperty = new TokenProperty<CrefParameterSyntax>("RefOrOutKeyword", n => n.RefOrOutKeyword, (n, v) => n.WithRefOrOutKeyword(v));

		public static SyntaxNodeProperty<CrefParameterSyntax, SyntaxToken> RefOrOutKeyword => RefOrOutKeywordProperty;

		private static readonly SyntaxNodeProperty<CrefParameterSyntax, TypeSyntax> TypeProperty = new NodeProperty<CrefParameterSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<CrefParameterSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<CrefParameterSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<CrefParameterSyntax>[] { RefOrOutKeyword, Type };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<CrefParameterSyntax>> Properties => PropertiesArray;
	}

	internal static class DefaultExpressionInfo
	{
		private static readonly SyntaxNodeProperty<DefaultExpressionSyntax, SyntaxToken> KeywordProperty = new TokenProperty<DefaultExpressionSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<DefaultExpressionSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<DefaultExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<DefaultExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<DefaultExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<DefaultExpressionSyntax, TypeSyntax> TypeProperty = new NodeProperty<DefaultExpressionSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<DefaultExpressionSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<DefaultExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<DefaultExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<DefaultExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<DefaultExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<DefaultExpressionSyntax>[] { Keyword, OpenParenToken, Type, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<DefaultExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class DefaultSwitchLabelInfo
	{
		private static readonly SyntaxNodeProperty<DefaultSwitchLabelSyntax, SyntaxToken> KeywordProperty = new TokenProperty<DefaultSwitchLabelSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<DefaultSwitchLabelSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<DefaultSwitchLabelSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<DefaultSwitchLabelSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<DefaultSwitchLabelSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<DefaultSwitchLabelSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<DefaultSwitchLabelSyntax>[] { Keyword, ColonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<DefaultSwitchLabelSyntax>> Properties => PropertiesArray;
	}

	internal static class DefineDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<DefineDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<DefineDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<DefineDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<DefineDirectiveTriviaSyntax, SyntaxToken> DefineKeywordProperty = new TokenProperty<DefineDirectiveTriviaSyntax>("DefineKeyword", n => n.DefineKeyword, (n, v) => n.WithDefineKeyword(v));

		public static SyntaxNodeProperty<DefineDirectiveTriviaSyntax, SyntaxToken> DefineKeyword => DefineKeywordProperty;

		private static readonly SyntaxNodeProperty<DefineDirectiveTriviaSyntax, SyntaxToken> NameProperty = new TokenProperty<DefineDirectiveTriviaSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<DefineDirectiveTriviaSyntax, SyntaxToken> Name => NameProperty;

		private static readonly SyntaxNodeProperty<DefineDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<DefineDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<DefineDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<DefineDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<DefineDirectiveTriviaSyntax>[] { HashToken, DefineKeyword, Name, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<DefineDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class DelegateDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<DelegateDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<DelegateDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxToken> DelegateKeywordProperty = new TokenProperty<DelegateDeclarationSyntax>("DelegateKeyword", n => n.DelegateKeyword, (n, v) => n.WithDelegateKeyword(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxToken> DelegateKeyword => DelegateKeywordProperty;

		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, TypeSyntax> ReturnTypeProperty = new NodeProperty<DelegateDeclarationSyntax, TypeSyntax>("ReturnType", n => n.ReturnType, (n, v) => n.WithReturnType(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, TypeSyntax> ReturnType => ReturnTypeProperty;

		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<DelegateDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, TypeParameterListSyntax> TypeParameterListProperty = new NodeProperty<DelegateDeclarationSyntax, TypeParameterListSyntax>("TypeParameterList", n => n.TypeParameterList, (n, v) => n.WithTypeParameterList(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, TypeParameterListSyntax> TypeParameterList => TypeParameterListProperty;

		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, ParameterListSyntax> ParameterListProperty = new NodeProperty<DelegateDeclarationSyntax, ParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, ParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClausesProperty = new ListProperty<DelegateDeclarationSyntax, TypeParameterConstraintClauseSyntax>("ConstraintClauses", n => n.ConstraintClauses, (n, v) => n.WithConstraintClauses(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClauses => ConstraintClausesProperty;

		private static readonly SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<DelegateDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<DelegateDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<DelegateDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<DelegateDeclarationSyntax>[] { AttributeLists, Modifiers, DelegateKeyword, ReturnType, Identifier, TypeParameterList, ParameterList, ConstraintClauses, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<DelegateDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class DestructorDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<DestructorDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<DestructorDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxToken> TildeTokenProperty = new TokenProperty<DestructorDeclarationSyntax>("TildeToken", n => n.TildeToken, (n, v) => n.WithTildeToken(v));

		public static SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxToken> TildeToken => TildeTokenProperty;

		private static readonly SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<DestructorDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<DestructorDeclarationSyntax, ParameterListSyntax> ParameterListProperty = new NodeProperty<DestructorDeclarationSyntax, ParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<DestructorDeclarationSyntax, ParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<DestructorDeclarationSyntax, BlockSyntax> BodyProperty = new NodeProperty<DestructorDeclarationSyntax, BlockSyntax>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<DestructorDeclarationSyntax, BlockSyntax> Body => BodyProperty;

		private static readonly SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<DestructorDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<DestructorDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<DestructorDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<DestructorDeclarationSyntax>[] { AttributeLists, Modifiers, TildeToken, Identifier, ParameterList, Body, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<DestructorDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class DocumentationCommentTriviaInfo
	{
		private static readonly SyntaxNodeProperty<DocumentationCommentTriviaSyntax, SyntaxList<XmlNodeSyntax>> ContentProperty = new ListProperty<DocumentationCommentTriviaSyntax, XmlNodeSyntax>("Content", n => n.Content, (n, v) => n.WithContent(v));

		public static SyntaxNodeProperty<DocumentationCommentTriviaSyntax, SyntaxList<XmlNodeSyntax>> Content => ContentProperty;

		private static readonly SyntaxNodeProperty<DocumentationCommentTriviaSyntax, SyntaxToken> EndOfCommentProperty = new TokenProperty<DocumentationCommentTriviaSyntax>("EndOfComment", n => n.EndOfComment, (n, v) => n.WithEndOfComment(v));

		public static SyntaxNodeProperty<DocumentationCommentTriviaSyntax, SyntaxToken> EndOfComment => EndOfCommentProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<DocumentationCommentTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<DocumentationCommentTriviaSyntax>[] { Content, EndOfComment };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<DocumentationCommentTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class DoStatementInfo
	{
		private static readonly SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> DoKeywordProperty = new TokenProperty<DoStatementSyntax>("DoKeyword", n => n.DoKeyword, (n, v) => n.WithDoKeyword(v));

		public static SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> DoKeyword => DoKeywordProperty;

		private static readonly SyntaxNodeProperty<DoStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<DoStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<DoStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> WhileKeywordProperty = new TokenProperty<DoStatementSyntax>("WhileKeyword", n => n.WhileKeyword, (n, v) => n.WithWhileKeyword(v));

		public static SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> WhileKeyword => WhileKeywordProperty;

		private static readonly SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<DoStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<DoStatementSyntax, ExpressionSyntax> ConditionProperty = new NodeProperty<DoStatementSyntax, ExpressionSyntax>("Condition", n => n.Condition, (n, v) => n.WithCondition(v));

		public static SyntaxNodeProperty<DoStatementSyntax, ExpressionSyntax> Condition => ConditionProperty;

		private static readonly SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<DoStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<DoStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<DoStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<DoStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<DoStatementSyntax>[] { DoKeyword, Statement, WhileKeyword, OpenParenToken, Condition, CloseParenToken, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<DoStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class ElementAccessExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ElementAccessExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ElementAccessExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ElementAccessExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<ElementAccessExpressionSyntax, BracketedArgumentListSyntax> ArgumentListProperty = new NodeProperty<ElementAccessExpressionSyntax, BracketedArgumentListSyntax>("ArgumentList", n => n.ArgumentList, (n, v) => n.WithArgumentList(v));

		public static SyntaxNodeProperty<ElementAccessExpressionSyntax, BracketedArgumentListSyntax> ArgumentList => ArgumentListProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ElementAccessExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ElementAccessExpressionSyntax>[] { Expression, ArgumentList };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ElementAccessExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ElementBindingExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ElementBindingExpressionSyntax, BracketedArgumentListSyntax> ArgumentListProperty = new NodeProperty<ElementBindingExpressionSyntax, BracketedArgumentListSyntax>("ArgumentList", n => n.ArgumentList, (n, v) => n.WithArgumentList(v));

		public static SyntaxNodeProperty<ElementBindingExpressionSyntax, BracketedArgumentListSyntax> ArgumentList => ArgumentListProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ElementBindingExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ElementBindingExpressionSyntax>[] { ArgumentList };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ElementBindingExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ElifDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<ElifDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<ElifDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<ElifDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<ElifDirectiveTriviaSyntax, SyntaxToken> ElifKeywordProperty = new TokenProperty<ElifDirectiveTriviaSyntax>("ElifKeyword", n => n.ElifKeyword, (n, v) => n.WithElifKeyword(v));

		public static SyntaxNodeProperty<ElifDirectiveTriviaSyntax, SyntaxToken> ElifKeyword => ElifKeywordProperty;

		private static readonly SyntaxNodeProperty<ElifDirectiveTriviaSyntax, ExpressionSyntax> ConditionProperty = new NodeProperty<ElifDirectiveTriviaSyntax, ExpressionSyntax>("Condition", n => n.Condition, (n, v) => n.WithCondition(v));

		public static SyntaxNodeProperty<ElifDirectiveTriviaSyntax, ExpressionSyntax> Condition => ConditionProperty;

		private static readonly SyntaxNodeProperty<ElifDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<ElifDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<ElifDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ElifDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ElifDirectiveTriviaSyntax>[] { HashToken, ElifKeyword, Condition, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ElifDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class ElseClauseInfo
	{
		private static readonly SyntaxNodeProperty<ElseClauseSyntax, SyntaxToken> ElseKeywordProperty = new TokenProperty<ElseClauseSyntax>("ElseKeyword", n => n.ElseKeyword, (n, v) => n.WithElseKeyword(v));

		public static SyntaxNodeProperty<ElseClauseSyntax, SyntaxToken> ElseKeyword => ElseKeywordProperty;

		private static readonly SyntaxNodeProperty<ElseClauseSyntax, StatementSyntax> StatementProperty = new NodeProperty<ElseClauseSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<ElseClauseSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ElseClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ElseClauseSyntax>[] { ElseKeyword, Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ElseClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class ElseDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<ElseDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<ElseDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<ElseDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<ElseDirectiveTriviaSyntax, SyntaxToken> ElseKeywordProperty = new TokenProperty<ElseDirectiveTriviaSyntax>("ElseKeyword", n => n.ElseKeyword, (n, v) => n.WithElseKeyword(v));

		public static SyntaxNodeProperty<ElseDirectiveTriviaSyntax, SyntaxToken> ElseKeyword => ElseKeywordProperty;

		private static readonly SyntaxNodeProperty<ElseDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<ElseDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<ElseDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ElseDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ElseDirectiveTriviaSyntax>[] { HashToken, ElseKeyword, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ElseDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class EmptyStatementInfo
	{
		private static readonly SyntaxNodeProperty<EmptyStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<EmptyStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<EmptyStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<EmptyStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<EmptyStatementSyntax>[] { SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<EmptyStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class EndIfDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<EndIfDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<EndIfDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<EndIfDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<EndIfDirectiveTriviaSyntax, SyntaxToken> EndIfKeywordProperty = new TokenProperty<EndIfDirectiveTriviaSyntax>("EndIfKeyword", n => n.EndIfKeyword, (n, v) => n.WithEndIfKeyword(v));

		public static SyntaxNodeProperty<EndIfDirectiveTriviaSyntax, SyntaxToken> EndIfKeyword => EndIfKeywordProperty;

		private static readonly SyntaxNodeProperty<EndIfDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<EndIfDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<EndIfDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<EndIfDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<EndIfDirectiveTriviaSyntax>[] { HashToken, EndIfKeyword, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<EndIfDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class EndRegionDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<EndRegionDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<EndRegionDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<EndRegionDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<EndRegionDirectiveTriviaSyntax, SyntaxToken> EndRegionKeywordProperty = new TokenProperty<EndRegionDirectiveTriviaSyntax>("EndRegionKeyword", n => n.EndRegionKeyword, (n, v) => n.WithEndRegionKeyword(v));

		public static SyntaxNodeProperty<EndRegionDirectiveTriviaSyntax, SyntaxToken> EndRegionKeyword => EndRegionKeywordProperty;

		private static readonly SyntaxNodeProperty<EndRegionDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<EndRegionDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<EndRegionDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<EndRegionDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<EndRegionDirectiveTriviaSyntax>[] { HashToken, EndRegionKeyword, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<EndRegionDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class EnumDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<EnumDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<EnumDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> EnumKeywordProperty = new TokenProperty<EnumDeclarationSyntax>("EnumKeyword", n => n.EnumKeyword, (n, v) => n.WithEnumKeyword(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> EnumKeyword => EnumKeywordProperty;

		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<EnumDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, BaseListSyntax> BaseListProperty = new NodeProperty<EnumDeclarationSyntax, BaseListSyntax>("BaseList", n => n.BaseList, (n, v) => n.WithBaseList(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, BaseListSyntax> BaseList => BaseListProperty;

		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<EnumDeclarationSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, SeparatedSyntaxList<EnumMemberDeclarationSyntax>> MembersProperty = new SeparatedListProperty<EnumDeclarationSyntax, EnumMemberDeclarationSyntax>("Members", n => n.Members, (n, v) => n.WithMembers(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, SeparatedSyntaxList<EnumMemberDeclarationSyntax>> Members => MembersProperty;

		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<EnumDeclarationSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<EnumDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<EnumDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<EnumDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<EnumDeclarationSyntax>[] { AttributeLists, Modifiers, EnumKeyword, Identifier, BaseList, OpenBraceToken, Members, CloseBraceToken, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<EnumDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class EnumMemberDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<EnumMemberDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<EnumMemberDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<EnumMemberDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<EnumMemberDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<EnumMemberDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<EnumMemberDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<EnumMemberDeclarationSyntax, EqualsValueClauseSyntax> EqualsValueProperty = new NodeProperty<EnumMemberDeclarationSyntax, EqualsValueClauseSyntax>("EqualsValue", n => n.EqualsValue, (n, v) => n.WithEqualsValue(v));

		public static SyntaxNodeProperty<EnumMemberDeclarationSyntax, EqualsValueClauseSyntax> EqualsValue => EqualsValueProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<EnumMemberDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<EnumMemberDeclarationSyntax>[] { AttributeLists, Identifier, EqualsValue };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<EnumMemberDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class EqualsValueClauseInfo
	{
		private static readonly SyntaxNodeProperty<EqualsValueClauseSyntax, SyntaxToken> EqualsTokenProperty = new TokenProperty<EqualsValueClauseSyntax>("EqualsToken", n => n.EqualsToken, (n, v) => n.WithEqualsToken(v));

		public static SyntaxNodeProperty<EqualsValueClauseSyntax, SyntaxToken> EqualsToken => EqualsTokenProperty;

		private static readonly SyntaxNodeProperty<EqualsValueClauseSyntax, ExpressionSyntax> ValueProperty = new NodeProperty<EqualsValueClauseSyntax, ExpressionSyntax>("Value", n => n.Value, (n, v) => n.WithValue(v));

		public static SyntaxNodeProperty<EqualsValueClauseSyntax, ExpressionSyntax> Value => ValueProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<EqualsValueClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<EqualsValueClauseSyntax>[] { EqualsToken, Value };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<EqualsValueClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class ErrorDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<ErrorDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<ErrorDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<ErrorDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<ErrorDirectiveTriviaSyntax, SyntaxToken> ErrorKeywordProperty = new TokenProperty<ErrorDirectiveTriviaSyntax>("ErrorKeyword", n => n.ErrorKeyword, (n, v) => n.WithErrorKeyword(v));

		public static SyntaxNodeProperty<ErrorDirectiveTriviaSyntax, SyntaxToken> ErrorKeyword => ErrorKeywordProperty;

		private static readonly SyntaxNodeProperty<ErrorDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<ErrorDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<ErrorDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ErrorDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ErrorDirectiveTriviaSyntax>[] { HashToken, ErrorKeyword, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ErrorDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class EventDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<EventDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<EventDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<EventDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<EventDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<EventDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<EventDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<EventDeclarationSyntax, SyntaxToken> EventKeywordProperty = new TokenProperty<EventDeclarationSyntax>("EventKeyword", n => n.EventKeyword, (n, v) => n.WithEventKeyword(v));

		public static SyntaxNodeProperty<EventDeclarationSyntax, SyntaxToken> EventKeyword => EventKeywordProperty;

		private static readonly SyntaxNodeProperty<EventDeclarationSyntax, TypeSyntax> TypeProperty = new NodeProperty<EventDeclarationSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<EventDeclarationSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<EventDeclarationSyntax, ExplicitInterfaceSpecifierSyntax> ExplicitInterfaceSpecifierProperty = new NodeProperty<EventDeclarationSyntax, ExplicitInterfaceSpecifierSyntax>("ExplicitInterfaceSpecifier", n => n.ExplicitInterfaceSpecifier, (n, v) => n.WithExplicitInterfaceSpecifier(v));

		public static SyntaxNodeProperty<EventDeclarationSyntax, ExplicitInterfaceSpecifierSyntax> ExplicitInterfaceSpecifier => ExplicitInterfaceSpecifierProperty;

		private static readonly SyntaxNodeProperty<EventDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<EventDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<EventDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<EventDeclarationSyntax, AccessorListSyntax> AccessorListProperty = new NodeProperty<EventDeclarationSyntax, AccessorListSyntax>("AccessorList", n => n.AccessorList, (n, v) => n.WithAccessorList(v));

		public static SyntaxNodeProperty<EventDeclarationSyntax, AccessorListSyntax> AccessorList => AccessorListProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<EventDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<EventDeclarationSyntax>[] { AttributeLists, Modifiers, EventKeyword, Type, ExplicitInterfaceSpecifier, Identifier, AccessorList };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<EventDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class EventFieldDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<EventFieldDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<EventFieldDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<EventFieldDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<EventFieldDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<EventFieldDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<EventFieldDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<EventFieldDeclarationSyntax, SyntaxToken> EventKeywordProperty = new TokenProperty<EventFieldDeclarationSyntax>("EventKeyword", n => n.EventKeyword, (n, v) => n.WithEventKeyword(v));

		public static SyntaxNodeProperty<EventFieldDeclarationSyntax, SyntaxToken> EventKeyword => EventKeywordProperty;

		private static readonly SyntaxNodeProperty<EventFieldDeclarationSyntax, VariableDeclarationSyntax> DeclarationProperty = new NodeProperty<EventFieldDeclarationSyntax, VariableDeclarationSyntax>("Declaration", n => n.Declaration, (n, v) => n.WithDeclaration(v));

		public static SyntaxNodeProperty<EventFieldDeclarationSyntax, VariableDeclarationSyntax> Declaration => DeclarationProperty;

		private static readonly SyntaxNodeProperty<EventFieldDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<EventFieldDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<EventFieldDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<EventFieldDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<EventFieldDeclarationSyntax>[] { AttributeLists, Modifiers, EventKeyword, Declaration, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<EventFieldDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class ExplicitInterfaceSpecifierInfo
	{
		private static readonly SyntaxNodeProperty<ExplicitInterfaceSpecifierSyntax, NameSyntax> NameProperty = new NodeProperty<ExplicitInterfaceSpecifierSyntax, NameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<ExplicitInterfaceSpecifierSyntax, NameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<ExplicitInterfaceSpecifierSyntax, SyntaxToken> DotTokenProperty = new TokenProperty<ExplicitInterfaceSpecifierSyntax>("DotToken", n => n.DotToken, (n, v) => n.WithDotToken(v));

		public static SyntaxNodeProperty<ExplicitInterfaceSpecifierSyntax, SyntaxToken> DotToken => DotTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ExplicitInterfaceSpecifierSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ExplicitInterfaceSpecifierSyntax>[] { Name, DotToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ExplicitInterfaceSpecifierSyntax>> Properties => PropertiesArray;
	}

	internal static class ExpressionStatementInfo
	{
		private static readonly SyntaxNodeProperty<ExpressionStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ExpressionStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ExpressionStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<ExpressionStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<ExpressionStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<ExpressionStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ExpressionStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ExpressionStatementSyntax>[] { Expression, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ExpressionStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class ExternAliasDirectiveInfo
	{
		private static readonly SyntaxNodeProperty<ExternAliasDirectiveSyntax, SyntaxToken> ExternKeywordProperty = new TokenProperty<ExternAliasDirectiveSyntax>("ExternKeyword", n => n.ExternKeyword, (n, v) => n.WithExternKeyword(v));

		public static SyntaxNodeProperty<ExternAliasDirectiveSyntax, SyntaxToken> ExternKeyword => ExternKeywordProperty;

		private static readonly SyntaxNodeProperty<ExternAliasDirectiveSyntax, SyntaxToken> AliasKeywordProperty = new TokenProperty<ExternAliasDirectiveSyntax>("AliasKeyword", n => n.AliasKeyword, (n, v) => n.WithAliasKeyword(v));

		public static SyntaxNodeProperty<ExternAliasDirectiveSyntax, SyntaxToken> AliasKeyword => AliasKeywordProperty;

		private static readonly SyntaxNodeProperty<ExternAliasDirectiveSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<ExternAliasDirectiveSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<ExternAliasDirectiveSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<ExternAliasDirectiveSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<ExternAliasDirectiveSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<ExternAliasDirectiveSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ExternAliasDirectiveSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ExternAliasDirectiveSyntax>[] { ExternKeyword, AliasKeyword, Identifier, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ExternAliasDirectiveSyntax>> Properties => PropertiesArray;
	}

	internal static class FieldDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<FieldDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<FieldDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<FieldDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<FieldDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<FieldDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<FieldDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<FieldDeclarationSyntax, VariableDeclarationSyntax> DeclarationProperty = new NodeProperty<FieldDeclarationSyntax, VariableDeclarationSyntax>("Declaration", n => n.Declaration, (n, v) => n.WithDeclaration(v));

		public static SyntaxNodeProperty<FieldDeclarationSyntax, VariableDeclarationSyntax> Declaration => DeclarationProperty;

		private static readonly SyntaxNodeProperty<FieldDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<FieldDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<FieldDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<FieldDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<FieldDeclarationSyntax>[] { AttributeLists, Modifiers, Declaration, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<FieldDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class FinallyClauseInfo
	{
		private static readonly SyntaxNodeProperty<FinallyClauseSyntax, SyntaxToken> FinallyKeywordProperty = new TokenProperty<FinallyClauseSyntax>("FinallyKeyword", n => n.FinallyKeyword, (n, v) => n.WithFinallyKeyword(v));

		public static SyntaxNodeProperty<FinallyClauseSyntax, SyntaxToken> FinallyKeyword => FinallyKeywordProperty;

		private static readonly SyntaxNodeProperty<FinallyClauseSyntax, BlockSyntax> BlockProperty = new NodeProperty<FinallyClauseSyntax, BlockSyntax>("Block", n => n.Block, (n, v) => n.WithBlock(v));

		public static SyntaxNodeProperty<FinallyClauseSyntax, BlockSyntax> Block => BlockProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<FinallyClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<FinallyClauseSyntax>[] { FinallyKeyword, Block };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<FinallyClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class FixedStatementInfo
	{
		private static readonly SyntaxNodeProperty<FixedStatementSyntax, SyntaxToken> FixedKeywordProperty = new TokenProperty<FixedStatementSyntax>("FixedKeyword", n => n.FixedKeyword, (n, v) => n.WithFixedKeyword(v));

		public static SyntaxNodeProperty<FixedStatementSyntax, SyntaxToken> FixedKeyword => FixedKeywordProperty;

		private static readonly SyntaxNodeProperty<FixedStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<FixedStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<FixedStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<FixedStatementSyntax, VariableDeclarationSyntax> DeclarationProperty = new NodeProperty<FixedStatementSyntax, VariableDeclarationSyntax>("Declaration", n => n.Declaration, (n, v) => n.WithDeclaration(v));

		public static SyntaxNodeProperty<FixedStatementSyntax, VariableDeclarationSyntax> Declaration => DeclarationProperty;

		private static readonly SyntaxNodeProperty<FixedStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<FixedStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<FixedStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<FixedStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<FixedStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<FixedStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<FixedStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<FixedStatementSyntax>[] { FixedKeyword, OpenParenToken, Declaration, CloseParenToken, Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<FixedStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class ForEachStatementInfo
	{
		private static readonly SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> ForEachKeywordProperty = new TokenProperty<ForEachStatementSyntax>("ForEachKeyword", n => n.ForEachKeyword, (n, v) => n.WithForEachKeyword(v));

		public static SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> ForEachKeyword => ForEachKeywordProperty;

		private static readonly SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<ForEachStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<ForEachStatementSyntax, TypeSyntax> TypeProperty = new NodeProperty<ForEachStatementSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<ForEachStatementSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<ForEachStatementSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> InKeywordProperty = new TokenProperty<ForEachStatementSyntax>("InKeyword", n => n.InKeyword, (n, v) => n.WithInKeyword(v));

		public static SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> InKeyword => InKeywordProperty;

		private static readonly SyntaxNodeProperty<ForEachStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ForEachStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ForEachStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<ForEachStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<ForEachStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<ForEachStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<ForEachStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<ForEachStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ForEachStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ForEachStatementSyntax>[] { ForEachKeyword, OpenParenToken, Type, Identifier, InKeyword, Expression, CloseParenToken, Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ForEachStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class ForStatementInfo
	{
		private static readonly SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> ForKeywordProperty = new TokenProperty<ForStatementSyntax>("ForKeyword", n => n.ForKeyword, (n, v) => n.WithForKeyword(v));

		public static SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> ForKeyword => ForKeywordProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<ForStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, VariableDeclarationSyntax> DeclarationProperty = new NodeProperty<ForStatementSyntax, VariableDeclarationSyntax>("Declaration", n => n.Declaration, (n, v) => n.WithDeclaration(v));

		public static SyntaxNodeProperty<ForStatementSyntax, VariableDeclarationSyntax> Declaration => DeclarationProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, SeparatedSyntaxList<ExpressionSyntax>> InitializersProperty = new SeparatedListProperty<ForStatementSyntax, ExpressionSyntax>("Initializers", n => n.Initializers, (n, v) => n.WithInitializers(v));

		public static SyntaxNodeProperty<ForStatementSyntax, SeparatedSyntaxList<ExpressionSyntax>> Initializers => InitializersProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> FirstSemicolonTokenProperty = new TokenProperty<ForStatementSyntax>("FirstSemicolonToken", n => n.FirstSemicolonToken, (n, v) => n.WithFirstSemicolonToken(v));

		public static SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> FirstSemicolonToken => FirstSemicolonTokenProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, ExpressionSyntax> ConditionProperty = new NodeProperty<ForStatementSyntax, ExpressionSyntax>("Condition", n => n.Condition, (n, v) => n.WithCondition(v));

		public static SyntaxNodeProperty<ForStatementSyntax, ExpressionSyntax> Condition => ConditionProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> SecondSemicolonTokenProperty = new TokenProperty<ForStatementSyntax>("SecondSemicolonToken", n => n.SecondSemicolonToken, (n, v) => n.WithSecondSemicolonToken(v));

		public static SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> SecondSemicolonToken => SecondSemicolonTokenProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, SeparatedSyntaxList<ExpressionSyntax>> IncrementorsProperty = new SeparatedListProperty<ForStatementSyntax, ExpressionSyntax>("Incrementors", n => n.Incrementors, (n, v) => n.WithIncrementors(v));

		public static SyntaxNodeProperty<ForStatementSyntax, SeparatedSyntaxList<ExpressionSyntax>> Incrementors => IncrementorsProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<ForStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<ForStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<ForStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<ForStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<ForStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ForStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ForStatementSyntax>[] { ForKeyword, OpenParenToken, Declaration, Initializers, FirstSemicolonToken, Condition, SecondSemicolonToken, Incrementors, CloseParenToken, Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ForStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class FromClauseInfo
	{
		private static readonly SyntaxNodeProperty<FromClauseSyntax, SyntaxToken> FromKeywordProperty = new TokenProperty<FromClauseSyntax>("FromKeyword", n => n.FromKeyword, (n, v) => n.WithFromKeyword(v));

		public static SyntaxNodeProperty<FromClauseSyntax, SyntaxToken> FromKeyword => FromKeywordProperty;

		private static readonly SyntaxNodeProperty<FromClauseSyntax, TypeSyntax> TypeProperty = new NodeProperty<FromClauseSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<FromClauseSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<FromClauseSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<FromClauseSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<FromClauseSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<FromClauseSyntax, SyntaxToken> InKeywordProperty = new TokenProperty<FromClauseSyntax>("InKeyword", n => n.InKeyword, (n, v) => n.WithInKeyword(v));

		public static SyntaxNodeProperty<FromClauseSyntax, SyntaxToken> InKeyword => InKeywordProperty;

		private static readonly SyntaxNodeProperty<FromClauseSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<FromClauseSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<FromClauseSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<FromClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<FromClauseSyntax>[] { FromKeyword, Type, Identifier, InKeyword, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<FromClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class GenericNameInfo
	{
		private static readonly SyntaxNodeProperty<GenericNameSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<GenericNameSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<GenericNameSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<GenericNameSyntax, TypeArgumentListSyntax> TypeArgumentListProperty = new NodeProperty<GenericNameSyntax, TypeArgumentListSyntax>("TypeArgumentList", n => n.TypeArgumentList, (n, v) => n.WithTypeArgumentList(v));

		public static SyntaxNodeProperty<GenericNameSyntax, TypeArgumentListSyntax> TypeArgumentList => TypeArgumentListProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<GenericNameSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<GenericNameSyntax>[] { Identifier, TypeArgumentList };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<GenericNameSyntax>> Properties => PropertiesArray;
	}

	internal static class GlobalStatementInfo
	{
		private static readonly SyntaxNodeProperty<GlobalStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<GlobalStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<GlobalStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<GlobalStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<GlobalStatementSyntax>[] { Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<GlobalStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class GotoStatementInfo
	{
		private static readonly SyntaxNodeProperty<GotoStatementSyntax, SyntaxToken> GotoKeywordProperty = new TokenProperty<GotoStatementSyntax>("GotoKeyword", n => n.GotoKeyword, (n, v) => n.WithGotoKeyword(v));

		public static SyntaxNodeProperty<GotoStatementSyntax, SyntaxToken> GotoKeyword => GotoKeywordProperty;

		private static readonly SyntaxNodeProperty<GotoStatementSyntax, SyntaxToken> CaseOrDefaultKeywordProperty = new TokenProperty<GotoStatementSyntax>("CaseOrDefaultKeyword", n => n.CaseOrDefaultKeyword, (n, v) => n.WithCaseOrDefaultKeyword(v));

		public static SyntaxNodeProperty<GotoStatementSyntax, SyntaxToken> CaseOrDefaultKeyword => CaseOrDefaultKeywordProperty;

		private static readonly SyntaxNodeProperty<GotoStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<GotoStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<GotoStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<GotoStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<GotoStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<GotoStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<GotoStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<GotoStatementSyntax>[] { GotoKeyword, CaseOrDefaultKeyword, Expression, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<GotoStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class GroupClauseInfo
	{
		private static readonly SyntaxNodeProperty<GroupClauseSyntax, SyntaxToken> GroupKeywordProperty = new TokenProperty<GroupClauseSyntax>("GroupKeyword", n => n.GroupKeyword, (n, v) => n.WithGroupKeyword(v));

		public static SyntaxNodeProperty<GroupClauseSyntax, SyntaxToken> GroupKeyword => GroupKeywordProperty;

		private static readonly SyntaxNodeProperty<GroupClauseSyntax, ExpressionSyntax> GroupExpressionProperty = new NodeProperty<GroupClauseSyntax, ExpressionSyntax>("GroupExpression", n => n.GroupExpression, (n, v) => n.WithGroupExpression(v));

		public static SyntaxNodeProperty<GroupClauseSyntax, ExpressionSyntax> GroupExpression => GroupExpressionProperty;

		private static readonly SyntaxNodeProperty<GroupClauseSyntax, SyntaxToken> ByKeywordProperty = new TokenProperty<GroupClauseSyntax>("ByKeyword", n => n.ByKeyword, (n, v) => n.WithByKeyword(v));

		public static SyntaxNodeProperty<GroupClauseSyntax, SyntaxToken> ByKeyword => ByKeywordProperty;

		private static readonly SyntaxNodeProperty<GroupClauseSyntax, ExpressionSyntax> ByExpressionProperty = new NodeProperty<GroupClauseSyntax, ExpressionSyntax>("ByExpression", n => n.ByExpression, (n, v) => n.WithByExpression(v));

		public static SyntaxNodeProperty<GroupClauseSyntax, ExpressionSyntax> ByExpression => ByExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<GroupClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<GroupClauseSyntax>[] { GroupKeyword, GroupExpression, ByKeyword, ByExpression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<GroupClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class IdentifierNameInfo
	{
		private static readonly SyntaxNodeProperty<IdentifierNameSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<IdentifierNameSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<IdentifierNameSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<IdentifierNameSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<IdentifierNameSyntax>[] { Identifier };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<IdentifierNameSyntax>> Properties => PropertiesArray;
	}

	internal static class IfDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<IfDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<IfDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<IfDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<IfDirectiveTriviaSyntax, SyntaxToken> IfKeywordProperty = new TokenProperty<IfDirectiveTriviaSyntax>("IfKeyword", n => n.IfKeyword, (n, v) => n.WithIfKeyword(v));

		public static SyntaxNodeProperty<IfDirectiveTriviaSyntax, SyntaxToken> IfKeyword => IfKeywordProperty;

		private static readonly SyntaxNodeProperty<IfDirectiveTriviaSyntax, ExpressionSyntax> ConditionProperty = new NodeProperty<IfDirectiveTriviaSyntax, ExpressionSyntax>("Condition", n => n.Condition, (n, v) => n.WithCondition(v));

		public static SyntaxNodeProperty<IfDirectiveTriviaSyntax, ExpressionSyntax> Condition => ConditionProperty;

		private static readonly SyntaxNodeProperty<IfDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<IfDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<IfDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<IfDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<IfDirectiveTriviaSyntax>[] { HashToken, IfKeyword, Condition, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<IfDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class IfStatementInfo
	{
		private static readonly SyntaxNodeProperty<IfStatementSyntax, SyntaxToken> IfKeywordProperty = new TokenProperty<IfStatementSyntax>("IfKeyword", n => n.IfKeyword, (n, v) => n.WithIfKeyword(v));

		public static SyntaxNodeProperty<IfStatementSyntax, SyntaxToken> IfKeyword => IfKeywordProperty;

		private static readonly SyntaxNodeProperty<IfStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<IfStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<IfStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<IfStatementSyntax, ExpressionSyntax> ConditionProperty = new NodeProperty<IfStatementSyntax, ExpressionSyntax>("Condition", n => n.Condition, (n, v) => n.WithCondition(v));

		public static SyntaxNodeProperty<IfStatementSyntax, ExpressionSyntax> Condition => ConditionProperty;

		private static readonly SyntaxNodeProperty<IfStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<IfStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<IfStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<IfStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<IfStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<IfStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly SyntaxNodeProperty<IfStatementSyntax, ElseClauseSyntax> ElseProperty = new NodeProperty<IfStatementSyntax, ElseClauseSyntax>("Else", n => n.Else, (n, v) => n.WithElse(v));

		public static SyntaxNodeProperty<IfStatementSyntax, ElseClauseSyntax> Else => ElseProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<IfStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<IfStatementSyntax>[] { IfKeyword, OpenParenToken, Condition, CloseParenToken, Statement, Else };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<IfStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class ImplicitArrayCreationExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, SyntaxToken> NewKeywordProperty = new TokenProperty<ImplicitArrayCreationExpressionSyntax>("NewKeyword", n => n.NewKeyword, (n, v) => n.WithNewKeyword(v));

		public static SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, SyntaxToken> NewKeyword => NewKeywordProperty;

		private static readonly SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, SyntaxToken> OpenBracketTokenProperty = new TokenProperty<ImplicitArrayCreationExpressionSyntax>("OpenBracketToken", n => n.OpenBracketToken, (n, v) => n.WithOpenBracketToken(v));

		public static SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, SyntaxToken> OpenBracketToken => OpenBracketTokenProperty;

		private static readonly SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, SyntaxTokenList> CommasProperty = new TokenListProperty<ImplicitArrayCreationExpressionSyntax>("Commas", n => n.Commas, (n, v) => n.WithCommas(v));

		public static SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, SyntaxTokenList> Commas => CommasProperty;

		private static readonly SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, SyntaxToken> CloseBracketTokenProperty = new TokenProperty<ImplicitArrayCreationExpressionSyntax>("CloseBracketToken", n => n.CloseBracketToken, (n, v) => n.WithCloseBracketToken(v));

		public static SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, SyntaxToken> CloseBracketToken => CloseBracketTokenProperty;

		private static readonly SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, InitializerExpressionSyntax> InitializerProperty = new NodeProperty<ImplicitArrayCreationExpressionSyntax, InitializerExpressionSyntax>("Initializer", n => n.Initializer, (n, v) => n.WithInitializer(v));

		public static SyntaxNodeProperty<ImplicitArrayCreationExpressionSyntax, InitializerExpressionSyntax> Initializer => InitializerProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ImplicitArrayCreationExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ImplicitArrayCreationExpressionSyntax>[] { NewKeyword, OpenBracketToken, Commas, CloseBracketToken, Initializer };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ImplicitArrayCreationExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ImplicitElementAccessInfo
	{
		private static readonly SyntaxNodeProperty<ImplicitElementAccessSyntax, BracketedArgumentListSyntax> ArgumentListProperty = new NodeProperty<ImplicitElementAccessSyntax, BracketedArgumentListSyntax>("ArgumentList", n => n.ArgumentList, (n, v) => n.WithArgumentList(v));

		public static SyntaxNodeProperty<ImplicitElementAccessSyntax, BracketedArgumentListSyntax> ArgumentList => ArgumentListProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ImplicitElementAccessSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ImplicitElementAccessSyntax>[] { ArgumentList };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ImplicitElementAccessSyntax>> Properties => PropertiesArray;
	}

	internal static class IncompleteMemberInfo
	{
		private static readonly SyntaxNodeProperty<IncompleteMemberSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<IncompleteMemberSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<IncompleteMemberSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<IncompleteMemberSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<IncompleteMemberSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<IncompleteMemberSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<IncompleteMemberSyntax, TypeSyntax> TypeProperty = new NodeProperty<IncompleteMemberSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<IncompleteMemberSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<IncompleteMemberSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<IncompleteMemberSyntax>[] { AttributeLists, Modifiers, Type };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<IncompleteMemberSyntax>> Properties => PropertiesArray;
	}

	internal static class IndexerDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<IndexerDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<IndexerDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, TypeSyntax> TypeProperty = new NodeProperty<IndexerDeclarationSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, ExplicitInterfaceSpecifierSyntax> ExplicitInterfaceSpecifierProperty = new NodeProperty<IndexerDeclarationSyntax, ExplicitInterfaceSpecifierSyntax>("ExplicitInterfaceSpecifier", n => n.ExplicitInterfaceSpecifier, (n, v) => n.WithExplicitInterfaceSpecifier(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, ExplicitInterfaceSpecifierSyntax> ExplicitInterfaceSpecifier => ExplicitInterfaceSpecifierProperty;

		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, SyntaxToken> ThisKeywordProperty = new TokenProperty<IndexerDeclarationSyntax>("ThisKeyword", n => n.ThisKeyword, (n, v) => n.WithThisKeyword(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, SyntaxToken> ThisKeyword => ThisKeywordProperty;

		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, BracketedParameterListSyntax> ParameterListProperty = new NodeProperty<IndexerDeclarationSyntax, BracketedParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, BracketedParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, AccessorListSyntax> AccessorListProperty = new NodeProperty<IndexerDeclarationSyntax, AccessorListSyntax>("AccessorList", n => n.AccessorList, (n, v) => n.WithAccessorList(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, AccessorListSyntax> AccessorList => AccessorListProperty;

		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBodyProperty = new NodeProperty<IndexerDeclarationSyntax, ArrowExpressionClauseSyntax>("ExpressionBody", n => n.ExpressionBody, (n, v) => n.WithExpressionBody(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBody => ExpressionBodyProperty;

		private static readonly SyntaxNodeProperty<IndexerDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<IndexerDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<IndexerDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<IndexerDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<IndexerDeclarationSyntax>[] { AttributeLists, Modifiers, Type, ExplicitInterfaceSpecifier, ThisKeyword, ParameterList, AccessorList, ExpressionBody, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<IndexerDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class IndexerMemberCrefInfo
	{
		private static readonly SyntaxNodeProperty<IndexerMemberCrefSyntax, SyntaxToken> ThisKeywordProperty = new TokenProperty<IndexerMemberCrefSyntax>("ThisKeyword", n => n.ThisKeyword, (n, v) => n.WithThisKeyword(v));

		public static SyntaxNodeProperty<IndexerMemberCrefSyntax, SyntaxToken> ThisKeyword => ThisKeywordProperty;

		private static readonly SyntaxNodeProperty<IndexerMemberCrefSyntax, CrefBracketedParameterListSyntax> ParametersProperty = new NodeProperty<IndexerMemberCrefSyntax, CrefBracketedParameterListSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<IndexerMemberCrefSyntax, CrefBracketedParameterListSyntax> Parameters => ParametersProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<IndexerMemberCrefSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<IndexerMemberCrefSyntax>[] { ThisKeyword, Parameters };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<IndexerMemberCrefSyntax>> Properties => PropertiesArray;
	}

	internal static class InitializerExpressionInfo
	{
		private static readonly SyntaxNodeProperty<InitializerExpressionSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<InitializerExpressionSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<InitializerExpressionSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<InitializerExpressionSyntax, SeparatedSyntaxList<ExpressionSyntax>> ExpressionsProperty = new SeparatedListProperty<InitializerExpressionSyntax, ExpressionSyntax>("Expressions", n => n.Expressions, (n, v) => n.WithExpressions(v));

		public static SyntaxNodeProperty<InitializerExpressionSyntax, SeparatedSyntaxList<ExpressionSyntax>> Expressions => ExpressionsProperty;

		private static readonly SyntaxNodeProperty<InitializerExpressionSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<InitializerExpressionSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<InitializerExpressionSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<InitializerExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<InitializerExpressionSyntax>[] { OpenBraceToken, Expressions, CloseBraceToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<InitializerExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class InterfaceDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<InterfaceDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<InterfaceDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> KeywordProperty = new TokenProperty<InterfaceDeclarationSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<InterfaceDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, TypeParameterListSyntax> TypeParameterListProperty = new NodeProperty<InterfaceDeclarationSyntax, TypeParameterListSyntax>("TypeParameterList", n => n.TypeParameterList, (n, v) => n.WithTypeParameterList(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, TypeParameterListSyntax> TypeParameterList => TypeParameterListProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, BaseListSyntax> BaseListProperty = new NodeProperty<InterfaceDeclarationSyntax, BaseListSyntax>("BaseList", n => n.BaseList, (n, v) => n.WithBaseList(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, BaseListSyntax> BaseList => BaseListProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClausesProperty = new ListProperty<InterfaceDeclarationSyntax, TypeParameterConstraintClauseSyntax>("ConstraintClauses", n => n.ConstraintClauses, (n, v) => n.WithConstraintClauses(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClauses => ConstraintClausesProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<InterfaceDeclarationSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> MembersProperty = new ListProperty<InterfaceDeclarationSyntax, MemberDeclarationSyntax>("Members", n => n.Members, (n, v) => n.WithMembers(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> Members => MembersProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<InterfaceDeclarationSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<InterfaceDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<InterfaceDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<InterfaceDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<InterfaceDeclarationSyntax>[] { AttributeLists, Modifiers, Keyword, Identifier, TypeParameterList, BaseList, ConstraintClauses, OpenBraceToken, Members, CloseBraceToken, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<InterfaceDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class InterpolatedStringExpressionInfo
	{
		private static readonly SyntaxNodeProperty<InterpolatedStringExpressionSyntax, SyntaxToken> StringStartTokenProperty = new TokenProperty<InterpolatedStringExpressionSyntax>("StringStartToken", n => n.StringStartToken, (n, v) => n.WithStringStartToken(v));

		public static SyntaxNodeProperty<InterpolatedStringExpressionSyntax, SyntaxToken> StringStartToken => StringStartTokenProperty;

		private static readonly SyntaxNodeProperty<InterpolatedStringExpressionSyntax, SyntaxList<InterpolatedStringContentSyntax>> ContentsProperty = new ListProperty<InterpolatedStringExpressionSyntax, InterpolatedStringContentSyntax>("Contents", n => n.Contents, (n, v) => n.WithContents(v));

		public static SyntaxNodeProperty<InterpolatedStringExpressionSyntax, SyntaxList<InterpolatedStringContentSyntax>> Contents => ContentsProperty;

		private static readonly SyntaxNodeProperty<InterpolatedStringExpressionSyntax, SyntaxToken> StringEndTokenProperty = new TokenProperty<InterpolatedStringExpressionSyntax>("StringEndToken", n => n.StringEndToken, (n, v) => n.WithStringEndToken(v));

		public static SyntaxNodeProperty<InterpolatedStringExpressionSyntax, SyntaxToken> StringEndToken => StringEndTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<InterpolatedStringExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<InterpolatedStringExpressionSyntax>[] { StringStartToken, Contents, StringEndToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<InterpolatedStringExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class InterpolatedStringTextInfo
	{
		private static readonly SyntaxNodeProperty<InterpolatedStringTextSyntax, SyntaxToken> TextTokenProperty = new TokenProperty<InterpolatedStringTextSyntax>("TextToken", n => n.TextToken, (n, v) => n.WithTextToken(v));

		public static SyntaxNodeProperty<InterpolatedStringTextSyntax, SyntaxToken> TextToken => TextTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<InterpolatedStringTextSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<InterpolatedStringTextSyntax>[] { TextToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<InterpolatedStringTextSyntax>> Properties => PropertiesArray;
	}

	internal static class InterpolationAlignmentClauseInfo
	{
		private static readonly SyntaxNodeProperty<InterpolationAlignmentClauseSyntax, SyntaxToken> CommaTokenProperty = new TokenProperty<InterpolationAlignmentClauseSyntax>("CommaToken", n => n.CommaToken, (n, v) => n.WithCommaToken(v));

		public static SyntaxNodeProperty<InterpolationAlignmentClauseSyntax, SyntaxToken> CommaToken => CommaTokenProperty;

		private static readonly SyntaxNodeProperty<InterpolationAlignmentClauseSyntax, ExpressionSyntax> ValueProperty = new NodeProperty<InterpolationAlignmentClauseSyntax, ExpressionSyntax>("Value", n => n.Value, (n, v) => n.WithValue(v));

		public static SyntaxNodeProperty<InterpolationAlignmentClauseSyntax, ExpressionSyntax> Value => ValueProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<InterpolationAlignmentClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<InterpolationAlignmentClauseSyntax>[] { CommaToken, Value };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<InterpolationAlignmentClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class InterpolationFormatClauseInfo
	{
		private static readonly SyntaxNodeProperty<InterpolationFormatClauseSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<InterpolationFormatClauseSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<InterpolationFormatClauseSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly SyntaxNodeProperty<InterpolationFormatClauseSyntax, SyntaxToken> FormatStringTokenProperty = new TokenProperty<InterpolationFormatClauseSyntax>("FormatStringToken", n => n.FormatStringToken, (n, v) => n.WithFormatStringToken(v));

		public static SyntaxNodeProperty<InterpolationFormatClauseSyntax, SyntaxToken> FormatStringToken => FormatStringTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<InterpolationFormatClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<InterpolationFormatClauseSyntax>[] { ColonToken, FormatStringToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<InterpolationFormatClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class InterpolationInfo
	{
		private static readonly SyntaxNodeProperty<InterpolationSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<InterpolationSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<InterpolationSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<InterpolationSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<InterpolationSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<InterpolationSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<InterpolationSyntax, InterpolationAlignmentClauseSyntax> AlignmentClauseProperty = new NodeProperty<InterpolationSyntax, InterpolationAlignmentClauseSyntax>("AlignmentClause", n => n.AlignmentClause, (n, v) => n.WithAlignmentClause(v));

		public static SyntaxNodeProperty<InterpolationSyntax, InterpolationAlignmentClauseSyntax> AlignmentClause => AlignmentClauseProperty;

		private static readonly SyntaxNodeProperty<InterpolationSyntax, InterpolationFormatClauseSyntax> FormatClauseProperty = new NodeProperty<InterpolationSyntax, InterpolationFormatClauseSyntax>("FormatClause", n => n.FormatClause, (n, v) => n.WithFormatClause(v));

		public static SyntaxNodeProperty<InterpolationSyntax, InterpolationFormatClauseSyntax> FormatClause => FormatClauseProperty;

		private static readonly SyntaxNodeProperty<InterpolationSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<InterpolationSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<InterpolationSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<InterpolationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<InterpolationSyntax>[] { OpenBraceToken, Expression, AlignmentClause, FormatClause, CloseBraceToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<InterpolationSyntax>> Properties => PropertiesArray;
	}

	internal static class InvocationExpressionInfo
	{
		private static readonly SyntaxNodeProperty<InvocationExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<InvocationExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<InvocationExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<InvocationExpressionSyntax, ArgumentListSyntax> ArgumentListProperty = new NodeProperty<InvocationExpressionSyntax, ArgumentListSyntax>("ArgumentList", n => n.ArgumentList, (n, v) => n.WithArgumentList(v));

		public static SyntaxNodeProperty<InvocationExpressionSyntax, ArgumentListSyntax> ArgumentList => ArgumentListProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<InvocationExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<InvocationExpressionSyntax>[] { Expression, ArgumentList };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<InvocationExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class JoinClauseInfo
	{
		private static readonly SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> JoinKeywordProperty = new TokenProperty<JoinClauseSyntax>("JoinKeyword", n => n.JoinKeyword, (n, v) => n.WithJoinKeyword(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> JoinKeyword => JoinKeywordProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, TypeSyntax> TypeProperty = new NodeProperty<JoinClauseSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<JoinClauseSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> InKeywordProperty = new TokenProperty<JoinClauseSyntax>("InKeyword", n => n.InKeyword, (n, v) => n.WithInKeyword(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> InKeyword => InKeywordProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, ExpressionSyntax> InExpressionProperty = new NodeProperty<JoinClauseSyntax, ExpressionSyntax>("InExpression", n => n.InExpression, (n, v) => n.WithInExpression(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, ExpressionSyntax> InExpression => InExpressionProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> OnKeywordProperty = new TokenProperty<JoinClauseSyntax>("OnKeyword", n => n.OnKeyword, (n, v) => n.WithOnKeyword(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> OnKeyword => OnKeywordProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, ExpressionSyntax> LeftExpressionProperty = new NodeProperty<JoinClauseSyntax, ExpressionSyntax>("LeftExpression", n => n.LeftExpression, (n, v) => n.WithLeftExpression(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, ExpressionSyntax> LeftExpression => LeftExpressionProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> EqualsKeywordProperty = new TokenProperty<JoinClauseSyntax>("EqualsKeyword", n => n.EqualsKeyword, (n, v) => n.WithEqualsKeyword(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, SyntaxToken> EqualsKeyword => EqualsKeywordProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, ExpressionSyntax> RightExpressionProperty = new NodeProperty<JoinClauseSyntax, ExpressionSyntax>("RightExpression", n => n.RightExpression, (n, v) => n.WithRightExpression(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, ExpressionSyntax> RightExpression => RightExpressionProperty;

		private static readonly SyntaxNodeProperty<JoinClauseSyntax, JoinIntoClauseSyntax> IntoProperty = new NodeProperty<JoinClauseSyntax, JoinIntoClauseSyntax>("Into", n => n.Into, (n, v) => n.WithInto(v));

		public static SyntaxNodeProperty<JoinClauseSyntax, JoinIntoClauseSyntax> Into => IntoProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<JoinClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<JoinClauseSyntax>[] { JoinKeyword, Type, Identifier, InKeyword, InExpression, OnKeyword, LeftExpression, EqualsKeyword, RightExpression, Into };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<JoinClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class JoinIntoClauseInfo
	{
		private static readonly SyntaxNodeProperty<JoinIntoClauseSyntax, SyntaxToken> IntoKeywordProperty = new TokenProperty<JoinIntoClauseSyntax>("IntoKeyword", n => n.IntoKeyword, (n, v) => n.WithIntoKeyword(v));

		public static SyntaxNodeProperty<JoinIntoClauseSyntax, SyntaxToken> IntoKeyword => IntoKeywordProperty;

		private static readonly SyntaxNodeProperty<JoinIntoClauseSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<JoinIntoClauseSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<JoinIntoClauseSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<JoinIntoClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<JoinIntoClauseSyntax>[] { IntoKeyword, Identifier };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<JoinIntoClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class LabeledStatementInfo
	{
		private static readonly SyntaxNodeProperty<LabeledStatementSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<LabeledStatementSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<LabeledStatementSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<LabeledStatementSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<LabeledStatementSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<LabeledStatementSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly SyntaxNodeProperty<LabeledStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<LabeledStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<LabeledStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<LabeledStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<LabeledStatementSyntax>[] { Identifier, ColonToken, Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<LabeledStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class LetClauseInfo
	{
		private static readonly SyntaxNodeProperty<LetClauseSyntax, SyntaxToken> LetKeywordProperty = new TokenProperty<LetClauseSyntax>("LetKeyword", n => n.LetKeyword, (n, v) => n.WithLetKeyword(v));

		public static SyntaxNodeProperty<LetClauseSyntax, SyntaxToken> LetKeyword => LetKeywordProperty;

		private static readonly SyntaxNodeProperty<LetClauseSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<LetClauseSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<LetClauseSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<LetClauseSyntax, SyntaxToken> EqualsTokenProperty = new TokenProperty<LetClauseSyntax>("EqualsToken", n => n.EqualsToken, (n, v) => n.WithEqualsToken(v));

		public static SyntaxNodeProperty<LetClauseSyntax, SyntaxToken> EqualsToken => EqualsTokenProperty;

		private static readonly SyntaxNodeProperty<LetClauseSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<LetClauseSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<LetClauseSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<LetClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<LetClauseSyntax>[] { LetKeyword, Identifier, EqualsToken, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<LetClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class LineDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<LineDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> LineKeywordProperty = new TokenProperty<LineDirectiveTriviaSyntax>("LineKeyword", n => n.LineKeyword, (n, v) => n.WithLineKeyword(v));

		public static SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> LineKeyword => LineKeywordProperty;

		private static readonly SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> LineProperty = new TokenProperty<LineDirectiveTriviaSyntax>("Line", n => n.Line, (n, v) => n.WithLine(v));

		public static SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> Line => LineProperty;

		private static readonly SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> FileProperty = new TokenProperty<LineDirectiveTriviaSyntax>("File", n => n.File, (n, v) => n.WithFile(v));

		public static SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> File => FileProperty;

		private static readonly SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<LineDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<LineDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<LineDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<LineDirectiveTriviaSyntax>[] { HashToken, LineKeyword, Line, File, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<LineDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class LiteralExpressionInfo
	{
		private static readonly SyntaxNodeProperty<LiteralExpressionSyntax, SyntaxToken> TokenProperty = new TokenProperty<LiteralExpressionSyntax>("Token", n => n.Token, (n, v) => n.WithToken(v));

		public static SyntaxNodeProperty<LiteralExpressionSyntax, SyntaxToken> Token => TokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<LiteralExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<LiteralExpressionSyntax>[] { Token };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<LiteralExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class LoadDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<LoadDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<LoadDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<LoadDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<LoadDirectiveTriviaSyntax, SyntaxToken> LoadKeywordProperty = new TokenProperty<LoadDirectiveTriviaSyntax>("LoadKeyword", n => n.LoadKeyword, (n, v) => n.WithLoadKeyword(v));

		public static SyntaxNodeProperty<LoadDirectiveTriviaSyntax, SyntaxToken> LoadKeyword => LoadKeywordProperty;

		private static readonly SyntaxNodeProperty<LoadDirectiveTriviaSyntax, SyntaxToken> FileProperty = new TokenProperty<LoadDirectiveTriviaSyntax>("File", n => n.File, (n, v) => n.WithFile(v));

		public static SyntaxNodeProperty<LoadDirectiveTriviaSyntax, SyntaxToken> File => FileProperty;

		private static readonly SyntaxNodeProperty<LoadDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<LoadDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<LoadDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<LoadDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<LoadDirectiveTriviaSyntax>[] { HashToken, LoadKeyword, File, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<LoadDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class LocalDeclarationStatementInfo
	{
		private static readonly SyntaxNodeProperty<LocalDeclarationStatementSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<LocalDeclarationStatementSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<LocalDeclarationStatementSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<LocalDeclarationStatementSyntax, VariableDeclarationSyntax> DeclarationProperty = new NodeProperty<LocalDeclarationStatementSyntax, VariableDeclarationSyntax>("Declaration", n => n.Declaration, (n, v) => n.WithDeclaration(v));

		public static SyntaxNodeProperty<LocalDeclarationStatementSyntax, VariableDeclarationSyntax> Declaration => DeclarationProperty;

		private static readonly SyntaxNodeProperty<LocalDeclarationStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<LocalDeclarationStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<LocalDeclarationStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<LocalDeclarationStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<LocalDeclarationStatementSyntax>[] { Modifiers, Declaration, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<LocalDeclarationStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class LockStatementInfo
	{
		private static readonly SyntaxNodeProperty<LockStatementSyntax, SyntaxToken> LockKeywordProperty = new TokenProperty<LockStatementSyntax>("LockKeyword", n => n.LockKeyword, (n, v) => n.WithLockKeyword(v));

		public static SyntaxNodeProperty<LockStatementSyntax, SyntaxToken> LockKeyword => LockKeywordProperty;

		private static readonly SyntaxNodeProperty<LockStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<LockStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<LockStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<LockStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<LockStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<LockStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<LockStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<LockStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<LockStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<LockStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<LockStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<LockStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<LockStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<LockStatementSyntax>[] { LockKeyword, OpenParenToken, Expression, CloseParenToken, Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<LockStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class MakeRefExpressionInfo
	{
		private static readonly SyntaxNodeProperty<MakeRefExpressionSyntax, SyntaxToken> KeywordProperty = new TokenProperty<MakeRefExpressionSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<MakeRefExpressionSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<MakeRefExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<MakeRefExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<MakeRefExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<MakeRefExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<MakeRefExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<MakeRefExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<MakeRefExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<MakeRefExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<MakeRefExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<MakeRefExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<MakeRefExpressionSyntax>[] { Keyword, OpenParenToken, Expression, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<MakeRefExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class MemberAccessExpressionInfo
	{
		private static readonly SyntaxNodeProperty<MemberAccessExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<MemberAccessExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<MemberAccessExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<MemberAccessExpressionSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<MemberAccessExpressionSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<MemberAccessExpressionSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly SyntaxNodeProperty<MemberAccessExpressionSyntax, SimpleNameSyntax> NameProperty = new NodeProperty<MemberAccessExpressionSyntax, SimpleNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<MemberAccessExpressionSyntax, SimpleNameSyntax> Name => NameProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<MemberAccessExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<MemberAccessExpressionSyntax>[] { Expression, OperatorToken, Name };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<MemberAccessExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class MemberBindingExpressionInfo
	{
		private static readonly SyntaxNodeProperty<MemberBindingExpressionSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<MemberBindingExpressionSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<MemberBindingExpressionSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly SyntaxNodeProperty<MemberBindingExpressionSyntax, SimpleNameSyntax> NameProperty = new NodeProperty<MemberBindingExpressionSyntax, SimpleNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<MemberBindingExpressionSyntax, SimpleNameSyntax> Name => NameProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<MemberBindingExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<MemberBindingExpressionSyntax>[] { OperatorToken, Name };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<MemberBindingExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class MethodDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<MethodDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<MethodDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, TypeSyntax> ReturnTypeProperty = new NodeProperty<MethodDeclarationSyntax, TypeSyntax>("ReturnType", n => n.ReturnType, (n, v) => n.WithReturnType(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, TypeSyntax> ReturnType => ReturnTypeProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, ExplicitInterfaceSpecifierSyntax> ExplicitInterfaceSpecifierProperty = new NodeProperty<MethodDeclarationSyntax, ExplicitInterfaceSpecifierSyntax>("ExplicitInterfaceSpecifier", n => n.ExplicitInterfaceSpecifier, (n, v) => n.WithExplicitInterfaceSpecifier(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, ExplicitInterfaceSpecifierSyntax> ExplicitInterfaceSpecifier => ExplicitInterfaceSpecifierProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<MethodDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, TypeParameterListSyntax> TypeParameterListProperty = new NodeProperty<MethodDeclarationSyntax, TypeParameterListSyntax>("TypeParameterList", n => n.TypeParameterList, (n, v) => n.WithTypeParameterList(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, TypeParameterListSyntax> TypeParameterList => TypeParameterListProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, ParameterListSyntax> ParameterListProperty = new NodeProperty<MethodDeclarationSyntax, ParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, ParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClausesProperty = new ListProperty<MethodDeclarationSyntax, TypeParameterConstraintClauseSyntax>("ConstraintClauses", n => n.ConstraintClauses, (n, v) => n.WithConstraintClauses(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClauses => ConstraintClausesProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, BlockSyntax> BodyProperty = new NodeProperty<MethodDeclarationSyntax, BlockSyntax>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, BlockSyntax> Body => BodyProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBodyProperty = new NodeProperty<MethodDeclarationSyntax, ArrowExpressionClauseSyntax>("ExpressionBody", n => n.ExpressionBody, (n, v) => n.WithExpressionBody(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBody => ExpressionBodyProperty;

		private static readonly SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<MethodDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<MethodDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<MethodDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<MethodDeclarationSyntax>[] { AttributeLists, Modifiers, ReturnType, ExplicitInterfaceSpecifier, Identifier, TypeParameterList, ParameterList, ConstraintClauses, Body, ExpressionBody, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<MethodDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class NameColonInfo
	{
		private static readonly SyntaxNodeProperty<NameColonSyntax, IdentifierNameSyntax> NameProperty = new NodeProperty<NameColonSyntax, IdentifierNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<NameColonSyntax, IdentifierNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<NameColonSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<NameColonSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<NameColonSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<NameColonSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<NameColonSyntax>[] { Name, ColonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<NameColonSyntax>> Properties => PropertiesArray;
	}

	internal static class NameEqualsInfo
	{
		private static readonly SyntaxNodeProperty<NameEqualsSyntax, IdentifierNameSyntax> NameProperty = new NodeProperty<NameEqualsSyntax, IdentifierNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<NameEqualsSyntax, IdentifierNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<NameEqualsSyntax, SyntaxToken> EqualsTokenProperty = new TokenProperty<NameEqualsSyntax>("EqualsToken", n => n.EqualsToken, (n, v) => n.WithEqualsToken(v));

		public static SyntaxNodeProperty<NameEqualsSyntax, SyntaxToken> EqualsToken => EqualsTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<NameEqualsSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<NameEqualsSyntax>[] { Name, EqualsToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<NameEqualsSyntax>> Properties => PropertiesArray;
	}

	internal static class NameMemberCrefInfo
	{
		private static readonly SyntaxNodeProperty<NameMemberCrefSyntax, TypeSyntax> NameProperty = new NodeProperty<NameMemberCrefSyntax, TypeSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<NameMemberCrefSyntax, TypeSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<NameMemberCrefSyntax, CrefParameterListSyntax> ParametersProperty = new NodeProperty<NameMemberCrefSyntax, CrefParameterListSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<NameMemberCrefSyntax, CrefParameterListSyntax> Parameters => ParametersProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<NameMemberCrefSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<NameMemberCrefSyntax>[] { Name, Parameters };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<NameMemberCrefSyntax>> Properties => PropertiesArray;
	}

	internal static class NamespaceDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxToken> NamespaceKeywordProperty = new TokenProperty<NamespaceDeclarationSyntax>("NamespaceKeyword", n => n.NamespaceKeyword, (n, v) => n.WithNamespaceKeyword(v));

		public static SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxToken> NamespaceKeyword => NamespaceKeywordProperty;

		private static readonly SyntaxNodeProperty<NamespaceDeclarationSyntax, NameSyntax> NameProperty = new NodeProperty<NamespaceDeclarationSyntax, NameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<NamespaceDeclarationSyntax, NameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<NamespaceDeclarationSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxList<ExternAliasDirectiveSyntax>> ExternsProperty = new ListProperty<NamespaceDeclarationSyntax, ExternAliasDirectiveSyntax>("Externs", n => n.Externs, (n, v) => n.WithExterns(v));

		public static SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxList<ExternAliasDirectiveSyntax>> Externs => ExternsProperty;

		private static readonly SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxList<UsingDirectiveSyntax>> UsingsProperty = new ListProperty<NamespaceDeclarationSyntax, UsingDirectiveSyntax>("Usings", n => n.Usings, (n, v) => n.WithUsings(v));

		public static SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxList<UsingDirectiveSyntax>> Usings => UsingsProperty;

		private static readonly SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> MembersProperty = new ListProperty<NamespaceDeclarationSyntax, MemberDeclarationSyntax>("Members", n => n.Members, (n, v) => n.WithMembers(v));

		public static SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> Members => MembersProperty;

		private static readonly SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<NamespaceDeclarationSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<NamespaceDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<NamespaceDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<NamespaceDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<NamespaceDeclarationSyntax>[] { NamespaceKeyword, Name, OpenBraceToken, Externs, Usings, Members, CloseBraceToken, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<NamespaceDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class NullableTypeInfo
	{
		private static readonly SyntaxNodeProperty<NullableTypeSyntax, TypeSyntax> ElementTypeProperty = new NodeProperty<NullableTypeSyntax, TypeSyntax>("ElementType", n => n.ElementType, (n, v) => n.WithElementType(v));

		public static SyntaxNodeProperty<NullableTypeSyntax, TypeSyntax> ElementType => ElementTypeProperty;

		private static readonly SyntaxNodeProperty<NullableTypeSyntax, SyntaxToken> QuestionTokenProperty = new TokenProperty<NullableTypeSyntax>("QuestionToken", n => n.QuestionToken, (n, v) => n.WithQuestionToken(v));

		public static SyntaxNodeProperty<NullableTypeSyntax, SyntaxToken> QuestionToken => QuestionTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<NullableTypeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<NullableTypeSyntax>[] { ElementType, QuestionToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<NullableTypeSyntax>> Properties => PropertiesArray;
	}

	internal static class ObjectCreationExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ObjectCreationExpressionSyntax, SyntaxToken> NewKeywordProperty = new TokenProperty<ObjectCreationExpressionSyntax>("NewKeyword", n => n.NewKeyword, (n, v) => n.WithNewKeyword(v));

		public static SyntaxNodeProperty<ObjectCreationExpressionSyntax, SyntaxToken> NewKeyword => NewKeywordProperty;

		private static readonly SyntaxNodeProperty<ObjectCreationExpressionSyntax, TypeSyntax> TypeProperty = new NodeProperty<ObjectCreationExpressionSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<ObjectCreationExpressionSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<ObjectCreationExpressionSyntax, ArgumentListSyntax> ArgumentListProperty = new NodeProperty<ObjectCreationExpressionSyntax, ArgumentListSyntax>("ArgumentList", n => n.ArgumentList, (n, v) => n.WithArgumentList(v));

		public static SyntaxNodeProperty<ObjectCreationExpressionSyntax, ArgumentListSyntax> ArgumentList => ArgumentListProperty;

		private static readonly SyntaxNodeProperty<ObjectCreationExpressionSyntax, InitializerExpressionSyntax> InitializerProperty = new NodeProperty<ObjectCreationExpressionSyntax, InitializerExpressionSyntax>("Initializer", n => n.Initializer, (n, v) => n.WithInitializer(v));

		public static SyntaxNodeProperty<ObjectCreationExpressionSyntax, InitializerExpressionSyntax> Initializer => InitializerProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ObjectCreationExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ObjectCreationExpressionSyntax>[] { NewKeyword, Type, ArgumentList, Initializer };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ObjectCreationExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class OmittedArraySizeExpressionInfo
	{
		private static readonly SyntaxNodeProperty<OmittedArraySizeExpressionSyntax, SyntaxToken> OmittedArraySizeExpressionTokenProperty = new TokenProperty<OmittedArraySizeExpressionSyntax>("OmittedArraySizeExpressionToken", n => n.OmittedArraySizeExpressionToken, (n, v) => n.WithOmittedArraySizeExpressionToken(v));

		public static SyntaxNodeProperty<OmittedArraySizeExpressionSyntax, SyntaxToken> OmittedArraySizeExpressionToken => OmittedArraySizeExpressionTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<OmittedArraySizeExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<OmittedArraySizeExpressionSyntax>[] { OmittedArraySizeExpressionToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<OmittedArraySizeExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class OmittedTypeArgumentInfo
	{
		private static readonly SyntaxNodeProperty<OmittedTypeArgumentSyntax, SyntaxToken> OmittedTypeArgumentTokenProperty = new TokenProperty<OmittedTypeArgumentSyntax>("OmittedTypeArgumentToken", n => n.OmittedTypeArgumentToken, (n, v) => n.WithOmittedTypeArgumentToken(v));

		public static SyntaxNodeProperty<OmittedTypeArgumentSyntax, SyntaxToken> OmittedTypeArgumentToken => OmittedTypeArgumentTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<OmittedTypeArgumentSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<OmittedTypeArgumentSyntax>[] { OmittedTypeArgumentToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<OmittedTypeArgumentSyntax>> Properties => PropertiesArray;
	}

	internal static class OperatorDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<OperatorDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<OperatorDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, TypeSyntax> ReturnTypeProperty = new NodeProperty<OperatorDeclarationSyntax, TypeSyntax>("ReturnType", n => n.ReturnType, (n, v) => n.WithReturnType(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, TypeSyntax> ReturnType => ReturnTypeProperty;

		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxToken> OperatorKeywordProperty = new TokenProperty<OperatorDeclarationSyntax>("OperatorKeyword", n => n.OperatorKeyword, (n, v) => n.WithOperatorKeyword(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxToken> OperatorKeyword => OperatorKeywordProperty;

		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<OperatorDeclarationSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, ParameterListSyntax> ParameterListProperty = new NodeProperty<OperatorDeclarationSyntax, ParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, ParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, BlockSyntax> BodyProperty = new NodeProperty<OperatorDeclarationSyntax, BlockSyntax>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, BlockSyntax> Body => BodyProperty;

		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBodyProperty = new NodeProperty<OperatorDeclarationSyntax, ArrowExpressionClauseSyntax>("ExpressionBody", n => n.ExpressionBody, (n, v) => n.WithExpressionBody(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBody => ExpressionBodyProperty;

		private static readonly SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<OperatorDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<OperatorDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<OperatorDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<OperatorDeclarationSyntax>[] { AttributeLists, Modifiers, ReturnType, OperatorKeyword, OperatorToken, ParameterList, Body, ExpressionBody, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<OperatorDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class OperatorMemberCrefInfo
	{
		private static readonly SyntaxNodeProperty<OperatorMemberCrefSyntax, SyntaxToken> OperatorKeywordProperty = new TokenProperty<OperatorMemberCrefSyntax>("OperatorKeyword", n => n.OperatorKeyword, (n, v) => n.WithOperatorKeyword(v));

		public static SyntaxNodeProperty<OperatorMemberCrefSyntax, SyntaxToken> OperatorKeyword => OperatorKeywordProperty;

		private static readonly SyntaxNodeProperty<OperatorMemberCrefSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<OperatorMemberCrefSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<OperatorMemberCrefSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly SyntaxNodeProperty<OperatorMemberCrefSyntax, CrefParameterListSyntax> ParametersProperty = new NodeProperty<OperatorMemberCrefSyntax, CrefParameterListSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<OperatorMemberCrefSyntax, CrefParameterListSyntax> Parameters => ParametersProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<OperatorMemberCrefSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<OperatorMemberCrefSyntax>[] { OperatorKeyword, OperatorToken, Parameters };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<OperatorMemberCrefSyntax>> Properties => PropertiesArray;
	}

	internal static class OrderByClauseInfo
	{
		private static readonly SyntaxNodeProperty<OrderByClauseSyntax, SyntaxToken> OrderByKeywordProperty = new TokenProperty<OrderByClauseSyntax>("OrderByKeyword", n => n.OrderByKeyword, (n, v) => n.WithOrderByKeyword(v));

		public static SyntaxNodeProperty<OrderByClauseSyntax, SyntaxToken> OrderByKeyword => OrderByKeywordProperty;

		private static readonly SyntaxNodeProperty<OrderByClauseSyntax, SeparatedSyntaxList<OrderingSyntax>> OrderingsProperty = new SeparatedListProperty<OrderByClauseSyntax, OrderingSyntax>("Orderings", n => n.Orderings, (n, v) => n.WithOrderings(v));

		public static SyntaxNodeProperty<OrderByClauseSyntax, SeparatedSyntaxList<OrderingSyntax>> Orderings => OrderingsProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<OrderByClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<OrderByClauseSyntax>[] { OrderByKeyword, Orderings };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<OrderByClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class OrderingInfo
	{
		private static readonly SyntaxNodeProperty<OrderingSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<OrderingSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<OrderingSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<OrderingSyntax, SyntaxToken> AscendingOrDescendingKeywordProperty = new TokenProperty<OrderingSyntax>("AscendingOrDescendingKeyword", n => n.AscendingOrDescendingKeyword, (n, v) => n.WithAscendingOrDescendingKeyword(v));

		public static SyntaxNodeProperty<OrderingSyntax, SyntaxToken> AscendingOrDescendingKeyword => AscendingOrDescendingKeywordProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<OrderingSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<OrderingSyntax>[] { Expression, AscendingOrDescendingKeyword };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<OrderingSyntax>> Properties => PropertiesArray;
	}

	internal static class ParameterListInfo
	{
		private static readonly SyntaxNodeProperty<ParameterListSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<ParameterListSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<ParameterListSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<ParameterListSyntax, SeparatedSyntaxList<ParameterSyntax>> ParametersProperty = new SeparatedListProperty<ParameterListSyntax, ParameterSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<ParameterListSyntax, SeparatedSyntaxList<ParameterSyntax>> Parameters => ParametersProperty;

		private static readonly SyntaxNodeProperty<ParameterListSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<ParameterListSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<ParameterListSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ParameterListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ParameterListSyntax>[] { OpenParenToken, Parameters, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ParameterListSyntax>> Properties => PropertiesArray;
	}

	internal static class ParameterInfo
	{
		private static readonly SyntaxNodeProperty<ParameterSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<ParameterSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<ParameterSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<ParameterSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<ParameterSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<ParameterSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<ParameterSyntax, TypeSyntax> TypeProperty = new NodeProperty<ParameterSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<ParameterSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<ParameterSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<ParameterSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<ParameterSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<ParameterSyntax, EqualsValueClauseSyntax> DefaultProperty = new NodeProperty<ParameterSyntax, EqualsValueClauseSyntax>("Default", n => n.Default, (n, v) => n.WithDefault(v));

		public static SyntaxNodeProperty<ParameterSyntax, EqualsValueClauseSyntax> Default => DefaultProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ParameterSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ParameterSyntax>[] { AttributeLists, Modifiers, Type, Identifier, Default };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ParameterSyntax>> Properties => PropertiesArray;
	}

	internal static class ParenthesizedExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ParenthesizedExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<ParenthesizedExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<ParenthesizedExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<ParenthesizedExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ParenthesizedExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ParenthesizedExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<ParenthesizedExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<ParenthesizedExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<ParenthesizedExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ParenthesizedExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ParenthesizedExpressionSyntax>[] { OpenParenToken, Expression, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ParenthesizedExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ParenthesizedLambdaExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ParenthesizedLambdaExpressionSyntax, SyntaxToken> AsyncKeywordProperty = new TokenProperty<ParenthesizedLambdaExpressionSyntax>("AsyncKeyword", n => n.AsyncKeyword, (n, v) => n.WithAsyncKeyword(v));

		public static SyntaxNodeProperty<ParenthesizedLambdaExpressionSyntax, SyntaxToken> AsyncKeyword => AsyncKeywordProperty;

		private static readonly SyntaxNodeProperty<ParenthesizedLambdaExpressionSyntax, ParameterListSyntax> ParameterListProperty = new NodeProperty<ParenthesizedLambdaExpressionSyntax, ParameterListSyntax>("ParameterList", n => n.ParameterList, (n, v) => n.WithParameterList(v));

		public static SyntaxNodeProperty<ParenthesizedLambdaExpressionSyntax, ParameterListSyntax> ParameterList => ParameterListProperty;

		private static readonly SyntaxNodeProperty<ParenthesizedLambdaExpressionSyntax, SyntaxToken> ArrowTokenProperty = new TokenProperty<ParenthesizedLambdaExpressionSyntax>("ArrowToken", n => n.ArrowToken, (n, v) => n.WithArrowToken(v));

		public static SyntaxNodeProperty<ParenthesizedLambdaExpressionSyntax, SyntaxToken> ArrowToken => ArrowTokenProperty;

		private static readonly SyntaxNodeProperty<ParenthesizedLambdaExpressionSyntax, CSharpSyntaxNode> BodyProperty = new NodeProperty<ParenthesizedLambdaExpressionSyntax, CSharpSyntaxNode>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<ParenthesizedLambdaExpressionSyntax, CSharpSyntaxNode> Body => BodyProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ParenthesizedLambdaExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ParenthesizedLambdaExpressionSyntax>[] { AsyncKeyword, ParameterList, ArrowToken, Body };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ParenthesizedLambdaExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class PointerTypeInfo
	{
		private static readonly SyntaxNodeProperty<PointerTypeSyntax, TypeSyntax> ElementTypeProperty = new NodeProperty<PointerTypeSyntax, TypeSyntax>("ElementType", n => n.ElementType, (n, v) => n.WithElementType(v));

		public static SyntaxNodeProperty<PointerTypeSyntax, TypeSyntax> ElementType => ElementTypeProperty;

		private static readonly SyntaxNodeProperty<PointerTypeSyntax, SyntaxToken> AsteriskTokenProperty = new TokenProperty<PointerTypeSyntax>("AsteriskToken", n => n.AsteriskToken, (n, v) => n.WithAsteriskToken(v));

		public static SyntaxNodeProperty<PointerTypeSyntax, SyntaxToken> AsteriskToken => AsteriskTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<PointerTypeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<PointerTypeSyntax>[] { ElementType, AsteriskToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<PointerTypeSyntax>> Properties => PropertiesArray;
	}

	internal static class PostfixUnaryExpressionInfo
	{
		private static readonly SyntaxNodeProperty<PostfixUnaryExpressionSyntax, ExpressionSyntax> OperandProperty = new NodeProperty<PostfixUnaryExpressionSyntax, ExpressionSyntax>("Operand", n => n.Operand, (n, v) => n.WithOperand(v));

		public static SyntaxNodeProperty<PostfixUnaryExpressionSyntax, ExpressionSyntax> Operand => OperandProperty;

		private static readonly SyntaxNodeProperty<PostfixUnaryExpressionSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<PostfixUnaryExpressionSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<PostfixUnaryExpressionSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<PostfixUnaryExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<PostfixUnaryExpressionSyntax>[] { Operand, OperatorToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<PostfixUnaryExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class PragmaChecksumDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<PragmaChecksumDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> PragmaKeywordProperty = new TokenProperty<PragmaChecksumDirectiveTriviaSyntax>("PragmaKeyword", n => n.PragmaKeyword, (n, v) => n.WithPragmaKeyword(v));

		public static SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> PragmaKeyword => PragmaKeywordProperty;

		private static readonly SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> ChecksumKeywordProperty = new TokenProperty<PragmaChecksumDirectiveTriviaSyntax>("ChecksumKeyword", n => n.ChecksumKeyword, (n, v) => n.WithChecksumKeyword(v));

		public static SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> ChecksumKeyword => ChecksumKeywordProperty;

		private static readonly SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> FileProperty = new TokenProperty<PragmaChecksumDirectiveTriviaSyntax>("File", n => n.File, (n, v) => n.WithFile(v));

		public static SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> File => FileProperty;

		private static readonly SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> GuidProperty = new TokenProperty<PragmaChecksumDirectiveTriviaSyntax>("Guid", n => n.Guid, (n, v) => n.WithGuid(v));

		public static SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> Guid => GuidProperty;

		private static readonly SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> BytesProperty = new TokenProperty<PragmaChecksumDirectiveTriviaSyntax>("Bytes", n => n.Bytes, (n, v) => n.WithBytes(v));

		public static SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> Bytes => BytesProperty;

		private static readonly SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<PragmaChecksumDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<PragmaChecksumDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<PragmaChecksumDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<PragmaChecksumDirectiveTriviaSyntax>[] { HashToken, PragmaKeyword, ChecksumKeyword, File, Guid, Bytes, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<PragmaChecksumDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class PragmaWarningDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<PragmaWarningDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> PragmaKeywordProperty = new TokenProperty<PragmaWarningDirectiveTriviaSyntax>("PragmaKeyword", n => n.PragmaKeyword, (n, v) => n.WithPragmaKeyword(v));

		public static SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> PragmaKeyword => PragmaKeywordProperty;

		private static readonly SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> WarningKeywordProperty = new TokenProperty<PragmaWarningDirectiveTriviaSyntax>("WarningKeyword", n => n.WarningKeyword, (n, v) => n.WithWarningKeyword(v));

		public static SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> WarningKeyword => WarningKeywordProperty;

		private static readonly SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> DisableOrRestoreKeywordProperty = new TokenProperty<PragmaWarningDirectiveTriviaSyntax>("DisableOrRestoreKeyword", n => n.DisableOrRestoreKeyword, (n, v) => n.WithDisableOrRestoreKeyword(v));

		public static SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> DisableOrRestoreKeyword => DisableOrRestoreKeywordProperty;

		private static readonly SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SeparatedSyntaxList<ExpressionSyntax>> ErrorCodesProperty = new SeparatedListProperty<PragmaWarningDirectiveTriviaSyntax, ExpressionSyntax>("ErrorCodes", n => n.ErrorCodes, (n, v) => n.WithErrorCodes(v));

		public static SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SeparatedSyntaxList<ExpressionSyntax>> ErrorCodes => ErrorCodesProperty;

		private static readonly SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<PragmaWarningDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<PragmaWarningDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<PragmaWarningDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<PragmaWarningDirectiveTriviaSyntax>[] { HashToken, PragmaKeyword, WarningKeyword, DisableOrRestoreKeyword, ErrorCodes, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<PragmaWarningDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class PredefinedTypeInfo
	{
		private static readonly SyntaxNodeProperty<PredefinedTypeSyntax, SyntaxToken> KeywordProperty = new TokenProperty<PredefinedTypeSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<PredefinedTypeSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<PredefinedTypeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<PredefinedTypeSyntax>[] { Keyword };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<PredefinedTypeSyntax>> Properties => PropertiesArray;
	}

	internal static class PrefixUnaryExpressionInfo
	{
		private static readonly SyntaxNodeProperty<PrefixUnaryExpressionSyntax, SyntaxToken> OperatorTokenProperty = new TokenProperty<PrefixUnaryExpressionSyntax>("OperatorToken", n => n.OperatorToken, (n, v) => n.WithOperatorToken(v));

		public static SyntaxNodeProperty<PrefixUnaryExpressionSyntax, SyntaxToken> OperatorToken => OperatorTokenProperty;

		private static readonly SyntaxNodeProperty<PrefixUnaryExpressionSyntax, ExpressionSyntax> OperandProperty = new NodeProperty<PrefixUnaryExpressionSyntax, ExpressionSyntax>("Operand", n => n.Operand, (n, v) => n.WithOperand(v));

		public static SyntaxNodeProperty<PrefixUnaryExpressionSyntax, ExpressionSyntax> Operand => OperandProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<PrefixUnaryExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<PrefixUnaryExpressionSyntax>[] { OperatorToken, Operand };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<PrefixUnaryExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class PropertyDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<PropertyDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<PropertyDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, TypeSyntax> TypeProperty = new NodeProperty<PropertyDeclarationSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, ExplicitInterfaceSpecifierSyntax> ExplicitInterfaceSpecifierProperty = new NodeProperty<PropertyDeclarationSyntax, ExplicitInterfaceSpecifierSyntax>("ExplicitInterfaceSpecifier", n => n.ExplicitInterfaceSpecifier, (n, v) => n.WithExplicitInterfaceSpecifier(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, ExplicitInterfaceSpecifierSyntax> ExplicitInterfaceSpecifier => ExplicitInterfaceSpecifierProperty;

		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<PropertyDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, AccessorListSyntax> AccessorListProperty = new NodeProperty<PropertyDeclarationSyntax, AccessorListSyntax>("AccessorList", n => n.AccessorList, (n, v) => n.WithAccessorList(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, AccessorListSyntax> AccessorList => AccessorListProperty;

		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBodyProperty = new NodeProperty<PropertyDeclarationSyntax, ArrowExpressionClauseSyntax>("ExpressionBody", n => n.ExpressionBody, (n, v) => n.WithExpressionBody(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, ArrowExpressionClauseSyntax> ExpressionBody => ExpressionBodyProperty;

		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, EqualsValueClauseSyntax> InitializerProperty = new NodeProperty<PropertyDeclarationSyntax, EqualsValueClauseSyntax>("Initializer", n => n.Initializer, (n, v) => n.WithInitializer(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, EqualsValueClauseSyntax> Initializer => InitializerProperty;

		private static readonly SyntaxNodeProperty<PropertyDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<PropertyDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<PropertyDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<PropertyDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<PropertyDeclarationSyntax>[] { AttributeLists, Modifiers, Type, ExplicitInterfaceSpecifier, Identifier, AccessorList, ExpressionBody, Initializer, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<PropertyDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class QualifiedCrefInfo
	{
		private static readonly SyntaxNodeProperty<QualifiedCrefSyntax, TypeSyntax> ContainerProperty = new NodeProperty<QualifiedCrefSyntax, TypeSyntax>("Container", n => n.Container, (n, v) => n.WithContainer(v));

		public static SyntaxNodeProperty<QualifiedCrefSyntax, TypeSyntax> Container => ContainerProperty;

		private static readonly SyntaxNodeProperty<QualifiedCrefSyntax, SyntaxToken> DotTokenProperty = new TokenProperty<QualifiedCrefSyntax>("DotToken", n => n.DotToken, (n, v) => n.WithDotToken(v));

		public static SyntaxNodeProperty<QualifiedCrefSyntax, SyntaxToken> DotToken => DotTokenProperty;

		private static readonly SyntaxNodeProperty<QualifiedCrefSyntax, MemberCrefSyntax> MemberProperty = new NodeProperty<QualifiedCrefSyntax, MemberCrefSyntax>("Member", n => n.Member, (n, v) => n.WithMember(v));

		public static SyntaxNodeProperty<QualifiedCrefSyntax, MemberCrefSyntax> Member => MemberProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<QualifiedCrefSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<QualifiedCrefSyntax>[] { Container, DotToken, Member };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<QualifiedCrefSyntax>> Properties => PropertiesArray;
	}

	internal static class QualifiedNameInfo
	{
		private static readonly SyntaxNodeProperty<QualifiedNameSyntax, NameSyntax> LeftProperty = new NodeProperty<QualifiedNameSyntax, NameSyntax>("Left", n => n.Left, (n, v) => n.WithLeft(v));

		public static SyntaxNodeProperty<QualifiedNameSyntax, NameSyntax> Left => LeftProperty;

		private static readonly SyntaxNodeProperty<QualifiedNameSyntax, SyntaxToken> DotTokenProperty = new TokenProperty<QualifiedNameSyntax>("DotToken", n => n.DotToken, (n, v) => n.WithDotToken(v));

		public static SyntaxNodeProperty<QualifiedNameSyntax, SyntaxToken> DotToken => DotTokenProperty;

		private static readonly SyntaxNodeProperty<QualifiedNameSyntax, SimpleNameSyntax> RightProperty = new NodeProperty<QualifiedNameSyntax, SimpleNameSyntax>("Right", n => n.Right, (n, v) => n.WithRight(v));

		public static SyntaxNodeProperty<QualifiedNameSyntax, SimpleNameSyntax> Right => RightProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<QualifiedNameSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<QualifiedNameSyntax>[] { Left, DotToken, Right };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<QualifiedNameSyntax>> Properties => PropertiesArray;
	}

	internal static class QueryBodyInfo
	{
		private static readonly SyntaxNodeProperty<QueryBodySyntax, SyntaxList<QueryClauseSyntax>> ClausesProperty = new ListProperty<QueryBodySyntax, QueryClauseSyntax>("Clauses", n => n.Clauses, (n, v) => n.WithClauses(v));

		public static SyntaxNodeProperty<QueryBodySyntax, SyntaxList<QueryClauseSyntax>> Clauses => ClausesProperty;

		private static readonly SyntaxNodeProperty<QueryBodySyntax, SelectOrGroupClauseSyntax> SelectOrGroupProperty = new NodeProperty<QueryBodySyntax, SelectOrGroupClauseSyntax>("SelectOrGroup", n => n.SelectOrGroup, (n, v) => n.WithSelectOrGroup(v));

		public static SyntaxNodeProperty<QueryBodySyntax, SelectOrGroupClauseSyntax> SelectOrGroup => SelectOrGroupProperty;

		private static readonly SyntaxNodeProperty<QueryBodySyntax, QueryContinuationSyntax> ContinuationProperty = new NodeProperty<QueryBodySyntax, QueryContinuationSyntax>("Continuation", n => n.Continuation, (n, v) => n.WithContinuation(v));

		public static SyntaxNodeProperty<QueryBodySyntax, QueryContinuationSyntax> Continuation => ContinuationProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<QueryBodySyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<QueryBodySyntax>[] { Clauses, SelectOrGroup, Continuation };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<QueryBodySyntax>> Properties => PropertiesArray;
	}

	internal static class QueryContinuationInfo
	{
		private static readonly SyntaxNodeProperty<QueryContinuationSyntax, SyntaxToken> IntoKeywordProperty = new TokenProperty<QueryContinuationSyntax>("IntoKeyword", n => n.IntoKeyword, (n, v) => n.WithIntoKeyword(v));

		public static SyntaxNodeProperty<QueryContinuationSyntax, SyntaxToken> IntoKeyword => IntoKeywordProperty;

		private static readonly SyntaxNodeProperty<QueryContinuationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<QueryContinuationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<QueryContinuationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<QueryContinuationSyntax, QueryBodySyntax> BodyProperty = new NodeProperty<QueryContinuationSyntax, QueryBodySyntax>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<QueryContinuationSyntax, QueryBodySyntax> Body => BodyProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<QueryContinuationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<QueryContinuationSyntax>[] { IntoKeyword, Identifier, Body };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<QueryContinuationSyntax>> Properties => PropertiesArray;
	}

	internal static class QueryExpressionInfo
	{
		private static readonly SyntaxNodeProperty<QueryExpressionSyntax, FromClauseSyntax> FromClauseProperty = new NodeProperty<QueryExpressionSyntax, FromClauseSyntax>("FromClause", n => n.FromClause, (n, v) => n.WithFromClause(v));

		public static SyntaxNodeProperty<QueryExpressionSyntax, FromClauseSyntax> FromClause => FromClauseProperty;

		private static readonly SyntaxNodeProperty<QueryExpressionSyntax, QueryBodySyntax> BodyProperty = new NodeProperty<QueryExpressionSyntax, QueryBodySyntax>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<QueryExpressionSyntax, QueryBodySyntax> Body => BodyProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<QueryExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<QueryExpressionSyntax>[] { FromClause, Body };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<QueryExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ReferenceDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<ReferenceDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<ReferenceDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<ReferenceDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<ReferenceDirectiveTriviaSyntax, SyntaxToken> ReferenceKeywordProperty = new TokenProperty<ReferenceDirectiveTriviaSyntax>("ReferenceKeyword", n => n.ReferenceKeyword, (n, v) => n.WithReferenceKeyword(v));

		public static SyntaxNodeProperty<ReferenceDirectiveTriviaSyntax, SyntaxToken> ReferenceKeyword => ReferenceKeywordProperty;

		private static readonly SyntaxNodeProperty<ReferenceDirectiveTriviaSyntax, SyntaxToken> FileProperty = new TokenProperty<ReferenceDirectiveTriviaSyntax>("File", n => n.File, (n, v) => n.WithFile(v));

		public static SyntaxNodeProperty<ReferenceDirectiveTriviaSyntax, SyntaxToken> File => FileProperty;

		private static readonly SyntaxNodeProperty<ReferenceDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<ReferenceDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<ReferenceDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ReferenceDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ReferenceDirectiveTriviaSyntax>[] { HashToken, ReferenceKeyword, File, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ReferenceDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class RefTypeExpressionInfo
	{
		private static readonly SyntaxNodeProperty<RefTypeExpressionSyntax, SyntaxToken> KeywordProperty = new TokenProperty<RefTypeExpressionSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<RefTypeExpressionSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<RefTypeExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<RefTypeExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<RefTypeExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<RefTypeExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<RefTypeExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<RefTypeExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<RefTypeExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<RefTypeExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<RefTypeExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<RefTypeExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<RefTypeExpressionSyntax>[] { Keyword, OpenParenToken, Expression, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<RefTypeExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class RefValueExpressionInfo
	{
		private static readonly SyntaxNodeProperty<RefValueExpressionSyntax, SyntaxToken> KeywordProperty = new TokenProperty<RefValueExpressionSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<RefValueExpressionSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<RefValueExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<RefValueExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<RefValueExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<RefValueExpressionSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<RefValueExpressionSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<RefValueExpressionSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<RefValueExpressionSyntax, SyntaxToken> CommaProperty = new TokenProperty<RefValueExpressionSyntax>("Comma", n => n.Comma, (n, v) => n.WithComma(v));

		public static SyntaxNodeProperty<RefValueExpressionSyntax, SyntaxToken> Comma => CommaProperty;

		private static readonly SyntaxNodeProperty<RefValueExpressionSyntax, TypeSyntax> TypeProperty = new NodeProperty<RefValueExpressionSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<RefValueExpressionSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<RefValueExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<RefValueExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<RefValueExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<RefValueExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<RefValueExpressionSyntax>[] { Keyword, OpenParenToken, Expression, Comma, Type, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<RefValueExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class RegionDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<RegionDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<RegionDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<RegionDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<RegionDirectiveTriviaSyntax, SyntaxToken> RegionKeywordProperty = new TokenProperty<RegionDirectiveTriviaSyntax>("RegionKeyword", n => n.RegionKeyword, (n, v) => n.WithRegionKeyword(v));

		public static SyntaxNodeProperty<RegionDirectiveTriviaSyntax, SyntaxToken> RegionKeyword => RegionKeywordProperty;

		private static readonly SyntaxNodeProperty<RegionDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<RegionDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<RegionDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<RegionDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<RegionDirectiveTriviaSyntax>[] { HashToken, RegionKeyword, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<RegionDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class ReturnStatementInfo
	{
		private static readonly SyntaxNodeProperty<ReturnStatementSyntax, SyntaxToken> ReturnKeywordProperty = new TokenProperty<ReturnStatementSyntax>("ReturnKeyword", n => n.ReturnKeyword, (n, v) => n.WithReturnKeyword(v));

		public static SyntaxNodeProperty<ReturnStatementSyntax, SyntaxToken> ReturnKeyword => ReturnKeywordProperty;

		private static readonly SyntaxNodeProperty<ReturnStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ReturnStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ReturnStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<ReturnStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<ReturnStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<ReturnStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ReturnStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ReturnStatementSyntax>[] { ReturnKeyword, Expression, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ReturnStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class SelectClauseInfo
	{
		private static readonly SyntaxNodeProperty<SelectClauseSyntax, SyntaxToken> SelectKeywordProperty = new TokenProperty<SelectClauseSyntax>("SelectKeyword", n => n.SelectKeyword, (n, v) => n.WithSelectKeyword(v));

		public static SyntaxNodeProperty<SelectClauseSyntax, SyntaxToken> SelectKeyword => SelectKeywordProperty;

		private static readonly SyntaxNodeProperty<SelectClauseSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<SelectClauseSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<SelectClauseSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<SelectClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<SelectClauseSyntax>[] { SelectKeyword, Expression };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<SelectClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class ShebangDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<ShebangDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<ShebangDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<ShebangDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<ShebangDirectiveTriviaSyntax, SyntaxToken> ExclamationTokenProperty = new TokenProperty<ShebangDirectiveTriviaSyntax>("ExclamationToken", n => n.ExclamationToken, (n, v) => n.WithExclamationToken(v));

		public static SyntaxNodeProperty<ShebangDirectiveTriviaSyntax, SyntaxToken> ExclamationToken => ExclamationTokenProperty;

		private static readonly SyntaxNodeProperty<ShebangDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<ShebangDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<ShebangDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ShebangDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ShebangDirectiveTriviaSyntax>[] { HashToken, ExclamationToken, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ShebangDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class SimpleBaseTypeInfo
	{
		private static readonly SyntaxNodeProperty<SimpleBaseTypeSyntax, TypeSyntax> TypeProperty = new NodeProperty<SimpleBaseTypeSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<SimpleBaseTypeSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<SimpleBaseTypeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<SimpleBaseTypeSyntax>[] { Type };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<SimpleBaseTypeSyntax>> Properties => PropertiesArray;
	}

	internal static class SimpleLambdaExpressionInfo
	{
		private static readonly SyntaxNodeProperty<SimpleLambdaExpressionSyntax, SyntaxToken> AsyncKeywordProperty = new TokenProperty<SimpleLambdaExpressionSyntax>("AsyncKeyword", n => n.AsyncKeyword, (n, v) => n.WithAsyncKeyword(v));

		public static SyntaxNodeProperty<SimpleLambdaExpressionSyntax, SyntaxToken> AsyncKeyword => AsyncKeywordProperty;

		private static readonly SyntaxNodeProperty<SimpleLambdaExpressionSyntax, ParameterSyntax> ParameterProperty = new NodeProperty<SimpleLambdaExpressionSyntax, ParameterSyntax>("Parameter", n => n.Parameter, (n, v) => n.WithParameter(v));

		public static SyntaxNodeProperty<SimpleLambdaExpressionSyntax, ParameterSyntax> Parameter => ParameterProperty;

		private static readonly SyntaxNodeProperty<SimpleLambdaExpressionSyntax, SyntaxToken> ArrowTokenProperty = new TokenProperty<SimpleLambdaExpressionSyntax>("ArrowToken", n => n.ArrowToken, (n, v) => n.WithArrowToken(v));

		public static SyntaxNodeProperty<SimpleLambdaExpressionSyntax, SyntaxToken> ArrowToken => ArrowTokenProperty;

		private static readonly SyntaxNodeProperty<SimpleLambdaExpressionSyntax, CSharpSyntaxNode> BodyProperty = new NodeProperty<SimpleLambdaExpressionSyntax, CSharpSyntaxNode>("Body", n => n.Body, (n, v) => n.WithBody(v));

		public static SyntaxNodeProperty<SimpleLambdaExpressionSyntax, CSharpSyntaxNode> Body => BodyProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<SimpleLambdaExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<SimpleLambdaExpressionSyntax>[] { AsyncKeyword, Parameter, ArrowToken, Body };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<SimpleLambdaExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class SizeOfExpressionInfo
	{
		private static readonly SyntaxNodeProperty<SizeOfExpressionSyntax, SyntaxToken> KeywordProperty = new TokenProperty<SizeOfExpressionSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<SizeOfExpressionSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<SizeOfExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<SizeOfExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<SizeOfExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<SizeOfExpressionSyntax, TypeSyntax> TypeProperty = new NodeProperty<SizeOfExpressionSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<SizeOfExpressionSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<SizeOfExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<SizeOfExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<SizeOfExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<SizeOfExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<SizeOfExpressionSyntax>[] { Keyword, OpenParenToken, Type, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<SizeOfExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class SkippedTokensTriviaInfo
	{
		private static readonly SyntaxNodeProperty<SkippedTokensTriviaSyntax, SyntaxTokenList> TokensProperty = new TokenListProperty<SkippedTokensTriviaSyntax>("Tokens", n => n.Tokens, (n, v) => n.WithTokens(v));

		public static SyntaxNodeProperty<SkippedTokensTriviaSyntax, SyntaxTokenList> Tokens => TokensProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<SkippedTokensTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<SkippedTokensTriviaSyntax>[] { Tokens };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<SkippedTokensTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class StackAllocArrayCreationExpressionInfo
	{
		private static readonly SyntaxNodeProperty<StackAllocArrayCreationExpressionSyntax, SyntaxToken> StackAllocKeywordProperty = new TokenProperty<StackAllocArrayCreationExpressionSyntax>("StackAllocKeyword", n => n.StackAllocKeyword, (n, v) => n.WithStackAllocKeyword(v));

		public static SyntaxNodeProperty<StackAllocArrayCreationExpressionSyntax, SyntaxToken> StackAllocKeyword => StackAllocKeywordProperty;

		private static readonly SyntaxNodeProperty<StackAllocArrayCreationExpressionSyntax, TypeSyntax> TypeProperty = new NodeProperty<StackAllocArrayCreationExpressionSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<StackAllocArrayCreationExpressionSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<StackAllocArrayCreationExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<StackAllocArrayCreationExpressionSyntax>[] { StackAllocKeyword, Type };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<StackAllocArrayCreationExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class StructDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<StructDeclarationSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxTokenList> ModifiersProperty = new TokenListProperty<StructDeclarationSyntax>("Modifiers", n => n.Modifiers, (n, v) => n.WithModifiers(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxTokenList> Modifiers => ModifiersProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> KeywordProperty = new TokenProperty<StructDeclarationSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<StructDeclarationSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, TypeParameterListSyntax> TypeParameterListProperty = new NodeProperty<StructDeclarationSyntax, TypeParameterListSyntax>("TypeParameterList", n => n.TypeParameterList, (n, v) => n.WithTypeParameterList(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, TypeParameterListSyntax> TypeParameterList => TypeParameterListProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, BaseListSyntax> BaseListProperty = new NodeProperty<StructDeclarationSyntax, BaseListSyntax>("BaseList", n => n.BaseList, (n, v) => n.WithBaseList(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, BaseListSyntax> BaseList => BaseListProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClausesProperty = new ListProperty<StructDeclarationSyntax, TypeParameterConstraintClauseSyntax>("ConstraintClauses", n => n.ConstraintClauses, (n, v) => n.WithConstraintClauses(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> ConstraintClauses => ConstraintClausesProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<StructDeclarationSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> MembersProperty = new ListProperty<StructDeclarationSyntax, MemberDeclarationSyntax>("Members", n => n.Members, (n, v) => n.WithMembers(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>> Members => MembersProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<StructDeclarationSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<StructDeclarationSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<StructDeclarationSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<StructDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<StructDeclarationSyntax>[] { AttributeLists, Modifiers, Keyword, Identifier, TypeParameterList, BaseList, ConstraintClauses, OpenBraceToken, Members, CloseBraceToken, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<StructDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class SwitchSectionInfo
	{
		private static readonly SyntaxNodeProperty<SwitchSectionSyntax, SyntaxList<SwitchLabelSyntax>> LabelsProperty = new ListProperty<SwitchSectionSyntax, SwitchLabelSyntax>("Labels", n => n.Labels, (n, v) => n.WithLabels(v));

		public static SyntaxNodeProperty<SwitchSectionSyntax, SyntaxList<SwitchLabelSyntax>> Labels => LabelsProperty;

		private static readonly SyntaxNodeProperty<SwitchSectionSyntax, SyntaxList<StatementSyntax>> StatementsProperty = new ListProperty<SwitchSectionSyntax, StatementSyntax>("Statements", n => n.Statements, (n, v) => n.WithStatements(v));

		public static SyntaxNodeProperty<SwitchSectionSyntax, SyntaxList<StatementSyntax>> Statements => StatementsProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<SwitchSectionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<SwitchSectionSyntax>[] { Labels, Statements };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<SwitchSectionSyntax>> Properties => PropertiesArray;
	}

	internal static class SwitchStatementInfo
	{
		private static readonly SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> SwitchKeywordProperty = new TokenProperty<SwitchStatementSyntax>("SwitchKeyword", n => n.SwitchKeyword, (n, v) => n.WithSwitchKeyword(v));

		public static SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> SwitchKeyword => SwitchKeywordProperty;

		private static readonly SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<SwitchStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<SwitchStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<SwitchStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<SwitchStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<SwitchStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> OpenBraceTokenProperty = new TokenProperty<SwitchStatementSyntax>("OpenBraceToken", n => n.OpenBraceToken, (n, v) => n.WithOpenBraceToken(v));

		public static SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> OpenBraceToken => OpenBraceTokenProperty;

		private static readonly SyntaxNodeProperty<SwitchStatementSyntax, SyntaxList<SwitchSectionSyntax>> SectionsProperty = new ListProperty<SwitchStatementSyntax, SwitchSectionSyntax>("Sections", n => n.Sections, (n, v) => n.WithSections(v));

		public static SyntaxNodeProperty<SwitchStatementSyntax, SyntaxList<SwitchSectionSyntax>> Sections => SectionsProperty;

		private static readonly SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> CloseBraceTokenProperty = new TokenProperty<SwitchStatementSyntax>("CloseBraceToken", n => n.CloseBraceToken, (n, v) => n.WithCloseBraceToken(v));

		public static SyntaxNodeProperty<SwitchStatementSyntax, SyntaxToken> CloseBraceToken => CloseBraceTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<SwitchStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<SwitchStatementSyntax>[] { SwitchKeyword, OpenParenToken, Expression, CloseParenToken, OpenBraceToken, Sections, CloseBraceToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<SwitchStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class ThisExpressionInfo
	{
		private static readonly SyntaxNodeProperty<ThisExpressionSyntax, SyntaxToken> TokenProperty = new TokenProperty<ThisExpressionSyntax>("Token", n => n.Token, (n, v) => n.WithToken(v));

		public static SyntaxNodeProperty<ThisExpressionSyntax, SyntaxToken> Token => TokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ThisExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ThisExpressionSyntax>[] { Token };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ThisExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class ThrowStatementInfo
	{
		private static readonly SyntaxNodeProperty<ThrowStatementSyntax, SyntaxToken> ThrowKeywordProperty = new TokenProperty<ThrowStatementSyntax>("ThrowKeyword", n => n.ThrowKeyword, (n, v) => n.WithThrowKeyword(v));

		public static SyntaxNodeProperty<ThrowStatementSyntax, SyntaxToken> ThrowKeyword => ThrowKeywordProperty;

		private static readonly SyntaxNodeProperty<ThrowStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<ThrowStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<ThrowStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<ThrowStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<ThrowStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<ThrowStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<ThrowStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<ThrowStatementSyntax>[] { ThrowKeyword, Expression, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<ThrowStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class TryStatementInfo
	{
		private static readonly SyntaxNodeProperty<TryStatementSyntax, SyntaxToken> TryKeywordProperty = new TokenProperty<TryStatementSyntax>("TryKeyword", n => n.TryKeyword, (n, v) => n.WithTryKeyword(v));

		public static SyntaxNodeProperty<TryStatementSyntax, SyntaxToken> TryKeyword => TryKeywordProperty;

		private static readonly SyntaxNodeProperty<TryStatementSyntax, BlockSyntax> BlockProperty = new NodeProperty<TryStatementSyntax, BlockSyntax>("Block", n => n.Block, (n, v) => n.WithBlock(v));

		public static SyntaxNodeProperty<TryStatementSyntax, BlockSyntax> Block => BlockProperty;

		private static readonly SyntaxNodeProperty<TryStatementSyntax, SyntaxList<CatchClauseSyntax>> CatchesProperty = new ListProperty<TryStatementSyntax, CatchClauseSyntax>("Catches", n => n.Catches, (n, v) => n.WithCatches(v));

		public static SyntaxNodeProperty<TryStatementSyntax, SyntaxList<CatchClauseSyntax>> Catches => CatchesProperty;

		private static readonly SyntaxNodeProperty<TryStatementSyntax, FinallyClauseSyntax> FinallyProperty = new NodeProperty<TryStatementSyntax, FinallyClauseSyntax>("Finally", n => n.Finally, (n, v) => n.WithFinally(v));

		public static SyntaxNodeProperty<TryStatementSyntax, FinallyClauseSyntax> Finally => FinallyProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<TryStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<TryStatementSyntax>[] { TryKeyword, Block, Catches, Finally };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<TryStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class TypeArgumentListInfo
	{
		private static readonly SyntaxNodeProperty<TypeArgumentListSyntax, SyntaxToken> LessThanTokenProperty = new TokenProperty<TypeArgumentListSyntax>("LessThanToken", n => n.LessThanToken, (n, v) => n.WithLessThanToken(v));

		public static SyntaxNodeProperty<TypeArgumentListSyntax, SyntaxToken> LessThanToken => LessThanTokenProperty;

		private static readonly SyntaxNodeProperty<TypeArgumentListSyntax, SeparatedSyntaxList<TypeSyntax>> ArgumentsProperty = new SeparatedListProperty<TypeArgumentListSyntax, TypeSyntax>("Arguments", n => n.Arguments, (n, v) => n.WithArguments(v));

		public static SyntaxNodeProperty<TypeArgumentListSyntax, SeparatedSyntaxList<TypeSyntax>> Arguments => ArgumentsProperty;

		private static readonly SyntaxNodeProperty<TypeArgumentListSyntax, SyntaxToken> GreaterThanTokenProperty = new TokenProperty<TypeArgumentListSyntax>("GreaterThanToken", n => n.GreaterThanToken, (n, v) => n.WithGreaterThanToken(v));

		public static SyntaxNodeProperty<TypeArgumentListSyntax, SyntaxToken> GreaterThanToken => GreaterThanTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<TypeArgumentListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<TypeArgumentListSyntax>[] { LessThanToken, Arguments, GreaterThanToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<TypeArgumentListSyntax>> Properties => PropertiesArray;
	}

	internal static class TypeConstraintInfo
	{
		private static readonly SyntaxNodeProperty<TypeConstraintSyntax, TypeSyntax> TypeProperty = new NodeProperty<TypeConstraintSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<TypeConstraintSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<TypeConstraintSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<TypeConstraintSyntax>[] { Type };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<TypeConstraintSyntax>> Properties => PropertiesArray;
	}

	internal static class TypeCrefInfo
	{
		private static readonly SyntaxNodeProperty<TypeCrefSyntax, TypeSyntax> TypeProperty = new NodeProperty<TypeCrefSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<TypeCrefSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<TypeCrefSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<TypeCrefSyntax>[] { Type };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<TypeCrefSyntax>> Properties => PropertiesArray;
	}

	internal static class TypeOfExpressionInfo
	{
		private static readonly SyntaxNodeProperty<TypeOfExpressionSyntax, SyntaxToken> KeywordProperty = new TokenProperty<TypeOfExpressionSyntax>("Keyword", n => n.Keyword, (n, v) => n.WithKeyword(v));

		public static SyntaxNodeProperty<TypeOfExpressionSyntax, SyntaxToken> Keyword => KeywordProperty;

		private static readonly SyntaxNodeProperty<TypeOfExpressionSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<TypeOfExpressionSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<TypeOfExpressionSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<TypeOfExpressionSyntax, TypeSyntax> TypeProperty = new NodeProperty<TypeOfExpressionSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<TypeOfExpressionSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<TypeOfExpressionSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<TypeOfExpressionSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<TypeOfExpressionSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<TypeOfExpressionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<TypeOfExpressionSyntax>[] { Keyword, OpenParenToken, Type, CloseParenToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<TypeOfExpressionSyntax>> Properties => PropertiesArray;
	}

	internal static class TypeParameterConstraintClauseInfo
	{
		private static readonly SyntaxNodeProperty<TypeParameterConstraintClauseSyntax, SyntaxToken> WhereKeywordProperty = new TokenProperty<TypeParameterConstraintClauseSyntax>("WhereKeyword", n => n.WhereKeyword, (n, v) => n.WithWhereKeyword(v));

		public static SyntaxNodeProperty<TypeParameterConstraintClauseSyntax, SyntaxToken> WhereKeyword => WhereKeywordProperty;

		private static readonly SyntaxNodeProperty<TypeParameterConstraintClauseSyntax, IdentifierNameSyntax> NameProperty = new NodeProperty<TypeParameterConstraintClauseSyntax, IdentifierNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<TypeParameterConstraintClauseSyntax, IdentifierNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<TypeParameterConstraintClauseSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<TypeParameterConstraintClauseSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<TypeParameterConstraintClauseSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly SyntaxNodeProperty<TypeParameterConstraintClauseSyntax, SeparatedSyntaxList<TypeParameterConstraintSyntax>> ConstraintsProperty = new SeparatedListProperty<TypeParameterConstraintClauseSyntax, TypeParameterConstraintSyntax>("Constraints", n => n.Constraints, (n, v) => n.WithConstraints(v));

		public static SyntaxNodeProperty<TypeParameterConstraintClauseSyntax, SeparatedSyntaxList<TypeParameterConstraintSyntax>> Constraints => ConstraintsProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<TypeParameterConstraintClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<TypeParameterConstraintClauseSyntax>[] { WhereKeyword, Name, ColonToken, Constraints };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<TypeParameterConstraintClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class TypeParameterListInfo
	{
		private static readonly SyntaxNodeProperty<TypeParameterListSyntax, SyntaxToken> LessThanTokenProperty = new TokenProperty<TypeParameterListSyntax>("LessThanToken", n => n.LessThanToken, (n, v) => n.WithLessThanToken(v));

		public static SyntaxNodeProperty<TypeParameterListSyntax, SyntaxToken> LessThanToken => LessThanTokenProperty;

		private static readonly SyntaxNodeProperty<TypeParameterListSyntax, SeparatedSyntaxList<TypeParameterSyntax>> ParametersProperty = new SeparatedListProperty<TypeParameterListSyntax, TypeParameterSyntax>("Parameters", n => n.Parameters, (n, v) => n.WithParameters(v));

		public static SyntaxNodeProperty<TypeParameterListSyntax, SeparatedSyntaxList<TypeParameterSyntax>> Parameters => ParametersProperty;

		private static readonly SyntaxNodeProperty<TypeParameterListSyntax, SyntaxToken> GreaterThanTokenProperty = new TokenProperty<TypeParameterListSyntax>("GreaterThanToken", n => n.GreaterThanToken, (n, v) => n.WithGreaterThanToken(v));

		public static SyntaxNodeProperty<TypeParameterListSyntax, SyntaxToken> GreaterThanToken => GreaterThanTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<TypeParameterListSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<TypeParameterListSyntax>[] { LessThanToken, Parameters, GreaterThanToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<TypeParameterListSyntax>> Properties => PropertiesArray;
	}

	internal static class TypeParameterInfo
	{
		private static readonly SyntaxNodeProperty<TypeParameterSyntax, SyntaxList<AttributeListSyntax>> AttributeListsProperty = new ListProperty<TypeParameterSyntax, AttributeListSyntax>("AttributeLists", n => n.AttributeLists, (n, v) => n.WithAttributeLists(v));

		public static SyntaxNodeProperty<TypeParameterSyntax, SyntaxList<AttributeListSyntax>> AttributeLists => AttributeListsProperty;

		private static readonly SyntaxNodeProperty<TypeParameterSyntax, SyntaxToken> VarianceKeywordProperty = new TokenProperty<TypeParameterSyntax>("VarianceKeyword", n => n.VarianceKeyword, (n, v) => n.WithVarianceKeyword(v));

		public static SyntaxNodeProperty<TypeParameterSyntax, SyntaxToken> VarianceKeyword => VarianceKeywordProperty;

		private static readonly SyntaxNodeProperty<TypeParameterSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<TypeParameterSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<TypeParameterSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<TypeParameterSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<TypeParameterSyntax>[] { AttributeLists, VarianceKeyword, Identifier };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<TypeParameterSyntax>> Properties => PropertiesArray;
	}

	internal static class UndefDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<UndefDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<UndefDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<UndefDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<UndefDirectiveTriviaSyntax, SyntaxToken> UndefKeywordProperty = new TokenProperty<UndefDirectiveTriviaSyntax>("UndefKeyword", n => n.UndefKeyword, (n, v) => n.WithUndefKeyword(v));

		public static SyntaxNodeProperty<UndefDirectiveTriviaSyntax, SyntaxToken> UndefKeyword => UndefKeywordProperty;

		private static readonly SyntaxNodeProperty<UndefDirectiveTriviaSyntax, SyntaxToken> NameProperty = new TokenProperty<UndefDirectiveTriviaSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<UndefDirectiveTriviaSyntax, SyntaxToken> Name => NameProperty;

		private static readonly SyntaxNodeProperty<UndefDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<UndefDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<UndefDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<UndefDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<UndefDirectiveTriviaSyntax>[] { HashToken, UndefKeyword, Name, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<UndefDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class UnsafeStatementInfo
	{
		private static readonly SyntaxNodeProperty<UnsafeStatementSyntax, SyntaxToken> UnsafeKeywordProperty = new TokenProperty<UnsafeStatementSyntax>("UnsafeKeyword", n => n.UnsafeKeyword, (n, v) => n.WithUnsafeKeyword(v));

		public static SyntaxNodeProperty<UnsafeStatementSyntax, SyntaxToken> UnsafeKeyword => UnsafeKeywordProperty;

		private static readonly SyntaxNodeProperty<UnsafeStatementSyntax, BlockSyntax> BlockProperty = new NodeProperty<UnsafeStatementSyntax, BlockSyntax>("Block", n => n.Block, (n, v) => n.WithBlock(v));

		public static SyntaxNodeProperty<UnsafeStatementSyntax, BlockSyntax> Block => BlockProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<UnsafeStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<UnsafeStatementSyntax>[] { UnsafeKeyword, Block };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<UnsafeStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class UsingDirectiveInfo
	{
		private static readonly SyntaxNodeProperty<UsingDirectiveSyntax, SyntaxToken> UsingKeywordProperty = new TokenProperty<UsingDirectiveSyntax>("UsingKeyword", n => n.UsingKeyword, (n, v) => n.WithUsingKeyword(v));

		public static SyntaxNodeProperty<UsingDirectiveSyntax, SyntaxToken> UsingKeyword => UsingKeywordProperty;

		private static readonly SyntaxNodeProperty<UsingDirectiveSyntax, SyntaxToken> StaticKeywordProperty = new TokenProperty<UsingDirectiveSyntax>("StaticKeyword", n => n.StaticKeyword, (n, v) => n.WithStaticKeyword(v));

		public static SyntaxNodeProperty<UsingDirectiveSyntax, SyntaxToken> StaticKeyword => StaticKeywordProperty;

		private static readonly SyntaxNodeProperty<UsingDirectiveSyntax, NameEqualsSyntax> AliasProperty = new NodeProperty<UsingDirectiveSyntax, NameEqualsSyntax>("Alias", n => n.Alias, (n, v) => n.WithAlias(v));

		public static SyntaxNodeProperty<UsingDirectiveSyntax, NameEqualsSyntax> Alias => AliasProperty;

		private static readonly SyntaxNodeProperty<UsingDirectiveSyntax, NameSyntax> NameProperty = new NodeProperty<UsingDirectiveSyntax, NameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<UsingDirectiveSyntax, NameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<UsingDirectiveSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<UsingDirectiveSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<UsingDirectiveSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<UsingDirectiveSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<UsingDirectiveSyntax>[] { UsingKeyword, StaticKeyword, Alias, Name, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<UsingDirectiveSyntax>> Properties => PropertiesArray;
	}

	internal static class UsingStatementInfo
	{
		private static readonly SyntaxNodeProperty<UsingStatementSyntax, SyntaxToken> UsingKeywordProperty = new TokenProperty<UsingStatementSyntax>("UsingKeyword", n => n.UsingKeyword, (n, v) => n.WithUsingKeyword(v));

		public static SyntaxNodeProperty<UsingStatementSyntax, SyntaxToken> UsingKeyword => UsingKeywordProperty;

		private static readonly SyntaxNodeProperty<UsingStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<UsingStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<UsingStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<UsingStatementSyntax, VariableDeclarationSyntax> DeclarationProperty = new NodeProperty<UsingStatementSyntax, VariableDeclarationSyntax>("Declaration", n => n.Declaration, (n, v) => n.WithDeclaration(v));

		public static SyntaxNodeProperty<UsingStatementSyntax, VariableDeclarationSyntax> Declaration => DeclarationProperty;

		private static readonly SyntaxNodeProperty<UsingStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<UsingStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<UsingStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<UsingStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<UsingStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<UsingStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<UsingStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<UsingStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<UsingStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<UsingStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<UsingStatementSyntax>[] { UsingKeyword, OpenParenToken, Declaration, Expression, CloseParenToken, Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<UsingStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class VariableDeclarationInfo
	{
		private static readonly SyntaxNodeProperty<VariableDeclarationSyntax, TypeSyntax> TypeProperty = new NodeProperty<VariableDeclarationSyntax, TypeSyntax>("Type", n => n.Type, (n, v) => n.WithType(v));

		public static SyntaxNodeProperty<VariableDeclarationSyntax, TypeSyntax> Type => TypeProperty;

		private static readonly SyntaxNodeProperty<VariableDeclarationSyntax, SeparatedSyntaxList<VariableDeclaratorSyntax>> VariablesProperty = new SeparatedListProperty<VariableDeclarationSyntax, VariableDeclaratorSyntax>("Variables", n => n.Variables, (n, v) => n.WithVariables(v));

		public static SyntaxNodeProperty<VariableDeclarationSyntax, SeparatedSyntaxList<VariableDeclaratorSyntax>> Variables => VariablesProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<VariableDeclarationSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<VariableDeclarationSyntax>[] { Type, Variables };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<VariableDeclarationSyntax>> Properties => PropertiesArray;
	}

	internal static class VariableDeclaratorInfo
	{
		private static readonly SyntaxNodeProperty<VariableDeclaratorSyntax, SyntaxToken> IdentifierProperty = new TokenProperty<VariableDeclaratorSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<VariableDeclaratorSyntax, SyntaxToken> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<VariableDeclaratorSyntax, BracketedArgumentListSyntax> ArgumentListProperty = new NodeProperty<VariableDeclaratorSyntax, BracketedArgumentListSyntax>("ArgumentList", n => n.ArgumentList, (n, v) => n.WithArgumentList(v));

		public static SyntaxNodeProperty<VariableDeclaratorSyntax, BracketedArgumentListSyntax> ArgumentList => ArgumentListProperty;

		private static readonly SyntaxNodeProperty<VariableDeclaratorSyntax, EqualsValueClauseSyntax> InitializerProperty = new NodeProperty<VariableDeclaratorSyntax, EqualsValueClauseSyntax>("Initializer", n => n.Initializer, (n, v) => n.WithInitializer(v));

		public static SyntaxNodeProperty<VariableDeclaratorSyntax, EqualsValueClauseSyntax> Initializer => InitializerProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<VariableDeclaratorSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<VariableDeclaratorSyntax>[] { Identifier, ArgumentList, Initializer };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<VariableDeclaratorSyntax>> Properties => PropertiesArray;
	}

	internal static class WarningDirectiveTriviaInfo
	{
		private static readonly SyntaxNodeProperty<WarningDirectiveTriviaSyntax, SyntaxToken> HashTokenProperty = new TokenProperty<WarningDirectiveTriviaSyntax>("HashToken", n => n.HashToken, (n, v) => n.WithHashToken(v));

		public static SyntaxNodeProperty<WarningDirectiveTriviaSyntax, SyntaxToken> HashToken => HashTokenProperty;

		private static readonly SyntaxNodeProperty<WarningDirectiveTriviaSyntax, SyntaxToken> WarningKeywordProperty = new TokenProperty<WarningDirectiveTriviaSyntax>("WarningKeyword", n => n.WarningKeyword, (n, v) => n.WithWarningKeyword(v));

		public static SyntaxNodeProperty<WarningDirectiveTriviaSyntax, SyntaxToken> WarningKeyword => WarningKeywordProperty;

		private static readonly SyntaxNodeProperty<WarningDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveTokenProperty = new TokenProperty<WarningDirectiveTriviaSyntax>("EndOfDirectiveToken", n => n.EndOfDirectiveToken, (n, v) => n.WithEndOfDirectiveToken(v));

		public static SyntaxNodeProperty<WarningDirectiveTriviaSyntax, SyntaxToken> EndOfDirectiveToken => EndOfDirectiveTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<WarningDirectiveTriviaSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<WarningDirectiveTriviaSyntax>[] { HashToken, WarningKeyword, EndOfDirectiveToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<WarningDirectiveTriviaSyntax>> Properties => PropertiesArray;
	}

	internal static class WhereClauseInfo
	{
		private static readonly SyntaxNodeProperty<WhereClauseSyntax, SyntaxToken> WhereKeywordProperty = new TokenProperty<WhereClauseSyntax>("WhereKeyword", n => n.WhereKeyword, (n, v) => n.WithWhereKeyword(v));

		public static SyntaxNodeProperty<WhereClauseSyntax, SyntaxToken> WhereKeyword => WhereKeywordProperty;

		private static readonly SyntaxNodeProperty<WhereClauseSyntax, ExpressionSyntax> ConditionProperty = new NodeProperty<WhereClauseSyntax, ExpressionSyntax>("Condition", n => n.Condition, (n, v) => n.WithCondition(v));

		public static SyntaxNodeProperty<WhereClauseSyntax, ExpressionSyntax> Condition => ConditionProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<WhereClauseSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<WhereClauseSyntax>[] { WhereKeyword, Condition };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<WhereClauseSyntax>> Properties => PropertiesArray;
	}

	internal static class WhileStatementInfo
	{
		private static readonly SyntaxNodeProperty<WhileStatementSyntax, SyntaxToken> WhileKeywordProperty = new TokenProperty<WhileStatementSyntax>("WhileKeyword", n => n.WhileKeyword, (n, v) => n.WithWhileKeyword(v));

		public static SyntaxNodeProperty<WhileStatementSyntax, SyntaxToken> WhileKeyword => WhileKeywordProperty;

		private static readonly SyntaxNodeProperty<WhileStatementSyntax, SyntaxToken> OpenParenTokenProperty = new TokenProperty<WhileStatementSyntax>("OpenParenToken", n => n.OpenParenToken, (n, v) => n.WithOpenParenToken(v));

		public static SyntaxNodeProperty<WhileStatementSyntax, SyntaxToken> OpenParenToken => OpenParenTokenProperty;

		private static readonly SyntaxNodeProperty<WhileStatementSyntax, ExpressionSyntax> ConditionProperty = new NodeProperty<WhileStatementSyntax, ExpressionSyntax>("Condition", n => n.Condition, (n, v) => n.WithCondition(v));

		public static SyntaxNodeProperty<WhileStatementSyntax, ExpressionSyntax> Condition => ConditionProperty;

		private static readonly SyntaxNodeProperty<WhileStatementSyntax, SyntaxToken> CloseParenTokenProperty = new TokenProperty<WhileStatementSyntax>("CloseParenToken", n => n.CloseParenToken, (n, v) => n.WithCloseParenToken(v));

		public static SyntaxNodeProperty<WhileStatementSyntax, SyntaxToken> CloseParenToken => CloseParenTokenProperty;

		private static readonly SyntaxNodeProperty<WhileStatementSyntax, StatementSyntax> StatementProperty = new NodeProperty<WhileStatementSyntax, StatementSyntax>("Statement", n => n.Statement, (n, v) => n.WithStatement(v));

		public static SyntaxNodeProperty<WhileStatementSyntax, StatementSyntax> Statement => StatementProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<WhileStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<WhileStatementSyntax>[] { WhileKeyword, OpenParenToken, Condition, CloseParenToken, Statement };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<WhileStatementSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlCDataSectionInfo
	{
		private static readonly SyntaxNodeProperty<XmlCDataSectionSyntax, SyntaxToken> StartCDataTokenProperty = new TokenProperty<XmlCDataSectionSyntax>("StartCDataToken", n => n.StartCDataToken, (n, v) => n.WithStartCDataToken(v));

		public static SyntaxNodeProperty<XmlCDataSectionSyntax, SyntaxToken> StartCDataToken => StartCDataTokenProperty;

		private static readonly SyntaxNodeProperty<XmlCDataSectionSyntax, SyntaxTokenList> TextTokensProperty = new TokenListProperty<XmlCDataSectionSyntax>("TextTokens", n => n.TextTokens, (n, v) => n.WithTextTokens(v));

		public static SyntaxNodeProperty<XmlCDataSectionSyntax, SyntaxTokenList> TextTokens => TextTokensProperty;

		private static readonly SyntaxNodeProperty<XmlCDataSectionSyntax, SyntaxToken> EndCDataTokenProperty = new TokenProperty<XmlCDataSectionSyntax>("EndCDataToken", n => n.EndCDataToken, (n, v) => n.WithEndCDataToken(v));

		public static SyntaxNodeProperty<XmlCDataSectionSyntax, SyntaxToken> EndCDataToken => EndCDataTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlCDataSectionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlCDataSectionSyntax>[] { StartCDataToken, TextTokens, EndCDataToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlCDataSectionSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlCommentInfo
	{
		private static readonly SyntaxNodeProperty<XmlCommentSyntax, SyntaxToken> LessThanExclamationMinusMinusTokenProperty = new TokenProperty<XmlCommentSyntax>("LessThanExclamationMinusMinusToken", n => n.LessThanExclamationMinusMinusToken, (n, v) => n.WithLessThanExclamationMinusMinusToken(v));

		public static SyntaxNodeProperty<XmlCommentSyntax, SyntaxToken> LessThanExclamationMinusMinusToken => LessThanExclamationMinusMinusTokenProperty;

		private static readonly SyntaxNodeProperty<XmlCommentSyntax, SyntaxTokenList> TextTokensProperty = new TokenListProperty<XmlCommentSyntax>("TextTokens", n => n.TextTokens, (n, v) => n.WithTextTokens(v));

		public static SyntaxNodeProperty<XmlCommentSyntax, SyntaxTokenList> TextTokens => TextTokensProperty;

		private static readonly SyntaxNodeProperty<XmlCommentSyntax, SyntaxToken> MinusMinusGreaterThanTokenProperty = new TokenProperty<XmlCommentSyntax>("MinusMinusGreaterThanToken", n => n.MinusMinusGreaterThanToken, (n, v) => n.WithMinusMinusGreaterThanToken(v));

		public static SyntaxNodeProperty<XmlCommentSyntax, SyntaxToken> MinusMinusGreaterThanToken => MinusMinusGreaterThanTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlCommentSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlCommentSyntax>[] { LessThanExclamationMinusMinusToken, TextTokens, MinusMinusGreaterThanToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlCommentSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlCrefAttributeInfo
	{
		private static readonly SyntaxNodeProperty<XmlCrefAttributeSyntax, XmlNameSyntax> NameProperty = new NodeProperty<XmlCrefAttributeSyntax, XmlNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<XmlCrefAttributeSyntax, XmlNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<XmlCrefAttributeSyntax, SyntaxToken> EqualsTokenProperty = new TokenProperty<XmlCrefAttributeSyntax>("EqualsToken", n => n.EqualsToken, (n, v) => n.WithEqualsToken(v));

		public static SyntaxNodeProperty<XmlCrefAttributeSyntax, SyntaxToken> EqualsToken => EqualsTokenProperty;

		private static readonly SyntaxNodeProperty<XmlCrefAttributeSyntax, SyntaxToken> StartQuoteTokenProperty = new TokenProperty<XmlCrefAttributeSyntax>("StartQuoteToken", n => n.StartQuoteToken, (n, v) => n.WithStartQuoteToken(v));

		public static SyntaxNodeProperty<XmlCrefAttributeSyntax, SyntaxToken> StartQuoteToken => StartQuoteTokenProperty;

		private static readonly SyntaxNodeProperty<XmlCrefAttributeSyntax, CrefSyntax> CrefProperty = new NodeProperty<XmlCrefAttributeSyntax, CrefSyntax>("Cref", n => n.Cref, (n, v) => n.WithCref(v));

		public static SyntaxNodeProperty<XmlCrefAttributeSyntax, CrefSyntax> Cref => CrefProperty;

		private static readonly SyntaxNodeProperty<XmlCrefAttributeSyntax, SyntaxToken> EndQuoteTokenProperty = new TokenProperty<XmlCrefAttributeSyntax>("EndQuoteToken", n => n.EndQuoteToken, (n, v) => n.WithEndQuoteToken(v));

		public static SyntaxNodeProperty<XmlCrefAttributeSyntax, SyntaxToken> EndQuoteToken => EndQuoteTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlCrefAttributeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlCrefAttributeSyntax>[] { Name, EqualsToken, StartQuoteToken, Cref, EndQuoteToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlCrefAttributeSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlElementEndTagInfo
	{
		private static readonly SyntaxNodeProperty<XmlElementEndTagSyntax, SyntaxToken> LessThanSlashTokenProperty = new TokenProperty<XmlElementEndTagSyntax>("LessThanSlashToken", n => n.LessThanSlashToken, (n, v) => n.WithLessThanSlashToken(v));

		public static SyntaxNodeProperty<XmlElementEndTagSyntax, SyntaxToken> LessThanSlashToken => LessThanSlashTokenProperty;

		private static readonly SyntaxNodeProperty<XmlElementEndTagSyntax, XmlNameSyntax> NameProperty = new NodeProperty<XmlElementEndTagSyntax, XmlNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<XmlElementEndTagSyntax, XmlNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<XmlElementEndTagSyntax, SyntaxToken> GreaterThanTokenProperty = new TokenProperty<XmlElementEndTagSyntax>("GreaterThanToken", n => n.GreaterThanToken, (n, v) => n.WithGreaterThanToken(v));

		public static SyntaxNodeProperty<XmlElementEndTagSyntax, SyntaxToken> GreaterThanToken => GreaterThanTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlElementEndTagSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlElementEndTagSyntax>[] { LessThanSlashToken, Name, GreaterThanToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlElementEndTagSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlElementStartTagInfo
	{
		private static readonly SyntaxNodeProperty<XmlElementStartTagSyntax, SyntaxToken> LessThanTokenProperty = new TokenProperty<XmlElementStartTagSyntax>("LessThanToken", n => n.LessThanToken, (n, v) => n.WithLessThanToken(v));

		public static SyntaxNodeProperty<XmlElementStartTagSyntax, SyntaxToken> LessThanToken => LessThanTokenProperty;

		private static readonly SyntaxNodeProperty<XmlElementStartTagSyntax, XmlNameSyntax> NameProperty = new NodeProperty<XmlElementStartTagSyntax, XmlNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<XmlElementStartTagSyntax, XmlNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<XmlElementStartTagSyntax, SyntaxList<XmlAttributeSyntax>> AttributesProperty = new ListProperty<XmlElementStartTagSyntax, XmlAttributeSyntax>("Attributes", n => n.Attributes, (n, v) => n.WithAttributes(v));

		public static SyntaxNodeProperty<XmlElementStartTagSyntax, SyntaxList<XmlAttributeSyntax>> Attributes => AttributesProperty;

		private static readonly SyntaxNodeProperty<XmlElementStartTagSyntax, SyntaxToken> GreaterThanTokenProperty = new TokenProperty<XmlElementStartTagSyntax>("GreaterThanToken", n => n.GreaterThanToken, (n, v) => n.WithGreaterThanToken(v));

		public static SyntaxNodeProperty<XmlElementStartTagSyntax, SyntaxToken> GreaterThanToken => GreaterThanTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlElementStartTagSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlElementStartTagSyntax>[] { LessThanToken, Name, Attributes, GreaterThanToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlElementStartTagSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlElementInfo
	{
		private static readonly SyntaxNodeProperty<XmlElementSyntax, XmlElementStartTagSyntax> StartTagProperty = new NodeProperty<XmlElementSyntax, XmlElementStartTagSyntax>("StartTag", n => n.StartTag, (n, v) => n.WithStartTag(v));

		public static SyntaxNodeProperty<XmlElementSyntax, XmlElementStartTagSyntax> StartTag => StartTagProperty;

		private static readonly SyntaxNodeProperty<XmlElementSyntax, SyntaxList<XmlNodeSyntax>> ContentProperty = new ListProperty<XmlElementSyntax, XmlNodeSyntax>("Content", n => n.Content, (n, v) => n.WithContent(v));

		public static SyntaxNodeProperty<XmlElementSyntax, SyntaxList<XmlNodeSyntax>> Content => ContentProperty;

		private static readonly SyntaxNodeProperty<XmlElementSyntax, XmlElementEndTagSyntax> EndTagProperty = new NodeProperty<XmlElementSyntax, XmlElementEndTagSyntax>("EndTag", n => n.EndTag, (n, v) => n.WithEndTag(v));

		public static SyntaxNodeProperty<XmlElementSyntax, XmlElementEndTagSyntax> EndTag => EndTagProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlElementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlElementSyntax>[] { StartTag, Content, EndTag };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlElementSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlEmptyElementInfo
	{
		private static readonly SyntaxNodeProperty<XmlEmptyElementSyntax, SyntaxToken> LessThanTokenProperty = new TokenProperty<XmlEmptyElementSyntax>("LessThanToken", n => n.LessThanToken, (n, v) => n.WithLessThanToken(v));

		public static SyntaxNodeProperty<XmlEmptyElementSyntax, SyntaxToken> LessThanToken => LessThanTokenProperty;

		private static readonly SyntaxNodeProperty<XmlEmptyElementSyntax, XmlNameSyntax> NameProperty = new NodeProperty<XmlEmptyElementSyntax, XmlNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<XmlEmptyElementSyntax, XmlNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<XmlEmptyElementSyntax, SyntaxList<XmlAttributeSyntax>> AttributesProperty = new ListProperty<XmlEmptyElementSyntax, XmlAttributeSyntax>("Attributes", n => n.Attributes, (n, v) => n.WithAttributes(v));

		public static SyntaxNodeProperty<XmlEmptyElementSyntax, SyntaxList<XmlAttributeSyntax>> Attributes => AttributesProperty;

		private static readonly SyntaxNodeProperty<XmlEmptyElementSyntax, SyntaxToken> SlashGreaterThanTokenProperty = new TokenProperty<XmlEmptyElementSyntax>("SlashGreaterThanToken", n => n.SlashGreaterThanToken, (n, v) => n.WithSlashGreaterThanToken(v));

		public static SyntaxNodeProperty<XmlEmptyElementSyntax, SyntaxToken> SlashGreaterThanToken => SlashGreaterThanTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlEmptyElementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlEmptyElementSyntax>[] { LessThanToken, Name, Attributes, SlashGreaterThanToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlEmptyElementSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlNameAttributeInfo
	{
		private static readonly SyntaxNodeProperty<XmlNameAttributeSyntax, XmlNameSyntax> NameProperty = new NodeProperty<XmlNameAttributeSyntax, XmlNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<XmlNameAttributeSyntax, XmlNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<XmlNameAttributeSyntax, SyntaxToken> EqualsTokenProperty = new TokenProperty<XmlNameAttributeSyntax>("EqualsToken", n => n.EqualsToken, (n, v) => n.WithEqualsToken(v));

		public static SyntaxNodeProperty<XmlNameAttributeSyntax, SyntaxToken> EqualsToken => EqualsTokenProperty;

		private static readonly SyntaxNodeProperty<XmlNameAttributeSyntax, SyntaxToken> StartQuoteTokenProperty = new TokenProperty<XmlNameAttributeSyntax>("StartQuoteToken", n => n.StartQuoteToken, (n, v) => n.WithStartQuoteToken(v));

		public static SyntaxNodeProperty<XmlNameAttributeSyntax, SyntaxToken> StartQuoteToken => StartQuoteTokenProperty;

		private static readonly SyntaxNodeProperty<XmlNameAttributeSyntax, IdentifierNameSyntax> IdentifierProperty = new NodeProperty<XmlNameAttributeSyntax, IdentifierNameSyntax>("Identifier", n => n.Identifier, (n, v) => n.WithIdentifier(v));

		public static SyntaxNodeProperty<XmlNameAttributeSyntax, IdentifierNameSyntax> Identifier => IdentifierProperty;

		private static readonly SyntaxNodeProperty<XmlNameAttributeSyntax, SyntaxToken> EndQuoteTokenProperty = new TokenProperty<XmlNameAttributeSyntax>("EndQuoteToken", n => n.EndQuoteToken, (n, v) => n.WithEndQuoteToken(v));

		public static SyntaxNodeProperty<XmlNameAttributeSyntax, SyntaxToken> EndQuoteToken => EndQuoteTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlNameAttributeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlNameAttributeSyntax>[] { Name, EqualsToken, StartQuoteToken, Identifier, EndQuoteToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlNameAttributeSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlNameInfo
	{
		private static readonly SyntaxNodeProperty<XmlNameSyntax, XmlPrefixSyntax> PrefixProperty = new NodeProperty<XmlNameSyntax, XmlPrefixSyntax>("Prefix", n => n.Prefix, (n, v) => n.WithPrefix(v));

		public static SyntaxNodeProperty<XmlNameSyntax, XmlPrefixSyntax> Prefix => PrefixProperty;

		private static readonly SyntaxNodeProperty<XmlNameSyntax, SyntaxToken> LocalNameProperty = new TokenProperty<XmlNameSyntax>("LocalName", n => n.LocalName, (n, v) => n.WithLocalName(v));

		public static SyntaxNodeProperty<XmlNameSyntax, SyntaxToken> LocalName => LocalNameProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlNameSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlNameSyntax>[] { Prefix, LocalName };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlNameSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlPrefixInfo
	{
		private static readonly SyntaxNodeProperty<XmlPrefixSyntax, SyntaxToken> PrefixProperty = new TokenProperty<XmlPrefixSyntax>("Prefix", n => n.Prefix, (n, v) => n.WithPrefix(v));

		public static SyntaxNodeProperty<XmlPrefixSyntax, SyntaxToken> Prefix => PrefixProperty;

		private static readonly SyntaxNodeProperty<XmlPrefixSyntax, SyntaxToken> ColonTokenProperty = new TokenProperty<XmlPrefixSyntax>("ColonToken", n => n.ColonToken, (n, v) => n.WithColonToken(v));

		public static SyntaxNodeProperty<XmlPrefixSyntax, SyntaxToken> ColonToken => ColonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlPrefixSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlPrefixSyntax>[] { Prefix, ColonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlPrefixSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlProcessingInstructionInfo
	{
		private static readonly SyntaxNodeProperty<XmlProcessingInstructionSyntax, SyntaxToken> StartProcessingInstructionTokenProperty = new TokenProperty<XmlProcessingInstructionSyntax>("StartProcessingInstructionToken", n => n.StartProcessingInstructionToken, (n, v) => n.WithStartProcessingInstructionToken(v));

		public static SyntaxNodeProperty<XmlProcessingInstructionSyntax, SyntaxToken> StartProcessingInstructionToken => StartProcessingInstructionTokenProperty;

		private static readonly SyntaxNodeProperty<XmlProcessingInstructionSyntax, XmlNameSyntax> NameProperty = new NodeProperty<XmlProcessingInstructionSyntax, XmlNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<XmlProcessingInstructionSyntax, XmlNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<XmlProcessingInstructionSyntax, SyntaxTokenList> TextTokensProperty = new TokenListProperty<XmlProcessingInstructionSyntax>("TextTokens", n => n.TextTokens, (n, v) => n.WithTextTokens(v));

		public static SyntaxNodeProperty<XmlProcessingInstructionSyntax, SyntaxTokenList> TextTokens => TextTokensProperty;

		private static readonly SyntaxNodeProperty<XmlProcessingInstructionSyntax, SyntaxToken> EndProcessingInstructionTokenProperty = new TokenProperty<XmlProcessingInstructionSyntax>("EndProcessingInstructionToken", n => n.EndProcessingInstructionToken, (n, v) => n.WithEndProcessingInstructionToken(v));

		public static SyntaxNodeProperty<XmlProcessingInstructionSyntax, SyntaxToken> EndProcessingInstructionToken => EndProcessingInstructionTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlProcessingInstructionSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlProcessingInstructionSyntax>[] { StartProcessingInstructionToken, Name, TextTokens, EndProcessingInstructionToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlProcessingInstructionSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlTextAttributeInfo
	{
		private static readonly SyntaxNodeProperty<XmlTextAttributeSyntax, XmlNameSyntax> NameProperty = new NodeProperty<XmlTextAttributeSyntax, XmlNameSyntax>("Name", n => n.Name, (n, v) => n.WithName(v));

		public static SyntaxNodeProperty<XmlTextAttributeSyntax, XmlNameSyntax> Name => NameProperty;

		private static readonly SyntaxNodeProperty<XmlTextAttributeSyntax, SyntaxToken> EqualsTokenProperty = new TokenProperty<XmlTextAttributeSyntax>("EqualsToken", n => n.EqualsToken, (n, v) => n.WithEqualsToken(v));

		public static SyntaxNodeProperty<XmlTextAttributeSyntax, SyntaxToken> EqualsToken => EqualsTokenProperty;

		private static readonly SyntaxNodeProperty<XmlTextAttributeSyntax, SyntaxToken> StartQuoteTokenProperty = new TokenProperty<XmlTextAttributeSyntax>("StartQuoteToken", n => n.StartQuoteToken, (n, v) => n.WithStartQuoteToken(v));

		public static SyntaxNodeProperty<XmlTextAttributeSyntax, SyntaxToken> StartQuoteToken => StartQuoteTokenProperty;

		private static readonly SyntaxNodeProperty<XmlTextAttributeSyntax, SyntaxTokenList> TextTokensProperty = new TokenListProperty<XmlTextAttributeSyntax>("TextTokens", n => n.TextTokens, (n, v) => n.WithTextTokens(v));

		public static SyntaxNodeProperty<XmlTextAttributeSyntax, SyntaxTokenList> TextTokens => TextTokensProperty;

		private static readonly SyntaxNodeProperty<XmlTextAttributeSyntax, SyntaxToken> EndQuoteTokenProperty = new TokenProperty<XmlTextAttributeSyntax>("EndQuoteToken", n => n.EndQuoteToken, (n, v) => n.WithEndQuoteToken(v));

		public static SyntaxNodeProperty<XmlTextAttributeSyntax, SyntaxToken> EndQuoteToken => EndQuoteTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlTextAttributeSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlTextAttributeSyntax>[] { Name, EqualsToken, StartQuoteToken, TextTokens, EndQuoteToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlTextAttributeSyntax>> Properties => PropertiesArray;
	}

	internal static class XmlTextInfo
	{
		private static readonly SyntaxNodeProperty<XmlTextSyntax, SyntaxTokenList> TextTokensProperty = new TokenListProperty<XmlTextSyntax>("TextTokens", n => n.TextTokens, (n, v) => n.WithTextTokens(v));

		public static SyntaxNodeProperty<XmlTextSyntax, SyntaxTokenList> TextTokens => TextTokensProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<XmlTextSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<XmlTextSyntax>[] { TextTokens };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<XmlTextSyntax>> Properties => PropertiesArray;
	}

	internal static class YieldStatementInfo
	{
		private static readonly SyntaxNodeProperty<YieldStatementSyntax, SyntaxToken> YieldKeywordProperty = new TokenProperty<YieldStatementSyntax>("YieldKeyword", n => n.YieldKeyword, (n, v) => n.WithYieldKeyword(v));

		public static SyntaxNodeProperty<YieldStatementSyntax, SyntaxToken> YieldKeyword => YieldKeywordProperty;

		private static readonly SyntaxNodeProperty<YieldStatementSyntax, SyntaxToken> ReturnOrBreakKeywordProperty = new TokenProperty<YieldStatementSyntax>("ReturnOrBreakKeyword", n => n.ReturnOrBreakKeyword, (n, v) => n.WithReturnOrBreakKeyword(v));

		public static SyntaxNodeProperty<YieldStatementSyntax, SyntaxToken> ReturnOrBreakKeyword => ReturnOrBreakKeywordProperty;

		private static readonly SyntaxNodeProperty<YieldStatementSyntax, ExpressionSyntax> ExpressionProperty = new NodeProperty<YieldStatementSyntax, ExpressionSyntax>("Expression", n => n.Expression, (n, v) => n.WithExpression(v));

		public static SyntaxNodeProperty<YieldStatementSyntax, ExpressionSyntax> Expression => ExpressionProperty;

		private static readonly SyntaxNodeProperty<YieldStatementSyntax, SyntaxToken> SemicolonTokenProperty = new TokenProperty<YieldStatementSyntax>("SemicolonToken", n => n.SemicolonToken, (n, v) => n.WithSemicolonToken(v));

		public static SyntaxNodeProperty<YieldStatementSyntax, SyntaxToken> SemicolonToken => SemicolonTokenProperty;

		private static readonly ISyntaxNodePropertyWithTypedNode<YieldStatementSyntax>[] PropertiesArray = new ISyntaxNodePropertyWithTypedNode<YieldStatementSyntax>[] { YieldKeyword, ReturnOrBreakKeyword, Expression, SemicolonToken };

		public static IReadOnlyList<ISyntaxNodePropertyWithTypedNode<YieldStatementSyntax>> Properties => PropertiesArray;
	}
}
