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
        SYMBOL_FOR          = 33, // for
        SYMBOL_I            = 34, // I
        SYMBOL_INTEGER      = 35, // Integer
        SYMBOL_JMN          = 36, // Jmn
        SYMBOL_JMP          = 37, // Jmp
        SYMBOL_JMZ          = 38, // Jmz
        SYMBOL_LABEL        = 39, // Label
        SYMBOL_LDP          = 40, // Ldp
        SYMBOL_LINE         = 41, // Line
        SYMBOL_MOD          = 42, // Mod
        SYMBOL_MOV          = 43, // Mov
        SYMBOL_MUL          = 44, // Mul
        SYMBOL_NEWLINE      = 45, // NewLine
        SYMBOL_NOP          = 46, // Nop
        SYMBOL_ORG          = 47, // Org
        SYMBOL_ROF          = 48, // rof
        SYMBOL_SEQ          = 49, // Seq
        SYMBOL_SLT          = 50, // Slt
        SYMBOL_SNE          = 51, // Sne
        SYMBOL_SPL          = 52, // Spl
        SYMBOL_STP          = 53, // Stp
        SYMBOL_SUB          = 54, // Sub
        SYMBOL_X            = 55, // X
        SYMBOL_COMMENTLINE2 = 56, // <Comment Line>
        SYMBOL_END2         = 57, // <End>
        SYMBOL_EQU2         = 58, // <Equ>
        SYMBOL_EXPRESSION   = 59, // <Expression>
        SYMBOL_FORIN        = 60, // <ForIn>
        SYMBOL_FORNL        = 61, // <ForNl>
        SYMBOL_MODE         = 62, // <Mode>
        SYMBOL_MODIFIER     = 63, // <Modifier>
        SYMBOL_MULTEXP      = 64, // <Mult Exp>
        SYMBOL_NEGATEEXP    = 65, // <Negate Exp>
        SYMBOL_NL           = 66, // <nl>
        SYMBOL_NLOPT        = 67, // <nl Opt>
        SYMBOL_OPERATION    = 68, // <Operation>
        SYMBOL_OPERATION0   = 69, // <Operation0>
        SYMBOL_OPERATION1   = 70, // <Operation1>
        SYMBOL_OPERATION2   = 71, // <Operation2>
        SYMBOL_OPERATOR0    = 72, // <Operator0>
        SYMBOL_OPERATOR1    = 73, // <Operator1>
        SYMBOL_OPERATOR2    = 74, // <Operator2>
        SYMBOL_ORG2         = 75, // <Org>
        SYMBOL_PARAMETER    = 76, // <Parameter>
        SYMBOL_ROFNL        = 77, // <RofNl>
        SYMBOL_START        = 78, // <Start>
        SYMBOL_STATEMENT    = 79, // <Statement>
        SYMBOL_STATEMENTNL  = 80, // <StatementNl>
        SYMBOL_STATEMENTS   = 81, // <Statements>
        SYMBOL_STATEMENTSF  = 82, // <StatementsF>
        SYMBOL_VALUE        = 83  // <Value>
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
        RULE_STATEMENTS               =  9, // <Statements> ::= <StatementNl>
        RULE_STATEMENTS2              = 10, // <Statements> ::= <StatementNl> <Statements>
        RULE_STATEMENTS3              = 11, // <Statements> ::= <ForNl> <StatementsF> <RofNl>
        RULE_STATEMENTS4              = 12, // <Statements> ::= <ForNl> <StatementsF> <RofNl> <Statements>
        RULE_STATEMENTSF              = 13, // <StatementsF> ::= <StatementNl>
        RULE_STATEMENTSF2             = 14, // <StatementsF> ::= <StatementNl> <StatementsF>
        RULE_STATEMENTNL              = 15, // <StatementNl> ::= <Statement> <Comment Line>
        RULE_STATEMENTNL2             = 16, // <StatementNl> ::= <Statement> <nl>
        RULE_FORNL                    = 17, // <ForNl> ::= <ForIn> <nl>
        RULE_FORNL2                   = 18, // <ForNl> ::= <ForIn> <Comment Line>
        RULE_FORIN_FOR                = 19, // <ForIn> ::= for <Expression>
        RULE_FORIN_LABEL_FOR          = 20, // <ForIn> ::= Label for <Expression>
        RULE_ROFNL_ROF                = 21, // <RofNl> ::= rof <nl>
        RULE_ROFNL_ROF2               = 22, // <RofNl> ::= rof <Comment Line>
        RULE_STATEMENT                = 23, // <Statement> ::= <Operation>
        RULE_STATEMENT_LABEL          = 24, // <Statement> ::= Label <Operation>
        RULE_STATEMENT2               = 25, // <Statement> ::= <Org>
        RULE_STATEMENT3               = 26, // <Statement> ::= <Equ>
        RULE_OPERATION                = 27, // <Operation> ::= <Operation0>
        RULE_OPERATION2               = 28, // <Operation> ::= <Operation1>
        RULE_OPERATION3               = 29, // <Operation> ::= <Operation2>
        RULE_OPERATION0               = 30, // <Operation0> ::= <Operator0>
        RULE_OPERATION0_COMMA         = 31, // <Operation0> ::= <Operator0> <Parameter> , <Parameter>
        RULE_OPERATION0_DOT_COMMA     = 32, // <Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION1               = 33, // <Operation1> ::= <Operator1> <Parameter>
        RULE_OPERATION1_DOT           = 34, // <Operation1> ::= <Operator1> . <Modifier> <Parameter>
        RULE_OPERATION1_COMMA         = 35, // <Operation1> ::= <Operator1> <Parameter> , <Parameter>
        RULE_OPERATION1_DOT_COMMA     = 36, // <Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION2_COMMA         = 37, // <Operation2> ::= <Operator2> <Parameter> , <Parameter>
        RULE_OPERATION2_DOT_COMMA     = 38, // <Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
        RULE_PARAMETER                = 39, // <Parameter> ::= <Expression>
        RULE_PARAMETER2               = 40, // <Parameter> ::= <Mode> <Expression>
        RULE_MODE_NUM                 = 41, // <Mode> ::= #
        RULE_MODE_DOLLAR              = 42, // <Mode> ::= $
        RULE_MODE_AT                  = 43, // <Mode> ::= @
        RULE_MODE_LT                  = 44, // <Mode> ::= <
        RULE_MODE_GT                  = 45, // <Mode> ::= >
        RULE_MODE_LBRACE              = 46, // <Mode> ::= {
        RULE_MODE_RBRACE              = 47, // <Mode> ::= }
        RULE_MODE_TIMES               = 48, // <Mode> ::= *
        RULE_OPERATOR0_NOP            = 49, // <Operator0> ::= Nop
        RULE_OPERATOR1_JMP            = 50, // <Operator1> ::= Jmp
        RULE_OPERATOR2_DAT            = 51, // <Operator2> ::= Dat
        RULE_OPERATOR2_SPL            = 52, // <Operator2> ::= Spl
        RULE_OPERATOR2_MOV            = 53, // <Operator2> ::= Mov
        RULE_OPERATOR2_ADD            = 54, // <Operator2> ::= Add
        RULE_OPERATOR2_SUB            = 55, // <Operator2> ::= Sub
        RULE_OPERATOR2_MUL            = 56, // <Operator2> ::= Mul
        RULE_OPERATOR2_DIV            = 57, // <Operator2> ::= Div
        RULE_OPERATOR2_MOD            = 58, // <Operator2> ::= Mod
        RULE_OPERATOR2_JMZ            = 59, // <Operator2> ::= Jmz
        RULE_OPERATOR2_JMN            = 60, // <Operator2> ::= Jmn
        RULE_OPERATOR2_DJN            = 61, // <Operator2> ::= Djn
        RULE_OPERATOR2_SLT            = 62, // <Operator2> ::= Slt
        RULE_OPERATOR2_SNE            = 63, // <Operator2> ::= Sne
        RULE_OPERATOR2_LDP            = 64, // <Operator2> ::= Ldp
        RULE_OPERATOR2_STP            = 65, // <Operator2> ::= Stp
        RULE_OPERATOR2_CMP            = 66, // <Operator2> ::= Cmp
        RULE_OPERATOR2_SEQ            = 67, // <Operator2> ::= Seq
        RULE_ORG_ORG_LABEL            = 68, // <Org> ::= Org Label
        RULE_EQU_LABEL_EQU            = 69, // <Equ> ::= Label Equ <Expression>
        RULE_MODIFIER_I               = 70, // <Modifier> ::= I
        RULE_MODIFIER_A               = 71, // <Modifier> ::= A
        RULE_MODIFIER_B               = 72, // <Modifier> ::= B
        RULE_MODIFIER_AB              = 73, // <Modifier> ::= AB
        RULE_MODIFIER_BA              = 74, // <Modifier> ::= BA
        RULE_MODIFIER_F               = 75, // <Modifier> ::= F
        RULE_MODIFIER_X               = 76, // <Modifier> ::= X
        RULE_EXPRESSION_PLUS          = 77, // <Expression> ::= <Expression> + <Mult Exp>
        RULE_EXPRESSION_MINUS         = 78, // <Expression> ::= <Expression> - <Mult Exp>
        RULE_EXPRESSION               = 79, // <Expression> ::= <Mult Exp>
        RULE_MULTEXP_TIMES            = 80, // <Mult Exp> ::= <Mult Exp> * <Negate Exp>
        RULE_MULTEXP_DIV              = 81, // <Mult Exp> ::= <Mult Exp> / <Negate Exp>
        RULE_MULTEXP_PERCENT          = 82, // <Mult Exp> ::= <Mult Exp> % <Negate Exp>
        RULE_MULTEXP                  = 83, // <Mult Exp> ::= <Negate Exp>
        RULE_NEGATEEXP_MINUS          = 84, // <Negate Exp> ::= - <Value>
        RULE_NEGATEEXP                = 85, // <Negate Exp> ::= <Value>
        RULE_VALUE_INTEGER            = 86, // <Value> ::= Integer
        RULE_VALUE_LABEL              = 87, // <Value> ::= Label
        RULE_VALUE_LPARAN_RPARAN      = 88  // <Value> ::= ( <Expression> )
    } ;
}