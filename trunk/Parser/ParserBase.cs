using System;
using System.Collections.Generic;
using System.IO;
using com.calitha.goldparser;
using nMars.Parser.Expressions;
using nMars.Parser.Statements;
using nMars.RedCode;

namespace nMars.Parser
{
    public abstract class ParserBase : ParserRoot
    {
        private LALRParser parser;
        protected Dictionary<string, Expression> variables;
        protected string org;
        protected Expression pin;
        protected int counter;

        protected ParserBase(Rules rules)
        {
            this.rules = rules;
            Stream redCode =
                typeof (ParserBase).Assembly.GetManifestResourceStream("nMars.Parser.Properties.RedCode.cgt");
            Init(redCode);
        }

        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnReduce += new LALRParser.ReduceHandler(ReduceEvent);
            parser.OnTokenRead += new LALRParser.TokenReadHandler(TokenReadEvent);
            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
        }

        protected ContainerStatement ParseInternal(string source)
        {
            if (!source.EndsWith("\n"))
                source = source + "\n";
            return (ContainerStatement) parser.Parse(source).UserObject;
        }

        private void TokenReadEvent(LALRParser argParser, TokenReadEventArgs args)
        {
            args.Token.UserObject = CreateObject(args.Token);
        }

        private void ReduceEvent(LALRParser argParser, ReduceEventArgs args)
        {
            args.Token.UserObject = CreateObject(args.Token);
        }

        #region Terminal

        private Object CreateObject(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int) SymbolConstants.SYMBOL_INTEGER:
                    //Integer
                    return token.Text;

                case (int) SymbolConstants.SYMBOL_LABEL:
                    //Variable
                    if (token.Text.EndsWith(":"))
                    {
                        return token.Text.Substring(0, token.Text.Length - 1);
                    }
                    return token.Text;

