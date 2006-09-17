using System;
using System.Collections.Generic;
using System.IO;
using com.calitha.goldparser;
using nMars.RedCode;

namespace nMars.Parser
{
    public class RedCodeTree
    {
        private LALRParser parser;
        protected Dictionary<string, InstructionStatement> labels;
        protected Dictionary<string, Expression> variables;
        protected string org;
        protected Expression pin;
        protected Rules rules;
        protected int counter;

        protected RedCodeTree(Rules rules)
        {
            this.rules = rules;
            Stream redCode =
                typeof (RedCodeTree).Assembly.GetManifestResourceStream("nMars.Parser.Properties.RedCode.cgt");
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

        protected void Prepare()
        {
            variables = new Dictionary<string, Expression>();
            labels = new Dictionary<string, InstructionStatement>();
            org = null;
            counter = 0;
            variables["CORESIZE"] = new Value(rules.CoreSize);
            variables["MAXPROCESSES"] = new Value(rules.maxProcesses);
            variables["MAXCYCLES"] = new Value(rules.maxCycles);
            variables["MAXLENGTH"] = new Value(rules.maxLength);
            variables["MINDISTANCE"] = new Value(rules.minDistance);
            variables["ROUNDS"] = new Value(rules.Rounds);
            variables["PSPACESIZE"] = new Value(rules.PSpaceSize);
            variables["VERSION"] = new Value(rules.Version);
            variables["WARRIORS"] = new Value(rules.Warriors);
            variables["CURLINE"] = new Value(0);
        }

        protected ContainerStatement Parse(string source)
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
            InstructionStatement statement;
            ContainerStatement statements;
            ForRofContainerStatement forrof;
            List<string> statementlabels;

            switch (token.Rule.Id)
            {
                    #region Null
                case (int)RuleConstants.RULE_ENDOPTIONAL2:
                    //<EndOptional> ::= 

                case (int)RuleConstants.RULE_EOLOPTIONAL2:
                    //<eolOptional> ::= 

                case (int)RuleConstants.RULE_EOL:
                    //<eol> ::= <eolSingle>

                case (int)RuleConstants.RULE_EOL2:
                    //<eol> ::= <eol> <eolSingle>

                case (int)RuleConstants.RULE_EOLSINGLE_NEWLINE:
                    //<eolSingle> ::= NewLine

                case (int)RuleConstants.RULE_EOLOPTIONAL:
                    //<eolOptional> ::= <eol>

                case (int)RuleConstants.RULE_ENDOPTIONAL_END:
                    //<EndOptional> ::= <eol> End <eolOptional>

                case (int)RuleConstants.RULE_ENDOPTIONAL_END_LABEL:
                    //<EndOptional> ::= <eol> End Label <eolOptional>

                case (int)RuleConstants.RULE_ENDOPTIONAL:
                    //<EndOptional> ::= <eol>

                case (int)RuleConstants.RULE_STATEMENT:
                    //<Statement> ::= <Pin>

                case (int)RuleConstants.RULE_STATEMENT2:
                    //<Statement> ::= <Org>

                case (int)RuleConstants.RULE_STATEMENT3:
                    //<Statement> ::= <Equ>

                    return null;

                    #endregion
                    
                    #region Forward
                case (int)RuleConstants.RULE_EOLSINGLE_COMMENT_LINE:
                    //<eolSingle> ::= Comment Line

                case (int)RuleConstants.RULE_ALLSTATEMENTS2:
                    //<AllStatements> ::= <For>

                case (int)RuleConstants.RULE_ALLSTATEMENTSOPTIONAL:
                    //<AllStatementsOptional> ::= <AllStatements> <eol>

                case (int)RuleConstants.RULE_OPERATION:
                    //<Operation> ::= <Operation0>

                case (int)RuleConstants.RULE_OPERATION2:
                    //<Operation> ::= <Operation1>

                case (int)RuleConstants.RULE_OPERATION3:
                    //<Operation> ::= <Operation2>

                    return token.Tokens[0].UserObject;
                    
                    #endregion

                    #region Statements
                    
                case (int)RuleConstants.RULE_START:
                    //<Start> ::= <eolOptional> <AllStatements> <EndOptional>
                    return token.Tokens[1].UserObject;

                case (int)RuleConstants.RULE_ALLSTATEMENTS:
                    //<AllStatements> ::= <Statement>
                    statement = (InstructionStatement)token.Tokens[0].UserObject;
                    statements = new ContainerStatement(statement);
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTS3:
                    //<AllStatements> ::= <AllStatements> <eol> <Statement>
                    statements = (ContainerStatement)token.Tokens[0].UserObject;
                    statement = (InstructionStatement)token.Tokens[2].UserObject;
                    statements.Add(statement);
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTS4:
                    //<AllStatements> ::= <AllStatements> <eol> <For>
                    statements = (ContainerStatement)token.Tokens[0].UserObject;
                    forrof = (ForRofContainerStatement)token.Tokens[2].UserObject;
                    statements.Add(forrof);
                    return statements;

                case (int)RuleConstants.RULE_ALLSTATEMENTSOPTIONAL2:
                    //<AllStatementsOptional> ::= 
                    statements = new ContainerStatement();
                    return statements;

                case (int)RuleConstants.RULE_FOR_FOR_ROF:
                    // <For> ::= <LabelsOptional> for <Expression> <eol> <AllStatementsOptional> rof
                    statementlabels = ((List<string>)token.Tokens[0].UserObject);
                    expression = (Expression)token.Tokens[2].UserObject;
                    forrof = new ForRofContainerStatement(statementlabels,
                                                        (string)token.Tokens[3].UserObject);
                    forrof.Add((Statement)token.Tokens[4].UserObject);

                    string l="#forof"+counter.ToString();
                    counter++;
                    if (statementlabels.Count>0)
                    {
                        l = statementlabels[statementlabels.Count - 1];
                    }
                    else
                    {
                        statementlabels.Add(l);
                    }
                    
                    CheckName(l);
                    variables[l] = expression;

                    l = l + "#start";
                    CheckName(l);
                    variables[l] = expression;

                    return forrof;


                    #endregion

                    #region Operation Statements
                    
                case (int)RuleConstants.RULE_STATEMENT4:
                    //<Statement> ::= <LabelsOptional> <Operation>
                    statementlabels = (List<string>)token.Tokens[0].UserObject;
                    statement = (InstructionStatement)token.Tokens[1].UserObject;
                    statement.Labels = statementlabels;
                    foreach (string label in statementlabels)
                    {
                        labels[label] = statement;
                    }
                    return statement;

                case (int)RuleConstants.RULE_STATEMENT5:
                    //<Statement> ::= <Labels> <eol> <Operation>
                    statementlabels = (List<string>)token.Tokens[0].UserObject;
                    statement = (InstructionStatement)token.Tokens[2].UserObject;
                    statement.Labels = statementlabels;
                    foreach (string label in statementlabels)
                    {
                        labels[label] = statement;
                    }
                    return statement;

                    #endregion
                    
                    #region Simple Statements
                    
                case (int)RuleConstants.RULE_PIN_PIN:
                    //<Pin> ::= Pin <Expression>
                    pin = (Expression)token.Tokens[1].UserObject;
                    return null;

                case (int)RuleConstants.RULE_ORG_ORG_LABEL:
                    //<Org> ::= Org Label
                    org = ((string)token.Tokens[1].UserObject);
                    return null;

                case (int)RuleConstants.RULE_EQU_EQU:
                    //<Equ> ::= <Labels> Equ <Expression>
                    statementlabels = (List<string>)token.Tokens[0].UserObject;
                    expression = (Expression)token.Tokens[2].UserObject;
                    foreach (string label in statementlabels)
                    {
                        CheckName(label);
                        variables[label] = expression;
                    }
                    return null;

                case (int)RuleConstants.RULE_EQU_EQU2:
                    //<Equ> ::= <Labels> <eol> Equ <Expression>
                    statementlabels = (List<string>)token.Tokens[0].UserObject;
                    expression = (Expression)token.Tokens[3].UserObject;
                    foreach (string label in statementlabels)
                    {
                        CheckName(label);
                        variables[label] = expression;
                    }
                    return null;

                    #endregion
                    
                    #region Labels
                    
                case (int)RuleConstants.RULE_LABELSOPTIONAL2:
                    //<LabelsOptional> ::= 
                    statementlabels = new List<string>();
                    return statementlabels;

                case (int)RuleConstants.RULE_LABELSOPTIONAL:
                    //<LabelsOptional> ::= <Labels>
                    return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_LABELS_LABEL:
                    //<Labels> ::= Label
                    statementlabels = new List<string>();
                    statementlabels.Add((string)token.Tokens[0].UserObject);
                    return statementlabels;

                case (int)RuleConstants.RULE_LABELS_LABEL2:
                    //<Labels> ::= <Labels> <eol> Label
                    statementlabels = (List<string>)token.Tokens[0].UserObject;
                    statementlabels.Add((string)token.Tokens[2].UserObject);
                    return statementlabels;

                case (int)RuleConstants.RULE_LABELS_LABEL3:
                    // <Labels> ::= <Labels> Label
                    statementlabels = (List<string>)token.Tokens[0].UserObject;
                    statementlabels.Add((string)token.Tokens[1].UserObject);
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
                                                    paramB);

                case (int) RuleConstants.RULE_OPERATION0_COMMA:
                    //<Operation0> ::= <Operator0> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    paramA = (Parameter) token.Tokens[1].UserObject;
                    paramB = (Parameter) token.Tokens[3].UserObject;
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB);

