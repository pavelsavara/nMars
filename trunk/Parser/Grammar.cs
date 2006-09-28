// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.Serialization;

namespace nMars.Parser
{
    [Serializable()]
    public class SymbolException : Exception
    {
        public SymbolException(string message) : base(message)
        {
        }

        public SymbolException(string message,
                               Exception inner) : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info,
                                  StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable()]
    public class RuleException : Exception
    {
        public RuleException(string message) : base(message)
        {
        }

        public RuleException(string message,
                             Exception inner) : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info,
                                StreamingContext context) : base(info, context)
        {
        }
    }

    internal enum SymbolConstants : int
    {
        SYMBOL_EOF = 0, // (EOF)
        SYMBOL_ERROR = 1, // (Error)
        SYMBOL_WHITESPACE = 2, // (Whitespace)
        SYMBOL_COMMENTLINE = 3, // (Comment Line)
        SYMBOL_MINUS = 4, // -
        SYMBOL_EXCLAMEQ = 5, // !=
        SYMBOL_NUM = 6, // #
        SYMBOL_DOLLAR = 7, // $
        SYMBOL_PERCENT = 8, // %
        SYMBOL_AMP = 9, // &
        SYMBOL_AMPAMP = 10, // &&
        SYMBOL_LPARAN = 11, // (
        SYMBOL_RPARAN = 12, // )
        SYMBOL_TIMES = 13, // *
        SYMBOL_COMMA = 14, // ,
        SYMBOL_DOT = 15, // .
        SYMBOL_DIV = 16, // /
        SYMBOL_COLON = 17, // :
        SYMBOL_QUESTION = 18, // ?
        SYMBOL_AT = 19, // @
        SYMBOL_CARET = 20, // ^
        SYMBOL_LBRACE = 21, // {
        SYMBOL_PIPE = 22, // |
        SYMBOL_PIPEPIPE = 23, // ||
        SYMBOL_RBRACE = 24, // }
        SYMBOL_PLUS = 25, // +
        SYMBOL_LT = 26, // <
        SYMBOL_LTLT = 27, // <<
        SYMBOL_LTEQ = 28, // <=
        SYMBOL_LTGT = 29, // <>
        SYMBOL_EQEQ = 30, // ==
        SYMBOL_GT = 31, // >
        SYMBOL_GTEQ = 32, // >=
        SYMBOL_GTGT = 33, // >>
        SYMBOL_A = 34, // A
        SYMBOL_AB = 35, // AB
        SYMBOL_ADD = 36, // Add
        SYMBOL_B = 37, // B
        SYMBOL_BA = 38, // BA
        SYMBOL_CMP = 39, // Cmp
        SYMBOL_COMMENT = 40, // Comment
        SYMBOL_DAT = 41, // Dat
        SYMBOL_DIV2 = 42, // Div
        SYMBOL_DJN = 43, // Djn
        SYMBOL_END = 44, // End
        SYMBOL_EQU = 45, // Equ
        SYMBOL_F = 46, // F
        SYMBOL_FOR = 47, // for
        SYMBOL_I = 48, // I
        SYMBOL_INTEGER = 49, // Integer
        SYMBOL_JMN = 50, // Jmn
        SYMBOL_JMP = 51, // Jmp
        SYMBOL_JMZ = 52, // Jmz
        SYMBOL_LABEL = 53, // Label
        SYMBOL_LDP = 54, // Ldp
        SYMBOL_LINE = 55, // Line
        SYMBOL_MOD = 56, // Mod
        SYMBOL_MOV = 57, // Mov
        SYMBOL_MUL = 58, // Mul
        SYMBOL_NEWLINE = 59, // NewLine
        SYMBOL_NOP = 60, // Nop
        SYMBOL_ORG = 61, // Org
        SYMBOL_PIN = 62, // Pin
        SYMBOL_ROF = 63, // rof
        SYMBOL_SEQ = 64, // Seq
        SYMBOL_SLT = 65, // Slt
        SYMBOL_SNE = 66, // Sne
        SYMBOL_SPL = 67, // Spl
        SYMBOL_STP = 68, // Stp
        SYMBOL_SUB = 69, // Sub
        SYMBOL_X = 70, // X
        SYMBOL_ADDEXP = 71, // <Add Exp>
        SYMBOL_ALLSTATEMENTS = 72, // <AllStatements>
        SYMBOL_ALLSTATEMENTSOPTIONAL = 73, // <AllStatementsOptional>
        SYMBOL_ANDEXP = 74, // <And Exp>
        SYMBOL_BINOREXP = 75, // <BinOr Exp>
        SYMBOL_BINXOREXP = 76, // <BinXor Exp>
        SYMBOL_COMPAREEXP = 77, // <Compare Exp>
        SYMBOL_ENDOPTIONAL = 78, // <EndOptional>
        SYMBOL_EOL = 79, // <eol>
        SYMBOL_EOLOPTIONAL = 80, // <eolOptional>
        SYMBOL_EOLSINGLE = 81, // <eolSingle>
        SYMBOL_EQU2 = 82, // <Equ>
        SYMBOL_EQUATEEXP = 83, // <Equate Exp>
        SYMBOL_EXPRESSION = 84, // <Expression>
        SYMBOL_EXPRESSIONOPTIONAL = 85, // <ExpressionOptional>
        SYMBOL_FOR2 = 86, // <For>
        SYMBOL_LABEL2 = 87, // <Label>
        SYMBOL_LABELS = 88, // <Labels>
        SYMBOL_LABELSOPTIONAL = 89, // <LabelsOptional>
        SYMBOL_MODE = 90, // <Mode>
        SYMBOL_MODEOPTIONAL = 91, // <ModeOptional>
        SYMBOL_MODIFIER = 92, // <Modifier>
        SYMBOL_MULTEXP = 93, // <Mult Exp>
        SYMBOL_NEGATEEXP = 94, // <Negate Exp>
        SYMBOL_OPERATION = 95, // <Operation>
        SYMBOL_OPERATION0 = 96, // <Operation0>
        SYMBOL_OPERATION1 = 97, // <Operation1>
        SYMBOL_OPERATION2 = 98, // <Operation2>
        SYMBOL_OPERATOR0 = 99, // <Operator0>
        SYMBOL_OPERATOR1 = 100, // <Operator1>
        SYMBOL_OPERATOR2 = 101, // <Operator2>
        SYMBOL_OREXP = 102, // <Or Exp>
        SYMBOL_ORG2 = 103, // <Org>
        SYMBOL_PARAMETER = 104, // <Parameter>
        SYMBOL_PIN2 = 105, // <Pin>
        SYMBOL_SHIFTEXP = 106, // <Shift Exp>
        SYMBOL_START = 107, // <Start>
        SYMBOL_STATEMENT = 108, // <Statement>
        SYMBOL_VALUE = 109 // <Value>
    } ;

    internal enum RuleConstants : int
    {
        RULE_EOL = 0, // <eol> ::= <eolSingle>
        RULE_EOL2 = 1, // <eol> ::= <eol> <eolSingle>
        RULE_EOLSINGLE_NEWLINE = 2, // <eolSingle> ::= NewLine
        RULE_EOLSINGLE_COMMENT_LINE = 3, // <eolSingle> ::= Comment Line
        RULE_EOLOPTIONAL = 4, // <eolOptional> ::= <eol>
        RULE_EOLOPTIONAL2 = 5, // <eolOptional> ::= 
        RULE_START = 6, // <Start> ::= <eolOptional> <AllStatements> <EndOptional>
        RULE_ENDOPTIONAL = 7, // <EndOptional> ::= <eol>
        RULE_ENDOPTIONAL_END = 8, // <EndOptional> ::= <eol> End <eolOptional>
        RULE_ENDOPTIONAL_END2 = 9, // <EndOptional> ::= <eol> End <Labels> <eolOptional>
        RULE_ENDOPTIONAL_END3 = 10, // <EndOptional> ::= <eol> <Labels> End <eolOptional>
        RULE_ENDOPTIONAL_END4 = 11, // <EndOptional> ::= <eol> <Labels> End <Labels> <eolOptional>
        RULE_ENDOPTIONAL_END5 = 12, // <EndOptional> ::= <eol> <Labels> <eol> End <eolOptional>
        RULE_ENDOPTIONAL_END6 = 13, // <EndOptional> ::= <eol> <Labels> <eol> End <Labels> <eolOptional>
        RULE_ENDOPTIONAL2 = 14, // <EndOptional> ::= 
        RULE_ALLSTATEMENTS = 15, // <AllStatements> ::= <Statement>
        RULE_ALLSTATEMENTS2 = 16, // <AllStatements> ::= <For>
        RULE_ALLSTATEMENTS3 = 17, // <AllStatements> ::= <AllStatements> <eol> <Statement>
        RULE_ALLSTATEMENTS4 = 18, // <AllStatements> ::= <AllStatements> <eol> <For>
        RULE_FOR_FOR_ROF = 19,
        // <For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
        RULE_ALLSTATEMENTSOPTIONAL = 20, // <AllStatementsOptional> ::= <AllStatements> <eol>
        RULE_ALLSTATEMENTSOPTIONAL2 = 21, // <AllStatementsOptional> ::= 
        RULE_STATEMENT = 22, // <Statement> ::= <Pin>
        RULE_STATEMENT2 = 23, // <Statement> ::= <Org>
        RULE_STATEMENT3 = 24, // <Statement> ::= <Equ>
        RULE_STATEMENT4 = 25, // <Statement> ::= <LabelsOptional> <Operation>
        RULE_STATEMENT5 = 26, // <Statement> ::= <Labels> <eol> <Operation>
        RULE_PIN_PIN = 27, // <Pin> ::= Pin <Expression>
        RULE_ORG_ORG_LABEL = 28, // <Org> ::= Org Label
        RULE_EQU_EQU = 29, // <Equ> ::= <Labels> Equ <ModeOptional> <Expression>
        RULE_EQU_EQU2 = 30, // <Equ> ::= <Labels> <eol> Equ <ModeOptional> <Expression>
        RULE_LABELSOPTIONAL = 31, // <LabelsOptional> ::= <Labels>
        RULE_LABELSOPTIONAL2 = 32, // <LabelsOptional> ::= 
        RULE_LABEL_LABEL = 33, // <Label> ::= Label
        RULE_LABEL = 34, // <Label> ::= <Modifier>
        RULE_LABEL_LABEL_AMP_LABEL = 35, // <Label> ::= Label & Label
        RULE_LABEL_LABEL_AMP = 36, // <Label> ::= Label & <Modifier>
        RULE_LABEL_AMP_LABEL = 37, // <Label> ::= <Modifier> & Label
        RULE_LABELS = 38, // <Labels> ::= <Label>
        RULE_LABELS2 = 39, // <Labels> ::= <Labels> <eol> <Label>
        RULE_LABELS3 = 40, // <Labels> ::= <Labels> <Label>
        RULE_OPERATION = 41, // <Operation> ::= <Operation0>
        RULE_OPERATION2 = 42, // <Operation> ::= <Operation1>
        RULE_OPERATION3 = 43, // <Operation> ::= <Operation2>
        RULE_OPERATION0 = 44, // <Operation0> ::= <Operator0>
        RULE_OPERATION0_COMMA = 45, // <Operation0> ::= <Operator0> <Parameter> , <Parameter>
        RULE_OPERATION0_DOT_COMMA = 46, // <Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION1 = 47, // <Operation1> ::= <Operator1> <Parameter>
        RULE_OPERATION1_DOT = 48, // <Operation1> ::= <Operator1> . <Modifier> <Parameter>
        RULE_OPERATION1_COMMA = 49, // <Operation1> ::= <Operator1> <Parameter> , <Parameter>
        RULE_OPERATION1_DOT_COMMA = 50, // <Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION2_COMMA = 51, // <Operation2> ::= <Operator2> <Parameter> , <Parameter>
        RULE_OPERATION2_DOT_COMMA = 52, // <Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
        RULE_PARAMETER = 53, // <Parameter> ::= <Expression>
        RULE_PARAMETER2 = 54, // <Parameter> ::= <Mode> <Expression>
        RULE_MODEOPTIONAL = 55, // <ModeOptional> ::= <Mode>
        RULE_MODEOPTIONAL2 = 56, // <ModeOptional> ::= 
        RULE_MODE_NUM = 57, // <Mode> ::= #
        RULE_MODE_DOLLAR = 58, // <Mode> ::= $
        RULE_MODE_AT = 59, // <Mode> ::= @
        RULE_MODE_LT = 60, // <Mode> ::= <
        RULE_MODE_GT = 61, // <Mode> ::= >
        RULE_MODE_LBRACE = 62, // <Mode> ::= {
        RULE_MODE_RBRACE = 63, // <Mode> ::= }
        RULE_MODE_TIMES = 64, // <Mode> ::= *
        RULE_OPERATOR0_NOP = 65, // <Operator0> ::= Nop
        RULE_OPERATOR1_JMP = 66, // <Operator1> ::= Jmp
        RULE_OPERATOR1_SPL = 67, // <Operator1> ::= Spl
        RULE_OPERATOR1_DAT = 68, // <Operator1> ::= Dat
        RULE_OPERATOR2_MOV = 69, // <Operator2> ::= Mov
        RULE_OPERATOR2_ADD = 70, // <Operator2> ::= Add
        RULE_OPERATOR2_SUB = 71, // <Operator2> ::= Sub
        RULE_OPERATOR2_MUL = 72, // <Operator2> ::= Mul
        RULE_OPERATOR2_DIV = 73, // <Operator2> ::= Div
        RULE_OPERATOR2_MOD = 74, // <Operator2> ::= Mod
        RULE_OPERATOR2_JMZ = 75, // <Operator2> ::= Jmz
        RULE_OPERATOR2_JMN = 76, // <Operator2> ::= Jmn
        RULE_OPERATOR2_DJN = 77, // <Operator2> ::= Djn
        RULE_OPERATOR2_SLT = 78, // <Operator2> ::= Slt
        RULE_OPERATOR2_SNE = 79, // <Operator2> ::= Sne
        RULE_OPERATOR2_LDP = 80, // <Operator2> ::= Ldp
        RULE_OPERATOR2_STP = 81, // <Operator2> ::= Stp
        RULE_OPERATOR2_CMP = 82, // <Operator2> ::= Cmp
        RULE_OPERATOR2_SEQ = 83, // <Operator2> ::= Seq
        RULE_MODIFIER_I = 84, // <Modifier> ::= I
        RULE_MODIFIER_A = 85, // <Modifier> ::= A
        RULE_MODIFIER_B = 86, // <Modifier> ::= B
        RULE_MODIFIER_AB = 87, // <Modifier> ::= AB
        RULE_MODIFIER_BA = 88, // <Modifier> ::= BA
        RULE_MODIFIER_F = 89, // <Modifier> ::= F
        RULE_MODIFIER_X = 90, // <Modifier> ::= X
        RULE_EXPRESSIONOPTIONAL = 91, // <ExpressionOptional> ::= <Expression>
        RULE_EXPRESSIONOPTIONAL2 = 92, // <ExpressionOptional> ::= 
        RULE_EXPRESSION_QUESTION_COLON = 93, // <Expression> ::= <Or Exp> ? <Expression> : <Expression>
        RULE_EXPRESSION = 94, // <Expression> ::= <Or Exp>
        RULE_OREXP_PIPEPIPE = 95, // <Or Exp> ::= <Or Exp> || <And Exp>
        RULE_OREXP = 96, // <Or Exp> ::= <And Exp>
        RULE_ANDEXP_AMPAMP = 97, // <And Exp> ::= <And Exp> && <BinOr Exp>
        RULE_ANDEXP = 98, // <And Exp> ::= <BinOr Exp>
        RULE_BINOREXP_PIPE = 99, // <BinOr Exp> ::= <BinOr Exp> | <BinXor Exp>
        RULE_BINOREXP = 100, // <BinOr Exp> ::= <BinXor Exp>
        RULE_BINXOREXP_CARET = 101, // <BinXor Exp> ::= <BinXor Exp> ^ <Equate Exp>
        RULE_BINXOREXP = 102, // <BinXor Exp> ::= <Equate Exp>
        RULE_EQUATEEXP_EQEQ = 103, // <Equate Exp> ::= <Equate Exp> == <Compare Exp>
        RULE_EQUATEEXP_EXCLAMEQ = 104, // <Equate Exp> ::= <Equate Exp> != <Compare Exp>
        RULE_EQUATEEXP_LTGT = 105, // <Equate Exp> ::= <Equate Exp> <> <Compare Exp>
        RULE_EQUATEEXP = 106, // <Equate Exp> ::= <Compare Exp>
        RULE_COMPAREEXP_LT = 107, // <Compare Exp> ::= <Compare Exp> < <Shift Exp>
        RULE_COMPAREEXP_GT = 108, // <Compare Exp> ::= <Compare Exp> > <Shift Exp>
        RULE_COMPAREEXP_LTEQ = 109, // <Compare Exp> ::= <Compare Exp> <= <Shift Exp>
        RULE_COMPAREEXP_GTEQ = 110, // <Compare Exp> ::= <Compare Exp> >= <Shift Exp>
        RULE_COMPAREEXP = 111, // <Compare Exp> ::= <Shift Exp>
        RULE_SHIFTEXP_LTLT = 112, // <Shift Exp> ::= <Shift Exp> << <Add Exp>
        RULE_SHIFTEXP_GTGT = 113, // <Shift Exp> ::= <Shift Exp> >> <Add Exp>
        RULE_SHIFTEXP = 114, // <Shift Exp> ::= <Add Exp>
        RULE_ADDEXP_PLUS = 115, // <Add Exp> ::= <Add Exp> + <Mult Exp>
        RULE_ADDEXP_MINUS = 116, // <Add Exp> ::= <Add Exp> - <Mult Exp>
        RULE_ADDEXP = 117, // <Add Exp> ::= <Mult Exp>
        RULE_MULTEXP_TIMES = 118, // <Mult Exp> ::= <Mult Exp> * <Negate Exp>
        RULE_MULTEXP_DIV = 119, // <Mult Exp> ::= <Mult Exp> / <Negate Exp>
        RULE_MULTEXP_PERCENT = 120, // <Mult Exp> ::= <Mult Exp> % <Negate Exp>
        RULE_MULTEXP = 121, // <Mult Exp> ::= <Negate Exp>
        RULE_NEGATEEXP_MINUS = 122, // <Negate Exp> ::= - <Value>
        RULE_NEGATEEXP = 123, // <Negate Exp> ::= <Value>
        RULE_VALUE_INTEGER = 124, // <Value> ::= Integer
        RULE_VALUE = 125, // <Value> ::= <Label>
        RULE_VALUE_LPARAN_RPARAN = 126 // <Value> ::= ( <Expression> )
    } ;
}