                default:
                    return null;
            }
        }

        #endregion

        #region Nonterminal

        public Object CreateObject(NonterminalToken token)
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
            List<LabelName> statementlabels;
            string labell;

            switch (token.Rule.Id)
            {
                    #region Null

                case (int) RuleConstants.RULE_EOLOPTIONAL2:
                    //<eolOptional> ::= 

                case (int) RuleConstants.RULE_EOL:
                    //<eol> ::= <eolSingle>

                case (int) RuleConstants.RULE_EOL2:
                    //<eol> ::= <eol> <eolSingle>

                case (int) RuleConstants.RULE_EOLSINGLE_NEWLINE:
                    //<eolSingle> ::= NewLine

                case (int) RuleConstants.RULE_EOLOPTIONAL:
                    //<eolOptional> ::= <eol>

                case (int) RuleConstants.RULE_ENDOPTIONAL:
                    //<EndOptional> ::= <eol>

                case (int) RuleConstants.RULE_ENDOPTIONAL_END:
                    //<EndOptional> ::= <eol> End <eolOptional>

                case (int) RuleConstants.RULE_ENDOPTIONAL_END3:
                    //<EndOptional> ::= <eol> <Labels> End <eolOptional>

                case (int) RuleConstants.RULE_ENDOPTIONAL_END5:
                    //<EndOptional> ::= <eol> <Labels> <eol> End <eolOptional>

                case (int) RuleConstants.RULE_ENDOPTIONAL2:
                    //<EndOptional> ::= 

                case (int) RuleConstants.RULE_STATEMENT:
                    //<Statement> ::= <Pin>

                case (int) RuleConstants.RULE_STATEMENT2:
                    //<Statement> ::= <Org>

                case (int) RuleConstants.RULE_EXPRESSIONOPTIONAL:
                    // <ExpressionOptional> ::= <Expression>

                case (int) RuleConstants.RULE_EXPRESSIONOPTIONAL2:
                    // <ExpressionOptional> ::= 

                case (int) RuleConstants.RULE_MODEOPTIONAL:
                    // <ModeOptional> ::= <Mode>

                case (int) RuleConstants.RULE_MODEOPTIONAL2:
                    // <ModeOptional> ::= 

                    return null;

                    #endregion

                    #region Forward

                case (int) RuleConstants.RULE_EOLSINGLE_COMMENT_LINE:
                    //<eolSingle> ::= Comment Line

                case (int) RuleConstants.RULE_ALLSTATEMENTSOPTIONAL:
                    //<AllStatementsOptional> ::= <AllStatements> <eol>

                case (int) RuleConstants.RULE_OPERATION:
                    //<Operation> ::= <Operation0>

                case (int) RuleConstants.RULE_OPERATION2:
                    //<Operation> ::= <Operation1>

                case (int) RuleConstants.RULE_OPERATION3:
                    //<Operation> ::= <Operation2>

                case (int) RuleConstants.RULE_EXPRESSION:
                    //<Expression> ::= <Or Exp>

                case (int) RuleConstants.RULE_OREXP:
                    //<Or Exp> ::= <And Exp>

                case (int) RuleConstants.RULE_ANDEXP:
                    //<And Exp> ::= <BinOr Exp>

                case (int) RuleConstants.RULE_BINOREXP:
                    //<BinOr Exp> ::= <BinXor Exp>

                case (int) RuleConstants.RULE_BINXOREXP:
                    //<BinXor Exp> ::= <BinAnd Exp>

                case (int) RuleConstants.RULE_EQUATEEXP:
                    //<Equate Exp> ::= <Compare Exp>

                case (int) RuleConstants.RULE_COMPAREEXP:
                    //<Compare Exp> ::= <Shift Exp>

                case (int) RuleConstants.RULE_SHIFTEXP:
                    //<Shift Exp> ::= <Add Exp>

                case (int) RuleConstants.RULE_ADDEXP:
                    //<Add Exp> ::= <Mult Exp>

                case (int) RuleConstants.RULE_MULTEXP:
                    //<Mult Exp> ::= <Negate Exp>

                case (int) RuleConstants.RULE_NEGATEEXP:
                    //<Negate Exp> ::= <Value>

                case (int) RuleConstants.RULE_VALUE:
                    // <Value> ::= <Label>

                case (int) RuleConstants.RULE_LABELSOPTIONAL:
                    //<LabelsOptional> ::= <Labels>

                case (int) RuleConstants.RULE_STATEMENT3:
                    //<Statement> ::= <Equ>

                    return token.Tokens[0].UserObject;

                    #endregion

                    #region Statements

                case (int) RuleConstants.RULE_START:
                    //<Start> ::= <eolOptional> <AllStatements> <EndOptional>
                    return token.Tokens[1].UserObject;

                case (int) RuleConstants.RULE_ALLSTATEMENTS:
                    //<AllStatements> ::= <Statement>
                    statement = (Statement) token.Tokens[0].UserObject;
                    statements = new ContainerStatement(statement);
                    return statements;

                case (int) RuleConstants.RULE_ALLSTATEMENTS3:
                    //<AllStatements> ::= <AllStatements> <eol> <Statement>
                    statements = (ContainerStatement) token.Tokens[0].UserObject;
                    statement = (Statement) token.Tokens[2].UserObject;
                    statements.Add(statement);
                    return statements;

                case (int) RuleConstants.RULE_ALLSTATEMENTS4:
                    //<AllStatements> ::= <AllStatements> <eol> <For>
                    statements = (ContainerStatement) token.Tokens[0].UserObject;
                    forrof = (ForRofContainerStatement) token.Tokens[2].UserObject;
                    statements.Add(forrof);
                    return statements;

                case (int) RuleConstants.RULE_ALLSTATEMENTS2:
                    //<AllStatements> ::= <For>
                    statements = new ContainerStatement();
                    forrof = (ForRofContainerStatement) token.Tokens[0].UserObject;
                    statements.Add(forrof);
                    return statements;

                case (int) RuleConstants.RULE_ALLSTATEMENTSOPTIONAL2:
                    //<AllStatementsOptional> ::= 
                    statements = new ContainerStatement();
                    return statements;

                case (int) RuleConstants.RULE_FOR_FOR_ROF:
                    // <For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof <ExpressionOptional>
                    statementlabels = ((List<LabelName>) token.Tokens[0].UserObject);
                    expression = (Expression) token.Tokens[2].UserObject;
                    forrof = new ForRofContainerStatement((string) token.Tokens[3].UserObject);
                    forrof.Labels = statementlabels;
                    forrof.Add((Statement) token.Tokens[4].UserObject);

                    LabelName l = new LabelName("#forof" + counter.ToString());
                    counter++;
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
                    variables[l.Name + "#start"] = expression;

                    return forrof;

                    #endregion

                    #region Operation Statements

                case (int) RuleConstants.RULE_STATEMENT4:
                    //<Statement> ::= <LabelsOptional> <Operation>
                    statementlabels = (List<LabelName>) token.Tokens[0].UserObject;
                    statement = (InstructionStatement) token.Tokens[1].UserObject;
                    statement.Labels = statementlabels;
                    foreach (LabelName label in statementlabels)
                    {
                        variables[label.Name] = label;
                    }
                    return statement;

                case (int) RuleConstants.RULE_STATEMENT5:
                    //<Statement> ::= <Labels> <eol> <Operation>
                    statementlabels = (List<LabelName>) token.Tokens[0].UserObject;
                    statement = (InstructionStatement) token.Tokens[2].UserObject;
                    statement.Labels = statementlabels;
                    foreach (LabelName label in statementlabels)
                    {
                        variables[label.Name] = label;
                    }
                    return statement;

                    #endregion

                    #region Simple Statements

                case (int) RuleConstants.RULE_PIN_PIN:
                    //<Pin> ::= Pin <Expression>
                    pin = (Expression) token.Tokens[1].UserObject;
                    return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END2:
                    //<EndOptional> ::= <eol> End <Labels> <eolOptional>
                    statementlabels = (List<LabelName>)token.Tokens[2].UserObject;
                    org = statementlabels[0].Name;
                    return null;
                    
                case (int)RuleConstants.RULE_ENDOPTIONAL_END4:
                    //<EndOptional> ::= <eol> <Labels> End <Labels> <eolOptional>
                    statementlabels = (List<LabelName>)token.Tokens[3].UserObject;
                    org = statementlabels[0].Name;
                    return null;

                case (int)RuleConstants.RULE_ENDOPTIONAL_END6:
                    //<EndOptional> ::= <eol> <Labels> <eol> End <Labels> <eolOptional>
                    statementlabels = (List<LabelName>)token.Tokens[4].UserObject;
                    org = statementlabels[0].Name;
                    return null;

                case (int)RuleConstants.RULE_ORG_ORG_LABEL:
                    //<Org> ::= Org Label
                    org = ((string) token.Tokens[1].UserObject);
                    return null;

                case (int) RuleConstants.RULE_EQU_EQU:
                    // <Equ> ::= <Labels> Equ <ModeOptional> <Expression>
                    statementlabels = (List<LabelName>) token.Tokens[0].UserObject;
                    expression = (Expression) token.Tokens[3].UserObject;
                    equ = new EquStatement(expression);
                    equ.Labels = statementlabels;
                    foreach (LabelName label in statementlabels)
                    {
                        CheckName(label.Name, token.Tokens[1].Location);
                        variables[label.Name] = expression;
                    }
                    return equ;

                case (int) RuleConstants.RULE_EQU_EQU2:
                    // <Equ> ::= <Labels> <eol> Equ <ModeOptional> <Expression>
                    statementlabels = (List<LabelName>) token.Tokens[0].UserObject;
                    expression = (Expression) token.Tokens[4].UserObject;
                    equ = new EquStatement(expression);
                    equ.Labels = statementlabels;
                    foreach (LabelName label in statementlabels)
                    {
                        CheckName(label.Name, token.Tokens[2].Location);
                        variables[label.Name] = expression;
                    }
                    return equ;

                    #endregion

                    #region Labels

                case (int) RuleConstants.RULE_LABEL:
                    // <Label> ::= <Modifier>
                    labell = token.Tokens[0].UserObject as string;
                    if (labell == null)
                    {
                        labell = token.Tokens[0].UserObject.ToString();
                    }
                    // CheckName(labell, token.Tokens[0].Location);                
                    return new LabelName(labell);

                case (int) RuleConstants.RULE_LABEL_LABEL_AMP:
                    // <Label> ::= Label & <Modifier>
                    labell = token.Tokens[2].UserObject as string;
                    if (labell == null)
                    {
                        labell = token.Tokens[2].UserObject.ToString();
                    }
                    return
                        new ComposedLabelName((string) token.Tokens[0].UserObject, labell);

                case (int) RuleConstants.RULE_LABEL_AMP_LABEL:
                    // <Label> ::= <Modifier> & Label
                    labell = token.Tokens[0].UserObject as string;
                    if (labell == null)
                    {
                        labell = token.Tokens[0].UserObject.ToString();
                    }
                    return
                        new ComposedLabelName(labell, (string) token.Tokens[2].UserObject);

                case (int) RuleConstants.RULE_LABEL_LABEL:
                    // <Label> ::= Label
                    labell = (string) token.Tokens[0].UserObject;
                    // CheckName(labell, token.Tokens[0].Location);
                    return new LabelName(labell);

                case (int) RuleConstants.RULE_LABEL_LABEL_AMP_LABEL:
                    // <Label> ::= Label & Label
                    return
                        new ComposedLabelName((string) token.Tokens[0].UserObject, (string) token.Tokens[2].UserObject);

                case (int) RuleConstants.RULE_LABELSOPTIONAL2:
                    //<LabelsOptional> ::= 
                    statementlabels = new List<LabelName>();
                    return statementlabels;

                case (int) RuleConstants.RULE_LABELS:
                    // <Labels> ::= <Label>
                    statementlabels = new List<LabelName>();
                    statementlabels.Add((LabelName) token.Tokens[0].UserObject);
                    return statementlabels;

                case (int) RuleConstants.RULE_LABELS2:
                    // <Labels> ::= <Labels> <eol> <Label>
                    statementlabels = (List<LabelName>) token.Tokens[0].UserObject;
                    statementlabels.Add((LabelName) token.Tokens[2].UserObject);
                    return statementlabels;

                case (int) RuleConstants.RULE_LABELS3:
                    // <Labels> ::= <Labels> <Label>
                    statementlabels = (List<LabelName>) token.Tokens[0].UserObject;
                    statementlabels.Add((LabelName) token.Tokens[1].UserObject);
                    return statementlabels;

                    #endregion

                    #region Operations

                case (int) RuleConstants.RULE_OPERATION0:
                    //<Operation0> ::= <Operator0>
                    op = (Operation) token.Tokens[0].UserObject;
                    paramA = new Parameter();
                    paramB = new Parameter();
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                case (int) RuleConstants.RULE_OPERATION0_COMMA:
                    //<Operation0> ::= <Operator0> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    paramA = (Parameter) token.Tokens[1].UserObject;
                    paramB = (Parameter) token.Tokens[3].UserObject;
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                case (int) RuleConstants.RULE_OPERATION0_DOT_COMMA:
                    //<Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    mod = (Modifier) token.Tokens[2].UserObject;
                    paramA = (Parameter) token.Tokens[3].UserObject;
                    paramB = (Parameter) token.Tokens[5].UserObject;
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                case (int) RuleConstants.RULE_OPERATION1:
                    //<Operation1> ::= <Operator1> <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
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
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                case (int) RuleConstants.RULE_OPERATION1_DOT:
                    //<Operation1> ::= <Operator1> . <Modifier> <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    mod = (Modifier) token.Tokens[2].UserObject;
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
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                case (int) RuleConstants.RULE_OPERATION1_COMMA:
                    //<Operation1> ::= <Operator1> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    paramA = (Parameter) token.Tokens[1].UserObject;
                    paramB = (Parameter) token.Tokens[3].UserObject;
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                case (int) RuleConstants.RULE_OPERATION1_DOT_COMMA:
                    //<Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    mod = (Modifier) token.Tokens[2].UserObject;
                    paramA = (Parameter) token.Tokens[3].UserObject;
                    paramB = (Parameter) token.Tokens[5].UserObject;
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                case (int) RuleConstants.RULE_OPERATION2_COMMA:
                    //<Operation2> ::= <Operator2> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    paramA = (Parameter) token.Tokens[1].UserObject;
                    paramB = (Parameter) token.Tokens[3].UserObject;
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                case (int) RuleConstants.RULE_OPERATION2_DOT_COMMA:
                    //<Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    mod = (Modifier) token.Tokens[2].UserObject;
                    paramA = (Parameter) token.Tokens[3].UserObject;
                    paramB = (Parameter) token.Tokens[5].UserObject;
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB,
                                                    token.Tokens[0].Location);

                    #endregion

                    #region Parameters

                case (int) RuleConstants.RULE_PARAMETER:
                    //<Parameter> ::= <Expression>
                    return new Parameter(Mode.Direct, (Expression) token.Tokens[0].UserObject);

                case (int) RuleConstants.RULE_PARAMETER2:
                    //<Parameter> ::= <Mode> <Expression>
                    return new Parameter((Mode) token.Tokens[0].UserObject, (Expression) token.Tokens[1].UserObject);

                    #endregion

                    #region Mode

                case (int) RuleConstants.RULE_MODE_NUM:
                    //<Mode> ::= #
                    //todo: Create a new object using the stored user objects.
                    return Mode.Immediate;

                case (int) RuleConstants.RULE_MODE_DOLLAR:
                    //<Mode> ::= $
                    return Mode.Direct;

                case (int) RuleConstants.RULE_MODE_AT:
                    //<Mode> ::= @
                    return Mode.IndirectB;

                case (int) RuleConstants.RULE_MODE_LT:
                    //<Mode> ::= <
                    return Mode.PreDecIndirectB;

                case (int) RuleConstants.RULE_MODE_GT:
                    //<Mode> ::= >
                    return Mode.PostIncIndirectB;

                case (int) RuleConstants.RULE_MODE_LBRACE:
                    //<Mode> ::= {
                    return Mode.PreDecIndirectA;

                case (int) RuleConstants.RULE_MODE_RBRACE:
                    //<Mode> ::= }
                    return Mode.PostIncIndirectA;

                case (int) RuleConstants.RULE_MODE_TIMES:
                    //<Mode> ::= *
                    return Mode.IndirectA;

                    #endregion

                    #region Operator

                case (int) RuleConstants.RULE_OPERATOR0_NOP:
                    //<Operator0> ::= Nop
                    return Operation.NOP;

                case (int) RuleConstants.RULE_OPERATOR1_JMP:
                    //<Operator1> ::= Jmp
                    return Operation.JMP;

                case (int) RuleConstants.RULE_OPERATOR1_DAT:
                    //<Operator2> ::= Dat
                    return Operation.DAT;

                case (int) RuleConstants.RULE_OPERATOR1_SPL:
                    //<Operator2> ::= Spl
                    return Operation.SPL;

                case (int) RuleConstants.RULE_OPERATOR2_MOV:
                    //<Operator2> ::= Mov
                    return Operation.MOV;

                case (int) RuleConstants.RULE_OPERATOR2_ADD:
                    //<Operator2> ::= Add
                    return Operation.ADD;

                case (int) RuleConstants.RULE_OPERATOR2_SUB:
                    //<Operator2> ::= Sub
                    return Operation.SUB;

                case (int) RuleConstants.RULE_OPERATOR2_MUL:
                    //<Operator2> ::= Mul
                    return Operation.MUL;

                case (int) RuleConstants.RULE_OPERATOR2_DIV:
                    //<Operator2> ::= Div
                    return Operation.DIV;

                case (int) RuleConstants.RULE_OPERATOR2_MOD:
                    //<Operator2> ::= Mod
                    return Operation.MOD;

                case (int) RuleConstants.RULE_OPERATOR2_JMZ:
                    //<Operator2> ::= Jmz
                    return Operation.JMZ;

                case (int) RuleConstants.RULE_OPERATOR2_JMN:
                    //<Operator2> ::= Jmn
                    return Operation.JMN;

                case (int) RuleConstants.RULE_OPERATOR2_DJN:
                    //<Operator2> ::= Djn
                    return Operation.DJN;

                case (int) RuleConstants.RULE_OPERATOR2_SLT:
                    //<Operator2> ::= Slt
                    return Operation.SLT;

                case (int) RuleConstants.RULE_OPERATOR2_SNE:
                    //<Operator2> ::= Sne
                    return Operation.SNE;

                case (int) RuleConstants.RULE_OPERATOR2_LDP:
                    //<Operator2> ::= Ldp
                    return Operation.LDP;

                case (int) RuleConstants.RULE_OPERATOR2_STP:
                    //<Operator2> ::= Stp
                    return Operation.STP;

                case (int) RuleConstants.RULE_OPERATOR2_CMP:
                    //<Operator2> ::= Cmp
                    return Operation.SEQ;

                case (int) RuleConstants.RULE_OPERATOR2_SEQ:
                    //<Operator2> ::= Seq
                    return Operation.SEQ;

                    #endregion

                    #region Modifiers

                case (int) RuleConstants.RULE_MODIFIER_I:
                    //<Modifier> ::= I
                    return Modifier.I;

                case (int) RuleConstants.RULE_MODIFIER_A:
                    //<Modifier> ::= A
                    return Modifier.A;

                case (int) RuleConstants.RULE_MODIFIER_B:
                    //<Modifier> ::= B
                    return Modifier.B;

                case (int) RuleConstants.RULE_MODIFIER_AB:
                    //<Modifier> ::= AB
                    return Modifier.AB;

                case (int) RuleConstants.RULE_MODIFIER_BA:
                    //<Modifier> ::= BA
                    return Modifier.BA;

                case (int) RuleConstants.RULE_MODIFIER_F:
                    //<Modifier> ::= F
                    return Modifier.F;

                case (int) RuleConstants.RULE_MODIFIER_X:
                    //<Modifier> ::= X
                    return Modifier.X;

                    #endregion

                    #region Expressions

                case (int) RuleConstants.RULE_EXPRESSION_QUESTION_COLON:
                    //<Expression> ::= <Or Exp> ? <Expression> : <Expression>
                    return
                        new TernaryExpression((Expression) token.Tokens[0].UserObject,
                                              (Expression) token.Tokens[2].UserObject,
                                              (Expression) token.Tokens[4].UserObject,
                                              TernaryExpression.TernaryOperation.If);

                case (int) RuleConstants.RULE_OREXP_PIPEPIPE:
                    //<Or Exp> ::= <Or Exp> || <And Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Or);

                case (int) RuleConstants.RULE_ANDEXP_AMPAMP:
                    //<And Exp> ::= <And Exp> && <BinOr Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.And);

                case (int) RuleConstants.RULE_BINOREXP_PIPE:
                    //<BinOr Exp> ::= <BinOr Exp> | <BinXor Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.BinOr);

                case (int) RuleConstants.RULE_BINXOREXP_CARET:
                    //<BinXor Exp> ::= <BinXor Exp> ^ <BinAnd Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.BinXor);

                case (int) RuleConstants.RULE_EQUATEEXP_EQEQ:
                    //<Equate Exp> ::= <Equate Exp> == <Compare Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareEq);

                case (int) RuleConstants.RULE_EQUATEEXP_LTGT:
                    //<Equate Exp> ::= <Equate Exp> <> <Compare Exp>

                case (int) RuleConstants.RULE_EQUATEEXP_EXCLAMEQ:
                    //<Equate Exp> ::= <Equate Exp> != <Compare Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareNe);

                case (int) RuleConstants.RULE_COMPAREEXP_LT:
                    //<Compare Exp> ::= <Compare Exp> < <Shift Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareLt);

                case (int) RuleConstants.RULE_COMPAREEXP_GT:
                    //<Compare Exp> ::= <Compare Exp> > <Shift Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareGt);

                case (int) RuleConstants.RULE_COMPAREEXP_LTEQ:
                    //<Compare Exp> ::= <Compare Exp> <= <Shift Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareLe);

                case (int) RuleConstants.RULE_COMPAREEXP_GTEQ:
                    //<Compare Exp> ::= <Compare Exp> >= <Shift Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.CompareGe);

                case (int) RuleConstants.RULE_SHIFTEXP_LTLT:
                    //<Shift Exp> ::= <Shift Exp> << <Add Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Shl);

                case (int) RuleConstants.RULE_SHIFTEXP_GTGT:
                    //<Shift Exp> ::= <Shift Exp> >> <Add Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Shr);

                case (int) RuleConstants.RULE_ADDEXP_PLUS:
                    //<Expression> ::= <Expression> + <Mult Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Plus);

                case (int) RuleConstants.RULE_ADDEXP_MINUS:
                    //<Expression> ::= <Expression> - <Mult Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Minus);

                case (int) RuleConstants.RULE_MULTEXP_TIMES:
                    //<Mult Exp> ::= <Mult Exp> * <Negate Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Multiply);

                case (int) RuleConstants.RULE_MULTEXP_DIV:
                    //<Mult Exp> ::= <Mult Exp> / <Negate Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Divide);

                case (int) RuleConstants.RULE_MULTEXP_PERCENT:
                    //<Mult Exp> ::= <Mult Exp> % <Negate Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Modulo);

                case (int) RuleConstants.RULE_NEGATEEXP_MINUS:
                    //<Negate Exp> ::= - <Value>
                    return
                        new UnaryExpression((Expression) token.Tokens[1].UserObject,
                                            UnaryExpression.UnaryOperation.Negate);

                case (int) RuleConstants.RULE_VALUE_INTEGER:
                    //<Value> ::= Integer
                    return new Value((string) token.Tokens[0].UserObject);

                case (int) RuleConstants.RULE_VALUE_LPARAN_RPARAN:
                    //<Value> ::= ( <Expression> )
                    return
                        new UnaryExpression((Expression) token.Tokens[1].UserObject,
                                            UnaryExpression.UnaryOperation.Brackets);

                    #endregion
            }
            throw new RuleException("Unknown rule");
        }

        private void CheckName(string name, Location location)
        {
            if (variables.ContainsKey(name))
            {
                throw new ParserException("Variable/label already defined : " + name + " at " + location.ToString());
            }
        }

        #endregion

        private void TokenErrorEvent(LALRParser argParser, TokenErrorEventArgs args)
        {
            string message = "Parse error caused by token: '" + args.Token.Text + "'" + " at " +
                             args.Token.Location.ToString();
            throw new ParserException(message);
        }

        private void ParseErrorEvent(LALRParser argParser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '" + args.UnexpectedToken.ToString() + "'" + " at " +
                             args.UnexpectedToken.Location.ToString();
            throw new ParserException(message);
        }
    }
}