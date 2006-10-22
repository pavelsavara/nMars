// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using nMars.Parser;
using nMars.Parser.Statements;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars
{
    public class nMarsParser : ParserBase, IParser
    {
        public nMarsParser(Rules aRules)
        {
            InitParser(aRules);
        }

        public override IWarrior Parse(string fileName, TextWriter err)
        {
            StreamReader sr = new StreamReader(fileName);
            string source = sr.ReadToEnd();
            sr.Close();
            ExtendedWarrior res = (ExtendedWarrior)Parse(source, err, Path.GetFileNameWithoutExtension(fileName));
            res.FileName = fileName;
            return res;
        }

        public IWarrior Parse(string sourceText, TextWriter err, string implicitName)
        {
            errOutput = err;
            errCount = 0;
            Prepare();
            try
            {
                Statement statement = ParseInternal(sourceText);
                ExtendedWarrior warrior = new ExtendedWarrior(rules);
                int currentAddress;

                //first pass to expand for-rof cycles
                currentAddress = 0;
                variables["CURLINE"] = new Value(0);
                statement.ExpandStatements(warrior, this, ref currentAddress, rules.coreSize, false);

                //second pass to evaluate variables/labels in context of for cycles
                currentAddress = 0;
                variables["CURLINE"] = new Value(0);
                statement.ExpandStatements(warrior, this, ref currentAddress, rules.coreSize, true);

                SetOrg(warrior);
                SetPin(warrior);
                SetName(warrior, implicitName);
                SetAuthor(warrior);
                warrior.Variables = variables;
                if (errCount > 0)
                    return null;
                return warrior;
            }
            catch (ParserException ex)
            {
                err.WriteLine(ex.Message);
                return null;
            }
        }

        private void SetAuthor(ExtendedWarrior warrior)
        {
            if (authorName != null)
            {
                warrior.Author = authorName;
            }
        }

        private void SetName(ExtendedWarrior warrior, string implicitName)
        {
            if (warriorName != null)
            {
                warrior.Name = warriorName;
            }
            else
            {
                warrior.Name = implicitName;
            }
        }

        private void SetPin(ExtendedWarrior warrior)
        {
            if (pin != null)
            {
                warrior.Pin = pin.Evaluate(this, 0);
            }
            else
            {
                warrior.Pin = -1;
            }
        }

        private void SetOrg(ExtendedWarrior warrior)
        {
            if (org != null)
            {
                if (!variables.ContainsKey(org))
                {
                    WriteError("Label not defined : " + org);
                    return;
                }
                warrior.StartOffset = variables[org].Evaluate(this, 0);
            }
        }

        protected void Prepare()
        {
            variables = new Dictionary<string, Expression>();
            org = null;
            counter = 0;
            warriorName = null;
            authorName = null;
            variables["CORESIZE"] = new Value(rules.coreSize);
            variables["MAXPROCESSES"] = new Value(rules.maxProcesses);
            variables["MAXCYCLES"] = new Value(rules.maxCycles);
            variables["MAXLENGTH"] = new Value(rules.maxLength);
            variables["MINDISTANCE"] = new Value(rules.minDistance);
            variables["ROUNDS"] = new Value(rules.rounds);
            variables["PSPACESIZE"] = new Value(rules.pSpaceSize);
            variables["VERSION"] = new Value(rules.version);
            variables["WARRIORS"] = new Value(rules.warriors);
        }
    }
}