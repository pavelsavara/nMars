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
        SYMBOL_EOF                   =   0, // (EOF)
        SYMBOL_ERROR                 =   1, // (Error)
        SYMBOL_WHITESPACE            =   2, // (Whitespace)
        SYMBOL_COMMENTLINE           =   3, // (Comment Line)
        SYMBOL_MINUS                 =   4, // -
        SYMBOL_EXCLAMEQ              =   5, // !=
        SYMBOL_NUM                   =   6, // #
        SYMBOL_DOLLAR                =   7, // $
        SYMBOL_PERCENT               =   8, // %
        SYMBOL_AMP                   =   9, // &
        SYMBOL_AMPAMP                =  10, // &&
        SYMBOL_AMPAMPAMP             =  11, // &&&
        SYMBOL_LPARAN                =  12, // (
        SYMBOL_RPARAN                =  13, // )
        SYMBOL_TIMES                 =  14, // *
        SYMBOL_COMMA                 =  15, // ,
        SYMBOL_DOT                   =  16, // .
        SYMBOL_DIV                   =  17, // /
        SYMBOL_COLON                 =  18, // :
        SYMBOL_QUESTION              =  19, // ?
        SYMBOL_AT                    =  20, // @
        SYMBOL_CARET                 =  21, // ^
        SYMBOL_LBRACE                =  22, // {
        SYMBOL_PIPE                  =  23, // |
        SYMBOL_PIPEPIPE              =  24, // ||
        SYMBOL_RBRACE                =  25, // }
        SYMBOL_PLUS                  =  26, // +
        SYMBOL_LT                    =  27, // <
        SYMBOL_LTLT                  =  28, // <<
        SYMBOL_LTEQ                  =  29, // <=
        SYMBOL_LTGT                  =  30, // <>
        SYMBOL_EQEQ                  =  31, // ==
        SYMBOL_GT                    =  32, // >
        SYMBOL_GTEQ                  =  33, // >=
        SYMBOL_GTGT                  =  34, // >>
        SYMBOL_A                     =  35, // A
        SYMBOL_AB                    =  36, // AB
        SYMBOL_ADD                   =  37, // Add
        SYMBOL_B                     =  38, // B
        SYMBOL_BA                    =  39, // BA
        SYMBOL_CMP                   =  40, // Cmp
        SYMBOL_COMMENT               =  41, // Comment
        SYMBOL_DAT                   =  42, // Dat
        SYMBOL_DIV2                  =  43, // Div
        SYMBOL_DJN                   =  44, // Djn
        SYMBOL_END                   =  45, // End
        SYMBOL_EQU                   =  46, // Equ
        SYMBOL_F                     =  47, // F
        SYMBOL_FOR                   =  48, // for
        SYMBOL_I                     =  49, // I
        SYMBOL_INTEGER               =  50, // Integer
        SYMBOL_JMN                   =  51, // Jmn
        SYMBOL_JMP                   =  52, // Jmp
        SYMBOL_JMZ                   =  53, // Jmz
        SYMBOL_LABEL                 =  54, // Label
        SYMBOL_LDP                   =  55, // Ldp
        SYMBOL_LINE                  =  56, // Line
        SYMBOL_MOD                   =  57, // Mod
        SYMBOL_MOV                   =  58, // Mov
        SYMBOL_MUL                   =  59, // Mul
        SYMBOL_NEWLINE               =  60, // NewLine
        SYMBOL_NOP                   =  61, // Nop
        SYMBOL_ORG                   =  62, // Org
        SYMBOL_PIN                   =  63, // Pin
        SYMBOL_ROF                   =  64, // rof
        SYMBOL_SEQ                   =  65, // Seq
        SYMBOL_SLT                   =  66, // Slt
        SYMBOL_SNE                   =  67, // Sne
        SYMBOL_SPL                   =  68, // Spl
        SYMBOL_STP                   =  69, // Stp
        SYMBOL_SUB                   =  70, // Sub
        SYMBOL_X                     =  71, // X
        SYMBOL_ADDEXP                =  72, // <Add Exp>
        SYMBOL_ALLSTATEMENTS         =  73, // <AllStatements>
        SYMBOL_ALLSTATEMENTSOPTIONAL =  74, // <AllStatementsOptional>
        SYMBOL_ANDEXP                =  75, // <And Exp>
        SYMBOL_BINANDEXP             =  76, // <BinAnd Exp>
        SYMBOL_BINOREXP              =  77, // <BinOr Exp>
        SYMBOL_BINXOREXP             =  78, // <BinXor Exp>
        SYMBOL_COMPAREEXP            =  79, // <Compare Exp>
        SYMBOL_ENDOPTIONAL           =  80, // <EndOptional>
        SYMBOL_EOL                   =  81, // <eol>
        SYMBOL_EOLOPTIONAL           =  82, // <eolOptional>
        SYMBOL_EOLSINGLE             =  83, // <eolSingle>
        SYMBOL_EQU2                  =  84, // <Equ>
        SYMBOL_EQUATEEXP             =  85, // <Equate Exp>
        SYMBOL_EXPRESSION            =  86, // <Expression>
        SYMBOL_EXPRESSIONOPTIONAL    =  87, // <ExpressionOptional>
        SYMBOL_FOR2                  =  88, // <For>
        SYMBOL_LABEL2                =  89, // <Label>
        SYMBOL_LABELS                =  90, // <Labels>
        SYMBOL_LABELSOPTIONAL        =  91, // <LabelsOptional>
        SYMBOL_MODE                  =  92, // <Mode>
        SYMBOL_MODEOPTIONAL          =  93, // <ModeOptional>
        SYMBOL_MODIFIER              =  94, // <Modifier>
        SYMBOL_MULTEXP               =  95, // <Mult Exp>
        SYMBOL_NEGATEEXP             =  96, // <Negate Exp>
        SYMBOL_OPERATION             =  97, // <Operation>
        SYMBOL_OPERATION0            =  98, // <Operation0>
        SYMBOL_OPERATION1            =  99, // <Operation1>
        SYMBOL_OPERATION2            = 100, // <Operation2>
        SYMBOL_OPERATOR0             = 101, // <Operator0>
        SYMBOL_OPERATOR1             = 102, // <Operator1>
        SYMBOL_OPERATOR2             = 103, // <Operator2>
        SYMBOL_OREXP                 = 104, // <Or Exp>
        SYMBOL_ORG2                  = 105, // <Org>
        SYMBOL_PARAMETER             = 106, // <Parameter>
        SYMBOL_PIN2                  = 107, // <Pin>
        SYMBOL_SHIFTEXP              = 108, // <Shift Exp>
        SYMBOL_START                 = 109, // <Start>
        SYMBOL_STATEMENT             = 110, // <Statement>
        SYMBOL_VALUE                 = 111  // <Value>
    };

    enum RuleConstants : int
    {
        RULE_EOL                       =   0, // <eol> ::= <eolSingle>
        RULE_EOL2                      =   1, // <eol> ::= <eol> <eolSingle>
        RULE_EOLSINGLE_NEWLINE         =   2, // <eolSingle> ::= NewLine
        RULE_EOLSINGLE_COMMENT_LINE    =   3, // <eolSingle> ::= Comment Line
        RULE_EOLOPTIONAL               =   4, // <eolOptional> ::= <eol>
        RULE_EOLOPTIONAL2              =   5, // <eolOptional> ::= 
        RULE_START                     =   6, // <Start> ::= <eolOptional> <AllStatements> <EndOptional>
        RULE_ENDOPTIONAL               =   7, // <EndOptional> ::= <eol>
        RULE_ENDOPTIONAL_END           =   8, // <EndOptional> ::= <eol> End <eolOptional>
        RULE_ENDOPTIONAL_END2          =   9, // <EndOptional> ::= <eol> End <Labels> <eolOptional>
        RULE_ENDOPTIONAL_END3          =  10, // <EndOptional> ::= <eol> <Labels> End <eolOptional>
        RULE_ENDOPTIONAL_END4          =  11, // <EndOptional> ::= <eol> <Labels> End <Labels> <eolOptional>
        RULE_ENDOPTIONAL_END5          =  12, // <EndOptional> ::= <eol> <Labels> <eol> End <eolOptional>
        RULE_ENDOPTIONAL_END6          =  13, // <EndOptional> ::= <eol> <Labels> <eol> End <Labels> <eolOptional>
        RULE_ENDOPTIONAL2              =  14, // <EndOptional> ::= 
        RULE_ALLSTATEMENTS             =  15, // <AllStatements> ::= <Statement>
        RULE_ALLSTATEMENTS2            =  16, // <AllStatements> ::= <For>
        RULE_ALLSTATEMENTS3            =  17, // <AllStatements> ::= <AllStatements> <eol> <Statement>
        RULE_ALLSTATEMENTS4            =  18, // <AllStatements> ::= <AllStatements> <eol> <For>
        RULE_FOR_FOR_ROF               =  19, // <For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
        RULE_ALLSTATEMENTSOPTIONAL     =  20, // <AllStatementsOptional> ::= <AllStatements> <eol>
        RULE_ALLSTATEMENTSOPTIONAL2    =  21, // <AllStatementsOptional> ::= 
        RULE_STATEMENT                 =  22, // <Statement> ::= <Pin>
        RULE_STATEMENT2                =  23, // <Statement> ::= <Org>
        RULE_STATEMENT3                =  24, // <Statement> ::= <Equ>
        RULE_STATEMENT4                =  25, // <Statement> ::= <LabelsOptional> <Operation>
        RULE_STATEMENT5                =  26, // <Statement> ::= <Labels> <eol> <Operation>
        RULE_PIN_PIN                   =  27, // <Pin> ::= Pin <Expression>
        RULE_ORG_ORG_LABEL             =  28, // <Org> ::= Org Label
        RULE_EQU_EQU                   =  29, // <Equ> ::= <Labels> Equ <ModeOptional> <Expression>
        RULE_EQU_EQU2                  =  30, // <Equ> ::= <Labels> <eol> Equ <ModeOptional> <Expression>
        RULE_LABELSOPTIONAL            =  31, // <LabelsOptional> ::= <Labels>
        RULE_LABELSOPTIONAL2           =  32, // <LabelsOptional> ::= 
        RULE_LABEL_LABEL               =  33, // <Label> ::= Label
        RULE_LABEL                     =  34, // <Label> ::= <Modifier>
        RULE_LABEL_LABEL_AMP_LABEL     =  35, // <Label> ::= Label & Label
        RULE_LABEL_LABEL_AMP           =  36, // <Label> ::= Label & <Modifier>
        RULE_LABEL_AMP_LABEL           =  37, // <Label> ::= <Modifier> & Label
        RULE_LABELS                    =  38, // <Labels> ::= <Label>
        RULE_LABELS2                   =  39, // <Labels> ::= <Labels> <eol> <Label>
        RULE_LABELS3                   =  40, // <Labels> ::= <Labels> <Label>
        RULE_OPERATION                 =  41, // <Operation> ::= <Operation0>
        RULE_OPERATION2                =  42, // <Operation> ::= <Operation1>
        RULE_OPERATION3                =  43, // <Operation> ::= <Operation2>
        RULE_OPERATION0                =  44, // <Operation0> ::= <Operator0>
        RULE_OPERATION0_COMMA          =  45, // <Operation0> ::= <Operator0> <Parameter> , <Parameter>
        RULE_OPERATION0_DOT_COMMA      =  46, // <Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION1                =  47, // <Operation1> ::= <Operator1> <Parameter>
        RULE_OPERATION1_DOT            =  48, // <Operation1> ::= <Operator1> . <Modifier> <Parameter>
        RULE_OPERATION1_COMMA          =  49, // <Operation1> ::= <Operator1> <Parameter> , <Parameter>
        RULE_OPERATION1_DOT_COMMA      =  50, // <Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
        RULE_OPERATION2_COMMA          =  51, // <Operation2> ::= <Operator2> <Parameter> , <Parameter>
        RULE_OPERATION2_DOT_COMMA      =  52, // <Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
        RULE_PARAMETER                 =  53, // <Parameter> ::= <Expression>
        RULE_PARAMETER2                =  54, // <Parameter> ::= <Mode> <Expression>
        RULE_MODEOPTIONAL              =  55, // <ModeOptional> ::= <Mode>
        RULE_MODEOPTIONAL2             =  56, // <ModeOptional> ::= 
        RULE_MODE_NUM                  =  57, // <Mode> ::= #
        RULE_MODE_DOLLAR               =  58, // <Mode> ::= $
        RULE_MODE_AT                   =  59, // <Mode> ::= @
        RULE_MODE_LT                   =  60, // <Mode> ::= <
        RULE_MODE_GT                   =  61, // <Mode> ::= >
        RULE_MODE_LBRACE               =  62, // <Mode> ::= {
        RULE_MODE_RBRACE               =  63, // <Mode> ::= }
        RULE_MODE_TIMES                =  64, // <Mode> ::= *
        RULE_OPERATOR0_NOP             =  65, // <Operator0> ::= Nop
        RULE_OPERATOR1_JMP             =  66, // <Operator1> ::= Jmp
        RULE_OPERATOR1_SPL             =  67, // <Operator1> ::= Spl
        RULE_OPERATOR1_DAT             =  68, // <Operator1> ::= Dat
        RULE_OPERATOR2_MOV             =  69, // <Operator2> ::= Mov
        RULE_OPERATOR2_ADD             =  70, // <Operator2> ::= Add
        RULE_OPERATOR2_SUB             =  71, // <Operator2> ::= Sub
        RULE_OPERATOR2_MUL             =  72, // <Operator2> ::= Mul
        RULE_OPERATOR2_DIV             =  73, // <Operator2> ::= Div
        RULE_OPERATOR2_MOD             =  74, // <Operator2> ::= Mod
        RULE_OPERATOR2_JMZ             =  75, // <Operator2> ::= Jmz
        RULE_OPERATOR2_JMN             =  76, // <Operator2> ::= Jmn
        RULE_OPERATOR2_DJN             =  77, // <Operator2> ::= Djn
        RULE_OPERATOR2_SLT             =  78, // <Operator2> ::= Slt
        RULE_OPERATOR2_SNE             =  79, // <Operator2> ::= Sne
        RULE_OPERATOR2_LDP             =  80, // <Operator2> ::= Ldp
        RULE_OPERATOR2_STP             =  81, // <Operator2> ::= Stp
        RULE_OPERATOR2_CMP             =  82, // <Operator2> ::= Cmp
        RULE_OPERATOR2_SEQ             =  83, // <Operator2> ::= Seq
        RULE_MODIFIER_I                =  84, // <Modifier> ::= I
        RULE_MODIFIER_A                =  85, // <Modifier> ::= A
        RULE_MODIFIER_B                =  86, // <Modifier> ::= B
        RULE_MODIFIER_AB               =  87, // <Modifier> ::= AB
        RULE_MODIFIER_BA               =  88, // <Modifier> ::= BA
        RULE_MODIFIER_F                =  89, // <Modifier> ::= F
        RULE_MODIFIER_X                =  90, // <Modifier> ::= X
        RULE_EXPRESSIONOPTIONAL        =  91, // <ExpressionOptional> ::= <Expression>
        RULE_EXPRESSIONOPTIONAL2       =  92, // <ExpressionOptional> ::= 
        RULE_EXPRESSION_QUESTION_COLON =  93, // <Expression> ::= <Or Exp> ? <Expression> : <Expression>
        RULE_EXPRESSION                =  94, // <Expression> ::= <Or Exp>
        RULE_OREXP_PIPEPIPE            =  95, // <Or Exp> ::= <Or Exp> || <And Exp>
        RULE_OREXP                     =  96, // <Or Exp> ::= <And Exp>
        RULE_ANDEXP_AMPAMP             =  97, // <And Exp> ::= <And Exp> && <BinOr Exp>
        RULE_ANDEXP                    =  98, // <And Exp> ::= <BinOr Exp>
        RULE_BINOREXP_PIPE             =  99, // <BinOr Exp> ::= <BinOr Exp> | <BinXor Exp>
        RULE_BINOREXP                  = 100, // <BinOr Exp> ::= <BinXor Exp>
        RULE_BINXOREXP_CARET           = 101, // <BinXor Exp> ::= <BinXor Exp> ^ <BinAnd Exp>
        RULE_BINXOREXP                 = 102, // <BinXor Exp> ::= <BinAnd Exp>
        RULE_BINANDEXP_AMPAMPAMP       = 103, // <BinAnd Exp> ::= <BinAnd Exp> &&& <Equate Exp>
        RULE_BINANDEXP                 = 104, // <BinAnd Exp> ::= <Equate Exp>
        RULE_EQUATEEXP_EQEQ            = 105, // <Equate Exp> ::= <Equate Exp> == <Compare Exp>
        RULE_EQUATEEXP_EXCLAMEQ        = 106, // <Equate Exp> ::= <Equate Exp> != <Compare Exp>
        RULE_EQUATEEXP_LTGT            = 107, // <Equate Exp> ::= <Equate Exp> <> <Compare Exp>
        RULE_EQUATEEXP                 = 108, // <Equate Exp> ::= <Compare Exp>
        RULE_COMPAREEXP_LT             = 109, // <Compare Exp> ::= <Compare Exp> < <Shift Exp>
        RULE_COMPAREEXP_GT             = 110, // <Compare Exp> ::= <Compare Exp> > <Shift Exp>
        RULE_COMPAREEXP_LTEQ           = 111, // <Compare Exp> ::= <Compare Exp> <= <Shift Exp>
        RULE_COMPAREEXP_GTEQ           = 112, // <Compare Exp> ::= <Compare Exp> >= <Shift Exp>
        RULE_COMPAREEXP                = 113, // <Compare Exp> ::= <Shift Exp>
        RULE_SHIFTEXP_LTLT             = 114, // <Shift Exp> ::= <Shift Exp> << <Add Exp>
        RULE_SHIFTEXP_GTGT             = 115, // <Shift Exp> ::= <Shift Exp> >> <Add Exp>
        RULE_SHIFTEXP                  = 116, // <Shift Exp> ::= <Add Exp>
        RULE_ADDEXP_PLUS               = 117, // <Add Exp> ::= <Add Exp> + <Mult Exp>
        RULE_ADDEXP_MINUS              = 118, // <Add Exp> ::= <Add Exp> - <Mult Exp>
        RULE_ADDEXP                    = 119, // <Add Exp> ::= <Mult Exp>
        RULE_MULTEXP_TIMES             = 120, // <Mult Exp> ::= <Mult Exp> * <Negate Exp>
        RULE_MULTEXP_DIV               = 121, // <Mult Exp> ::= <Mult Exp> / <Negate Exp>
        RULE_MULTEXP_PERCENT           = 122, // <Mult Exp> ::= <Mult Exp> % <Negate Exp>
        RULE_MULTEXP                   = 123, // <Mult Exp> ::= <Negate Exp>
        RULE_NEGATEEXP_MINUS           = 124, // <Negate Exp> ::= - <Value>
        RULE_NEGATEEXP                 = 125, // <Negate Exp> ::= <Value>
        RULE_VALUE_INTEGER             = 126, // <Value> ::= Integer
        RULE_VALUE                     = 127, // <Value> ::= <Label>
        RULE_VALUE_LPARAN_RPARAN       = 128  // <Value> ::= ( <Expression> )
    };
}