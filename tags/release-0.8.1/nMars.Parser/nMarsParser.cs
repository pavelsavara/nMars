// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using nMars.Parser.Statements;
using nMars.Parser.Warrior;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Parser
{
    public class nMarsParser : ParserTokens, IParser
    {
        public override string Name
        {
            get { return GetType().Namespace; }
        }

        public override string Version
        {
            get { return ModuleRegister.GetVersion(GetType()); }
        }

        public override IWarrior Parse(string fileName, ISimpleOutput err)
        {
            StreamReader sr = new StreamReader(fileName);
            string source = sr.ReadToEnd();
            sr.Close();
            ExtendedWarrior res = (ExtendedWarrior)Parse(source, err, Path.GetFileNameWithoutExtension(fileName));
            if (res != null) res.FileName = fileName;
            return res;
        }

        public IWarrior Parse(string sourceText, ISimpleOutput err, string implicitName)
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
                statement.ExpandStatements(warrior, this, ref currentAddress, rules.CoreSize, false);

                //second pass to evaluate variables/labels in context of for cycles
                currentAddress = 0;
                variables["CURLINE"] = new Value(0);
                statement.ExpandStatements(warrior, this, ref currentAddress, rules.CoreSize, true);

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
                err.ErrorWriteLine(ex.Message);
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
                warrior.Pin = PSpace.UNSHARED;
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
            variables["CORESIZE"] = new Value(rules.CoreSize);
            variables["MAXPROCESSES"] = new Value(rules.MaxProcesses);
            variables["MAXCYCLES"] = new Value(rules.MaxCycles);
            variables["MAXLENGTH"] = new Value(rules.MaxLength);
            variables["MINDISTANCE"] = new Value(rules.MinDistance);
            variables["ROUNDS"] = new Value(rules.Rounds);
            variables["PSPACESIZE"] = new Value(rules.PSpaceSize);
            variables["VERSION"] = new Value(rules.Version);
            variables["WARRIORS"] = new Value(rules.WarriorsCount);
        }
    }
}