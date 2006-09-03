
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
        SYMBOL_EOF                     =  0, // (EOF)
        SYMBOL_ERROR                   =  1, // (Error)
        SYMBOL_WHITESPACE              =  2, // (Whitespace)
        SYMBOL_COMMENTLINE             =  3, // (Comment Line)
        SYMBOL_MINUS                   =  4, // -
        SYMBOL_NUM                     =  5, // #
        SYMBOL_DOLLAR                  =  6, // $
        SYMBOL_PERCENT                 =  7, // %
        SYMBOL_LPARAN                  =  8, // (
        SYMBOL_RPARAN                  =  9, // )
        SYMBOL_TIMES                   = 10, // *
        SYMBOL_COMMA                   = 11, // ,
        SYMBOL_DOT                     = 12, // .
        SYMBOL_DIV                     = 13, // /
        SYMBOL_AT                      = 14, // @
        SYMBOL_LBRACE                  = 15, // {
        SYMBOL_RBRACE                  = 16, // }
        SYMBOL_PLUS                    = 17, // +
        SYMBOL_LT                      = 18, // <
        SYMBOL_GT                      = 19, // >
        SYMBOL_A                       = 20, // A
        SYMBOL_AB                      = 21, // AB
        SYMBOL_ADD                     = 22, // Add
        SYMBOL_B                       = 23, // B
        SYMBOL_BA                      = 24, // BA
        SYMBOL_CMP                     = 25, // Cmp
        SYMBOL_COMMENT                 = 26, // Comment
        SYMBOL_DAT                     = 27, // Dat
        SYMBOL_DIV2                    = 28, // Div
        SYMBOL_DJN                     = 29, // Djn
        SYMBOL_END                     = 30, // End
        SYMBOL_EQU                     = 31, // Equ
        SYMBOL_F                       = 32, // F
        SYMBOL_FOR                     = 33, // for
        SYMBOL_I                       = 34, // I
        SYMBOL_INTEGER                 = 35, // Integer
        SYMBOL_JMN                     = 36, // Jmn
        SYMBOL_JMP                     = 37, // Jmp
        SYMBOL_JMZ                     = 38, // Jmz
        SYMBOL_LABEL                   = 39, // Label
        SYMBOL_LDP                     = 40, // Ldp
        SYMBOL_LINE                    = 41, // Line
        SYMBOL_MOD                     = 42, // Mod
        SYMBOL_MOV                     = 43, // Mov
        SYMBOL_MUL                     = 44, // Mul
        SYMBOL_NEWLINE                 = 45, // NewLine
        SYMBOL_NOP                     = 46, // Nop
        SYMBOL_ORG                     = 47, // Org
        SYMBOL_PIN                     = 48, // Pin
        SYMBOL_ROF                     = 49, // rof
        SYMBOL_SEQ                     = 50, // Seq
        SYMBOL_SLT                     = 51, // Slt
        SYMBOL_SNE                     = 52, // Sne
        SYMBOL_SPL                     = 53, // Spl
        SYMBOL_STP                     = 54, // Stp
        SYMBOL_SUB                     = 55, // Sub
        SYMBOL_X                       = 56, // X
        SYMBOL_ALLSTATEMENTS           = 57, // <AllStatements>
        SYMBOL_ENDOPTIONAL             = 58, // <EndOptional>
        SYMBOL_EOL                     = 59, // <eol>
        SYMBOL_EOLOPTIONAL             = 60, // <eolOptional>
        SYMBOL_EOLSINGLE               = 61, // <eolSingle>
        SYMBOL_EQU2                    = 62, // <Equ>
        SYMBOL_EXPRESSION              = 63, // <Expression>
        SYMBOL_FOR2                    = 64, // <For>
        SYMBOL_INNERSTATEMENTS         = 65, // <InnerStatements>
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
    };

    enum RuleConstants : int
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

                case (int)SymbolConstants.SYMBOL_AT :
                //@
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LBRACE :
                //{
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

                case (int)SymbolConstants.SYMBOL_GT :
                //>
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

                case (int)SymbolConstants.SYMBOL_ALLSTATEMENTS :
                //<AllStatements>
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

                case (int)SymbolConstants.SYMBOL_EXPRESSION :
                //<Expression>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR2 :
                //<For>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INNERSTATEMENTS :
                //<InnerStatements>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_INNERSTATEMENTSOPTIONAL :
                //<InnerStatementsOptional>
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

                case (int)RuleConstants.RULE_ENDOPTIONAL_END :
                //<EndOptional> ::= <eol> End <eolOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END_LABEL :
                //<EndOptional> ::= <eol> End Label <eolOptional>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL :
                //<EndOptional> ::= <eol>
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
                //<For> ::= <LabelsOptional> for <Expression> <eol> <InnerStatementsOptional> rof
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INNERSTATEMENTSOPTIONAL :
                //<InnerStatementsOptional> ::= <InnerStatements> <eol>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INNERSTATEMENTSOPTIONAL2 :
                //<InnerStatementsOptional> ::= 
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INNERSTATEMENTS :
                //<InnerStatements> ::= <Statement>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_INNERSTATEMENTS2 :
                //<InnerStatements> ::= <InnerStatements> <eol> <Statement>
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
                //<Equ> ::= <Labels> Equ <Expression>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EQU_EQU2 :
                //<Equ> ::= <Labels> <eol> Equ <Expression>
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

                case (int)RuleConstants.RULE_LABELS_LABEL :
                //<Labels> ::= Label
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_LABELS_LABEL2 :
                //<Labels> ::= <Labels> <eol> Label
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

                case (int)RuleConstants.RULE_EXPRESSION_PLUS :
                //<Expression> ::= <Expression> + <Mult Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_MINUS :
                //<Expression> ::= <Expression> - <Mult Exp>
                //todo: Create a new object using the stored user objects.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <Mult Exp>
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

                case (int)RuleConstants.RULE_VALUE_LABEL :
                //<Value> ::= Label
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
