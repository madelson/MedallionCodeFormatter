using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;

namespace MedallionCodeFormatter
{
    internal class LayoutProcessor
    {
        // rules for indentation
        // * standard indent string (e. g. \t)
        // * entering (), [], or {} increases the indent level
        // * case, default increases indent level
        // * unblocked if, else, while, etc. increase indent level
        // * -> can we say that any statement on a different line than it's parent has a higher indent level?
        // e. g. broken a && b, a.b, etc

        // start in canonical form (as collapsed as possible)
        // - single blank lines preserved
        // - single line comments preserved
        // - standard indenting (see above)
        // - for usings, all on own lines
        // - assembly attributes on own line
        // - for a namespace, one type on own line or every type on own line
        // - for a type, every decl on one one or own line
        // - for parameters, every one on one or own line
        // - standard spacing around operators

        // rules for layout (from canonical form)
        // * work through each line
        // * if overflows, go up the tree looking for rules to apply to break things up
        // * pick the highest one and apply => retry!
        // * rules include
        //  - type or similar to multi line
        //  - 

        // ALTERNATIVE APPROACH: start in canonical form and look for opportunities to collapse

        private int indentLevel;

        public void Process(SyntaxNode node)
        {
            
            var indentLevel = 0;
            SyntaxToken previous = default(SyntaxToken);
            foreach (var token in node.DescendantTokens())
            {
                switch (token.Kind())
                {
                    case SyntaxKind.AbstractKeyword:
                    case SyntaxKind.AddKeyword:
                    case SyntaxKind.AliasKeyword:
                    case SyntaxKind.ArgListKeyword:
                    case SyntaxKind.AscendingKeyword:
                    case SyntaxKind.AsKeyword:
                    case SyntaxKind.AssemblyKeyword:
                    case SyntaxKind.AsyncKeyword:
                    case SyntaxKind.AwaitKeyword:
                    case SyntaxKind.BaseKeyword:
                    case SyntaxKind.BoolKeyword:
                    case SyntaxKind.BreakKeyword:
                    case SyntaxKind.ByKeyword:
                    case SyntaxKind.TildeToken:
                        this.ProcessUnaryOperator(token);
                        break;
                    case SyntaxKind.ExclamationToken:
                        this.ProcessUnaryOperator(token);
                        break;
                    case SyntaxKind.DollarToken:
                        throw new NotSupportedException(token.Kind().ToString());
                    case SyntaxKind.PercentToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.CaretToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.AmpersandToken:
                        switch (token.Parent.Kind())
                        {
                            case SyntaxKind.BitwiseAndExpression:
                                this.ProcessBinaryOperator(token);
                                break;
                            case SyntaxKind.AddressOfExpression:
                                this.ProcessUnaryOperator(token);
                                break;
                            default:
                                throw new InvalidOperationException("Unexpected parent kind " + token.Parent.Kind() + " for token " + token.Kind());
                        }
                        break;
                    case SyntaxKind.AsteriskToken:
                        switch (token.Parent.Kind())
                        {
                            case SyntaxKind.MultiplyExpression:
                                this.ProcessBinaryOperator(token);
                                break;
                            default:
                                throw new NotSupportedException("Parent kind of asterisk was " + token.Parent.Kind());
                        }
                        break;
                    case SyntaxKind.OpenParenToken:
                        this.EnterGroup(token);
                        break;
                    case SyntaxKind.CloseParenToken:
                        this.ExitGroup(token);
                        break;
                    case SyntaxKind.MinusToken:
                        switch (token.Parent.Kind())
                        {
                            case SyntaxKind.SubtractExpression:
                                this.ProcessBinaryOperator(token);
                                break;
                            case SyntaxKind.UnaryMinusExpression:
                                this.ProcessUnaryOperator(token);
                                break;
                            default:
                                throw new InvalidOperationException("Unexpected parent kind " + token.Parent.Kind() + " for " + token.Kind());
                        }
                        break;
                    case SyntaxKind.PlusToken:
                        switch (token.Parent.Kind())
                        {
                            case SyntaxKind.AddExpression:
                                this.ProcessBinaryOperator(token);
                                break;
                            case SyntaxKind.UnaryPlusExpression:
                                this.ProcessUnaryOperator(token);
                                break;
                            default:
                                throw new InvalidOperationException("Unexpected parent kind " + token.Parent.Kind() + " for " + token.Kind());
                        }
                        break;
                    case SyntaxKind.EqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.OpenBraceToken:
                        this.EnterGroup(token);
                        break;
                    case SyntaxKind.CloseBraceToken:
                        this.ExitGroup(token);
                        break;
                    case SyntaxKind.OpenBracketToken:
                        this.EnterGroup(token);
                        break;
                    case SyntaxKind.CloseBracketToken:
                        this.ExitGroup(token);
                        break;
                    case SyntaxKind.BarToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.BackslashToken:
                        throw new NotSupportedException(token.Kind().ToString());
                    case SyntaxKind.ColonToken:
                        switch (token.Parent.Kind())
                        {
                            case SyntaxKind.ConditionalExpression:
                                this.ProcessBinaryOperator(token);
                                break;
                            default:
                                throw new NotSupportedException("Parent kind " + token.Parent.Kind() + " for " + token.Kind());
                        }
                        break;
                    case SyntaxKind.SemicolonToken:
                        this.ProcessSemicolon(token);
                        break;
                    case SyntaxKind.DoubleQuoteToken:
                    case SyntaxKind.SingleQuoteToken:
                        throw new NotSupportedException("XML");
                    case SyntaxKind.LessThanToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.CommaToken:
                        this.ProcessComma(token);
                        break;
                    case SyntaxKind.GreaterThanToken:
                        this.ProcessBinaryOperator(token); break;
                        break;
                    case SyntaxKind.DotToken:
                        this.ProcessAccessor(token);
                        break;
                    case SyntaxKind.QuestionToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.HashToken:
                        throw new NotSupportedException("TRIVIA");
                    case SyntaxKind.SlashToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.SlashGreaterThanToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.LessThanSlashToken:
                    case SyntaxKind.XmlCommentStartToken:
                    case SyntaxKind.XmlCommentEndToken:
                    case SyntaxKind.XmlCDataStartToken:
                    case SyntaxKind.XmlCDataEndToken:
                    case SyntaxKind.XmlProcessingInstructionStartToken:
                    case SyntaxKind.XmlProcessingInstructionEndToken:
                        throw new NotSupportedException("XML");
                    case SyntaxKind.BarBarToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.AmpersandAmpersandToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.MinusMinusToken:
                        this.ProcessUnaryOperator(token);
                        break;
                    case SyntaxKind.PlusPlusToken:
                        this.ProcessUnaryOperator(token);
                        break;
                    case SyntaxKind.ColonColonToken:
                        throw new NotSupportedException(token.Kind().ToString());
                    case SyntaxKind.QuestionQuestionToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.MinusGreaterThanToken:
                        this.ProcessAccessor(token);
                        break;
                    case SyntaxKind.ExclamationEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.EqualsEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.EqualsGreaterThanToken:
                        this.ProcessLambdaOperator(token);
                        break;
                    case SyntaxKind.LessThanEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.LessThanLessThanToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.LessThanLessThanEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.GreaterThanEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.GreaterThanGreaterThanToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.GreaterThanGreaterThanEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.SlashEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.AsteriskEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.BarEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.AmpersandEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.PlusEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.MinusEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.CaretEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.PercentEqualsToken:
                        this.ProcessBinaryOperator(token);
                        break;
                    case SyntaxKind.InterpolatedStringStartToken:
                    case SyntaxKind.InterpolatedStringEndToken:
                    case SyntaxKind.InterpolatedVerbatimStringStartToken:
                        throw new NotSupportedException("C#6");
                    case SyntaxKind.OmittedTypeArgumentToken:
                    case SyntaxKind.OmittedArraySizeExpressionToken:
                        break; // no-op
                    case SyntaxKind.EndOfDirectiveToken:
                    case SyntaxKind.EndOfDocumentationCommentToken:
                        throw new InvalidOperationException("TRIVIA");
                    case SyntaxKind.EndOfFileToken:
                        break;
                    case SyntaxKind.BadToken:
                        throw new NotSupportedException("BAD");
                    case SyntaxKind.IdentifierToken: 
                    case SyntaxKind.NumericLiteralToken:
                    case SyntaxKind.CharacterLiteralToken:
                    case SyntaxKind.StringLiteralToken:
                        this.ProcessIdentifierOrLiteral(token);
                        break;
                    case SyntaxKind.XmlEntityLiteralToken:
                    case SyntaxKind.XmlTextLiteralToken:
                    case SyntaxKind.XmlTextLiteralNewLineToken:
                        throw new InvalidOperationException("XML");
                    case SyntaxKind.InterpolatedStringToken:
                    case SyntaxKind.InterpolatedStringTextToken:
                        throw new NotSupportedException("C#6");
                    case SyntaxKind.SkippedTokensTrivia:
                        throw new NotSupportedException("Skipped");
                    default:
                        throw new InvalidOperationException("Unexpected kind " + token.Kind());
                }
            }
        }

        private void ProcessUnaryOperator(SyntaxToken token)
        {

        }

        private void ProcessBinaryOperator(SyntaxToken token)
        {

        }

        private void EnterGroup(SyntaxToken token)
        {
            ++this.indentLevel;
        }

        private void ExitGroup(SyntaxToken token)
        {
            --this.indentLevel;
        }

        private void ProcessSemicolon(SyntaxToken token)
        {

        }

        private void ProcessComma(SyntaxToken token)
        {

        }

        private void ProcessAccessor(SyntaxToken token)
        {

        }

        private void ProcessLambdaOperator(SyntaxToken token)
        {

        }

        private void ProcessIdentifierOrLiteral(SyntaxToken token)
        {

        }
    }
}
