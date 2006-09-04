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
        SYMBOL_AMP                   =  8, // &
        SYMBOL_LPARAN                =  9, // (
        SYMBOL_RPARAN                = 10, // )
        SYMBOL_TIMES                 = 11, // *
        SYMBOL_COMMA                 = 12, // ,
        SYMBOL_DOT                   = 13, // .
        SYMBOL_DIV                   = 14, // /
        SYMBOL_AT                    = 15, // @
        SYMBOL_CARET                 = 16, // ^
        SYMBOL_LBRACE                = 17, // {
        SYMBOL_PIPE                  = 18, // |
        SYMBOL_RBRACE                = 19, // }
        SYMBOL_PLUS                  = 20, // +
        SYMBOL_LT                    = 21, // <
        SYMBOL_LTLT                  = 22, // <<
        SYMBOL_GT                    = 23, // >
        SYMBOL_GTGT                  = 24, // >>
        SYMBOL_A                     = 25, // A
        SYMBOL_AB                    = 26, // AB
        SYMBOL_ADD                   = 27, // Add
        SYMBOL_B                     = 28, // B
        SYMBOL_BA                    = 29, // BA
        SYMBOL_CMP                   = 30, // Cmp
        SYMBOL_COMMENT               = 31, // Comment
        SYMBOL_DAT                   = 32, // Dat
        SYMBOL_DIV2                  = 33, // Div
        SYMBOL_DJN                   = 34, // Djn
        SYMBOL_END                   = 35, // End
        SYMBOL_EQU                   = 36, // Equ
        SYMBOL_F                     = 37, // F
        SYMBOL_FOR                   = 38, // for
        SYMBOL_I                     = 39, // I
        SYMBOL_INTEGER               = 40, // Integer
        SYMBOL_JMN                   = 41, // Jmn
        SYMBOL_JMP                   = 42, // Jmp
        SYMBOL_JMZ                   = 43, // Jmz
        SYMBOL_LABEL                 = 44, // Label
        SYMBOL_LDP                   = 45, // Ldp
        SYMBOL_LINE                  = 46, // Line
        SYMBOL_MOD                   = 47, // Mod
        SYMBOL_MOV                   = 48, // Mov
        SYMBOL_MUL                   = 49, // Mul
        SYMBOL_NEWLINE               = 50, // NewLine
        SYMBOL_NOP                   = 51, // Nop
        SYMBOL_ORG                   = 52, // Org
        SYMBOL_PIN                   = 53, // Pin
        SYMBOL_ROF                   = 54, // rof
        SYMBOL_SEQ                   = 55, // Seq
        SYMBOL_SLT                   = 56, // Slt
        SYMBOL_SNE                   = 57, // Sne
        SYMBOL_SPL                   = 58, // Spl
        SYMBOL_STP                   = 59, // Stp
        SYMBOL_SUB                   = 60, // Sub
        SYMBOL_X                     = 61, // X
        SYMBOL_ADDEXP                = 62, // <Add Exp>
        SYMBOL_ALLSTATEMENTS         = 63, // <AllStatements>
        SYMBOL_ALLSTATEMENTSOPTIONAL = 64, // <AllStatementsOptional>
        SYMBOL_ANDEXP                = 65, // <And Exp>
        SYMBOL_ENDOPTIONAL           = 66, // <EndOptional>
        SYMBOL_EOL                   = 67, // <eol>
        SYMBOL_EOLOPTIONAL           = 68, // <eolOptional>
        SYMBOL_EOLSINGLE             = 69, // <eolSingle>
        SYMBOL_EQU2                  = 70, // <Equ>
        SYMBOL_EXPRESSION            = 71, // <Expression>
        SYMBOL_FOR2                  = 72, // <For>
        SYMBOL_LABELS                = 73, // <Labels>
        SYMBOL_LABELSOPTIONAL        = 74, // <LabelsOptional>
        SYMBOL_MODE                  = 75, // <Mode>
        SYMBOL_MODIFIER              = 76, // <Modifier>
        SYMBOL_MULTEXP               = 77, // <Mult Exp>
        SYMBOL_NEGATEEXP             = 78, // <Negate Exp>
        SYMBOL_OPERATION             = 79, // <Operation>
        SYMBOL_OPERATION0            = 80, // <Operation0>
        SYMBOL_OPERATION1            = 81, // <Operation1>
        SYMBOL_OPERATION2            = 82, // <Operation2>
        SYMBOL_OPERATOR0             = 83, // <Operator0>
        SYMBOL_OPERATOR1             = 84, // <Operator1>
        SYMBOL_OPERATOR2             = 85, // <Operator2>
        SYMBOL_ORG2                  = 86, // <Org>
        SYMBOL_PARAMETER             = 87, // <Parameter>
        SYMBOL_PIN2                  = 88, // <Pin>
        SYMBOL_SHIFTEXP              = 89, // <Shift Exp>
        SYMBOL_START                 = 90, // <Start>
        SYMBOL_STATEMENT             = 91, // <Statement>
        SYMBOL_VALUE                 = 92, // <Value>
        SYMBOL_XOREXP                = 93  // <Xor Exp>
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
        RULE_FOR_FOR_ROF            = 15, // <For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof
        RULE_ALLSTATEMENTSOPTIONAL  = 16, // <AllStatementsOptional> ::= <AllStatements> <eol>
        RULE_ALLSTATEMENTSOPTIONAL2 = 17, // <AllStatementsOptional> ::= 
        RULE_STATEMENT              = 18, // <Statement> ::= <Pin>
        RULE_STATEMENT2             = 19, // <Statement> ::= <Org>
        RULE_STATEMENT3             = 20, // <Statement> ::= <Equ>
        RULE_STATEMENT4             = 21, // <Statement> ::= <LabelsOptional> <Operation>
        RULE_STATEMENT5             = 22, // <Statement> ::= <Labels> <eol> <Operation>
        RULE_PIN_PIN                = 23, // <Pin> ::= Pin <Expression>
        RULE_ORG_ORG_LABEL          = 24, // <Org> ::= Org Label
        RULE_EQU_EQU                = 25, // <Equ> ::= <Labels> Equ <Expression>
        RULE_EQU_EQU2               = 26, // <Equ> ::= <Labels> <eol> Equ <Expression>
        RULE_LABELSOPTIONAL         = 27, // <LabelsOptional> ::= <Labels>
        RULE_LABELSOPTIONAL2        = 28, // <LabelsOptional> ::= 
        RULE_LABELS_LABEL           = 29, // <Labels> ::= Label
        RULE_LABELS_LABEL2          = 30, // <Labels> ::= <Labels> <eol> Label
        RULE_LABELS_LABEL3          =  31, // <Labels> ::= <Labels> Label
        RULE_OPERATION              =  32, // <Operation> ::= <Operation0>
        RULE_OPERATION2             =  33, // <Operation> ::= <Operation1>
        RULE_OPERATION3             =  34, // <Operation> ::= <Operation2>
        RULE_OPERATION0             =  35, // <Operation0> ::= <Operator0>
        RULE_OPERATION0_COMMA       =  36, // <Operation0> ::= <Operator0> <Parameter> , <Parameter>
        RULE_OPERATION0_DOT_COMMA   =  37, // <Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION1             =  38, // <Operation1> ::= <Operator1> <Parameter>
        RULE_OPERATION1_DOT         =  39, // <Operation1> ::= <Operator1> . <Modifier> <Parameter>
        RULE_OPERATION1_COMMA       =  40, // <Operation1> ::= <Operator1> <Parameter> , <Parameter>
        RULE_OPERATION1_DOT_COMMA   =  41, // <Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION2_COMMA       =  42, // <Operation2> ::= <Operator2> <Parameter> , <Parameter>
        RULE_OPERATION2_DOT_COMMA   =  43, // <Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
        RULE_PARAMETER              =  44, // <Parameter> ::= <Expression>
        RULE_PARAMETER2             =  45, // <Parameter> ::= <Mode> <Expression>
        RULE_MODE_NUM               =  46, // <Mode> ::= #
        RULE_MODE_DOLLAR            =  47, // <Mode> ::= $
        RULE_MODE_AT                =  48, // <Mode> ::= @
        RULE_MODE_LT                =  49, // <Mode> ::= <
        RULE_MODE_GT                =  50, // <Mode> ::= >
        RULE_MODE_LBRACE            =  51, // <Mode> ::= {
        RULE_MODE_RBRACE            =  52, // <Mode> ::= }
        RULE_MODE_TIMES             =  53, // <Mode> ::= *
        RULE_OPERATOR0_NOP          =  54, // <Operator0> ::= Nop
        RULE_OPERATOR1_JMP          =  55, // <Operator1> ::= Jmp
        RULE_OPERATOR1_SPL          =  56, // <Operator1> ::= Spl
        RULE_OPERATOR1_DAT          =  57, // <Operator1> ::= Dat
        RULE_OPERATOR2_MOV          =  58, // <Operator2> ::= Mov
        RULE_OPERATOR2_ADD          =  59, // <Operator2> ::= Add
        RULE_OPERATOR2_SUB          =  60, // <Operator2> ::= Sub
        RULE_OPERATOR2_MUL          =  61, // <Operator2> ::= Mul
        RULE_OPERATOR2_DIV          =  62, // <Operator2> ::= Div
        RULE_OPERATOR2_MOD          =  63, // <Operator2> ::= Mod
        RULE_OPERATOR2_JMZ          =  64, // <Operator2> ::= Jmz
        RULE_OPERATOR2_JMN          =  65, // <Operator2> ::= Jmn
        RULE_OPERATOR2_DJN          =  66, // <Operator2> ::= Djn
        RULE_OPERATOR2_SLT          =  67, // <Operator2> ::= Slt
        RULE_OPERATOR2_SNE          =  68, // <Operator2> ::= Sne
        RULE_OPERATOR2_LDP          =  69, // <Operator2> ::= Ldp
        RULE_OPERATOR2_STP          =  70, // <Operator2> ::= Stp
        RULE_OPERATOR2_CMP          =  71, // <Operator2> ::= Cmp
        RULE_OPERATOR2_SEQ          =  72, // <Operator2> ::= Seq
        RULE_MODIFIER_I             =  73, // <Modifier> ::= I
        RULE_MODIFIER_A             =  74, // <Modifier> ::= A
        RULE_MODIFIER_B             =  75, // <Modifier> ::= B
        RULE_MODIFIER_AB            =  76, // <Modifier> ::= AB
        RULE_MODIFIER_BA            =  77, // <Modifier> ::= BA
        RULE_MODIFIER_F             =  78, // <Modifier> ::= F
        RULE_MODIFIER_X             =  79, // <Modifier> ::= X
        RULE_EXPRESSION_PIPE        =  80, // <Expression> ::= <Expression> | <Xor Exp>
        RULE_EXPRESSION             =  81, // <Expression> ::= <Xor Exp>
        RULE_XOREXP_CARET           =  82, // <Xor Exp> ::= <Xor Exp> ^ <And Exp>
        RULE_XOREXP                 =  83, // <Xor Exp> ::= <And Exp>
        RULE_ANDEXP_AMP             =  84, // <And Exp> ::= <And Exp> & <Shift Exp>
        RULE_ANDEXP                 =  85, // <And Exp> ::= <Shift Exp>
        RULE_SHIFTEXP_LTLT          =  86, // <Shift Exp> ::= <Shift Exp> << <Add Exp>
        RULE_SHIFTEXP_GTGT          =  87, // <Shift Exp> ::= <Shift Exp> >> <Add Exp>
        RULE_SHIFTEXP               =  88, // <Shift Exp> ::= <Add Exp>
        RULE_ADDEXP_PLUS            =  89, // <Add Exp> ::= <Add Exp> + <Mult Exp>
        RULE_ADDEXP_MINUS           =  90, // <Add Exp> ::= <Add Exp> - <Mult Exp>
        RULE_ADDEXP                 =  91, // <Add Exp> ::= <Mult Exp>
        RULE_MULTEXP_TIMES          =  92, // <Mult Exp> ::= <Mult Exp> * <Negate Exp>
        RULE_MULTEXP_DIV            =  93, // <Mult Exp> ::= <Mult Exp> / <Negate Exp>
        RULE_MULTEXP_PERCENT        =  94, // <Mult Exp> ::= <Mult Exp> % <Negate Exp>
        RULE_MULTEXP                =  95, // <Mult Exp> ::= <Negate Exp>
        RULE_NEGATEEXP_MINUS        =  96, // <Negate Exp> ::= - <Value>
        RULE_NEGATEEXP              =  97, // <Negate Exp> ::= <Value>
        RULE_VALUE_INTEGER          =  98, // <Value> ::= Integer
        RULE_VALUE_LABEL            =  99, // <Value> ::= Label
        RULE_VALUE_LPARAN_RPARAN    = 100  // <Value> ::= ( <Expression> )
    } ;
}