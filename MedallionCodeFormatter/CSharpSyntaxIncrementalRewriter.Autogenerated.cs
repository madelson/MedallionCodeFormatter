using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace MedallionCodeFormatter
{
	internal partial class CSharpSyntaxIncrementalRewriter : CSharpSyntaxVisitor<SyntaxNode>
	{
		public override SyntaxNode VisitAccessorDeclaration(AccessorDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithBody(this.TypedVisit(node.Body));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitAccessorList(AccessorListSyntax node)
		{
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSyntaxList(node, n => n.Accessors, (n, list) => n.WithAccessors(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			return node;
		}

		public override SyntaxNode VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
		{
			node = node.WithAlias(this.TypedVisit(node.Alias));
			node = node.WithColonColonToken(this.VisitToken(node.ColonColonToken));
			node = node.WithName(this.TypedVisit(node.Name));
			return node;
		}

		public override SyntaxNode VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
		{
			node = node.WithAsyncKeyword(this.VisitToken(node.AsyncKeyword));
			node = node.WithDelegateKeyword(this.VisitToken(node.DelegateKeyword));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = node.WithBody(this.TypedVisit(node.Body));
			return node;
		}

		public override SyntaxNode VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
		{
			node = node.WithNewKeyword(this.VisitToken(node.NewKeyword));
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Initializers, (n, list) => n.WithInitializers(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			return node;
		}

		public override SyntaxNode VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
		{
			node = node.WithNameEquals(this.TypedVisit(node.NameEquals));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitArgumentList(ArgumentListSyntax node)
		{
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Arguments, (n, list) => n.WithArguments(list));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitArgument(ArgumentSyntax node)
		{
			node = node.WithNameColon(this.TypedVisit(node.NameColon));
			node = node.WithRefOrOutKeyword(this.VisitToken(node.RefOrOutKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
		{
			node = node.WithNewKeyword(this.VisitToken(node.NewKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithInitializer(this.TypedVisit(node.Initializer));
			return node;
		}

		public override SyntaxNode VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
		{
			node = node.WithOpenBracketToken(this.VisitToken(node.OpenBracketToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Sizes, (n, list) => n.WithSizes(list));
			node = node.WithCloseBracketToken(this.VisitToken(node.CloseBracketToken));
			return node;
		}

		public override SyntaxNode VisitArrayType(ArrayTypeSyntax node)
		{
			node = node.WithElementType(this.TypedVisit(node.ElementType));
			node = this.IncrementalVisitSyntaxList(node, n => n.RankSpecifiers, (n, list) => n.WithRankSpecifiers(list));
			return node;
		}

		public override SyntaxNode VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
		{
			node = node.WithArrowToken(this.VisitToken(node.ArrowToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitAssignmentExpression(AssignmentExpressionSyntax node)
		{
			node = node.WithLeft(this.TypedVisit(node.Left));
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			node = node.WithRight(this.TypedVisit(node.Right));
			return node;
		}

		public override SyntaxNode VisitAttributeArgumentList(AttributeArgumentListSyntax node)
		{
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Arguments, (n, list) => n.WithArguments(list));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitAttributeArgument(AttributeArgumentSyntax node)
		{
			node = node.WithNameEquals(this.TypedVisit(node.NameEquals));
			node = node.WithNameColon(this.TypedVisit(node.NameColon));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitAttributeList(AttributeListSyntax node)
		{
			node = node.WithOpenBracketToken(this.VisitToken(node.OpenBracketToken));
			node = node.WithTarget(this.TypedVisit(node.Target));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Attributes, (n, list) => n.WithAttributes(list));
			node = node.WithCloseBracketToken(this.VisitToken(node.CloseBracketToken));
			return node;
		}

		public override SyntaxNode VisitAttribute(AttributeSyntax node)
		{
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithArgumentList(this.TypedVisit(node.ArgumentList));
			return node;
		}

		public override SyntaxNode VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
		{
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			return node;
		}

		public override SyntaxNode VisitAwaitExpression(AwaitExpressionSyntax node)
		{
			node = node.WithAwaitKeyword(this.VisitToken(node.AwaitKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitBaseExpression(BaseExpressionSyntax node)
		{
			node = node.WithToken(this.VisitToken(node.Token));
			return node;
		}

		public override SyntaxNode VisitBaseList(BaseListSyntax node)
		{
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Types, (n, list) => n.WithTypes(list));
			return node;
		}

		public override SyntaxNode VisitBinaryExpression(BinaryExpressionSyntax node)
		{
			node = node.WithLeft(this.TypedVisit(node.Left));
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			node = node.WithRight(this.TypedVisit(node.Right));
			return node;
		}

		public override SyntaxNode VisitBlock(BlockSyntax node)
		{
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSyntaxList(node, n => n.Statements, (n, list) => n.WithStatements(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			return node;
		}

		public override SyntaxNode VisitBracketedArgumentList(BracketedArgumentListSyntax node)
		{
			node = node.WithOpenBracketToken(this.VisitToken(node.OpenBracketToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Arguments, (n, list) => n.WithArguments(list));
			node = node.WithCloseBracketToken(this.VisitToken(node.CloseBracketToken));
			return node;
		}

		public override SyntaxNode VisitBracketedParameterList(BracketedParameterListSyntax node)
		{
			node = node.WithOpenBracketToken(this.VisitToken(node.OpenBracketToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Parameters, (n, list) => n.WithParameters(list));
			node = node.WithCloseBracketToken(this.VisitToken(node.CloseBracketToken));
			return node;
		}

		public override SyntaxNode VisitBreakStatement(BreakStatementSyntax node)
		{
			node = node.WithBreakKeyword(this.VisitToken(node.BreakKeyword));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitCaseSwitchLabel(CaseSwitchLabelSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithValue(this.TypedVisit(node.Value));
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			return node;
		}

		public override SyntaxNode VisitCastExpression(CastExpressionSyntax node)
		{
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitCatchClause(CatchClauseSyntax node)
		{
			node = node.WithCatchKeyword(this.VisitToken(node.CatchKeyword));
			node = node.WithDeclaration(this.TypedVisit(node.Declaration));
			node = node.WithFilter(this.TypedVisit(node.Filter));
			node = node.WithBlock(this.TypedVisit(node.Block));
			return node;
		}

		public override SyntaxNode VisitCatchDeclaration(CatchDeclarationSyntax node)
		{
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitCatchFilterClause(CatchFilterClauseSyntax node)
		{
			node = node.WithWhenKeyword(this.VisitToken(node.WhenKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithFilterExpression(this.TypedVisit(node.FilterExpression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitCheckedExpression(CheckedExpressionSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitCheckedStatement(CheckedStatementSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithBlock(this.TypedVisit(node.Block));
			return node;
		}

		public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithTypeParameterList(this.TypedVisit(node.TypeParameterList));
			node = node.WithBaseList(this.TypedVisit(node.BaseList));
			node = this.IncrementalVisitSyntaxList(node, n => n.ConstraintClauses, (n, list) => n.WithConstraintClauses(list));
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSyntaxList(node, n => n.Members, (n, list) => n.WithMembers(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
		{
			node = node.WithClassOrStructKeyword(this.VisitToken(node.ClassOrStructKeyword));
			return node;
		}

		public override SyntaxNode VisitCompilationUnit(CompilationUnitSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.Externs, (n, list) => n.WithExterns(list));
			node = this.IncrementalVisitSyntaxList(node, n => n.Usings, (n, list) => n.WithUsings(list));
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxList(node, n => n.Members, (n, list) => n.WithMembers(list));
			node = node.WithEndOfFileToken(this.VisitToken(node.EndOfFileToken));
			return node;
		}

		public override SyntaxNode VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
		{
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			node = node.WithWhenNotNull(this.TypedVisit(node.WhenNotNull));
			return node;
		}

		public override SyntaxNode VisitConditionalExpression(ConditionalExpressionSyntax node)
		{
			node = node.WithCondition(this.TypedVisit(node.Condition));
			node = node.WithQuestionToken(this.VisitToken(node.QuestionToken));
			node = node.WithWhenTrue(this.TypedVisit(node.WhenTrue));
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			node = node.WithWhenFalse(this.TypedVisit(node.WhenFalse));
			return node;
		}

		public override SyntaxNode VisitConstructorConstraint(ConstructorConstraintSyntax node)
		{
			node = node.WithNewKeyword(this.VisitToken(node.NewKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = node.WithInitializer(this.TypedVisit(node.Initializer));
			node = node.WithBody(this.TypedVisit(node.Body));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitConstructorInitializer(ConstructorInitializerSyntax node)
		{
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			node = node.WithThisOrBaseKeyword(this.VisitToken(node.ThisOrBaseKeyword));
			node = node.WithArgumentList(this.TypedVisit(node.ArgumentList));
			return node;
		}

		public override SyntaxNode VisitContinueStatement(ContinueStatementSyntax node)
		{
			node = node.WithContinueKeyword(this.VisitToken(node.ContinueKeyword));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithImplicitOrExplicitKeyword(this.VisitToken(node.ImplicitOrExplicitKeyword));
			node = node.WithOperatorKeyword(this.VisitToken(node.OperatorKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = node.WithBody(this.TypedVisit(node.Body));
			node = node.WithExpressionBody(this.TypedVisit(node.ExpressionBody));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax node)
		{
			node = node.WithImplicitOrExplicitKeyword(this.VisitToken(node.ImplicitOrExplicitKeyword));
			node = node.WithOperatorKeyword(this.VisitToken(node.OperatorKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithParameters(this.TypedVisit(node.Parameters));
			return node;
		}

		public override SyntaxNode VisitCrefBracketedParameterList(CrefBracketedParameterListSyntax node)
		{
			node = node.WithOpenBracketToken(this.VisitToken(node.OpenBracketToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Parameters, (n, list) => n.WithParameters(list));
			node = node.WithCloseBracketToken(this.VisitToken(node.CloseBracketToken));
			return node;
		}

		public override SyntaxNode VisitCrefParameterList(CrefParameterListSyntax node)
		{
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Parameters, (n, list) => n.WithParameters(list));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitCrefParameter(CrefParameterSyntax node)
		{
			node = node.WithRefOrOutKeyword(this.VisitToken(node.RefOrOutKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			return node;
		}

		public override SyntaxNode VisitDefaultExpression(DefaultExpressionSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			return node;
		}

		public override SyntaxNode VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithDefineKeyword(this.VisitToken(node.DefineKeyword));
			node = node.WithName(this.VisitToken(node.Name));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithDelegateKeyword(this.VisitToken(node.DelegateKeyword));
			node = node.WithReturnType(this.TypedVisit(node.ReturnType));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithTypeParameterList(this.TypedVisit(node.TypeParameterList));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = this.IncrementalVisitSyntaxList(node, n => n.ConstraintClauses, (n, list) => n.WithConstraintClauses(list));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithTildeToken(this.VisitToken(node.TildeToken));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = node.WithBody(this.TypedVisit(node.Body));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.Content, (n, list) => n.WithContent(list));
			node = node.WithEndOfComment(this.VisitToken(node.EndOfComment));
			return node;
		}

		public override SyntaxNode VisitDoStatement(DoStatementSyntax node)
		{
			node = node.WithDoKeyword(this.VisitToken(node.DoKeyword));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			node = node.WithWhileKeyword(this.VisitToken(node.WhileKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithCondition(this.TypedVisit(node.Condition));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitElementAccessExpression(ElementAccessExpressionSyntax node)
		{
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithArgumentList(this.TypedVisit(node.ArgumentList));
			return node;
		}

		public override SyntaxNode VisitElementBindingExpression(ElementBindingExpressionSyntax node)
		{
			node = node.WithArgumentList(this.TypedVisit(node.ArgumentList));
			return node;
		}

		public override SyntaxNode VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithElifKeyword(this.VisitToken(node.ElifKeyword));
			node = node.WithCondition(this.TypedVisit(node.Condition));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitElseClause(ElseClauseSyntax node)
		{
			node = node.WithElseKeyword(this.VisitToken(node.ElseKeyword));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithElseKeyword(this.VisitToken(node.ElseKeyword));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitEmptyStatement(EmptyStatementSyntax node)
		{
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithEndIfKeyword(this.VisitToken(node.EndIfKeyword));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithEndRegionKeyword(this.VisitToken(node.EndRegionKeyword));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithEnumKeyword(this.VisitToken(node.EnumKeyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithBaseList(this.TypedVisit(node.BaseList));
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Members, (n, list) => n.WithMembers(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithEqualsValue(this.TypedVisit(node.EqualsValue));
			return node;
		}

		public override SyntaxNode VisitEqualsValueClause(EqualsValueClauseSyntax node)
		{
			node = node.WithEqualsToken(this.VisitToken(node.EqualsToken));
			node = node.WithValue(this.TypedVisit(node.Value));
			return node;
		}

		public override SyntaxNode VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithErrorKeyword(this.VisitToken(node.ErrorKeyword));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithEventKeyword(this.VisitToken(node.EventKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithExplicitInterfaceSpecifier(this.TypedVisit(node.ExplicitInterfaceSpecifier));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithAccessorList(this.TypedVisit(node.AccessorList));
			return node;
		}

		public override SyntaxNode VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithEventKeyword(this.VisitToken(node.EventKeyword));
			node = node.WithDeclaration(this.TypedVisit(node.Declaration));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
		{
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithDotToken(this.VisitToken(node.DotToken));
			return node;
		}

		public override SyntaxNode VisitExpressionStatement(ExpressionStatementSyntax node)
		{
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
		{
			node = node.WithExternKeyword(this.VisitToken(node.ExternKeyword));
			node = node.WithAliasKeyword(this.VisitToken(node.AliasKeyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithDeclaration(this.TypedVisit(node.Declaration));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitFinallyClause(FinallyClauseSyntax node)
		{
			node = node.WithFinallyKeyword(this.VisitToken(node.FinallyKeyword));
			node = node.WithBlock(this.TypedVisit(node.Block));
			return node;
		}

		public override SyntaxNode VisitFixedStatement(FixedStatementSyntax node)
		{
			node = node.WithFixedKeyword(this.VisitToken(node.FixedKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithDeclaration(this.TypedVisit(node.Declaration));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitForEachStatement(ForEachStatementSyntax node)
		{
			node = node.WithForEachKeyword(this.VisitToken(node.ForEachKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithInKeyword(this.VisitToken(node.InKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitForStatement(ForStatementSyntax node)
		{
			node = node.WithForKeyword(this.VisitToken(node.ForKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithDeclaration(this.TypedVisit(node.Declaration));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Initializers, (n, list) => n.WithInitializers(list));
			node = node.WithFirstSemicolonToken(this.VisitToken(node.FirstSemicolonToken));
			node = node.WithCondition(this.TypedVisit(node.Condition));
			node = node.WithSecondSemicolonToken(this.VisitToken(node.SecondSemicolonToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Incrementors, (n, list) => n.WithIncrementors(list));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitFromClause(FromClauseSyntax node)
		{
			node = node.WithFromKeyword(this.VisitToken(node.FromKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithInKeyword(this.VisitToken(node.InKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitGenericName(GenericNameSyntax node)
		{
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithTypeArgumentList(this.TypedVisit(node.TypeArgumentList));
			return node;
		}

		public override SyntaxNode VisitGlobalStatement(GlobalStatementSyntax node)
		{
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitGotoStatement(GotoStatementSyntax node)
		{
			node = node.WithGotoKeyword(this.VisitToken(node.GotoKeyword));
			node = node.WithCaseOrDefaultKeyword(this.VisitToken(node.CaseOrDefaultKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitGroupClause(GroupClauseSyntax node)
		{
			node = node.WithGroupKeyword(this.VisitToken(node.GroupKeyword));
			node = node.WithGroupExpression(this.TypedVisit(node.GroupExpression));
			node = node.WithByKeyword(this.VisitToken(node.ByKeyword));
			node = node.WithByExpression(this.TypedVisit(node.ByExpression));
			return node;
		}

		public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
		{
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			return node;
		}

		public override SyntaxNode VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithIfKeyword(this.VisitToken(node.IfKeyword));
			node = node.WithCondition(this.TypedVisit(node.Condition));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitIfStatement(IfStatementSyntax node)
		{
			node = node.WithIfKeyword(this.VisitToken(node.IfKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithCondition(this.TypedVisit(node.Condition));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			node = node.WithElse(this.TypedVisit(node.Else));
			return node;
		}

		public override SyntaxNode VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
		{
			node = node.WithNewKeyword(this.VisitToken(node.NewKeyword));
			node = node.WithOpenBracketToken(this.VisitToken(node.OpenBracketToken));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Commas, (n, list) => n.WithCommas(list));
			node = node.WithCloseBracketToken(this.VisitToken(node.CloseBracketToken));
			node = node.WithInitializer(this.TypedVisit(node.Initializer));
			return node;
		}

		public override SyntaxNode VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
		{
			node = node.WithArgumentList(this.TypedVisit(node.ArgumentList));
			return node;
		}

		public override SyntaxNode VisitIncompleteMember(IncompleteMemberSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithType(this.TypedVisit(node.Type));
			return node;
		}

		public override SyntaxNode VisitIndexerDeclaration(IndexerDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithExplicitInterfaceSpecifier(this.TypedVisit(node.ExplicitInterfaceSpecifier));
			node = node.WithThisKeyword(this.VisitToken(node.ThisKeyword));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = node.WithAccessorList(this.TypedVisit(node.AccessorList));
			node = node.WithExpressionBody(this.TypedVisit(node.ExpressionBody));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitIndexerMemberCref(IndexerMemberCrefSyntax node)
		{
			node = node.WithThisKeyword(this.VisitToken(node.ThisKeyword));
			node = node.WithParameters(this.TypedVisit(node.Parameters));
			return node;
		}

		public override SyntaxNode VisitInitializerExpression(InitializerExpressionSyntax node)
		{
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Expressions, (n, list) => n.WithExpressions(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			return node;
		}

		public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithTypeParameterList(this.TypedVisit(node.TypeParameterList));
			node = node.WithBaseList(this.TypedVisit(node.BaseList));
			node = this.IncrementalVisitSyntaxList(node, n => n.ConstraintClauses, (n, list) => n.WithConstraintClauses(list));
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSyntaxList(node, n => n.Members, (n, list) => n.WithMembers(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
		{
			node = node.WithStringStartToken(this.VisitToken(node.StringStartToken));
			node = this.IncrementalVisitSyntaxList(node, n => n.Contents, (n, list) => n.WithContents(list));
			node = node.WithStringEndToken(this.VisitToken(node.StringEndToken));
			return node;
		}

		public override SyntaxNode VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
		{
			node = node.WithTextToken(this.VisitToken(node.TextToken));
			return node;
		}

		public override SyntaxNode VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)
		{
			node = node.WithCommaToken(this.VisitToken(node.CommaToken));
			node = node.WithValue(this.TypedVisit(node.Value));
			return node;
		}

		public override SyntaxNode VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)
		{
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			node = node.WithFormatStringToken(this.VisitToken(node.FormatStringToken));
			return node;
		}

		public override SyntaxNode VisitInterpolation(InterpolationSyntax node)
		{
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithAlignmentClause(this.TypedVisit(node.AlignmentClause));
			node = node.WithFormatClause(this.TypedVisit(node.FormatClause));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			return node;
		}

		public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax node)
		{
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithArgumentList(this.TypedVisit(node.ArgumentList));
			return node;
		}

		public override SyntaxNode VisitJoinClause(JoinClauseSyntax node)
		{
			node = node.WithJoinKeyword(this.VisitToken(node.JoinKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithInKeyword(this.VisitToken(node.InKeyword));
			node = node.WithInExpression(this.TypedVisit(node.InExpression));
			node = node.WithOnKeyword(this.VisitToken(node.OnKeyword));
			node = node.WithLeftExpression(this.TypedVisit(node.LeftExpression));
			node = node.WithEqualsKeyword(this.VisitToken(node.EqualsKeyword));
			node = node.WithRightExpression(this.TypedVisit(node.RightExpression));
			node = node.WithInto(this.TypedVisit(node.Into));
			return node;
		}

		public override SyntaxNode VisitJoinIntoClause(JoinIntoClauseSyntax node)
		{
			node = node.WithIntoKeyword(this.VisitToken(node.IntoKeyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			return node;
		}

		public override SyntaxNode VisitLabeledStatement(LabeledStatementSyntax node)
		{
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitLetClause(LetClauseSyntax node)
		{
			node = node.WithLetKeyword(this.VisitToken(node.LetKeyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithEqualsToken(this.VisitToken(node.EqualsToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithLineKeyword(this.VisitToken(node.LineKeyword));
			node = node.WithLine(this.VisitToken(node.Line));
			node = node.WithFile(this.VisitToken(node.File));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitLiteralExpression(LiteralExpressionSyntax node)
		{
			node = node.WithToken(this.VisitToken(node.Token));
			return node;
		}

		public override SyntaxNode VisitLoadDirectiveTrivia(LoadDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithLoadKeyword(this.VisitToken(node.LoadKeyword));
			node = node.WithFile(this.VisitToken(node.File));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
		{
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithDeclaration(this.TypedVisit(node.Declaration));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitLockStatement(LockStatementSyntax node)
		{
			node = node.WithLockKeyword(this.VisitToken(node.LockKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitMakeRefExpression(MakeRefExpressionSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
		{
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			node = node.WithName(this.TypedVisit(node.Name));
			return node;
		}

		public override SyntaxNode VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
		{
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			node = node.WithName(this.TypedVisit(node.Name));
			return node;
		}

		public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithReturnType(this.TypedVisit(node.ReturnType));
			node = node.WithExplicitInterfaceSpecifier(this.TypedVisit(node.ExplicitInterfaceSpecifier));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithTypeParameterList(this.TypedVisit(node.TypeParameterList));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = this.IncrementalVisitSyntaxList(node, n => n.ConstraintClauses, (n, list) => n.WithConstraintClauses(list));
			node = node.WithBody(this.TypedVisit(node.Body));
			node = node.WithExpressionBody(this.TypedVisit(node.ExpressionBody));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitNameColon(NameColonSyntax node)
		{
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			return node;
		}

		public override SyntaxNode VisitNameEquals(NameEqualsSyntax node)
		{
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithEqualsToken(this.VisitToken(node.EqualsToken));
			return node;
		}

		public override SyntaxNode VisitNameMemberCref(NameMemberCrefSyntax node)
		{
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithParameters(this.TypedVisit(node.Parameters));
			return node;
		}

		public override SyntaxNode VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
		{
			node = node.WithNamespaceKeyword(this.VisitToken(node.NamespaceKeyword));
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSyntaxList(node, n => n.Externs, (n, list) => n.WithExterns(list));
			node = this.IncrementalVisitSyntaxList(node, n => n.Usings, (n, list) => n.WithUsings(list));
			node = this.IncrementalVisitSyntaxList(node, n => n.Members, (n, list) => n.WithMembers(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitNullableType(NullableTypeSyntax node)
		{
			node = node.WithElementType(this.TypedVisit(node.ElementType));
			node = node.WithQuestionToken(this.VisitToken(node.QuestionToken));
			return node;
		}

		public override SyntaxNode VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
		{
			node = node.WithNewKeyword(this.VisitToken(node.NewKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithArgumentList(this.TypedVisit(node.ArgumentList));
			node = node.WithInitializer(this.TypedVisit(node.Initializer));
			return node;
		}

		public override SyntaxNode VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
		{
			node = node.WithOmittedArraySizeExpressionToken(this.VisitToken(node.OmittedArraySizeExpressionToken));
			return node;
		}

		public override SyntaxNode VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
		{
			node = node.WithOmittedTypeArgumentToken(this.VisitToken(node.OmittedTypeArgumentToken));
			return node;
		}

		public override SyntaxNode VisitOperatorDeclaration(OperatorDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithReturnType(this.TypedVisit(node.ReturnType));
			node = node.WithOperatorKeyword(this.VisitToken(node.OperatorKeyword));
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = node.WithBody(this.TypedVisit(node.Body));
			node = node.WithExpressionBody(this.TypedVisit(node.ExpressionBody));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitOperatorMemberCref(OperatorMemberCrefSyntax node)
		{
			node = node.WithOperatorKeyword(this.VisitToken(node.OperatorKeyword));
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			node = node.WithParameters(this.TypedVisit(node.Parameters));
			return node;
		}

		public override SyntaxNode VisitOrderByClause(OrderByClauseSyntax node)
		{
			node = node.WithOrderByKeyword(this.VisitToken(node.OrderByKeyword));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Orderings, (n, list) => n.WithOrderings(list));
			return node;
		}

		public override SyntaxNode VisitOrdering(OrderingSyntax node)
		{
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithAscendingOrDescendingKeyword(this.VisitToken(node.AscendingOrDescendingKeyword));
			return node;
		}

		public override SyntaxNode VisitParameterList(ParameterListSyntax node)
		{
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Parameters, (n, list) => n.WithParameters(list));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitParameter(ParameterSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithDefault(this.TypedVisit(node.Default));
			return node;
		}

		public override SyntaxNode VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
		{
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
		{
			node = node.WithAsyncKeyword(this.VisitToken(node.AsyncKeyword));
			node = node.WithParameterList(this.TypedVisit(node.ParameterList));
			node = node.WithArrowToken(this.VisitToken(node.ArrowToken));
			node = node.WithBody(this.TypedVisit(node.Body));
			return node;
		}

		public override SyntaxNode VisitPointerType(PointerTypeSyntax node)
		{
			node = node.WithElementType(this.TypedVisit(node.ElementType));
			node = node.WithAsteriskToken(this.VisitToken(node.AsteriskToken));
			return node;
		}

		public override SyntaxNode VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
		{
			node = node.WithOperand(this.TypedVisit(node.Operand));
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			return node;
		}

		public override SyntaxNode VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithPragmaKeyword(this.VisitToken(node.PragmaKeyword));
			node = node.WithChecksumKeyword(this.VisitToken(node.ChecksumKeyword));
			node = node.WithFile(this.VisitToken(node.File));
			node = node.WithGuid(this.VisitToken(node.Guid));
			node = node.WithBytes(this.VisitToken(node.Bytes));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithPragmaKeyword(this.VisitToken(node.PragmaKeyword));
			node = node.WithWarningKeyword(this.VisitToken(node.WarningKeyword));
			node = node.WithDisableOrRestoreKeyword(this.VisitToken(node.DisableOrRestoreKeyword));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.ErrorCodes, (n, list) => n.WithErrorCodes(list));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitPredefinedType(PredefinedTypeSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			return node;
		}

		public override SyntaxNode VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
		{
			node = node.WithOperatorToken(this.VisitToken(node.OperatorToken));
			node = node.WithOperand(this.TypedVisit(node.Operand));
			return node;
		}

		public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithExplicitInterfaceSpecifier(this.TypedVisit(node.ExplicitInterfaceSpecifier));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithAccessorList(this.TypedVisit(node.AccessorList));
			node = node.WithExpressionBody(this.TypedVisit(node.ExpressionBody));
			node = node.WithInitializer(this.TypedVisit(node.Initializer));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitQualifiedCref(QualifiedCrefSyntax node)
		{
			node = node.WithContainer(this.TypedVisit(node.Container));
			node = node.WithDotToken(this.VisitToken(node.DotToken));
			node = node.WithMember(this.TypedVisit(node.Member));
			return node;
		}

		public override SyntaxNode VisitQualifiedName(QualifiedNameSyntax node)
		{
			node = node.WithLeft(this.TypedVisit(node.Left));
			node = node.WithDotToken(this.VisitToken(node.DotToken));
			node = node.WithRight(this.TypedVisit(node.Right));
			return node;
		}

		public override SyntaxNode VisitQueryBody(QueryBodySyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.Clauses, (n, list) => n.WithClauses(list));
			node = node.WithSelectOrGroup(this.TypedVisit(node.SelectOrGroup));
			node = node.WithContinuation(this.TypedVisit(node.Continuation));
			return node;
		}

		public override SyntaxNode VisitQueryContinuation(QueryContinuationSyntax node)
		{
			node = node.WithIntoKeyword(this.VisitToken(node.IntoKeyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithBody(this.TypedVisit(node.Body));
			return node;
		}

		public override SyntaxNode VisitQueryExpression(QueryExpressionSyntax node)
		{
			node = node.WithFromClause(this.TypedVisit(node.FromClause));
			node = node.WithBody(this.TypedVisit(node.Body));
			return node;
		}

		public override SyntaxNode VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithReferenceKeyword(this.VisitToken(node.ReferenceKeyword));
			node = node.WithFile(this.VisitToken(node.File));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitRefTypeExpression(RefTypeExpressionSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitRefValueExpression(RefValueExpressionSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithComma(this.VisitToken(node.Comma));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithRegionKeyword(this.VisitToken(node.RegionKeyword));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitReturnStatement(ReturnStatementSyntax node)
		{
			node = node.WithReturnKeyword(this.VisitToken(node.ReturnKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitSelectClause(SelectClauseSyntax node)
		{
			node = node.WithSelectKeyword(this.VisitToken(node.SelectKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			return node;
		}

		public override SyntaxNode VisitShebangDirectiveTrivia(ShebangDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithExclamationToken(this.VisitToken(node.ExclamationToken));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitSimpleBaseType(SimpleBaseTypeSyntax node)
		{
			node = node.WithType(this.TypedVisit(node.Type));
			return node;
		}

		public override SyntaxNode VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
		{
			node = node.WithAsyncKeyword(this.VisitToken(node.AsyncKeyword));
			node = node.WithParameter(this.TypedVisit(node.Parameter));
			node = node.WithArrowToken(this.VisitToken(node.ArrowToken));
			node = node.WithBody(this.TypedVisit(node.Body));
			return node;
		}

		public override SyntaxNode VisitSizeOfExpression(SizeOfExpressionSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
		{
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Tokens, (n, list) => n.WithTokens(list));
			return node;
		}

		public override SyntaxNode VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
		{
			node = node.WithStackAllocKeyword(this.VisitToken(node.StackAllocKeyword));
			node = node.WithType(this.TypedVisit(node.Type));
			return node;
		}

		public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.Modifiers, (n, list) => n.WithModifiers(list));
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithTypeParameterList(this.TypedVisit(node.TypeParameterList));
			node = node.WithBaseList(this.TypedVisit(node.BaseList));
			node = this.IncrementalVisitSyntaxList(node, n => n.ConstraintClauses, (n, list) => n.WithConstraintClauses(list));
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSyntaxList(node, n => n.Members, (n, list) => n.WithMembers(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitSwitchSection(SwitchSectionSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.Labels, (n, list) => n.WithLabels(list));
			node = this.IncrementalVisitSyntaxList(node, n => n.Statements, (n, list) => n.WithStatements(list));
			return node;
		}

		public override SyntaxNode VisitSwitchStatement(SwitchStatementSyntax node)
		{
			node = node.WithSwitchKeyword(this.VisitToken(node.SwitchKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithOpenBraceToken(this.VisitToken(node.OpenBraceToken));
			node = this.IncrementalVisitSyntaxList(node, n => n.Sections, (n, list) => n.WithSections(list));
			node = node.WithCloseBraceToken(this.VisitToken(node.CloseBraceToken));
			return node;
		}

		public override SyntaxNode VisitThisExpression(ThisExpressionSyntax node)
		{
			node = node.WithToken(this.VisitToken(node.Token));
			return node;
		}

		public override SyntaxNode VisitThrowStatement(ThrowStatementSyntax node)
		{
			node = node.WithThrowKeyword(this.VisitToken(node.ThrowKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitTryStatement(TryStatementSyntax node)
		{
			node = node.WithTryKeyword(this.VisitToken(node.TryKeyword));
			node = node.WithBlock(this.TypedVisit(node.Block));
			node = this.IncrementalVisitSyntaxList(node, n => n.Catches, (n, list) => n.WithCatches(list));
			node = node.WithFinally(this.TypedVisit(node.Finally));
			return node;
		}

		public override SyntaxNode VisitTypeArgumentList(TypeArgumentListSyntax node)
		{
			node = node.WithLessThanToken(this.VisitToken(node.LessThanToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Arguments, (n, list) => n.WithArguments(list));
			node = node.WithGreaterThanToken(this.VisitToken(node.GreaterThanToken));
			return node;
		}

		public override SyntaxNode VisitTypeConstraint(TypeConstraintSyntax node)
		{
			node = node.WithType(this.TypedVisit(node.Type));
			return node;
		}

		public override SyntaxNode VisitTypeCref(TypeCrefSyntax node)
		{
			node = node.WithType(this.TypedVisit(node.Type));
			return node;
		}

		public override SyntaxNode VisitTypeOfExpression(TypeOfExpressionSyntax node)
		{
			node = node.WithKeyword(this.VisitToken(node.Keyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithType(this.TypedVisit(node.Type));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			return node;
		}

		public override SyntaxNode VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
		{
			node = node.WithWhereKeyword(this.VisitToken(node.WhereKeyword));
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Constraints, (n, list) => n.WithConstraints(list));
			return node;
		}

		public override SyntaxNode VisitTypeParameterList(TypeParameterListSyntax node)
		{
			node = node.WithLessThanToken(this.VisitToken(node.LessThanToken));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Parameters, (n, list) => n.WithParameters(list));
			node = node.WithGreaterThanToken(this.VisitToken(node.GreaterThanToken));
			return node;
		}

		public override SyntaxNode VisitTypeParameter(TypeParameterSyntax node)
		{
			node = this.IncrementalVisitSyntaxList(node, n => n.AttributeLists, (n, list) => n.WithAttributeLists(list));
			node = node.WithVarianceKeyword(this.VisitToken(node.VarianceKeyword));
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			return node;
		}

		public override SyntaxNode VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithUndefKeyword(this.VisitToken(node.UndefKeyword));
			node = node.WithName(this.VisitToken(node.Name));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitUnsafeStatement(UnsafeStatementSyntax node)
		{
			node = node.WithUnsafeKeyword(this.VisitToken(node.UnsafeKeyword));
			node = node.WithBlock(this.TypedVisit(node.Block));
			return node;
		}

		public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node)
		{
			node = node.WithUsingKeyword(this.VisitToken(node.UsingKeyword));
			node = node.WithStaticKeyword(this.VisitToken(node.StaticKeyword));
			node = node.WithAlias(this.TypedVisit(node.Alias));
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}

		public override SyntaxNode VisitUsingStatement(UsingStatementSyntax node)
		{
			node = node.WithUsingKeyword(this.VisitToken(node.UsingKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithDeclaration(this.TypedVisit(node.Declaration));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitVariableDeclaration(VariableDeclarationSyntax node)
		{
			node = node.WithType(this.TypedVisit(node.Type));
			node = this.IncrementalVisitSeparatedSyntaxList(node, n => n.Variables, (n, list) => n.WithVariables(list));
			return node;
		}

		public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
		{
			node = node.WithIdentifier(this.VisitToken(node.Identifier));
			node = node.WithArgumentList(this.TypedVisit(node.ArgumentList));
			node = node.WithInitializer(this.TypedVisit(node.Initializer));
			return node;
		}

		public override SyntaxNode VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)
		{
			node = node.WithHashToken(this.VisitToken(node.HashToken));
			node = node.WithWarningKeyword(this.VisitToken(node.WarningKeyword));
			node = node.WithEndOfDirectiveToken(this.VisitToken(node.EndOfDirectiveToken));
			return node;
		}

		public override SyntaxNode VisitWhereClause(WhereClauseSyntax node)
		{
			node = node.WithWhereKeyword(this.VisitToken(node.WhereKeyword));
			node = node.WithCondition(this.TypedVisit(node.Condition));
			return node;
		}

		public override SyntaxNode VisitWhileStatement(WhileStatementSyntax node)
		{
			node = node.WithWhileKeyword(this.VisitToken(node.WhileKeyword));
			node = node.WithOpenParenToken(this.VisitToken(node.OpenParenToken));
			node = node.WithCondition(this.TypedVisit(node.Condition));
			node = node.WithCloseParenToken(this.VisitToken(node.CloseParenToken));
			node = node.WithStatement(this.TypedVisit(node.Statement));
			return node;
		}

		public override SyntaxNode VisitXmlCDataSection(XmlCDataSectionSyntax node)
		{
			node = node.WithStartCDataToken(this.VisitToken(node.StartCDataToken));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.TextTokens, (n, list) => n.WithTextTokens(list));
			node = node.WithEndCDataToken(this.VisitToken(node.EndCDataToken));
			return node;
		}

		public override SyntaxNode VisitXmlComment(XmlCommentSyntax node)
		{
			node = node.WithLessThanExclamationMinusMinusToken(this.VisitToken(node.LessThanExclamationMinusMinusToken));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.TextTokens, (n, list) => n.WithTextTokens(list));
			node = node.WithMinusMinusGreaterThanToken(this.VisitToken(node.MinusMinusGreaterThanToken));
			return node;
		}

		public override SyntaxNode VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
		{
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithEqualsToken(this.VisitToken(node.EqualsToken));
			node = node.WithStartQuoteToken(this.VisitToken(node.StartQuoteToken));
			node = node.WithCref(this.TypedVisit(node.Cref));
			node = node.WithEndQuoteToken(this.VisitToken(node.EndQuoteToken));
			return node;
		}

		public override SyntaxNode VisitXmlElementEndTag(XmlElementEndTagSyntax node)
		{
			node = node.WithLessThanSlashToken(this.VisitToken(node.LessThanSlashToken));
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithGreaterThanToken(this.VisitToken(node.GreaterThanToken));
			return node;
		}

		public override SyntaxNode VisitXmlElementStartTag(XmlElementStartTagSyntax node)
		{
			node = node.WithLessThanToken(this.VisitToken(node.LessThanToken));
			node = node.WithName(this.TypedVisit(node.Name));
			node = this.IncrementalVisitSyntaxList(node, n => n.Attributes, (n, list) => n.WithAttributes(list));
			node = node.WithGreaterThanToken(this.VisitToken(node.GreaterThanToken));
			return node;
		}

		public override SyntaxNode VisitXmlElement(XmlElementSyntax node)
		{
			node = node.WithStartTag(this.TypedVisit(node.StartTag));
			node = this.IncrementalVisitSyntaxList(node, n => n.Content, (n, list) => n.WithContent(list));
			node = node.WithEndTag(this.TypedVisit(node.EndTag));
			return node;
		}

		public override SyntaxNode VisitXmlEmptyElement(XmlEmptyElementSyntax node)
		{
			node = node.WithLessThanToken(this.VisitToken(node.LessThanToken));
			node = node.WithName(this.TypedVisit(node.Name));
			node = this.IncrementalVisitSyntaxList(node, n => n.Attributes, (n, list) => n.WithAttributes(list));
			node = node.WithSlashGreaterThanToken(this.VisitToken(node.SlashGreaterThanToken));
			return node;
		}

		public override SyntaxNode VisitXmlNameAttribute(XmlNameAttributeSyntax node)
		{
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithEqualsToken(this.VisitToken(node.EqualsToken));
			node = node.WithStartQuoteToken(this.VisitToken(node.StartQuoteToken));
			node = node.WithIdentifier(this.TypedVisit(node.Identifier));
			node = node.WithEndQuoteToken(this.VisitToken(node.EndQuoteToken));
			return node;
		}

		public override SyntaxNode VisitXmlName(XmlNameSyntax node)
		{
			node = node.WithPrefix(this.TypedVisit(node.Prefix));
			node = node.WithLocalName(this.VisitToken(node.LocalName));
			return node;
		}

		public override SyntaxNode VisitXmlPrefix(XmlPrefixSyntax node)
		{
			node = node.WithPrefix(this.VisitToken(node.Prefix));
			node = node.WithColonToken(this.VisitToken(node.ColonToken));
			return node;
		}

		public override SyntaxNode VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
		{
			node = node.WithStartProcessingInstructionToken(this.VisitToken(node.StartProcessingInstructionToken));
			node = node.WithName(this.TypedVisit(node.Name));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.TextTokens, (n, list) => n.WithTextTokens(list));
			node = node.WithEndProcessingInstructionToken(this.VisitToken(node.EndProcessingInstructionToken));
			return node;
		}

		public override SyntaxNode VisitXmlTextAttribute(XmlTextAttributeSyntax node)
		{
			node = node.WithName(this.TypedVisit(node.Name));
			node = node.WithEqualsToken(this.VisitToken(node.EqualsToken));
			node = node.WithStartQuoteToken(this.VisitToken(node.StartQuoteToken));
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.TextTokens, (n, list) => n.WithTextTokens(list));
			node = node.WithEndQuoteToken(this.VisitToken(node.EndQuoteToken));
			return node;
		}

		public override SyntaxNode VisitXmlText(XmlTextSyntax node)
		{
			node = this.IncrementalVisitSyntaxTokenList(node, n => n.TextTokens, (n, list) => n.WithTextTokens(list));
			return node;
		}

		public override SyntaxNode VisitYieldStatement(YieldStatementSyntax node)
		{
			node = node.WithYieldKeyword(this.VisitToken(node.YieldKeyword));
			node = node.WithReturnOrBreakKeyword(this.VisitToken(node.ReturnOrBreakKeyword));
			node = node.WithExpression(this.TypedVisit(node.Expression));
			node = node.WithSemicolonToken(this.VisitToken(node.SemicolonToken));
			return node;
		}
	}
}
