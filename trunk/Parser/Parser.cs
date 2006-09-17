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

        public IWarrior Load(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string source = sr.ReadToEnd();
            sr.Close();
            return Parse(source, Path.GetFileNameWithoutExtension(fileName));
        }

        public IWarrior Parse(string source, string implicitName)
        {
            Prepare();
            Statement statement = Parse(source);
            ExtendedWarrior warrior = new ExtendedWarrior(rules);
            int currentAddress;

            //first pass to expand for cycles
            currentAddress = 0;
            statement.ExpandStatements(warrior, variables, ref currentAddress, rules.CoreSize, false);
            variables["MAXLENGTH"] = new Value(warrior.Length);

            //second pass to evaluate variables/labels in context of for cycles
            currentAddress = 0;
            statement.ExpandStatements(warrior, variables, ref currentAddress, rules.CoreSize, true);

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
    }
}