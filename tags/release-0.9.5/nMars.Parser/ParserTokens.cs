// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using com.calitha.goldparser;
using nMars.Parser.Expressions;
using nMars.Parser.Statements;
using nMars.RedCode;
using ParserException=nMars.RedCode.ParserException;

namespace nMars.Parser
{
    public abstract class ParserTokens : BaseParser
    {
        #region Initialization

        protected ParserTokens()
        {
            Assembly assembly = typeof(ParserTokens).Assembly;
            Stream redCode = assembly.GetManifestResourceStream("nMars.Parser.Properties.RedCode.cgt");
            if (redCode == null)
            {
                redCode = assembly.GetManifestResourceStream("RedCode.cgt");
            }
            if (redCode == null)
            {
                throw new ApplicationException("Couldn't load parser structures.");
            }
            Init(redCode);
        }


        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnReduce += new LALRParser.ReduceHandler(OnReduce);
            parser.OnTokenRead += new LALRParser.TokenReadHandler(OnTokenRead);
            parser.OnShift += new LALRParser.ShiftHandler(OnShift);
            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        #endregion

        #region Preprocessing

        protected ContainerStatement ParseInternal(string source)
        {
            //;redcode
            Match sta = start.Match(source);
            if (sta != null && sta.Success && sta.Index > 0)
            {
                string pre = source.Substring(0, sta.Index+1);
                string prere = Regex.Replace(pre, "^.?", ";", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                source = 
                    prere + 
                    source.Substring(sta.Index+1);
            }
            sta = for0.Match(source);
            if (sta != null && sta.Success && sta.Index > 0)
            {
                string pre = source.Substring(0, sta.Index);
                string mid = source.Substring(sta.Index);
                Match end = rof.Match(mid);
                if (end != null && end.Success && end.Index > 0)
                {
                    mid = mid.Substring(0,end.Index+3);
                    string post = source.Substring(sta.Index + end.Index + 3);
                    source = pre + Regex.Replace(mid, "^.?", ";", RegexOptions.IgnoreCase | RegexOptions.Multiline) + post;
                }
            }
            if (!source.EndsWith("\n"))
                source = source + "\n";
            source = Regex.Replace(source, "^;assert", "@assert", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            endSymbol = 0;

            return (ContainerStatement)parser.Parse(source).UserObject;
        }

        private static Regex start;
        private static Regex for0;
        private static Regex rof;
        static ParserTokens()
        {
            start = new Regex("^;redcode", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);
            for0 = new Regex("^.*for 0", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);
            rof = new Regex("rof", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);
        }

        #endregion

        #region 

        protected void ProcessComments(List<string> comments)
        {
            foreach (string comment in comments)
            {
                string lcomment = comment.ToLower();
                if (lcomment.StartsWith("assert "))
                {
                    CheckAssert(lcomment.Substring(7));
                }
                else if (lcomment.StartsWith("name "))
                {
                    warriorName = comment.Substring(5).Trim();
                }
                else if (lcomment.StartsWith("author "))
                {
                    authorName = comment.Substring(7).Trim();
                }
            }
        }

        protected void CheckAssert(string assert)
        {
            //TODO
        }

        private void OnTokenRead(LALRParser argParser, TokenReadEventArgs args)
        {
            if (endSymbol == 2)
            {
                TerminalToken eofToken =
                    new TerminalToken(SymbolCollection.EOF, SymbolCollection.EOF.Name, args.Token.Location);
                argParser.lookahead = eofToken;
                endSymbol = 3;
                return;
            }
            args.Token.UserObject = CreateObject(args.Token, argParser);
        }

        private void OnReduce(LALRParser argParser, ReduceEventArgs args)
        {
            args.Token.UserObject = CreateObject(args.Token, argParser);
            if (endSymbol == 2)
            {
                TerminalToken eofToken =
                    new TerminalToken(SymbolCollection.EOF, SymbolCollection.EOF.Name, args.Token.Location);
                argParser.lookahead = eofToken;
                endSymbol = 3;
            }
        }

        void OnShift(LALRParser argParser, ShiftEventArgs args)
        {
            if (endSymbol == 2)
            {
                TerminalToken eofToken =
                    new TerminalToken(SymbolCollection.EOF, SymbolCollection.EOF.Name, args.Token.Location);
                argParser.lookahead = eofToken;
                endSymbol = 3;
            }
        }

        #endregion

        #region Terminal

        private Object CreateObject(TerminalToken token, LALRParser argParser)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_INTEGER:
                    //Integer
                    return token.Text;

                case (int)SymbolConstants.SYMBOL_NEWLINE:
                    if (endSymbol == 1)
                    {
                        endSymbol = 2;
                    }
                    return token.UserObject;

                case (int)SymbolConstants.SYMBOL_LABEL:
                    //Variable
                    if (token.Text.EndsWith(":"))
                    {
                        return token.Text.Substring(0, token.Text.Length - 1);
                    }
                    return token.Text;
                case (int)SymbolConstants.SYMBOL_END:
                    //end
                    endSymbol = 1;
                    return null;
                default:
                    return null;
            }
        }

