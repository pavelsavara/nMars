
using System;
using System.IO;
using System.Runtime.Serialization;
using com.calitha.goldparser.lalr;
using com.calitha.commons;

namespace com.calitha.goldparser
{

    [Serializable()]
    public class SymbolException : System.Exception
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
    public class RuleException : System.Exception
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

    enum SymbolConstants : int
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
        RULE_ENDOPTIONAL_END2          =   9, // <EndOptional> ::= <eol> End <Expression> <eolOptional>
        RULE_ENDOPTIONAL_END3          =  10, // <EndOptional> ::= <eol> <Labels> End <eolOptional>
        RULE_ENDOPTIONAL_END4          =  11, // <EndOptional> ::= <eol> <Labels> End <Expression> <eolOptional>
        RULE_ENDOPTIONAL_END5          =  12, // <EndOptional> ::= <eol> <Labels> <eol> End <eolOptional>
        RULE_ENDOPTIONAL_END6          =  13, // <EndOptional> ::= <eol> <Labels> <eol> End <Expression> <eolOptional>
        RULE_ENDOPTIONAL2              =  14, // <EndOptional> ::= 
        RULE_ALLSTATEMENTS             =  15, // <AllStatements> ::= <Statement>
        RULE_ALLSTATEMENTS2            =  16, // <AllStatements> ::= <For>
        RULE_ALLSTATEMENTS3            =  17, // <AllStatements> ::= <AllStatements> <eol> <Statement>
        RULE_ALLSTATEMENTS4            =  18, // <AllStatements> ::= <AllStatements> <eol> <For>
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
    };

    public class MyParser
    {
        private LALRParser parser;

        public MyParser(string filename)
        {
            FileStream stream = new FileStream(filename,
                                               FileMode.Open, 
                                               FileAccess.Read, 
                                               FileShare.Read);
            Init(stream);
            stream.Close();
        }

        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }

        public MyParser(Stream stream)
        {
            Init(stream);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
                //todo: Use your object any way you like
            }
        }

        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }

        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //(Whitespace)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMENTLINE :
                //(Comment Line)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //-
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ :
                //!=
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NUM :
                //#
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DOLLAR :
                //$
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PERCENT :
                //%
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AMP :
                //&
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AMPAMP :
                //&&
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AMPAMPAMP :
                //&&&
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPARAN :
                //(
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPARAN :
                //)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMES :
                //*
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //,
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DOT :
                //.
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV :
                ///
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLON :
                //:
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_QUESTION :
                //?
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AT :
                //@
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ATASSERT :
                //@assert
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CARET :
                //^
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //{
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PIPE :
                //|
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PIPEPIPE :
                //||
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RBRACE :
                //}
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUS :
                //+
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LT :
                //<
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTLT :
                //<<
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTEQ :
                //<=
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LTGT :
                //<>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQEQ :
                //==
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GT :
                //>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTEQ :
                //>=
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GTGT :
                //>>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_A :
                //A
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_AB :
                //AB
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ADD :
                //Add
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_B :
                //B
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BA :
                //BA
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CMP :
                //Cmp
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMENT :
                //Comment
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DAT :
                //Dat
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV2 :
                //Div
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DJN :
                //Djn
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_END :
                //End
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQU :
                //Equ
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_F :
                //F
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR :
                //for
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_I :
                //I
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INTEGER :
                //Integer
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_JMN :
                //Jmn
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_JMP :
                //Jmp
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_JMZ :
                //Jmz
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LABEL :
                //Label
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LDP :
                //Ldp
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LINE :
                //Line
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MOD :
                //Mod
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MOV :
                //Mov
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MUL :
                //Mul
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NEWLINE :
                //NewLine
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NOP :
                //Nop
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ORG :
                //Org
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PIN :
                //Pin
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ROF :
                //rof
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SEQ :
                //Seq
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SLT :
                //Slt
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SNE :
                //Sne
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SPL :
                //Spl
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STP :
                //Stp
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SUB :
                //Sub
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_X :
                //X
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ADDEXP :
                //<Add Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ALLSTATEMENTS :
                //<AllStatements>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ALLSTATEMENTSOPTIONAL :
                //<AllStatementsOptional>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ANDEXP :
                //<And Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ASSERT :
                //<Assert>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BINANDEXP :
                //<BinAnd Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BINOREXP :
                //<BinOr Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_BINXOREXP :
                //<BinXor Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMPAREEXP :
                //<Compare Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ENDOPTIONAL :
                //<EndOptional>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EOL :
                //<eol>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EOLOPTIONAL :
                //<eolOptional>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EOLSINGLE :
                //<eolSingle>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQU2 :
                //<Equ>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQUATEEXP :
                //<Equate Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSION :
                //<Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRESSIONOPTIONAL :
                //<ExpressionOptional>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR2 :
                //<For>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LABEL2 :
                //<Label>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LABELS :
                //<Labels>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LABELSOPTIONAL :
                //<LabelsOptional>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MODE :
                //<Mode>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MODEOPTIONAL :
                //<ModeOptional>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MODIFIER :
                //<Modifier>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MULTEXP :
                //<Mult Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NEGATEEXP :
                //<Negate Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERATION :
                //<Operation>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERATION0 :
                //<Operation0>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERATION1 :
                //<Operation1>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERATION2 :
                //<Operation2>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERATOR0 :
                //<Operator0>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERATOR1 :
                //<Operator1>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERATOR2 :
                //<Operator2>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OREXP :
                //<Or Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ORG2 :
                //<Org>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PARAMETER :
                //<Parameter>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PIN2 :
                //<Pin>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_SHIFTEXP :
                //<Shift Exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_START :
                //<Start>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENT :
                //<Statement>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_VALUE :
                //<Value>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }

        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_EOL :
                //<eol> ::= <eolSingle>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EOL2 :
                //<eol> ::= <eol> <eolSingle>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EOLSINGLE_NEWLINE :
                //<eolSingle> ::= NewLine
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EOLSINGLE_COMMENT_LINE :
                //<eolSingle> ::= Comment Line
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EOLOPTIONAL :
                //<eolOptional> ::= <eol>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EOLOPTIONAL2 :
                //<eolOptional> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_START :
                //<Start> ::= <eolOptional> <AllStatements> <EndOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL :
                //<EndOptional> ::= <eol>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END :
                //<EndOptional> ::= <eol> End <eolOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END2 :
                //<EndOptional> ::= <eol> End <Expression> <eolOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END3 :
                //<EndOptional> ::= <eol> <Labels> End <eolOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END4 :
                //<EndOptional> ::= <eol> <Labels> End <Expression> <eolOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END5 :
                //<EndOptional> ::= <eol> <Labels> <eol> End <eolOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END6 :
                //<EndOptional> ::= <eol> <Labels> <eol> End <Expression> <eolOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL2 :
                //<EndOptional> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTS :
                //<AllStatements> ::= <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTS2 :
                //<AllStatements> ::= <For>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTS3 :
                //<AllStatements> ::= <AllStatements> <eol> <Statement>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTS4 :
                //<AllStatements> ::= <AllStatements> <eol> <For>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FOR_FOR_ROF :
                //<For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FOR_FOR_ROF2 :
                //<For> ::= <Labels> <eol> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTSOPTIONAL :
                //<AllStatementsOptional> ::= <AllStatements> <eol>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTSOPTIONAL2 :
                //<AllStatementsOptional> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT :
                //<Statement> ::= <Pin>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT2 :
                //<Statement> ::= <Org>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT3 :
                //<Statement> ::= <Equ>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT4 :
                //<Statement> ::= <LabelsOptional> <Operation>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT5 :
                //<Statement> ::= <Labels> <eol> <Operation>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT6 :
                //<Statement> ::= <Assert>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PIN_PIN :
                //<Pin> ::= Pin <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSERT_ATASSERT :
                //<Assert> ::= @assert <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ORG_ORG :
                //<Org> ::= Org <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQU_EQU :
                //<Equ> ::= <Labels> Equ <ModeOptional> <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQU_EQU2 :
                //<Equ> ::= <Labels> <eol> Equ <ModeOptional> <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABELSOPTIONAL :
                //<LabelsOptional> ::= <Labels>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABELSOPTIONAL2 :
                //<LabelsOptional> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABEL_LABEL :
                //<Label> ::= Label
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABEL :
                //<Label> ::= <Modifier>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABEL_LABEL_AMP_LABEL :
                //<Label> ::= Label & Label
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABEL_LABEL_AMP :
                //<Label> ::= Label & <Modifier>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABEL_AMP_LABEL :
                //<Label> ::= <Modifier> & Label
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABELS :
                //<Labels> ::= <Label>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABELS2 :
                //<Labels> ::= <Labels> <eol> <Label>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_LABELS3 :
                //<Labels> ::= <Labels> <Label>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION :
                //<Operation> ::= <Operation0>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION2 :
                //<Operation> ::= <Operation1>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION3 :
                //<Operation> ::= <Operation2>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION0 :
                //<Operation0> ::= <Operator0>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION0_COMMA :
                //<Operation0> ::= <Operator0> <Parameter> , <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION0_DOT_COMMA :
                //<Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION02 :
                //<Operation0> ::= <Operator0> <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION0_DOT :
                //<Operation0> ::= <Operator0> . <Modifier> <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION0_DOT2 :
                //<Operation0> ::= <Operator0> . <Modifier>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION1 :
                //<Operation1> ::= <Operator1> <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION1_DOT :
                //<Operation1> ::= <Operator1> . <Modifier> <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION1_COMMA :
                //<Operation1> ::= <Operator1> <Parameter> , <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION1_DOT_COMMA :
                //<Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION2_COMMA :
                //<Operation2> ::= <Operator2> <Parameter> , <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION2_DOT_COMMA :
                //<Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETER :
                //<Parameter> ::= <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PARAMETER2 :
                //<Parameter> ::= <Mode> <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODEOPTIONAL :
                //<ModeOptional> ::= <Mode>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODEOPTIONAL2 :
                //<ModeOptional> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODE_NUM :
                //<Mode> ::= #
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODE_DOLLAR :
                //<Mode> ::= $
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODE_AT :
                //<Mode> ::= @
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODE_LT :
                //<Mode> ::= <
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODE_GT :
                //<Mode> ::= >
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODE_LBRACE :
                //<Mode> ::= {
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODE_RBRACE :
                //<Mode> ::= }
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODE_TIMES :
                //<Mode> ::= *
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR0_NOP :
                //<Operator0> ::= Nop
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR1_JMP :
                //<Operator1> ::= Jmp
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR1_SPL :
                //<Operator1> ::= Spl
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR1_DAT :
                //<Operator1> ::= Dat
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_MOV :
                //<Operator2> ::= Mov
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_ADD :
                //<Operator2> ::= Add
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SUB :
                //<Operator2> ::= Sub
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_MUL :
                //<Operator2> ::= Mul
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_DIV :
                //<Operator2> ::= Div
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_MOD :
                //<Operator2> ::= Mod
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_JMZ :
                //<Operator2> ::= Jmz
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_JMN :
                //<Operator2> ::= Jmn
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_DJN :
                //<Operator2> ::= Djn
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SLT :
                //<Operator2> ::= Slt
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SNE :
                //<Operator2> ::= Sne
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_LDP :
                //<Operator2> ::= Ldp
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_STP :
                //<Operator2> ::= Stp
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_CMP :
                //<Operator2> ::= Cmp
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SEQ :
                //<Operator2> ::= Seq
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_I :
                //<Modifier> ::= I
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_A :
                //<Modifier> ::= A
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_B :
                //<Modifier> ::= B
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_AB :
                //<Modifier> ::= AB
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_BA :
                //<Modifier> ::= BA
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_F :
                //<Modifier> ::= F
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_X :
                //<Modifier> ::= X
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONOPTIONAL :
                //<ExpressionOptional> ::= <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONOPTIONAL2 :
                //<ExpressionOptional> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_QUESTION_COLON :
                //<Expression> ::= <Or Exp> ? <Expression> : <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <Or Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OREXP_PIPEPIPE :
                //<Or Exp> ::= <Or Exp> || <And Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OREXP :
                //<Or Exp> ::= <And Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ANDEXP_AMPAMP :
                //<And Exp> ::= <And Exp> && <BinOr Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ANDEXP :
                //<And Exp> ::= <BinOr Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BINOREXP_PIPE :
                //<BinOr Exp> ::= <BinOr Exp> | <BinXor Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BINOREXP :
                //<BinOr Exp> ::= <BinXor Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BINXOREXP_CARET :
                //<BinXor Exp> ::= <BinXor Exp> ^ <BinAnd Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BINXOREXP :
                //<BinXor Exp> ::= <BinAnd Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BINANDEXP_AMPAMPAMP :
                //<BinAnd Exp> ::= <BinAnd Exp> &&& <Equate Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_BINANDEXP :
                //<BinAnd Exp> ::= <Equate Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUATEEXP_EQEQ :
                //<Equate Exp> ::= <Equate Exp> == <Compare Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUATEEXP_EXCLAMEQ :
                //<Equate Exp> ::= <Equate Exp> != <Compare Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUATEEXP_LTGT :
                //<Equate Exp> ::= <Equate Exp> <> <Compare Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQUATEEXP :
                //<Equate Exp> ::= <Compare Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP_LT :
                //<Compare Exp> ::= <Compare Exp> < <Shift Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP_GT :
                //<Compare Exp> ::= <Compare Exp> > <Shift Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP_LTEQ :
                //<Compare Exp> ::= <Compare Exp> <= <Shift Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP_GTEQ :
                //<Compare Exp> ::= <Compare Exp> >= <Shift Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP :
                //<Compare Exp> ::= <Shift Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SHIFTEXP_LTLT :
                //<Shift Exp> ::= <Shift Exp> << <Add Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SHIFTEXP_GTGT :
                //<Shift Exp> ::= <Shift Exp> >> <Add Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_SHIFTEXP :
                //<Shift Exp> ::= <Add Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDEXP_PLUS :
                //<Add Exp> ::= <Add Exp> + <Mult Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDEXP_MINUS :
                //<Add Exp> ::= <Add Exp> - <Mult Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ADDEXP :
                //<Add Exp> ::= <Mult Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTEXP_TIMES :
                //<Mult Exp> ::= <Mult Exp> * <Negate Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTEXP_DIV :
                //<Mult Exp> ::= <Mult Exp> / <Negate Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTEXP_PERCENT :
                //<Mult Exp> ::= <Mult Exp> % <Negate Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_MULTEXP :
                //<Mult Exp> ::= <Negate Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NEGATEEXP_MINUS :
                //<Negate Exp> ::= - <Value>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NEGATEEXP_PLUS :
                //<Negate Exp> ::= + <Value>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NEGATEEXP :
                //<Negate Exp> ::= <Value>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE_INTEGER :
                //<Value> ::= Integer
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE :
                //<Value> ::= <Label>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE_LPARAN_RPARAN :
                //<Value> ::= ( <Expression> )
                //todo: Create a new object using the stored tokens.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '"+args.Token.ToString()+"'";
            //todo: Report message to UI?
        }

        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '"+args.UnexpectedToken.ToString()+"'";
            //todo: Report message to UI?
        }

    }
}
