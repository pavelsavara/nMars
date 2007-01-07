// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using nMars.Parser.Statements;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Parser
{
    public class nMarsParser : ParserTokens, IParser
    {
        protected override IWarrior Parse(string aFileName)
        {
            fileName = aFileName;
            StreamReader sr = new StreamReader(fileName);
            string source = sr.ReadToEnd();
            sr.Close();

            ExtendedWarrior warrior = Parse(source, Path.GetFileNameWithoutExtension(fileName));
            if (warrior != null) 
                warrior.FileName = fileName;
            return warrior;
        }

        private ExtendedWarrior Parse(string sourceText, string implicitName)
        {
            errCount = 0;
            Prepare();
            try
            {
                Statement statement = ParseInternal(sourceText);
                ExtendedWarrior warrior = new ExtendedWarrior(project.Rules);
                int currentAddress;

                //first pass to expand for-rof cycles
                currentAddress = 0;
                variables["CURLINE"] = new Value(0);
                statement.ExpandStatements(warrior, this, ref currentAddress, project.Rules.CoreSize, false);

                //second pass to evaluate variables/labels in context of for cycles
                currentAddress = 0;
                variables["CURLINE"] = new Value(0);
                statement.ExpandStatements(warrior, this, ref currentAddress, project.Rules.CoreSize, true);

                SetOrg(warrior);
                SetPin(warrior);
                SetName(warrior, implicitName);
                SetAuthor(warrior);
                warrior.Variables = variables;
                if (errCount > 0)
                    return null;
                return warrior;
            }
            catch (ParserException)
            {
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
            variables["CORESIZE"] = new Value(project.Rules.CoreSize);
            variables["MAXPROCESSES"] = new Value(project.Rules.MaxProcesses);
            variables["MAXCYCLES"] = new Value(project.Rules.MaxCycles);
            variables["MAXLENGTH"] = new Value(project.Rules.MaxLength);
            variables["MINDISTANCE"] = new Value(project.Rules.MinDistance);
            variables["ROUNDS"] = new Value(project.Rules.Rounds);
            variables["PSPACESIZE"] = new Value(project.Rules.PSpaceSize);
            variables["VERSION"] = new Value(project.Rules.Version);
            variables["WARRIORS"] = new Value(project.Rules.WarriorsCount);
        }
    }
}