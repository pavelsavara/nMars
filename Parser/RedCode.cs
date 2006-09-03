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
        SYMBOL_ALLSTATEMENTS           = 57, // <AllStatements>
        SYMBOL_ENDOPTIONAL             = 58, // <EndOptional>
        SYMBOL_EOL                     = 59, // <eol>
        SYMBOL_EOLOPTIONAL             = 60, // <eolOptional>
        SYMBOL_EOLSINGLE               = 61, // <eolSingle>
        SYMBOL_EQU2                   = 62, // <Equ>
        SYMBOL_EXPRESSION             = 63, // <Expression>
        SYMBOL_FOR2                   = 64, // <For>
        SYMBOL_INNERSTATEMENTS        = 65, // <InnerStatements>
        SYMBOL_INNERSTATEMENTSOPTIONAL = 66, // <InnerStatementsOptional>
        SYMBOL_LABELS                  = 67, // <Labels>
        SYMBOL_LABELSOPTIONAL          = 68, // <LabelsOptional>
        SYMBOL_MODE                    = 69, // <Mode>
        SYMBOL_MODIFIER                = 70, // <Modifier>
        SYMBOL_MULTEXP                 = 71, // <Mult Exp>
        SYMBOL_NEGATEEXP               = 72, // <Negate Exp>
        SYMBOL_OPERATION               = 73, // <Operation>
        SYMBOL_OPERATION0              = 74, // <Operation0>
        SYMBOL_OPERATION1              = 75, // <Operation1>
        SYMBOL_OPERATION2              = 76, // <Operation2>
        SYMBOL_OPERATOR0               = 77, // <Operator0>
        SYMBOL_OPERATOR1               = 78, // <Operator1>
        SYMBOL_OPERATOR2               = 79, // <Operator2>
        SYMBOL_ORG2                    = 80, // <Org>
        SYMBOL_PARAMETER               = 81, // <Parameter>
        SYMBOL_PIN2                    = 82, // <Pin>
        SYMBOL_START                   = 83, // <Start>
        SYMBOL_STATEMENT               = 84, // <Statement>
        SYMBOL_VALUE                   = 85  // <Value>
    } ;

    internal enum RuleConstants : int
    {
        RULE_EOL                      =  0, // <eol> ::= <eolSingle>
        RULE_EOL2                     =  1, // <eol> ::= <eol> <eolSingle>
        RULE_EOLSINGLE_NEWLINE        =  2, // <eolSingle> ::= NewLine
        RULE_EOLSINGLE_COMMENT_LINE   =  3, // <eolSingle> ::= Comment Line
        RULE_EOLOPTIONAL              =  4, // <eolOptional> ::= <eol>
        RULE_EOLOPTIONAL2             =  5, // <eolOptional> ::= 
        RULE_START                    =  6, // <Start> ::= <eolOptional> <AllStatements> <EndOptional>
        RULE_ENDOPTIONAL_END          =  7, // <EndOptional> ::= <eol> End <eolOptional>
        RULE_ENDOPTIONAL_END_LABEL    =  8, // <EndOptional> ::= <eol> End Label <eolOptional>
        RULE_ENDOPTIONAL              =  9, // <EndOptional> ::= <eol>
        RULE_ENDOPTIONAL2             = 10, // <EndOptional> ::= 
        RULE_ALLSTATEMENTS            = 11, // <AllStatements> ::= <Statement>
        RULE_ALLSTATEMENTS2           = 12, // <AllStatements> ::= <For>
        RULE_ALLSTATEMENTS3           = 13, // <AllStatements> ::= <AllStatements> <eol> <Statement>
        RULE_ALLSTATEMENTS4           = 14, // <AllStatements> ::= <AllStatements> <eol> <For>
        RULE_FOR_FOR_ROF              = 15, // <For> ::= <LabelsOptional> for <Expression> <eol> <InnerStatementsOptional> rof
        RULE_INNERSTATEMENTSOPTIONAL  = 16, // <InnerStatementsOptional> ::= <InnerStatements> <eol>
        RULE_INNERSTATEMENTSOPTIONAL2 = 17, // <InnerStatementsOptional> ::= 
        RULE_INNERSTATEMENTS          = 18, // <InnerStatements> ::= <Statement>
        RULE_INNERSTATEMENTS2         = 19, // <InnerStatements> ::= <InnerStatements> <eol> <Statement>
        RULE_STATEMENT                = 20, // <Statement> ::= <Pin>
        RULE_STATEMENT2               = 21, // <Statement> ::= <Org>
        RULE_STATEMENT3               = 22, // <Statement> ::= <Equ>
        RULE_STATEMENT4               = 23, // <Statement> ::= <LabelsOptional> <Operation>
        RULE_STATEMENT5               = 24, // <Statement> ::= <Labels> <eol> <Operation>
        RULE_PIN_PIN                  = 25, // <Pin> ::= Pin <Expression>
        RULE_ORG_ORG_LABEL            = 26, // <Org> ::= Org Label
        RULE_EQU_EQU                  = 27, // <Equ> ::= <Labels> Equ <Expression>
        RULE_EQU_EQU2                 = 28, // <Equ> ::= <Labels> <eol> Equ <Expression>
        RULE_LABELSOPTIONAL           = 29, // <LabelsOptional> ::= <Labels>
        RULE_LABELSOPTIONAL2          = 30, // <LabelsOptional> ::= 
        RULE_LABELS_LABEL             = 31, // <Labels> ::= Label
        RULE_LABELS_LABEL2            = 32, // <Labels> ::= <Labels> <eol> Label
        RULE_OPERATION                = 33, // <Operation> ::= <Operation0>
        RULE_OPERATION2               = 34, // <Operation> ::= <Operation1>
        RULE_OPERATION3               = 35, // <Operation> ::= <Operation2>
        RULE_OPERATION0               = 36, // <Operation0> ::= <Operator0>
        RULE_OPERATION0_COMMA         = 37, // <Operation0> ::= <Operator0> <Parameter> , <Parameter>
        RULE_OPERATION0_DOT_COMMA     = 38, // <Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION1               = 39, // <Operation1> ::= <Operator1> <Parameter>
        RULE_OPERATION1_DOT           = 40, // <Operation1> ::= <Operator1> . <Modifier> <Parameter>
        RULE_OPERATION1_COMMA         = 41, // <Operation1> ::= <Operator1> <Parameter> , <Parameter>
        RULE_OPERATION1_DOT_COMMA     = 42, // <Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION2_COMMA         = 43, // <Operation2> ::= <Operator2> <Parameter> , <Parameter>
        RULE_OPERATION2_DOT_COMMA     = 44, // <Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
        RULE_PARAMETER                = 45, // <Parameter> ::= <Expression>
        RULE_PARAMETER2               = 46, // <Parameter> ::= <Mode> <Expression>
        RULE_MODE_NUM                 = 47, // <Mode> ::= #
        RULE_MODE_DOLLAR              = 48, // <Mode> ::= $
        RULE_MODE_AT                  = 49, // <Mode> ::= @
        RULE_MODE_LT                  = 50, // <Mode> ::= <
        RULE_MODE_GT                  = 51, // <Mode> ::= >
        RULE_MODE_LBRACE              = 52, // <Mode> ::= {
        RULE_MODE_RBRACE              = 53, // <Mode> ::= }
        RULE_MODE_TIMES               = 54, // <Mode> ::= *
        RULE_OPERATOR0_NOP            = 55, // <Operator0> ::= Nop
        RULE_OPERATOR1_JMP            = 56, // <Operator1> ::= Jmp
        RULE_OPERATOR1_SPL            = 57, // <Operator1> ::= Spl
        RULE_OPERATOR1_DAT            = 58, // <Operator1> ::= Dat
        RULE_OPERATOR2_MOV            = 59, // <Operator2> ::= Mov
        RULE_OPERATOR2_ADD            = 60, // <Operator2> ::= Add
        RULE_OPERATOR2_SUB            = 61, // <Operator2> ::= Sub
        RULE_OPERATOR2_MUL            = 62, // <Operator2> ::= Mul
        RULE_OPERATOR2_DIV            = 63, // <Operator2> ::= Div
        RULE_OPERATOR2_MOD            = 64, // <Operator2> ::= Mod
        RULE_OPERATOR2_JMZ            = 65, // <Operator2> ::= Jmz
        RULE_OPERATOR2_JMN            = 66, // <Operator2> ::= Jmn
        RULE_OPERATOR2_DJN            = 67, // <Operator2> ::= Djn
        RULE_OPERATOR2_SLT            = 68, // <Operator2> ::= Slt
        RULE_OPERATOR2_SNE            = 69, // <Operator2> ::= Sne
        RULE_OPERATOR2_LDP            = 70, // <Operator2> ::= Ldp
        RULE_OPERATOR2_STP            = 71, // <Operator2> ::= Stp
        RULE_OPERATOR2_CMP            = 72, // <Operator2> ::= Cmp
        RULE_OPERATOR2_SEQ            = 73, // <Operator2> ::= Seq
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