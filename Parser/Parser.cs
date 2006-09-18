using System;
using System.Collections.Generic;
using System.IO;
using nMars.Parser.Statements;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Parser
{
    public class Parser : ParserBase, IParser
    {
        public Parser(Rules rules)
            : base(rules)
        {
        }

        public override IWarrior Parse(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string source = sr.ReadToEnd();
            sr.Close();
            return Parse(source, Path.GetFileNameWithoutExtension(fileName));
        }

        public IWarrior Parse(string sourceText, string implicitName)
        {
            Prepare();
            Statement statement = ParseInternal(sourceText);
            ExtendedWarrior warrior = new ExtendedWarrior(rules);
            int currentAddress;

            //first pass to expand for cycles
            currentAddress = 0;
            statement.ExpandStatements(warrior, variables, ref currentAddress, rules.coreSize, false);
            variables["MAXLENGTH"] = new Value(warrior.Length);

            //second pass to evaluate variables/labels in context of for cycles
            currentAddress = 0;
            statement.ExpandStatements(warrior, variables, ref currentAddress, rules.coreSize, true);

            warrior.Name = implicitName;
            if (org != null)
            {
                if (!variables.ContainsKey(org))
                {
                    throw new Exception("LabelName not defined : " + org);
                }
                warrior.StartOffset = variables[org].Evaluate(variables);
            }
            else
            {
                warrior.StartOffset = 0;
            }
            if (pin != null)
            {
                warrior.Pin = pin.Evaluate(variables);
            }
            else
            {
                warrior.Pin = -1;
            }
            warrior.Variables = variables;
            return warrior;
        }

        protected void Prepare()
        {
            variables = new Dictionary<string, Expression>();
            org = null;
            counter = 0;
            variables["CORESIZE"] = new Value(rules.coreSize);
            variables["MAXPROCESSES"] = new Value(rules.maxProcesses);
            variables["MAXCYCLES"] = new Value(rules.maxCycles);
            variables["MAXLENGTH"] = new Value(rules.maxLength);
            variables["MINDISTANCE"] = new Value(rules.minDistance);
            variables["ROUNDS"] = new Value(rules.rounds);
            variables["PSPACESIZE"] = new Value(rules.pSpaceSize);
            variables["VERSION"] = new Value(rules.version);
            variables["WARRIORS"] = new Value(rules.warriors);
            variables["CURLINE"] = new Value(0);
        }
    }
}