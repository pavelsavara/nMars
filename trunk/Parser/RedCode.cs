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
        SYMBOL_NUM = 5, // #
        SYMBOL_DOLLAR = 6, // $
        SYMBOL_PERCENT = 7, // %
        SYMBOL_LPARAN = 8, // (
        SYMBOL_RPARAN = 9, // )
        SYMBOL_TIMES = 10, // *
        SYMBOL_COMMA = 11, // ,
        SYMBOL_DOT = 12, // .
        SYMBOL_DIV = 13, // /
        SYMBOL_AT = 14, // @
        SYMBOL_LBRACE = 15, // {
        SYMBOL_RBRACE = 16, // }
        SYMBOL_PLUS = 17, // +
        SYMBOL_LT = 18, // <
        SYMBOL_GT = 19, // >
        SYMBOL_A = 20, // A
        SYMBOL_AB = 21, // AB
        SYMBOL_ADD = 22, // Add
        SYMBOL_B = 23, // B
        SYMBOL_BA = 24, // BA
        SYMBOL_CMP = 25, // Cmp
        SYMBOL_COMMENT = 26, // Comment
        SYMBOL_DAT = 27, // Dat
        SYMBOL_DIV2 = 28, // Div
        SYMBOL_DJN = 29, // Djn
        SYMBOL_END = 30, // End
        SYMBOL_EQU = 31, // Equ
        SYMBOL_F = 32, // F
        SYMBOL_FOR = 33, // for
        SYMBOL_I = 34, // I
        SYMBOL_INTEGER = 35, // Integer
        SYMBOL_JMN = 36, // Jmn
        SYMBOL_JMP = 37, // Jmp
        SYMBOL_JMZ = 38, // Jmz
        SYMBOL_LABEL = 39, // Label
        SYMBOL_LDP = 40, // Ldp
        SYMBOL_LINE = 41, // Line
        SYMBOL_MOD = 42, // Mod
        SYMBOL_MOV = 43, // Mov
        SYMBOL_MUL = 44, // Mul
        SYMBOL_NEWLINE = 45, // NewLine
        SYMBOL_NOP = 46, // Nop
        SYMBOL_ORG = 47, // Org
        SYMBOL_PIN = 48, // Pin
        SYMBOL_ROF = 49, // rof
        SYMBOL_SEQ = 50, // Seq
        SYMBOL_SLT = 51, // Slt
        SYMBOL_SNE = 52, // Sne
        SYMBOL_SPL = 53, // Spl
        SYMBOL_STP = 54, // Stp
        SYMBOL_SUB = 55, // Sub
        SYMBOL_X = 56, // X
        SYMBOL_COMMENTLINE2 = 57, // <Comment Line>
        SYMBOL_END2 = 58, // <End>
        SYMBOL_EQU2 = 59, // <Equ>
        SYMBOL_EXPRESSION = 60, // <Expression>
        SYMBOL_FORIN = 61, // <ForIn>
        SYMBOL_FORNL = 62, // <ForNl>
        SYMBOL_MODE = 63, // <Mode>
        SYMBOL_MODIFIER = 64, // <Modifier>
        SYMBOL_MULTEXP = 65, // <Mult Exp>
        SYMBOL_NEGATEEXP = 66, // <Negate Exp>
        SYMBOL_NL = 67, // <nl>
        SYMBOL_NLOPT = 68, // <nl Opt>
        SYMBOL_OPERATION = 69, // <Operation>
        SYMBOL_OPERATION0 = 70, // <Operation0>
        SYMBOL_OPERATION1 = 71, // <Operation1>
        SYMBOL_OPERATION2 = 72, // <Operation2>
        SYMBOL_OPERATOR0 = 73, // <Operator0>
        SYMBOL_OPERATOR1 = 74, // <Operator1>
        SYMBOL_OPERATOR2 = 75, // <Operator2>
        SYMBOL_ORG2 = 76, // <Org>
        SYMBOL_PARAMETER = 77, // <Parameter>
        SYMBOL_PIN2 = 78, // <Pin>
        SYMBOL_ROFNL = 79, // <RofNl>
        SYMBOL_START = 80, // <Start>
        SYMBOL_STATEMENT = 81, // <Statement>
        SYMBOL_STATEMENTNL = 82, // <StatementNl>
        SYMBOL_STATEMENTS = 83, // <Statements>
        SYMBOL_STATEMENTSF = 84, // <StatementsF>
        SYMBOL_VALUE = 85 // <Value>
    } ;

    internal enum RuleConstants : int
    {
        RULE_NL_NEWLINE = 0, // <nl> ::= NewLine <nl>
        RULE_NL_NEWLINE2 = 1, // <nl> ::= NewLine
        RULE_COMMENTLINE_COMMENT_LINE = 2, // <Comment Line> ::= Comment Line
        RULE_NLOPT_NEWLINE = 3, // <nl Opt> ::= NewLine <nl Opt>
        RULE_NLOPT = 4, // <nl Opt> ::= 
        RULE_START = 5, // <Start> ::= <nl Opt> <Statements>
        RULE_START2 = 6, // <Start> ::= <nl Opt> <Statements> <End>
        RULE_END_END = 7, // <End> ::= End
        RULE_END_END2 = 8, // <End> ::= End <nl>
        RULE_END_END_LABEL            =  9, // <End> ::= End Label
        RULE_END_END_LABEL2           = 10, // <End> ::= End Label <nl>
        RULE_STATEMENTS               = 11, // <Statements> ::= <StatementNl>
        RULE_STATEMENTS2              = 12, // <Statements> ::= <StatementNl> <Statements>
        RULE_STATEMENTS3              = 13, // <Statements> ::= <ForNl> <StatementsF> <RofNl>
        RULE_STATEMENTS4              = 14, // <Statements> ::= <ForNl> <StatementsF> <RofNl> <Statements>
        RULE_STATEMENTSF              = 15, // <StatementsF> ::= <StatementNl>
        RULE_STATEMENTSF2             = 16, // <StatementsF> ::= <StatementNl> <StatementsF>
        RULE_STATEMENTNL              = 17, // <StatementNl> ::= <Statement> <Comment Line>
        RULE_STATEMENTNL2             = 18, // <StatementNl> ::= <Statement> <nl>
        RULE_FORNL                    = 19, // <ForNl> ::= <ForIn> <nl>
        RULE_FORNL2                   = 20, // <ForNl> ::= <ForIn> <Comment Line>
        RULE_FORIN_FOR                = 21, // <ForIn> ::= for <Expression>
        RULE_FORIN_LABEL_FOR          = 22, // <ForIn> ::= Label for <Expression>
        RULE_ROFNL_ROF                = 23, // <RofNl> ::= rof <nl>
        RULE_ROFNL_ROF2               = 24, // <RofNl> ::= rof <Comment Line>
        RULE_STATEMENT                = 25, // <Statement> ::= <Operation>
        RULE_STATEMENT_LABEL          = 26, // <Statement> ::= Label <Operation>
        RULE_STATEMENT2               = 27, // <Statement> ::= <Org>
        RULE_STATEMENT3               = 28, // <Statement> ::= <Equ>
        RULE_STATEMENT4               = 29, // <Statement> ::= <Pin>
        RULE_OPERATION                = 30, // <Operation> ::= <Operation0>
        RULE_OPERATION2               = 31, // <Operation> ::= <Operation1>
        RULE_OPERATION3               = 32, // <Operation> ::= <Operation2>
        RULE_OPERATION0               = 33, // <Operation0> ::= <Operator0>
        RULE_OPERATION0_COMMA         = 34, // <Operation0> ::= <Operator0> <Parameter> , <Parameter>
        RULE_OPERATION0_DOT_COMMA     = 35, // <Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION1               = 36, // <Operation1> ::= <Operator1> <Parameter>
        RULE_OPERATION1_DOT           = 37, // <Operation1> ::= <Operator1> . <Modifier> <Parameter>
        RULE_OPERATION1_COMMA         = 38, // <Operation1> ::= <Operator1> <Parameter> , <Parameter>
        RULE_OPERATION1_DOT_COMMA     = 39, // <Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION2_COMMA         = 40, // <Operation2> ::= <Operator2> <Parameter> , <Parameter>
        RULE_OPERATION2_DOT_COMMA     = 41, // <Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
        RULE_PARAMETER                = 42, // <Parameter> ::= <Expression>
        RULE_PARAMETER2               = 43, // <Parameter> ::= <Mode> <Expression>
        RULE_MODE_NUM                 = 44, // <Mode> ::= #
        RULE_MODE_DOLLAR              = 45, // <Mode> ::= $
        RULE_MODE_AT                  = 46, // <Mode> ::= @
        RULE_MODE_LT                  = 47, // <Mode> ::= <
        RULE_MODE_GT                  = 48, // <Mode> ::= >
        RULE_MODE_LBRACE              = 49, // <Mode> ::= {
        RULE_MODE_RBRACE              = 50, // <Mode> ::= }
        RULE_MODE_TIMES               = 51, // <Mode> ::= *
        RULE_OPERATOR0_NOP            = 52, // <Operator0> ::= Nop
        RULE_OPERATOR1_JMP            = 53, // <Operator1> ::= Jmp
        RULE_OPERATOR1_SPL            = 54, // <Operator1> ::= Spl
        RULE_OPERATOR1_DAT            = 55, // <Operator1> ::= Dat
        RULE_OPERATOR2_MOV            = 56, // <Operator2> ::= Mov
        RULE_OPERATOR2_ADD            = 57, // <Operator2> ::= Add
        RULE_OPERATOR2_SUB            = 58, // <Operator2> ::= Sub
        RULE_OPERATOR2_MUL            = 59, // <Operator2> ::= Mul
        RULE_OPERATOR2_DIV            = 60, // <Operator2> ::= Div
        RULE_OPERATOR2_MOD            = 61, // <Operator2> ::= Mod
        RULE_OPERATOR2_JMZ            = 62, // <Operator2> ::= Jmz
        RULE_OPERATOR2_JMN            = 63, // <Operator2> ::= Jmn
        RULE_OPERATOR2_DJN            = 64, // <Operator2> ::= Djn
        RULE_OPERATOR2_SLT            = 65, // <Operator2> ::= Slt
        RULE_OPERATOR2_SNE            = 66, // <Operator2> ::= Sne
        RULE_OPERATOR2_LDP            = 67, // <Operator2> ::= Ldp
        RULE_OPERATOR2_STP            = 68, // <Operator2> ::= Stp
        RULE_OPERATOR2_CMP            = 69, // <Operator2> ::= Cmp
        RULE_OPERATOR2_SEQ            = 70, // <Operator2> ::= Seq
        RULE_ORG_ORG_LABEL            = 71, // <Org> ::= Org Label
        RULE_PIN_PIN                  = 72, // <Pin> ::= Pin <Expression>
        RULE_EQU_LABEL_EQU            = 73, // <Equ> ::= Label Equ <Expression>
        RULE_MODIFIER_I               = 74, // <Modifier> ::= I
        RULE_MODIFIER_A               = 75, // <Modifier> ::= A
        RULE_MODIFIER_B               = 76, // <Modifier> ::= B
        RULE_MODIFIER_AB              = 77, // <Modifier> ::= AB
        RULE_MODIFIER_BA              = 78, // <Modifier> ::= BA
        RULE_MODIFIER_F               = 79, // <Modifier> ::= F
        RULE_MODIFIER_X               = 80, // <Modifier> ::= X
        RULE_EXPRESSION_PLUS          = 81, // <Expression> ::= <Expression> + <Mult Exp>
        RULE_EXPRESSION_MINUS         = 82, // <Expression> ::= <Expression> - <Mult Exp>
        RULE_EXPRESSION               = 83, // <Expression> ::= <Mult Exp>
        RULE_MULTEXP_TIMES            = 84, // <Mult Exp> ::= <Mult Exp> * <Negate Exp>
        RULE_MULTEXP_DIV              = 85, // <Mult Exp> ::= <Mult Exp> / <Negate Exp>
        RULE_MULTEXP_PERCENT          = 86, // <Mult Exp> ::= <Mult Exp> % <Negate Exp>
        RULE_MULTEXP                  = 87, // <Mult Exp> ::= <Negate Exp>
        RULE_NEGATEEXP_MINUS          = 88, // <Negate Exp> ::= - <Value>
        RULE_NEGATEEXP                = 89, // <Negate Exp> ::= <Value>
        RULE_VALUE_INTEGER            = 90, // <Value> ::= Integer
        RULE_VALUE_LABEL              = 91, // <Value> ::= Label
        RULE_VALUE_LPARAN_RPARAN      = 92  // <Value> ::= ( <Expression> )
    } ;
}