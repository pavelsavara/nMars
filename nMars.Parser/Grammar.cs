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
        public SymbolException(string message)
            : base(message)
        {
        }

        public SymbolException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected SymbolException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }

    [Serializable()]
    public class RuleException : Exception
    {
        public RuleException(string message)
            : base(message)
        {
        }

        public RuleException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected RuleException(SerializationInfo info, StreamingContext context)
            : base(info, context)
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
        SYMBOL_AMPAMPAMP = 11, // &&&
        SYMBOL_LPARAN = 12, // (
        SYMBOL_RPARAN = 13, // )
        SYMBOL_TIMES = 14, // *
        SYMBOL_COMMA = 15, // ,
        SYMBOL_DOT = 16, // .
        SYMBOL_DIV = 17, // /
        SYMBOL_COLON = 18, // :
        SYMBOL_QUESTION = 19, // ?
        SYMBOL_AT = 20, // @
        SYMBOL_ATASSERT              =  21, // @assert
        SYMBOL_CARET                 =  22, // ^
        SYMBOL_LBRACE                =  23, // {
        SYMBOL_PIPE                  =  24, // |
        SYMBOL_PIPEPIPE              =  25, // ||
        SYMBOL_RBRACE                =  26, // }
        SYMBOL_PLUS                  =  27, // +
        SYMBOL_LT                    =  28, // <
        SYMBOL_LTLT                  =  29, // <<
        SYMBOL_LTEQ                  =  30, // <=
        SYMBOL_LTGT                  =  31, // <>
        SYMBOL_EQEQ                  =  32, // ==
        SYMBOL_GT                    =  33, // >
        SYMBOL_GTEQ                  =  34, // >=
        SYMBOL_GTGT                  =  35, // >>
        SYMBOL_A                     =  36, // A
        SYMBOL_AB                    =  37, // AB
        SYMBOL_ADD                   =  38, // Add
        SYMBOL_B                     =  39, // B
        SYMBOL_BA                    =  40, // BA
        SYMBOL_CMP                   =  41, // Cmp
        SYMBOL_COMMENT               =  42, // Comment
        SYMBOL_DAT                   =  43, // Dat
        SYMBOL_DIV2                  =  44, // Div
        SYMBOL_DJN                   =  45, // Djn
        SYMBOL_END                   =  46, // End
        SYMBOL_EQU                   =  47, // Equ
        SYMBOL_F                     =  48, // F
        SYMBOL_FOR                   =  49, // for
        SYMBOL_I                     =  50, // I
        SYMBOL_INTEGER               =  51, // Integer
        SYMBOL_JMN                   =  52, // Jmn
        SYMBOL_JMP                   =  53, // Jmp
        SYMBOL_JMZ                   =  54, // Jmz
        SYMBOL_LABEL                 =  55, // Label
        SYMBOL_LDP                   =  56, // Ldp
        SYMBOL_LINE                  =  57, // Line
        SYMBOL_MOD                   =  58, // Mod
        SYMBOL_MOV                   =  59, // Mov
        SYMBOL_MUL                   =  60, // Mul
        SYMBOL_NEWLINE               =  61, // NewLine
        SYMBOL_NOP                   =  62, // Nop
        SYMBOL_ORG                   =  63, // Org
        SYMBOL_PIN                   =  64, // Pin
        SYMBOL_ROF                   =  65, // rof
        SYMBOL_SEQ                   =  66, // Seq
        SYMBOL_SLT                   =  67, // Slt
        SYMBOL_SNE                   =  68, // Sne
        SYMBOL_SPL                   =  69, // Spl
        SYMBOL_STP                   =  70, // Stp
        SYMBOL_SUB                   =  71, // Sub
        SYMBOL_X                     =  72, // X
        SYMBOL_ADDEXP                =  73, // <Add Exp>
        SYMBOL_ALLSTATEMENTS         =  74, // <AllStatements>
        SYMBOL_ALLSTATEMENTSOPTIONAL =  75, // <AllStatementsOptional>
        SYMBOL_ANDEXP                =  76, // <And Exp>
        SYMBOL_ASSERT                =  77, // <Assert>
        SYMBOL_BINANDEXP             =  78, // <BinAnd Exp>
        SYMBOL_BINOREXP              =  79, // <BinOr Exp>
        SYMBOL_BINXOREXP             =  80, // <BinXor Exp>
        SYMBOL_COMPAREEXP            =  81, // <Compare Exp>
        SYMBOL_ENDOPTIONAL           =  82, // <EndOptional>
        SYMBOL_EOL                   =  83, // <eol>
        SYMBOL_EOLOPTIONAL           =  84, // <eolOptional>
        SYMBOL_EOLSINGLE             =  85, // <eolSingle>
        SYMBOL_EQU2                  =  86, // <Equ>
        SYMBOL_EQUATEEXP             =  87, // <Equate Exp>
        SYMBOL_EXPRESSION            =  88, // <Expression>
        SYMBOL_EXPRESSIONOPTIONAL    =  89, // <ExpressionOptional>
        SYMBOL_FOR2                  =  90, // <For>
        SYMBOL_LABEL2                =  91, // <Label>
        SYMBOL_LABELS                =  92, // <Labels>
        SYMBOL_LABELSOPTIONAL        =  93, // <LabelsOptional>
        SYMBOL_MODE                  =  94, // <Mode>
        SYMBOL_MODEOPTIONAL          =  95, // <ModeOptional>
        SYMBOL_MODIFIER              =  96, // <Modifier>
        SYMBOL_MULTEXP               =  97, // <Mult Exp>
        SYMBOL_NEGATEEXP             =  98, // <Negate Exp>
        SYMBOL_OPERATION             =  99, // <Operation>
        SYMBOL_OPERATION0            = 100, // <Operation0>
        SYMBOL_OPERATION1            = 101, // <Operation1>
        SYMBOL_OPERATION2            = 102, // <Operation2>
        SYMBOL_OPERATOR0             = 103, // <Operator0>
        SYMBOL_OPERATOR1             = 104, // <Operator1>
        SYMBOL_OPERATOR2             = 105, // <Operator2>
        SYMBOL_OREXP                 = 106, // <Or Exp>
        SYMBOL_ORG2                  = 107, // <Org>
        SYMBOL_PARAMETER             = 108, // <Parameter>
        SYMBOL_PIN2                  = 109, // <Pin>
        SYMBOL_SHIFTEXP              = 110, // <Shift Exp>
        SYMBOL_START                 = 111, // <Start>
        SYMBOL_STATEMENT             = 112, // <Statement>
        SYMBOL_VALUE                 = 113  // <Value>
    } ;

    enum RuleConstants : int
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
        RULE_ENDOPTIONAL_END2          =   9, // <EndOptional> ::= <eol> End <Expression> <eolOptional>
        RULE_ENDOPTIONAL_END3 = 10, // <EndOptional> ::= <eol> <Labels> End <eolOptional>
        RULE_ENDOPTIONAL_END4          =  11, // <EndOptional> ::= <eol> <Labels> End <Expression> <eolOptional>
        RULE_ENDOPTIONAL_END5 = 12, // <EndOptional> ::= <eol> <Labels> <eol> End <eolOptional>
        RULE_ENDOPTIONAL_END6          =  13, // <EndOptional> ::= <eol> <Labels> <eol> End <Expression> <eolOptional>
        RULE_ENDOPTIONAL2 = 14, // <EndOptional> ::= 
        RULE_ALLSTATEMENTS = 15, // <AllStatements> ::= <Statement>
        RULE_ALLSTATEMENTS2 = 16, // <AllStatements> ::= <For>
        RULE_ALLSTATEMENTS3 = 17, // <AllStatements> ::= <AllStatements> <eol> <Statement>
        RULE_ALLSTATEMENTS4 = 18, // <AllStatements> ::= <AllStatements> <eol> <For>
        RULE_FOR_FOR_ROF               =  19, // <For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
        RULE_FOR_FOR_ROF2              =  20, // <For> ::= <Labels> <eol> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
        RULE_ALLSTATEMENTSOPTIONAL     =  21, // <AllStatementsOptional> ::= <AllStatements> <eol>
        RULE_ALLSTATEMENTSOPTIONAL2    =  22, // <AllStatementsOptional> ::= 
        RULE_STATEMENT                 =  23, // <Statement> ::= <Pin>
        RULE_STATEMENT2                =  24, // <Statement> ::= <Org>
        RULE_STATEMENT3                =  25, // <Statement> ::= <Equ>
        RULE_STATEMENT4                =  26, // <Statement> ::= <LabelsOptional> <Operation>
        RULE_STATEMENT5                =  27, // <Statement> ::= <Labels> <eol> <Operation>
        RULE_STATEMENT6                =  28, // <Statement> ::= <Assert>
        RULE_PIN_PIN                   =  29, // <Pin> ::= Pin <Expression>
        RULE_ASSERT_ATASSERT           =  30, // <Assert> ::= @assert <Expression>
        RULE_ORG_ORG                   =  31, // <Org> ::= Org <Expression>
        RULE_EQU_EQU                   =  32, // <Equ> ::= <Labels> Equ <ModeOptional> <Expression>
        RULE_EQU_EQU2                  =  33, // <Equ> ::= <Labels> <eol> Equ <ModeOptional> <Expression>
        RULE_LABELSOPTIONAL            =  34, // <LabelsOptional> ::= <Labels>
        RULE_LABELSOPTIONAL2           =  35, // <LabelsOptional> ::= 
        RULE_LABEL_LABEL               =  36, // <Label> ::= Label
        RULE_LABEL                     =  37, // <Label> ::= <Modifier>
        RULE_LABEL_LABEL_AMP_LABEL     =  38, // <Label> ::= Label & Label
        RULE_LABEL_LABEL_AMP           =  39, // <Label> ::= Label & <Modifier>
        RULE_LABEL_AMP_LABEL           =  40, // <Label> ::= <Modifier> & Label
        RULE_LABELS                    =  41, // <Labels> ::= <Label>
        RULE_LABELS2                   =  42, // <Labels> ::= <Labels> <eol> <Label>
        RULE_LABELS3                   =  43, // <Labels> ::= <Labels> <Label>
        RULE_OPERATION                 =  44, // <Operation> ::= <Operation0>
        RULE_OPERATION2                =  45, // <Operation> ::= <Operation1>
        RULE_OPERATION3                =  46, // <Operation> ::= <Operation2>
        RULE_OPERATION0                =  47, // <Operation0> ::= <Operator0>
        RULE_OPERATION0_COMMA          =  48, // <Operation0> ::= <Operator0> <Parameter> , <Parameter>
        RULE_OPERATION0_DOT_COMMA      =  49, // <Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION02               =  50, // <Operation0> ::= <Operator0> <Parameter>
        RULE_OPERATION0_DOT            =  51, // <Operation0> ::= <Operator0> . <Modifier> <Parameter>
        RULE_OPERATION0_DOT2           =  52, // <Operation0> ::= <Operator0> . <Modifier>
        RULE_OPERATION1                =  53, // <Operation1> ::= <Operator1> <Parameter>
        RULE_OPERATION1_DOT            =  54, // <Operation1> ::= <Operator1> . <Modifier> <Parameter>
        RULE_OPERATION1_COMMA          =  55, // <Operation1> ::= <Operator1> <Parameter> , <Parameter>
        RULE_OPERATION1_DOT_COMMA      =  56, // <Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION2_COMMA          =  57, // <Operation2> ::= <Operator2> <Parameter> , <Parameter>
        RULE_OPERATION2_DOT_COMMA      =  58, // <Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
        RULE_PARAMETER                 =  59, // <Parameter> ::= <Expression>
        RULE_PARAMETER2                =  60, // <Parameter> ::= <Mode> <Expression>
        RULE_MODEOPTIONAL              =  61, // <ModeOptional> ::= <Mode>
        RULE_MODEOPTIONAL2             =  62, // <ModeOptional> ::= 
        RULE_MODE_NUM                  =  63, // <Mode> ::= #
        RULE_MODE_DOLLAR               =  64, // <Mode> ::= $
        RULE_MODE_AT                   =  65, // <Mode> ::= @
        RULE_MODE_LT                   =  66, // <Mode> ::= <
        RULE_MODE_GT                   =  67, // <Mode> ::= >
        RULE_MODE_LBRACE               =  68, // <Mode> ::= {
        RULE_MODE_RBRACE               =  69, // <Mode> ::= }
        RULE_MODE_TIMES                =  70, // <Mode> ::= *
        RULE_OPERATOR0_NOP             =  71, // <Operator0> ::= Nop
        RULE_OPERATOR1_JMP             =  72, // <Operator1> ::= Jmp
        RULE_OPERATOR1_SPL             =  73, // <Operator1> ::= Spl
        RULE_OPERATOR1_DAT             =  74, // <Operator1> ::= Dat
        RULE_OPERATOR2_MOV             =  75, // <Operator2> ::= Mov
        RULE_OPERATOR2_ADD             =  76, // <Operator2> ::= Add
        RULE_OPERATOR2_SUB             =  77, // <Operator2> ::= Sub
        RULE_OPERATOR2_MUL             =  78, // <Operator2> ::= Mul
        RULE_OPERATOR2_DIV             =  79, // <Operator2> ::= Div
        RULE_OPERATOR2_MOD             =  80, // <Operator2> ::= Mod
        RULE_OPERATOR2_JMZ             =  81, // <Operator2> ::= Jmz
        RULE_OPERATOR2_JMN             =  82, // <Operator2> ::= Jmn
        RULE_OPERATOR2_DJN             =  83, // <Operator2> ::= Djn
        RULE_OPERATOR2_SLT             =  84, // <Operator2> ::= Slt
        RULE_OPERATOR2_SNE             =  85, // <Operator2> ::= Sne
        RULE_OPERATOR2_LDP             =  86, // <Operator2> ::= Ldp
        RULE_OPERATOR2_STP             =  87, // <Operator2> ::= Stp
        RULE_OPERATOR2_CMP             =  88, // <Operator2> ::= Cmp
        RULE_OPERATOR2_SEQ             =  89, // <Operator2> ::= Seq
        RULE_MODIFIER_I                =  90, // <Modifier> ::= I
        RULE_MODIFIER_A                =  91, // <Modifier> ::= A
        RULE_MODIFIER_B                =  92, // <Modifier> ::= B
        RULE_MODIFIER_AB               =  93, // <Modifier> ::= AB
        RULE_MODIFIER_BA               =  94, // <Modifier> ::= BA
        RULE_MODIFIER_F                =  95, // <Modifier> ::= F
        RULE_MODIFIER_X                =  96, // <Modifier> ::= X
        RULE_EXPRESSIONOPTIONAL        =  97, // <ExpressionOptional> ::= <Expression>
        RULE_EXPRESSIONOPTIONAL2       =  98, // <ExpressionOptional> ::= 
        RULE_EXPRESSION_QUESTION_COLON =  99, // <Expression> ::= <Or Exp> ? <Expression> : <Expression>
        RULE_EXPRESSION                = 100, // <Expression> ::= <Or Exp>
        RULE_OREXP_PIPEPIPE            = 101, // <Or Exp> ::= <Or Exp> || <And Exp>
        RULE_OREXP                     = 102, // <Or Exp> ::= <And Exp>
        RULE_ANDEXP_AMPAMP             = 103, // <And Exp> ::= <And Exp> && <BinOr Exp>
        RULE_ANDEXP                    = 104, // <And Exp> ::= <BinOr Exp>
        RULE_BINOREXP_PIPE             = 105, // <BinOr Exp> ::= <BinOr Exp> | <BinXor Exp>
        RULE_BINOREXP                  = 106, // <BinOr Exp> ::= <BinXor Exp>
        RULE_BINXOREXP_CARET           = 107, // <BinXor Exp> ::= <BinXor Exp> ^ <BinAnd Exp>
        RULE_BINXOREXP                 = 108, // <BinXor Exp> ::= <BinAnd Exp>
        RULE_BINANDEXP_AMPAMPAMP       = 109, // <BinAnd Exp> ::= <BinAnd Exp> &&& <Equate Exp>
        RULE_BINANDEXP                 = 110, // <BinAnd Exp> ::= <Equate Exp>
        RULE_EQUATEEXP_EQEQ            = 111, // <Equate Exp> ::= <Equate Exp> == <Compare Exp>
        RULE_EQUATEEXP_EXCLAMEQ        = 112, // <Equate Exp> ::= <Equate Exp> != <Compare Exp>
        RULE_EQUATEEXP_LTGT            = 113, // <Equate Exp> ::= <Equate Exp> <> <Compare Exp>
        RULE_EQUATEEXP                 = 114, // <Equate Exp> ::= <Compare Exp>
        RULE_COMPAREEXP_LT             = 115, // <Compare Exp> ::= <Compare Exp> < <Shift Exp>
        RULE_COMPAREEXP_GT             = 116, // <Compare Exp> ::= <Compare Exp> > <Shift Exp>
        RULE_COMPAREEXP_LTEQ           = 117, // <Compare Exp> ::= <Compare Exp> <= <Shift Exp>
        RULE_COMPAREEXP_GTEQ           = 118, // <Compare Exp> ::= <Compare Exp> >= <Shift Exp>
        RULE_COMPAREEXP                = 119, // <Compare Exp> ::= <Shift Exp>
        RULE_SHIFTEXP_LTLT             = 120, // <Shift Exp> ::= <Shift Exp> << <Add Exp>
        RULE_SHIFTEXP_GTGT             = 121, // <Shift Exp> ::= <Shift Exp> >> <Add Exp>
        RULE_SHIFTEXP                  = 122, // <Shift Exp> ::= <Add Exp>
        RULE_ADDEXP_PLUS               = 123, // <Add Exp> ::= <Add Exp> + <Mult Exp>
        RULE_ADDEXP_MINUS              = 124, // <Add Exp> ::= <Add Exp> - <Mult Exp>
        RULE_ADDEXP                    = 125, // <Add Exp> ::= <Mult Exp>
        RULE_MULTEXP_TIMES             = 126, // <Mult Exp> ::= <Mult Exp> * <Negate Exp>
        RULE_MULTEXP_DIV               = 127, // <Mult Exp> ::= <Mult Exp> / <Negate Exp>
        RULE_MULTEXP_PERCENT           = 128, // <Mult Exp> ::= <Mult Exp> % <Negate Exp>
        RULE_MULTEXP                   = 129, // <Mult Exp> ::= <Negate Exp>
        RULE_NEGATEEXP_MINUS           = 130, // <Negate Exp> ::= - <Value>
        RULE_NEGATEEXP_PLUS            = 131, // <Negate Exp> ::= + <Value>
        RULE_NEGATEEXP                 = 132, // <Negate Exp> ::= <Value>
        RULE_VALUE_INTEGER             = 133, // <Value> ::= Integer
        RULE_VALUE                     = 134, // <Value> ::= <Label>
        RULE_VALUE_LPARAN_RPARAN       = 135  // <Value> ::= ( <Expression> )
    } ;
}