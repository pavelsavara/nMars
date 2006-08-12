
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
        SYMBOL_EOF          =  0, // (EOF)
        SYMBOL_ERROR        =  1, // (Error)
        SYMBOL_WHITESPACE   =  2, // (Whitespace)
        SYMBOL_COMMENTLINE  =  3, // (Comment Line)
        SYMBOL_MINUS        =  4, // -
        SYMBOL_NUM          =  5, // #
        SYMBOL_DOLLAR       =  6, // $
        SYMBOL_PERCENT      =  7, // %
        SYMBOL_LPARAN       =  8, // (
        SYMBOL_RPARAN       =  9, // )
        SYMBOL_TIMES        = 10, // *
        SYMBOL_COMMA        = 11, // ,
        SYMBOL_DOT          = 12, // .
        SYMBOL_DIV          = 13, // /
        SYMBOL_AT           = 14, // @
        SYMBOL_LBRACE       = 15, // {
        SYMBOL_RBRACE       = 16, // }
        SYMBOL_PLUS         = 17, // +
        SYMBOL_LT           = 18, // <
        SYMBOL_GT           = 19, // >
        SYMBOL_A            = 20, // A
        SYMBOL_AB           = 21, // AB
        SYMBOL_ADD          = 22, // Add
        SYMBOL_B            = 23, // B
        SYMBOL_BA           = 24, // BA
        SYMBOL_CMP          = 25, // Cmp
        SYMBOL_COMMENT      = 26, // Comment
        SYMBOL_DAT          = 27, // Dat
        SYMBOL_DIV2         = 28, // Div
        SYMBOL_DJN          = 29, // Djn
        SYMBOL_END          = 30, // End
        SYMBOL_EQU          = 31, // Equ
        SYMBOL_F            = 32, // F
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
    };

    enum RuleConstants : int
    {
        RULE_NL_NEWLINE               =  0, // <nl> ::= NewLine <nl>
        RULE_NL_NEWLINE2              =  1, // <nl> ::= NewLine
        RULE_COMMENTLINE_COMMENT_LINE =  2, // <Comment Line> ::= Comment Line
        RULE_NLOPT_NEWLINE            =  3, // <nl Opt> ::= NewLine <nl Opt>
        RULE_NLOPT                    =  4, // <nl Opt> ::= 
        RULE_START                    =  5, // <Start> ::= <nl Opt> <Statements>
        RULE_START2                   =  6, // <Start> ::= <nl Opt> <Statements> <End>
        RULE_END_END                  =  7, // <End> ::= End
        RULE_END_END2                 =  8, // <End> ::= End <nl>
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

                case (int)SymbolConstants.SYMBOL_COMMENTLINE2 :
                //<Comment Line>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_END2 :
                //<End>
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

                case (int)SymbolConstants.SYMBOL_FORIN :
                //<ForIn>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FORNL :
                //<ForNl>
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

                case (int)SymbolConstants.SYMBOL_NL :
                //<nl>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_NLOPT :
                //<nl Opt>
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

                case (int)SymbolConstants.SYMBOL_ROFNL :
                //<RofNl>
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

                case (int)SymbolConstants.SYMBOL_STATEMENTNL :
                //<StatementNl>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENTS :
                //<Statements>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATEMENTSF :
                //<StatementsF>
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
                case (int)RuleConstants.RULE_NL_NEWLINE :
                //<nl> ::= NewLine <nl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NL_NEWLINE2 :
                //<nl> ::= NewLine
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_COMMENTLINE_COMMENT_LINE :
                //<Comment Line> ::= Comment Line
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NLOPT_NEWLINE :
                //<nl Opt> ::= NewLine <nl Opt>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_NLOPT :
                //<nl Opt> ::= 
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_START :
                //<Start> ::= <nl Opt> <Statements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_START2 :
                //<Start> ::= <nl Opt> <Statements> <End>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_END_END :
                //<End> ::= End
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_END_END2 :
                //<End> ::= End <nl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTS :
                //<Statements> ::= <StatementNl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTS2 :
                //<Statements> ::= <StatementNl> <Statements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTS3 :
                //<Statements> ::= <ForNl> <StatementsF> <RofNl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTS4 :
                //<Statements> ::= <ForNl> <StatementsF> <RofNl> <Statements>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTSF :
                //<StatementsF> ::= <StatementNl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTSF2 :
                //<StatementsF> ::= <StatementNl> <StatementsF>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTNL :
                //<StatementNl> ::= <Statement> <Comment Line>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENTNL2 :
                //<StatementNl> ::= <Statement> <nl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FORNL :
                //<ForNl> ::= <ForIn> <nl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FORNL2 :
                //<ForNl> ::= <ForIn> <Comment Line>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FORIN_FOR :
                //<ForIn> ::= for <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FORIN_LABEL_FOR :
                //<ForIn> ::= Label for <Expression>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ROFNL_ROF :
                //<RofNl> ::= rof <nl>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ROFNL_ROF2 :
                //<RofNl> ::= rof <Comment Line>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT :
                //<Statement> ::= <Operation>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATEMENT_LABEL :
                //<Statement> ::= Label <Operation>
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

                case (int)RuleConstants.RULE_OPERATOR2_DAT :
                //<Operator2> ::= Dat
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATOR2_SPL :
                //<Operator2> ::= Spl
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

                case (int)RuleConstants.RULE_ORG_ORG_LABEL :
                //<Org> ::= Org Label
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EQU_LABEL_EQU :
                //<Equ> ::= Label Equ <Expression>
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

                case (int)RuleConstants.RULE_EXPRESSION_PLUS :
                //<Expression> ::= <Expression> + <Mult Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION_MINUS :
                //<Expression> ::= <Expression> - <Mult Exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRESSION :
                //<Expression> ::= <Mult Exp>
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

                case (int)RuleConstants.RULE_NEGATEEXP :
                //<Negate Exp> ::= <Value>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE_INTEGER :
                //<Value> ::= Integer
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_VALUE_LABEL :
                //<Value> ::= Label
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