                case (int) RuleConstants.RULE_OPERATION0_DOT_COMMA:
                    //<Operation0> ::= <Operator0> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    mod = (Modifier) token.Tokens[2].UserObject;
                    paramA = (Parameter) token.Tokens[3].UserObject;
                    paramB = (Parameter) token.Tokens[5].UserObject;
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB);

                case (int) RuleConstants.RULE_OPERATION1:
                    //<Operation1> ::= <Operator1> <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    paramA = new Parameter();
                    paramB = (Parameter)token.Tokens[1].UserObject; 
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB);

                case (int) RuleConstants.RULE_OPERATION1_DOT:
                    //<Operation1> ::= <Operator1> . <Modifier> <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    mod = (Modifier) token.Tokens[2].UserObject;
                    paramA = new Parameter();
                    paramB = (Parameter)token.Tokens[3].UserObject; 
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB);

                case (int) RuleConstants.RULE_OPERATION1_COMMA:
                    //<Operation1> ::= <Operator1> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    paramA = (Parameter) token.Tokens[1].UserObject;
                    paramB = (Parameter) token.Tokens[3].UserObject;
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB);

                case (int) RuleConstants.RULE_OPERATION1_DOT_COMMA:
                    //<Operation1> ::= <Operator1> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    mod = (Modifier) token.Tokens[2].UserObject;
                    paramA = (Parameter) token.Tokens[3].UserObject;
                    paramB = (Parameter) token.Tokens[5].UserObject;
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB);

                case (int) RuleConstants.RULE_OPERATION2_COMMA:
                    //<Operation2> ::= <Operator2> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    paramA = (Parameter) token.Tokens[1].UserObject;
                    paramB = (Parameter) token.Tokens[3].UserObject;
                    mod = Instruction.DefaultModifier(op, paramA.Mode, paramB.Mode);
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB);

                case (int) RuleConstants.RULE_OPERATION2_DOT_COMMA:
                    //<Operation2> ::= <Operator2> . <Modifier> <Parameter> , <Parameter>
                    op = (Operation) token.Tokens[0].UserObject;
                    mod = (Modifier) token.Tokens[2].UserObject;
                    paramA = (Parameter) token.Tokens[3].UserObject;
                    paramB = (Parameter) token.Tokens[5].UserObject;
                    return new InstructionStatement(op,
                                                    mod,
                                                    paramA,
                                                    paramB);

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

                case (int)RuleConstants.RULE_EXPRESSION_PIPE:
                    //<Expression> ::= <Expression> | <Xor Exp>
                    return
                        new BinaryExpression((Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Or);

                case (int)RuleConstants.RULE_EXPRESSION:
                    //<Expression> ::= <Xor Exp>
                    return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_XOREXP_CARET:
                    //<Xor Exp> ::= <Xor Exp> ^ <And Exp>
                    return
                        new BinaryExpression((Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Xor);

                case (int)RuleConstants.RULE_XOREXP:
                    //<Xor Exp> ::= <And Exp>
                    return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_ANDEXP_AMP:
                    //<And Exp> ::= <And Exp> & <Shift Exp>
                    return
                        new BinaryExpression((Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.And);

                case (int)RuleConstants.RULE_ANDEXP:
                    //<And Exp> ::= <Shift Exp>
                    return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_SHIFTEXP_LTLT:
                    //<Shift Exp> ::= <Shift Exp> << <Add Exp>
                    return
                        new BinaryExpression((Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Shl);

                case (int)RuleConstants.RULE_SHIFTEXP_GTGT:
                    //<Shift Exp> ::= <Shift Exp> >> <Add Exp>
                    return
                        new BinaryExpression((Expression)token.Tokens[0].UserObject,
                                             (Expression)token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Shr);

                case (int)RuleConstants.RULE_SHIFTEXP:
                    //<Shift Exp> ::= <Add Exp>
                    return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_ADDEXP_PLUS:
                    //<Expression> ::= <Expression> + <Mult Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Plus);

                case (int)RuleConstants.RULE_ADDEXP_MINUS:
                    //<Expression> ::= <Expression> - <Mult Exp>
                    return
                        new BinaryExpression((Expression) token.Tokens[0].UserObject,
                                             (Expression) token.Tokens[2].UserObject,
                                             BinaryExpression.BinaryOperation.Minus);

                case (int)RuleConstants.RULE_ADDEXP:
                    //<Add Exp> ::= <Mult Exp>
                    return token.Tokens[0].UserObject;

                case (int)RuleConstants.RULE_MULTEXP_TIMES:
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

                case (int) RuleConstants.RULE_MULTEXP:
                    //<Mult Exp> ::= <Negate Exp>
                    return token.Tokens[0].UserObject;

                case (int) RuleConstants.RULE_NEGATEEXP_MINUS:
                    //<Negate Exp> ::= - <Value>
                    return
                        new UnaryExpression((Expression) token.Tokens[1].UserObject,
                                            UnaryExpression.UnaryOperation.Negate);

                case (int) RuleConstants.RULE_NEGATEEXP:
                    //<Negate Exp> ::= <Value>
                    return token.Tokens[0].UserObject;

                case (int) RuleConstants.RULE_VALUE_INTEGER:
                    //<Value> ::= Integer
                    return new Value((string) token.Tokens[0].UserObject);

                case (int) RuleConstants.RULE_VALUE_LABEL:
                    //<Value> ::= Label
                    return new Variable(((string) token.Tokens[0].UserObject), variables, labels);

                case (int) RuleConstants.RULE_VALUE_LPARAN_RPARAN:
                    //<Value> ::= ( <Expression> )
                    return
                        new UnaryExpression((Expression) token.Tokens[1].UserObject,
                                            UnaryExpression.UnaryOperation.Brackets);

                    #endregion
            }
            throw new RuleException("Unknown rule");
        }

        private void CheckName(string name)
        {
            if (variables.ContainsKey(name))
            {
                throw new ParserException("Variable already defined : " + name);
            }
            if (labels.ContainsKey(name))
            {
                throw new ParserException("Label already defined : " + name);
            }
        }

        #endregion

        private void TokenErrorEvent(LALRParser argParser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '" + args.Token.ToString() + "'";
            throw new ParserException(message);
        }

        private void ParseErrorEvent(LALRParser argParser, ParseErrorEventArgs args)
        {
            string message = "Parse error caused by token: '" + args.UnexpectedToken.ToString() + "'" + " at " + args.UnexpectedToken.Location.ToString();
            throw new ParserException(message);
        }
    }
}