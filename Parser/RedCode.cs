
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
        SYMBOL_LPARAN                =  11, // (
        SYMBOL_RPARAN                =  12, // )
        SYMBOL_TIMES                 =  13, // *
        SYMBOL_COMMA                 =  14, // ,
        SYMBOL_DOT                   =  15, // .
        SYMBOL_DIV                   =  16, // /
        SYMBOL_COLON                 =  17, // :
        SYMBOL_QUESTION              =  18, // ?
        SYMBOL_AT                    =  19, // @
        SYMBOL_CARET                 =  20, // ^
        SYMBOL_LBRACE                =  21, // {
        SYMBOL_PIPE                  =  22, // |
        SYMBOL_PIPEPIPE              =  23, // ||
        SYMBOL_RBRACE                =  24, // }
        SYMBOL_PLUS                  =  25, // +
        SYMBOL_LT                    =  26, // <
        SYMBOL_LTLT                  =  27, // <<
        SYMBOL_LTEQ                  =  28, // <=
        SYMBOL_LTGT                  =  29, // <>
        SYMBOL_EQEQ                  =  30, // ==
        SYMBOL_GT                    =  31, // >
        SYMBOL_GTEQ                  =  32, // >=
        SYMBOL_GTGT                  =  33, // >>
        SYMBOL_A                     =  34, // A
        SYMBOL_AB                    =  35, // AB
        SYMBOL_ADD                   =  36, // Add
        SYMBOL_B                     =  37, // B
        SYMBOL_BA                    =  38, // BA
        SYMBOL_CMP                   =  39, // Cmp
        SYMBOL_COMMENT               =  40, // Comment
        SYMBOL_DAT                   =  41, // Dat
        SYMBOL_DIV2                  =  42, // Div
        SYMBOL_DJN                   =  43, // Djn
        SYMBOL_END                   =  44, // End
        SYMBOL_EQU                   =  45, // Equ
        SYMBOL_F                     =  46, // F
        SYMBOL_FOR                   =  47, // for
        SYMBOL_I                     =  48, // I
        SYMBOL_INTEGER               =  49, // Integer
        SYMBOL_JMN                   =  50, // Jmn
        SYMBOL_JMP                   =  51, // Jmp
        SYMBOL_JMZ                   =  52, // Jmz
        SYMBOL_LABEL                 =  53, // Label
        SYMBOL_LDP                   =  54, // Ldp
        SYMBOL_LINE                  =  55, // Line
        SYMBOL_MOD                   =  56, // Mod
        SYMBOL_MOV                   =  57, // Mov
        SYMBOL_MUL                   =  58, // Mul
        SYMBOL_NEWLINE               =  59, // NewLine
        SYMBOL_NOP                   =  60, // Nop
        SYMBOL_ORG                   =  61, // Org
        SYMBOL_PIN                   =  62, // Pin
        SYMBOL_ROF                   =  63, // rof
        SYMBOL_SEQ                   =  64, // Seq
        SYMBOL_SLT                   =  65, // Slt
        SYMBOL_SNE                   =  66, // Sne
        SYMBOL_SPL                   =  67, // Spl
        SYMBOL_STP                   =  68, // Stp
        SYMBOL_SUB                   =  69, // Sub
        SYMBOL_X                     =  70, // X
        SYMBOL_ADDEXP                =  71, // <Add Exp>
        SYMBOL_ALLSTATEMENTS         =  72, // <AllStatements>
        SYMBOL_ALLSTATEMENTSOPTIONAL =  73, // <AllStatementsOptional>
        SYMBOL_ANDEXP                =  74, // <And Exp>
        SYMBOL_BINOREXP              =  75, // <BinOr Exp>
        SYMBOL_BINXOREXP             =  76, // <BinXor Exp>
        SYMBOL_COMPAREEXP            =  77, // <Compare Exp>
        SYMBOL_ENDOPTIONAL           =  78, // <EndOptional>
        SYMBOL_EOL                   =  79, // <eol>
        SYMBOL_EOLOPTIONAL           =  80, // <eolOptional>
        SYMBOL_EOLSINGLE             =  81, // <eolSingle>
        SYMBOL_EQU2                  =  82, // <Equ>
        SYMBOL_EQUATEEXP             =  83, // <Equate Exp>
        SYMBOL_EXPRESSION            =  84, // <Expression>
        SYMBOL_EXPRESSIONOPTIONAL    =  85, // <ExpressionOptional>
        SYMBOL_FOR2                  =  86, // <For>
        SYMBOL_LABEL2                =  87, // <Label>
        SYMBOL_LABELS                =  88, // <Labels>
        SYMBOL_LABELSOPTIONAL        =  89, // <LabelsOptional>
        SYMBOL_MODE                  =  90, // <Mode>
        SYMBOL_MODEOPTIONAL          =  91, // <ModeOptional>
        SYMBOL_MODIFIER              =  92, // <Modifier>
        SYMBOL_MULTEXP               =  93, // <Mult Exp>
        SYMBOL_NEGATEEXP             =  94, // <Negate Exp>
        SYMBOL_OPERATION             =  95, // <Operation>
        SYMBOL_OPERATION0            =  96, // <Operation0>
        SYMBOL_OPERATION1            =  97, // <Operation1>
        SYMBOL_OPERATION2            =  98, // <Operation2>
        SYMBOL_OPERATOR0             =  99, // <Operator0>
        SYMBOL_OPERATOR1             = 100, // <Operator1>
        SYMBOL_OPERATOR2             = 101, // <Operator2>
        SYMBOL_OREXP                 = 102, // <Or Exp>
        SYMBOL_ORG2                  = 103, // <Org>
        SYMBOL_PARAMETER             = 104, // <Parameter>
        SYMBOL_PIN2                  = 105, // <Pin>
        SYMBOL_SHIFTEXP              = 106, // <Shift Exp>
        SYMBOL_START                 = 107, // <Start>
        SYMBOL_STATEMENT             = 108, // <Statement>
        SYMBOL_VALUE                 = 109  // <Value>
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
        RULE_BINXOREXP_CARET           = 101, // <BinXor Exp> ::= <BinXor Exp> ^ <Equate Exp>
        RULE_BINXOREXP                 = 102, // <BinXor Exp> ::= <Equate Exp>
        RULE_EQUATEEXP_EQEQ            = 103, // <Equate Exp> ::= <Equate Exp> == <Compare Exp>
        RULE_EQUATEEXP_EXCLAMEQ        = 104, // <Equate Exp> ::= <Equate Exp> != <Compare Exp>
        RULE_EQUATEEXP_LTGT            = 105, // <Equate Exp> ::= <Equate Exp> <> <Compare Exp>
        RULE_EQUATEEXP                 = 106, // <Equate Exp> ::= <Compare Exp>
        RULE_COMPAREEXP_LT             = 107, // <Compare Exp> ::= <Compare Exp> < <Shift Exp>
        RULE_COMPAREEXP_GT             = 108, // <Compare Exp> ::= <Compare Exp> > <Shift Exp>
        RULE_COMPAREEXP_LTEQ           = 109, // <Compare Exp> ::= <Compare Exp> <= <Shift Exp>
        RULE_COMPAREEXP_GTEQ           = 110, // <Compare Exp> ::= <Compare Exp> >= <Shift Exp>
        RULE_COMPAREEXP                = 111, // <Compare Exp> ::= <Shift Exp>
        RULE_SHIFTEXP_LTLT             = 112, // <Shift Exp> ::= <Shift Exp> << <Add Exp>
        RULE_SHIFTEXP_GTGT             = 113, // <Shift Exp> ::= <Shift Exp> >> <Add Exp>
        RULE_SHIFTEXP                  = 114, // <Shift Exp> ::= <Add Exp>
        RULE_ADDEXP_PLUS               = 115, // <Add Exp> ::= <Add Exp> + <Mult Exp>
        RULE_ADDEXP_MINUS              = 116, // <Add Exp> ::= <Add Exp> - <Mult Exp>
        RULE_ADDEXP                    = 117, // <Add Exp> ::= <Mult Exp>
        RULE_MULTEXP_TIMES             = 118, // <Mult Exp> ::= <Mult Exp> * <Negate Exp>
        RULE_MULTEXP_DIV               = 119, // <Mult Exp> ::= <Mult Exp> / <Negate Exp>
        RULE_MULTEXP_PERCENT           = 120, // <Mult Exp> ::= <Mult Exp> % <Negate Exp>
        RULE_MULTEXP                   = 121, // <Mult Exp> ::= <Negate Exp>
        RULE_NEGATEEXP_MINUS           = 122, // <Negate Exp> ::= - <Value>
        RULE_NEGATEEXP                 = 123, // <Negate Exp> ::= <Value>
        RULE_VALUE_INTEGER             = 124, // <Value> ::= Integer
        RULE_VALUE                     = 125, // <Value> ::= <Label>
        RULE_VALUE_LPARAN_RPARAN       = 126  // <Value> ::= ( <Expression> )
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

            parser.OnReduce += new LALRParser.ReduceHandler(ReduceEvent);
            parser.OnTokenRead += new LALRParser.TokenReadHandler(TokenReadEvent);
            parser.OnAccept += new LALRParser.AcceptHandler(AcceptEvent);
            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        public void Parse(string source)
        {
            parser.Parse(source);

        }

        private void TokenReadEvent(LALRParser parser, TokenReadEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }

        private Object CreateObject(TerminalToken token)
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

        private void ReduceEvent(LALRParser parser, ReduceEventArgs args)
        {
            try
            {
                args.Token.UserObject = CreateObject(args.Token);
            }
            catch (Exception e)
            {
                args.Continue = false;
                //todo: Report message to UI?
            }
        }

        public static Object CreateObject(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_EOL :
                //<eol> ::= <eolSingle>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EOL2 :
                //<eol> ::= <eol> <eolSingle>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EOLSINGLE_NEWLINE :
                //<eolSingle> ::= NewLine
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EOLSINGLE_COMMENT_LINE :
                //<eolSingle> ::= Comment Line
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EOLOPTIONAL :
                //<eolOptional> ::= <eol>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EOLOPTIONAL2 :
                //<eolOptional> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_START :
                //<Start> ::= <eolOptional> <AllStatements> <EndOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL :
                //<EndOptional> ::= <eol>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END :
                //<EndOptional> ::= <eol> End <eolOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END2 :
                //<EndOptional> ::= <eol> End <Labels> <eolOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END3 :
                //<EndOptional> ::= <eol> <Labels> End <eolOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END4 :
                //<EndOptional> ::= <eol> <Labels> End <Labels> <eolOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END5 :
                //<EndOptional> ::= <eol> <Labels> <eol> End <eolOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END6 :
                //<EndOptional> ::= <eol> <Labels> <eol> End <Labels> <eolOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL2 :
                //<EndOptional> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTS :
                //<AllStatements> ::= <Statement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTS2 :
                //<AllStatements> ::= <For>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTS3 :
                //<AllStatements> ::= <AllStatements> <eol> <Statement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTS4 :
                //<AllStatements> ::= <AllStatements> <eol> <For>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_FOR_FOR_ROF :
                //<For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTSOPTIONAL :
                //<AllStatementsOptional> ::= <AllStatements> <eol>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ALLSTATEMENTSOPTIONAL2 :
                //<AllStatementsOptional> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT :
                //<Statement> ::= <Pin>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT2 :
                //<Statement> ::= <Org>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT3 :
                //<Statement> ::= <Equ>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT4 :
                //<Statement> ::= <LabelsOptional> <Operation>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_STATEMENT5 :
                //<Statement> ::= <Labels> <eol> <Operation>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PIN_PIN :
                //<Pin> ::= Pin <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ORG_ORG_LABEL :
                //<Org> ::= Org Label
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EQU_EQU :
                //<Equ> ::= <Labels> Equ <ModeOptional> <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EQU_EQU2 :
                //<Equ> ::= <Labels> <eol> Equ <ModeOptional> <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABELSOPTIONAL :
                //<LabelsOptional> ::= <Labels>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABELSOPTIONAL2 :
                //<LabelsOptional> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABEL_LABEL :
                //<Label> ::= Label
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABEL :
                //<Label> ::= <Modifier>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABEL_LABEL_AMP_LABEL :
                //<Label> ::= Label & Label
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABEL_LABEL_AMP :
                //<Label> ::= Label & <Modifier>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABEL_AMP_LABEL :
                //<Label> ::= <Modifier> & Label
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABELS :
                //<Labels> ::= <Label>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABELS2 :
                //<Labels> ::= <Labels> <eol> <Label>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABELS3 :
                //<Labels> ::= <Labels> <Label>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION :
                //<Operation> ::= <Operation0>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION2 :
                //<Operation> ::= <Operation1>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION3 :
                //<Operation> ::= <Operation2>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION0 :
                //<Operation0> ::= <Operator0>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION0_COMMA :
                //<Operation0> ::= <Operator0> <Parameter> , <Parameter>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION0_DOT_COMMA :
                //<Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION1 :
                //<Operation1> ::= <Operator1> <Parameter>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION1_DOT :
                //<Operation1> ::= <Operator1> . <Modifier> <Parameter>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION1_COMMA :
                //<Operation1> ::= <Operator1> <Parameter> , <Parameter>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION1_DOT_COMMA :
                //<Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION2_COMMA :
                //<Operation2> ::= <Operator2> <Parameter> , <Parameter>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATION2_DOT_COMMA :
                //<Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PARAMETER :
                //<Parameter> ::= <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_PARAMETER2 :
                //<Parameter> ::= <Mode> <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODEOPTIONAL :
                //<ModeOptional> ::= <Mode>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODEOPTIONAL2 :
                //<ModeOptional> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODE_NUM :
                //<Mode> ::= #
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODE_DOLLAR :
                //<Mode> ::= $
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODE_AT :
                //<Mode> ::= @
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODE_LT :
                //<Mode> ::= <
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODE_GT :
                //<Mode> ::= >
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODE_LBRACE :
                //<Mode> ::= {
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODE_RBRACE :
                //<Mode> ::= }
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODE_TIMES :
                //<Mode> ::= *
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR0_NOP :
                //<Operator0> ::= Nop
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR1_JMP :
                //<Operator1> ::= Jmp
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR1_SPL :
                //<Operator1> ::= Spl
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR1_DAT :
                //<Operator1> ::= Dat
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_MOV :
                //<Operator2> ::= Mov
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_ADD :
                //<Operator2> ::= Add
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SUB :
                //<Operator2> ::= Sub
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_MUL :
                //<Operator2> ::= Mul
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_DIV :
                //<Operator2> ::= Div
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_MOD :
                //<Operator2> ::= Mod
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_JMZ :
                //<Operator2> ::= Jmz
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_JMN :
                //<Operator2> ::= Jmn
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_DJN :
                //<Operator2> ::= Djn
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SLT :
                //<Operator2> ::= Slt
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SNE :
                //<Operator2> ::= Sne
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_LDP :
                //<Operator2> ::= Ldp
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_STP :
                //<Operator2> ::= Stp
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_CMP :
                //<Operator2> ::= Cmp
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SEQ :
                //<Operator2> ::= Seq
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_I :
                //<Modifier> ::= I
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_A :
                //<Modifier> ::= A
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_B :
                //<Modifier> ::= B
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_AB :
                //<Modifier> ::= AB
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_BA :
                //<Modifier> ::= BA
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_F :
                //<Modifier> ::= F
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MODIFIER_X :
                //<Modifier> ::= X
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONOPTIONAL :
                //<ExpressionOptional> ::= <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSIONOPTIONAL2 :
                //<ExpressionOptional> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_QUESTION_COLON :
                //<Expression> ::= <Or Exp> ? <Expression> : <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <Or Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OREXP_PIPEPIPE :
                //<Or Exp> ::= <Or Exp> || <And Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_OREXP :
                //<Or Exp> ::= <And Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ANDEXP_AMPAMP :
                //<And Exp> ::= <And Exp> && <BinOr Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ANDEXP :
                //<And Exp> ::= <BinOr Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BINOREXP_PIPE :
                //<BinOr Exp> ::= <BinOr Exp> | <BinXor Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BINOREXP :
                //<BinOr Exp> ::= <BinXor Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BINXOREXP_CARET :
                //<BinXor Exp> ::= <BinXor Exp> ^ <Equate Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_BINXOREXP :
                //<BinXor Exp> ::= <Equate Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EQUATEEXP_EQEQ :
                //<Equate Exp> ::= <Equate Exp> == <Compare Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EQUATEEXP_EXCLAMEQ :
                //<Equate Exp> ::= <Equate Exp> != <Compare Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EQUATEEXP_LTGT :
                //<Equate Exp> ::= <Equate Exp> <> <Compare Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EQUATEEXP :
                //<Equate Exp> ::= <Compare Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP_LT :
                //<Compare Exp> ::= <Compare Exp> < <Shift Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP_GT :
                //<Compare Exp> ::= <Compare Exp> > <Shift Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP_LTEQ :
                //<Compare Exp> ::= <Compare Exp> <= <Shift Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP_GTEQ :
                //<Compare Exp> ::= <Compare Exp> >= <Shift Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_COMPAREEXP :
                //<Compare Exp> ::= <Shift Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_SHIFTEXP_LTLT :
                //<Shift Exp> ::= <Shift Exp> << <Add Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_SHIFTEXP_GTGT :
                //<Shift Exp> ::= <Shift Exp> >> <Add Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_SHIFTEXP :
                //<Shift Exp> ::= <Add Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ADDEXP_PLUS :
                //<Add Exp> ::= <Add Exp> + <Mult Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ADDEXP_MINUS :
                //<Add Exp> ::= <Add Exp> - <Mult Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ADDEXP :
                //<Add Exp> ::= <Mult Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MULTEXP_TIMES :
                //<Mult Exp> ::= <Mult Exp> * <Negate Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MULTEXP_DIV :
                //<Mult Exp> ::= <Mult Exp> / <Negate Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MULTEXP_PERCENT :
                //<Mult Exp> ::= <Mult Exp> % <Negate Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_MULTEXP :
                //<Mult Exp> ::= <Negate Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_NEGATEEXP_MINUS :
                //<Negate Exp> ::= - <Value>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_NEGATEEXP :
                //<Negate Exp> ::= <Value>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VALUE_INTEGER :
                //<Value> ::= Integer
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VALUE :
                //<Value> ::= <Label>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_VALUE_LPARAN_RPARAN :
                //<Value> ::= ( <Expression> )
                //todo: Create a new object using the stored user objects.
                return null;

            }
            throw new RuleException("Unknown rule");
        }

        private void AcceptEvent(LALRParser parser, AcceptEventArgs args)
        {
            //todo: Use your fully reduced args.Token.UserObject
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