        #endregion

        #region Nonterminal

        public Object CreateObject(NonterminalToken token, LALRParser argParser)
        {
            Expression expression;
            Operation op;
            Modifier mod;
            Parameter paramA;
            Parameter paramB;
            EquStatement equ;
            Statement statement;
            ContainerStatement statements;
            ForRofContainerStatement forrof;
            List<LabelName> labels;
            List<string> comments;
            string labell;

            switch (token.Rule.Id)
            {
                    #region Comment

                case (int)RuleConstants.RULE_EOL:
                    //<eol> ::= <eolSingle>
                    comments = new List<string>();
                    if (token.Tokens[0].UserObject != null)
                    {
                        string c = (string)token.Tokens[0].UserObject;
                        comments.Add(c.Replace("\r", ""));
                    }
                    return comments;

                case (int)RuleConstants.RULE_EOL2:
                    //<eol> ::= <eol> <eolSingle>
                    comments = (List<string>)token.Tokens[0].UserObject;
                    if (token.Tokens[1].UserObject != null)
                    {
                        string c = (string)token.Tokens[1].UserObject;
                        comments.Add(c.Replace("\r", ""));
                    }
                    return comments;

                case (int)RuleConstants.RULE_EOLSINGLE_NEWLINE:
                    //<eolSingle> ::= NewLine
                    return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_EOLOPTIONAL2:
                    //<eolOptional> ::= 
                    comments = new List<string>();
                    return comments;

                case (int)RuleConstants.RULE_EOLOPTIONAL:
                    //<eolOptional> ::= <eol>
                    return token.Tokens[0].UserObject;

                    #endregion

                    #region Null

                case (int)RuleConstants.RULE_EOLSINGLE_COMMENT_LINE:
                    //<eolSingle> ::= Comment Line

                case (int)RuleConstants.RULE_STATEMENT:
                    //<Statement> ::= <Pin>

                case (int)RuleConstants.RULE_STATEMENT2:
                    //<Statement> ::= <Org>

                case (int)RuleConstants.RULE_EXPRESSIONOPTIONAL:
                    // <ExpressionOptional> ::= <Expression>

                case (int)RuleConstants.RULE_EXPRESSIONOPTIONAL2:
                    // <ExpressionOptional> ::= 


                    return null;

                    #endregion

                    #region Forward

                case (int)RuleConstants.RULE_MODEOPTIONAL:
                    // <ModeOptional> ::= <Mode>

                case (int)RuleConstants.RULE_OPERATION:
                    //<Operation> ::= <Operation0>

                case (int)RuleConstants.RULE_OPERATION2:
                    //<Operation> ::= <Operation1>

                case (int)RuleConstants.RULE_OPERATION3:
                    //<Operation> ::= <Operation2>

                case (int)RuleConstants.RULE_EXPRESSION:
                    //<Expression> ::= <Or Exp>

                case (int)RuleConstants.RULE_OREXP:
                    //<Or Exp> ::= <And Exp>

                case (int)RuleConstants.RULE_ANDEXP:
                    //<And Exp> ::= <BinOr Exp>

                case (int)RuleConstants.RULE_BINOREXP:
                    //<BinOr Exp> ::= <BinXor Exp>

                case (int)RuleConstants.RULE_BINXOREXP:
                    //<BinXor Exp> ::= <BinAnd Exp>

                case (int)RuleConstants.RULE_BINANDEXP:
                    // <BinAnd Exp> ::= <Equate Exp>

                case (int)RuleConstants.RULE_EQUATEEXP:
                    //<Equate Exp> ::= <Compare Exp>

                case (int)RuleConstants.RULE_COMPAREEXP:
                    //<Compare Exp> ::= <Shift Exp>

                case (int)RuleConstants.RULE_SHIFTEXP:
                    //<Shift Exp> ::= <Add Exp>

                case (int)RuleConstants.RULE_ADDEXP:
                    //<Add Exp> ::= <Mult Exp>

                case (int)RuleConstants.RULE_MULTEXP:
                    //<Mult Exp> ::= <Negate Exp>

                case (int)RuleConstants.RULE_NEGATEEXP:
                    //<Negate Exp> ::= <Value>

                case (int)RuleConstants.RULE_VALUE:
                    // <Value> ::= <Label>

                case (int)RuleConstants.RULE_LABELSOPTIONAL:
                    //<LabelsOptional> ::= <Labels>

                case (int)RuleConstants.RULE_STATEMENT3:
                    //<Statement> ::= <Equ>

                case (int)RuleConstants.RULE_STATEMENT6:
                    // <Statement> ::= <Assert>

                    return token.Tokens[0].UserObject;

                    #endregion

                    #region Statements

                case (int)RuleConstants.RULE_START:
                    //<Start> ::= <eolOptional> <AllStatements> <EndOptional>
                    comments = (List<string>)token.Tokens[0].UserObject;
                    ProcessComments(comments);
                    if (endSymbol<2)
                        endSymbol = 2;
                    statements = (ContainerStatement)token.Tokens[1].UserObject;
                    statement = (Statement)token.Tokens[2].UserObject;
                    if (statement!=null)
                    {
                        statements.Add(statement);
                    }
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTS:
                    //<AllStatements> ::= <Statement>
                    statement = (Statement)token.Tokens[0].UserObject;
                    statements = new ContainerStatement(statement, token.Location);
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTSOPTIONAL:
                    //<AllStatementsOptional> ::= <AllStatements> <eol>
                    statements = (ContainerStatement)token.Tokens[0].UserObject;
                    comments = (List<string>)token.Tokens[1].UserObject;
                    statements.AppendComments(comments);
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTS3:
                    //<AllStatements> ::= <AllStatements> <eol> <Statement>
                    statements = (ContainerStatement)token.Tokens[0].UserObject;
                    statement = (Statement)token.Tokens[2].UserObject;
                    comments = (List<string>)token.Tokens[1].UserObject;
                    statements.AppendComments(comments);
                    statements.Add(statement);
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTS4:
                    //<AllStatements> ::= <AllStatements> <eol> <For>
                    statements = (ContainerStatement)token.Tokens[0].UserObject;
                    comments = (List<string>)token.Tokens[1].UserObject;
                    statements.AppendComments(comments);
                    forrof = (ForRofContainerStatement)token.Tokens[2].UserObject;
                    statements.Add(forrof);
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTS2:
                    //<AllStatements> ::= <For>
                    statements = new ContainerStatement(token.Location);
                    forrof = (ForRofContainerStatement)token.Tokens[0].UserObject;
                    statements.Add(forrof);
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTSOPTIONAL2:
                    //<AllStatementsOptional> ::= 
                    statements = new ContainerStatement(token.Location);
                    return statements;

                case (int)RuleConstants.RULE_FOR_FOR_ROF2:
                    // <For> ::= <Labels> <eol> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
                    labels = ((List<LabelName>)token.Tokens[0].UserObject);
                    expression = (Expression)token.Tokens[3].UserObject;
                    comments = (List<string>)token.Tokens[4].UserObject;
                    statement = (Statement)token.Tokens[5].UserObject;
                    forrof = CreateForrof(comments, expression, statement, labels, token);
                    return forrof;

                case (int)RuleConstants.RULE_FOR_FOR_ROF:
                    // <For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
                    labels = ((List<LabelName>)token.Tokens[0].UserObject);
                    expression = (Expression)token.Tokens[2].UserObject;
                    comments = (List<string>)token.Tokens[3].UserObject;
                    statement = (Statement)token.Tokens[4].UserObject;
                    forrof = CreateForrof(comments, expression, statement, labels, token);
                    return forrof;
                case (int)RuleConstants.RULE_ASSERT_ATASSERT:
                    // <Assert> ::= @assert <Expression>
                    expression = (Expression)token.Tokens[1].UserObject;
                    return new AssertStatement(expression, token.Location);
                    #endregion

                    #region Operation Statements

                case (int)RuleConstants.RULE_STATEMENT4:
                    //<Statement> ::= <LabelsOptional> <Operation>
                    labels = (List<LabelName>)token.Tokens[0].UserObject;
                    statement = (InstructionStatement)token.Tokens[1].UserObject;
                    statement.Labels = labels;
                    foreach (LabelName label in labels)
                    {
                        variables[label.Name] = label;
                    }
                    return statement;

                case (int)RuleConstants.RULE_STATEMENT5:
                    //<Statement> ::= <Labels> <eol> <Operation>
                    labels = (List<LabelName>)token.Tokens[0].UserObject;
                    statement = (InstructionStatement)token.Tokens[2].UserObject;
                    statement.Labels = labels;
                    foreach (LabelName label in labels)
                    {
                        variables[label.Name] = label;
                    }
                    return statement;

                    #endregion

                    #region Simple Statements

                case (int)RuleConstants.RULE_MODEOPTIONAL2:
                // <ModeOptional> ::= 
                    return Mode.NULL;

                case (int)RuleConstants.RULE_PIN_PIN:
                    //<Pin> ::= Pin <Expression>
                    pin = (Expression)token.Tokens[1].UserObject;
                    return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL:
                //<EndOptional> ::= <eol>

                case (int)RuleConstants.RULE_ENDOPTIONAL2:
                //<EndOptional> ::= 

                case (int)RuleConstants.RULE_ENDOPTIONAL_END:
                //<EndOptional> ::= <eol> End <eolOptional>
                    if (endSymbol < 2)
                        endSymbol = 2;
                    return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END3:
                //<EndOptional> ::= <eol> <Labels> End <eolOptional>

                case (int)RuleConstants.RULE_ENDOPTIONAL_END5:
                //<EndOptional> ::= <eol> <Labels> <eol> End <eolOptional>
                    if (endSymbol < 2)
                        endSymbol = 2;
                    labels = (List<LabelName>)token.Tokens[1].UserObject;
                    labels.Add(new LabelName(token.Tokens[1].Location, "#end#"));
                    statement = new EquStatement(null, token.Location);
                    statement.Labels = labels;
                    return statement;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END2:
                    //<EndOptional> ::= <eol> End <Expression> <eolOptional>
                    org = (Expression)token.Tokens[2].UserObject;
                    if (endSymbol < 2) 
                        endSymbol = 2;
                    return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END4:
                    //<EndOptional> ::= <eol> <Labels> End <Expression> <eolOptional>
                    org = (Expression)token.Tokens[3].UserObject;
                    if (endSymbol < 2)
                        endSymbol = 2;
                    labels = (List<LabelName>)token.Tokens[1].UserObject;
                    labels.Add(new LabelName(token.Tokens[1].Location, "#end#"));
                    statement = new EquStatement(null, token.Location);
                    statement.Labels = labels;
                    return statement;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END6:
                    //<EndOptional> ::= <eol> <Labels> <eol> End <Expression> <eolOptional>
                    org = (Expression)token.Tokens[4].UserObject;
                    if (endSymbol < 2)
                        endSymbol = 2;
                    labels = (List<LabelName>)token.Tokens[1].UserObject;
                    labels.Add(new LabelName(token.Tokens[1].Location, "#end#"));
                    statement = new EquStatement(null, token.Location);
                    statement.Labels = labels;
                    return statement;

                case (int)RuleConstants.RULE_ORG_ORG:
                    //<Org> ::= Org <Expression>
                    org = (Expression)token.Tokens[1].UserObject;
                    return null;

                case (int)RuleConstants.RULE_EQU_EQU:
                    // <Equ> ::= <Labels> Equ <ModeOptional> <Expression>
                    labels = (List<LabelName>)token.Tokens[0].UserObject;
                    expression = (Expression)token.Tokens[3].UserObject;
                    Mode mode = (Mode)token.Tokens[2].UserObject;
                    if (mode!=Mode.NULL)
                    {
                        expression = new ModifiedExpression(token.Tokens[2].Location, expression, mode);
                    }
                    equ = new EquStatement(expression, token.Location);
                    equ.Labels = labels;
                    foreach (LabelName label in labels)
                    {
                        CheckName(label.Name, token.Tokens[1].Location);
                        variables[label.Name] = expression;
                    }
                    return equ;

                case (int)RuleConstants.RULE_EQU_EQU2:
                    // <Equ> ::= <Labels> <eol> Equ <ModeOptional> <Expression>
                    labels = (List<LabelName>)token.Tokens[0].UserObject;
                    expression = (Expression)token.Tokens[4].UserObject;
                    equ = new EquStatement(expression, token.Location);
                    equ.Labels = labels;
                    foreach (LabelName label in labels)
                    {
                        CheckName(label.Name, token.Tokens[2].Location);
                        variables[label.Name] = expression;
                    }
                    return equ;

                    #endregion

                    #region Labels

                case (int)RuleConstants.RULE_LABEL:
                    // <Label> ::= <Modifier>
                    labell = token.Tokens[0].UserObject as string;
                    if (labell == null)
                    {
                        labell = token.Tokens[0].UserObject.ToString();
                    }
                    // CheckName(labell, token.Tokens[0].Location);                
                    return new LabelName(token.Tokens[0].Location, labell);

                case (int)RuleConstants.RULE_LABEL_LABEL_AMP:
                    // <Label> ::= Label & <Modifier>
                    labell = token.Tokens[2].UserObject as string;
                    if (labell == null)
                    {
                        labell = token.Tokens[2].UserObject.ToString();
                    }
                    return new ComposedLabelName(token.Tokens[0].Location, (string)token.Tokens[0].UserObject, labell);

                case (int)RuleConstants.RULE_LABEL_AMP_LABEL:
                    // <Label> ::= <Modifier> & Label
                    labell = token.Tokens[0].UserObject as string;
                    if (labell == null)
                    {
                        labell = token.Tokens[0].UserObject.ToString();
                    }
                    return new ComposedLabelName(token.Tokens[0].Location, labell, (string)token.Tokens[2].UserObject);

                case (int)RuleConstants.RULE_LABEL_LABEL:
                    // <Label> ::= Label
                    labell = (string)token.Tokens[0].UserObject;
                    // CheckName(labell, token.Tokens[0].Location);
                    return new LabelName(token.Tokens[0].Location, labell);

                case (int)RuleConstants.RULE_LABEL_LABEL_AMP_LABEL:
                    // <Label> ::= Label & Label
                    return new ComposedLabelName(token.Tokens[0].Location, (string)token.Tokens[0].UserObject, (string)token.Tokens[2].UserObject);

                case (int)RuleConstants.RULE_LABELSOPTIONAL2:
                    //<LabelsOptional> ::= 
                    labels = new List<LabelName>();
                    return labels;

                case (int)RuleConstants.RULE_LABELS:
                    // <Labels> ::= <Label>
                    labels = new List<LabelName>();
                    labels.Add((LabelName)token.Tokens[0].UserObject);
                    return labels;

                case (int)RuleConstants.RULE_LABELS2:
                    // <Labels> ::= <Labels> <eol> <Label>
                    labels = (List<LabelName>)token.Tokens[0].UserObject;
                    labels.Add((LabelName)token.Tokens[2].UserObject);
                    return labels;

                case (int)RuleConstants.RULE_LABELS3:
                    // <Labels> ::= <Labels> <Label>
                    labels = (List<LabelName>)token.Tokens[0].UserObject;
                    labels.Add((LabelName)token.Tokens[1].UserObject);
                    return labels;

                    #endregion

                    #region Operations
                case (int)RuleConstants.RULE_OPERATION0:
                    //<Operation0> ::= <Operator0>
                    op = (Operation)token.Tokens[0].UserObject;
                    paramA = new Parameter();
                    paramB = new Parameter();
                    mod = Modifier.NULL;
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION0_DOT2:
                    // <Operation0> ::= <Operator0> . <Modifier>
                    op = (Operation)token.Tokens[0].UserObject;
                    mod = (Modifier)token.Tokens[2].UserObject;
                    paramA = new Parameter();
                    paramB = new Parameter();
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION0_COMMA:
                    //<Operation0> ::= <Operator0> <Parameter> , <Parameter>
                    op = (Operation)token.Tokens[0].UserObject;
                    paramA = (Parameter)token.Tokens[1].UserObject;
                    paramB = (Parameter)token.Tokens[3].UserObject;
                    mod = Modifier.NULL;
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION0_DOT_COMMA:
                    //<Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation)token.Tokens[0].UserObject;
                    mod = (Modifier)token.Tokens[2].UserObject;
                    paramA = (Parameter)token.Tokens[3].UserObject;
                    paramB = (Parameter)token.Tokens[5].UserObject;
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION02:
                    //<Operation0> ::= <Operator0> <Parameter>
                case (int)RuleConstants.RULE_OPERATION1:
                    //<Operation1> ::= <Operator1> <Parameter>
                    op = (Operation)token.Tokens[0].UserObject;
                    if (op == Operation.DAT)
                    {
                        paramA = new Parameter();
                        paramA.Mode = Mode.Immediate;
                        paramB = (Parameter)token.Tokens[1].UserObject;
                    }
                    else
                    {
                        paramA = (Parameter)token.Tokens[1].UserObject;
                        paramB = new Parameter();
                    }
                    mod = Modifier.NULL;
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION0_DOT:
                    //<Operation0> ::= <Operator0> . <Modifier> <Parameter>
                case (int)RuleConstants.RULE_OPERATION1_DOT:
                    //<Operation1> ::= <Operator1> . <Modifier> <Parameter>
                    op = (Operation)token.Tokens[0].UserObject;
                    mod = (Modifier)token.Tokens[2].UserObject;
                    if (op == Operation.DAT)
                    {
                        paramA = new Parameter();
                        paramA.Mode = Mode.Immediate;
                        paramB = (Parameter)token.Tokens[3].UserObject;
                    }
                    else
                    {
                        paramA = (Parameter)token.Tokens[3].UserObject;
                        paramB = new Parameter();
                    }
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION1_COMMA:
                    //<Operation1> ::= <Operator1> <Parameter> , <Parameter>
                    op = (Operation)token.Tokens[0].UserObject;
                    paramA = (Parameter)token.Tokens[1].UserObject;
                    paramB = (Parameter)token.Tokens[3].UserObject;
                    mod = Modifier.NULL;
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION1_DOT_COMMA:
                    //<Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation)token.Tokens[0].UserObject;
                    mod = (Modifier)token.Tokens[2].UserObject;
                    paramA = (Parameter)token.Tokens[3].UserObject;
                    paramB = (Parameter)token.Tokens[5].UserObject;
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION2_COMMA:
                    //<Operation2> ::= <Operator2> <Parameter> , <Parameter>
                    op = (Operation)token.Tokens[0].UserObject;
                    paramA = (Parameter)token.Tokens[1].UserObject;
                    paramB = (Parameter)token.Tokens[3].UserObject;
                    mod = Modifier.NULL;
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                case (int)RuleConstants.RULE_OPERATION2_DOT_COMMA:
                    //<Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation)token.Tokens[0].UserObject;
                    mod = (Modifier)token.Tokens[2].UserObject;
                    paramA = (Parameter)token.Tokens[3].UserObject;
                    paramB = (Parameter)token.Tokens[5].UserObject;
                    return new InstructionStatement(op, mod, paramA, paramB, token.Tokens[0].Location);

                    #endregion

                    #region Parameters

                case (int)RuleConstants.RULE_PARAMETER:
                    //<Parameter> ::= <Expression>
                    return new Parameter(Mode.NULL, (Expression)token.Tokens[0].UserObject);

                case (int)RuleConstants.RULE_PARAMETER2:
                    //<Parameter> ::= <Mode> <Expression>
                    return new Parameter((Mode)token.Tokens[0].UserObject, (Expression)token.Tokens[1].UserObject);

                    #endregion

                    #region Mode

                case (int)RuleConstants.RULE_MODE_NUM:
                    //<Mode> ::= #
                    //todo: Create a new object using the stored user objects.
                    return Mode.Immediate;

                case (int)RuleConstants.RULE_MODE_DOLLAR:
                    //<Mode> ::= $
                    return Mode.Direct;

                case (int)RuleConstants.RULE_MODE_AT:
                    //<Mode> ::= @
                    return Mode.IndirectB;

                case (int)RuleConstants.RULE_MODE_LT:
                    //<Mode> ::= <
                    return Mode.PreDecIndirectB;

                case (int)RuleConstants.RULE_MODE_GT:
                    //<Mode> ::= >
                    return Mode.PostIncIndirectB;

                case (int)RuleConstants.RULE_MODE_LBRACE:
                    //<Mode> ::= {
                    return Mode.PreDecIndirectA;

                case (int)RuleConstants.RULE_MODE_RBRACE:
                    //<Mode> ::= }
                    return Mode.PostIncIndirectA;

                case (int)RuleConstants.RULE_MODE_TIMES:
                    //<Mode> ::= *
                    return Mode.IndirectA;

                    #endregion

                    #region Operator

                case (int)RuleConstants.RULE_OPERATOR0_NOP:
                    //<Operator0> ::= Nop
                    return Operation.NOP;

                case (int)RuleConstants.RULE_OPERATOR1_JMP:
                    //<Operator1> ::= Jmp
                    return Operation.JMP;

                case (int)RuleConstants.RULE_OPERATOR1_DAT:
                    //<Operator2> ::= Dat
                    return Operation.DAT;

                case (int)RuleConstants.RULE_OPERATOR1_SPL:
                    //<Operator2> ::= Spl
                    return Operation.SPL;

                case (int)RuleConstants.RULE_OPERATOR2_MOV:
                    //<Operator2> ::= Mov
                    return Operation.MOV;

                case (int)RuleConstants.RULE_OPERATOR2_ADD:
                    //<Operator2> ::= Add
                    return Operation.ADD;

                case (int)RuleConstants.RULE_OPERATOR2_SUB:
                    //<Operator2> ::= Sub
                    return Operation.SUB;

                case (int)RuleConstants.RULE_OPERATOR2_MUL:
                    //<Operator2> ::= Mul
                    return Operation.MUL;

                case (int)RuleConstants.RULE_OPERATOR2_DIV:
                    //<Operator2> ::= Div
                    return Operation.DIV;

                case (int)RuleConstants.RULE_OPERATOR2_MOD:
                    //<Operator2> ::= Mod
                    return Operation.MOD;

                case (int)RuleConstants.RULE_OPERATOR2_JMZ:
                    //<Operator2> ::= Jmz
                    return Operation.JMZ;

                case (int)RuleConstants.RULE_OPERATOR2_JMN:
                    //<Operator2> ::= Jmn
                    return Operation.JMN;

                case (int)RuleConstants.RULE_OPERATOR2_DJN:
                    //<Operator2> ::= Djn
                    return Operation.DJN;

                case (int)RuleConstants.RULE_OPERATOR2_SLT:
                    //<Operator2> ::= Slt
                    return Operation.SLT;

                case (int)RuleConstants.RULE_OPERATOR2_SNE:
                    //<Operator2> ::= Sne
                    return Operation.SNE;

                case (int)RuleConstants.RULE_OPERATOR2_LDP:
                    //<Operator2> ::= Ldp
                    return Operation.LDP;

                case (int)RuleConstants.RULE_OPERATOR2_STP:
                    //<Operator2> ::= Stp
                    return Operation.STP;

                case (int)RuleConstants.RULE_OPERATOR2_CMP:
                    //<Operator2> ::= Cmp
                    return Operation.CMP;

                case (int)RuleConstants.RULE_OPERATOR2_SEQ:
                    //<Operator2> ::= Seq
                    return Operation.CMP;

                    #endregion

                    #region Modifiers

                case (int)RuleConstants.RULE_MODIFIER_I:
                    //<Modifier> ::= I
                    return Modifier.I;

                case (int)RuleConstants.RULE_MODIFIER_A:
                    //<Modifier> ::= A
                    return Modifier.A;

                case (int)RuleConstants.RULE_MODIFIER_B:
                    //<Modifier> ::= B
                    return Modifier.B;

                case (int)RuleConstants.RULE_MODIFIER_AB:
                    //<Modifier> ::= AB
                    return Modifier.AB;

                case (int)RuleConstants.RULE_MODIFIER_BA:
                    //<Modifier> ::= BA
                    return Modifier.BA;

                case (int)RuleConstants.RULE_MODIFIER_F:
                    //<Modifier> ::= F
                    return Modifier.F;

                case (int)RuleConstants.RULE_MODIFIER_X:
                    //<Modifier> ::= X
                    return Modifier.X;

                    #endregion

                    #region Expressions

                case (int)RuleConstants.RULE_EXPRESSION_QUESTION_COLON:
                    //<Expression> ::= <Or Exp> ? <Expression> : <Expression>
                    return
                        new TernaryExpression(token.Tokens[1].Location, 
                                              (Expression)token.Tokens[0].UserObject,
                                              (Expression)token.Tokens[2].UserObject,
                                              (Expression)token.Tokens[4].UserObject,
                                              TernaryExpression.TernaryOperation.If);

                case (int)RuleConstants.RULE_OREXP_PIPEPIPE:
                    //<Or Exp> ::= <Or Exp> || <And Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject, BinaryExpression.BinaryOperation.Or);

                case (int)RuleConstants.RULE_ANDEXP_AMPAMP:
                    //<And Exp> ::= <And Exp> && <BinOr Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.And);

                case (int)RuleConstants.RULE_BINOREXP_PIPE:
                    //<BinOr Exp> ::= <BinOr Exp> | <BinXor Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.BinOr);

                case (int)RuleConstants.RULE_BINXOREXP_CARET:
                    //<BinXor Exp> ::= <BinXor Exp> ^ <BinAnd Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.BinXor);

                case (int)RuleConstants.RULE_BINANDEXP_AMPAMPAMP:
                    // <BinAnd Exp> ::= <BinAnd Exp> &&& <Equate Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.BinAnd);

                case (int)RuleConstants.RULE_EQUATEEXP_EQEQ:
                    //<Equate Exp> ::= <Equate Exp> == <Compare Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareEq);

                case (int)RuleConstants.RULE_EQUATEEXP_LTGT:
                    //<Equate Exp> ::= <Equate Exp> <> <Compare Exp>

                case (int)RuleConstants.RULE_EQUATEEXP_EXCLAMEQ:
                    //<Equate Exp> ::= <Equate Exp> != <Compare Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareNe);

                case (int)RuleConstants.RULE_COMPAREEXP_LT:
                    //<Compare Exp> ::= <Compare Exp> < <Shift Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareLt);

                case (int)RuleConstants.RULE_COMPAREEXP_GT:
                    //<Compare Exp> ::= <Compare Exp> > <Shift Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareGt);

                case (int)RuleConstants.RULE_COMPAREEXP_LTEQ:
                    //<Compare Exp> ::= <Compare Exp> <= <Shift Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareLe);

                case (int)RuleConstants.RULE_COMPAREEXP_GTEQ:
                    //<Compare Exp> ::= <Compare Exp> >= <Shift Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareGe);

                case (int)RuleConstants.RULE_SHIFTEXP_LTLT:
                    //<Shift Exp> ::= <Shift Exp> << <Add Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Shl);

                case (int)RuleConstants.RULE_SHIFTEXP_GTGT:
                    //<Shift Exp> ::= <Shift Exp> >> <Add Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Shr);

                case (int)RuleConstants.RULE_ADDEXP_PLUS:
                    //<Expression> ::= <Expression> + <Mult Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Plus);

                case (int)RuleConstants.RULE_ADDEXP_MINUS:
                    //<Expression> ::= <Expression> - <Mult Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Minus);

                case (int)RuleConstants.RULE_MULTEXP_TIMES:
                    //<Mult Exp> ::= <Mult Exp> * <Negate Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Multiply);

                case (int)RuleConstants.RULE_MULTEXP_DIV:
                    //<Mult Exp> ::= <Mult Exp> / <Negate Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Divide);

                case (int)RuleConstants.RULE_MULTEXP_PERCENT:
                    //<Mult Exp> ::= <Mult Exp> % <Negate Exp>
                    return
                        new BinaryExpression(token.Tokens[1].Location,
                                             (Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Modulo);

                case (int)RuleConstants.RULE_NEGATEEXP_MINUS:
                    //<Negate Exp> ::= - <Value>
                    return
                        new UnaryExpression(token.Tokens[0].Location,
                                            (Expression)token.Tokens[1].UserObject,
                                            UnaryExpression.UnaryOperation.Negate);
                case (int)RuleConstants.RULE_NEGATEEXP_PLUS:
                    //<Negate Exp> ::= + <Value>
                    return token.Tokens[1].UserObject;

                case (int)RuleConstants.RULE_VALUE_INTEGER:
                    //<Value> ::= Integer
                    return new Value(token.Tokens[0].Location, (string)token.Tokens[0].UserObject);

                case (int)RuleConstants.RULE_VALUE_LPARAN_RPARAN:
                    //<Value> ::= ( <Expression> )
                    return
                        new UnaryExpression(token.Tokens[0].Location, (Expression)token.Tokens[1].UserObject,
                                            UnaryExpression.UnaryOperation.Brackets);

                    #endregion
            }
            throw new RuleException("Unknown rule");
        }

        private ForRofContainerStatement CreateForrof(List<string> comments, Expression expression, Statement statement, List<LabelName> statementlabels, NonterminalToken token)
        {
            ForRofContainerStatement forrof;
            forrof = new ForRofContainerStatement(token.Location);
            forrof.Comments = comments;
            forrof.Labels = statementlabels;
            forrof.Add(statement);

            LabelName l = new LabelName(expression.Location, "#forof" + rofforCounter);
            if (statementlabels.Count > 0)
            {
                l = statementlabels[statementlabels.Count - 1];
            }
            else
            {
                statementlabels.Add(l);
            }

            //for label could be reused
            //CheckName(l, token.Tokens[1].Location);
            variables[l.Name] = expression;

            //for label could be reused
            //CheckName(l, token.Tokens[1].Location);
            forrof.LimitName = l.Name + "#" + rofforCounter + "#limit";
            variables[forrof.LimitName] = expression;

            rofforCounter++;
            return forrof;
        }

        #endregion

        #region Errors

        private void CheckName(string variableName, Location location)
        {
            if (variables.ContainsKey(variableName))
            {
                WriteWarning("Variable/label already defined : " + variableName + " at " + location, location);
            }
        }

        private void TokenErrorEvent(LALRParser argParser, TokenErrorEventArgs args)
        {
            WriteError("Parse error caused by token: '" + args.Token.Text + "'" + " at " +
                       args.Token.Location, args.Token.Location);

            args.Continue = true;
        }

        private void ParseErrorEvent(LALRParser argParser, ParseErrorEventArgs args)
        {
            WriteError("Parse error caused by token: '" + args.UnexpectedToken + "'" + " at " +
                       args.UnexpectedToken.Location, args.UnexpectedToken.Location);
            args.Continue = ContinueMode.Insert;
        }

        protected internal void WriteError(string message)
        {
            WriteError(message, null);
        }

        protected internal void WriteError(string message, Location location)
        {
            if (location != null)
            {
                WriteMessage(
                    new ParserMessage("Error: " + message, ParseMessageLevel.Error, fileName, location.LineNr, location.ColumnNr));
            }
            else
            {
                WriteMessage(
                    new ParserMessage("Error: " + message, ParseMessageLevel.Error, fileName, 0, 0));
            }
        }

        protected internal void WriteWarning(string message, Location location)
        {
            if (location != null)
            {
                WriteMessage(
                    new ParserMessage("Warning: " + message, ParseMessageLevel.Warning, fileName, location.LineNr, location.ColumnNr));
            }
            else
            {
                WriteMessage(
                    new ParserMessage("Warning: " + message, ParseMessageLevel.Warning, fileName, 0, 0));
            }
        }

        protected internal void WriteMessage(ParserMessage message)
        {
            if (console != null && message.Level > project.ParserOptions.ErrorLevel)
                console.ErrorWriteLine(message.Message);

            if (message.Level > ParseMessageLevel.Warning)
            {
                errCount++;
                if (errCount > 10)
                {
                    if (project.ParserOptions.ErrorLevel <= ParseMessageLevel.Warning
                        && console!=null)
                    {
                        console.ErrorWriteLine("Too much errors");
                    }
                    throw new ParserException("Too much errors");
                }
                result.Succesfull = false;
            }
            result.Messages.Add(message);
        }

        #endregion

        #region Variables

        private LALRParser parser;
        protected internal Variables variables;
        protected int errCount;
        protected Expression org;
        protected Expression pin;
        protected int rofforCounter;
        protected string warriorName = null;
        protected string authorName = null;
        protected string fileName;
        private int endSymbol;

        #endregion

    }
}