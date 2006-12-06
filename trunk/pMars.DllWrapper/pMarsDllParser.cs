// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace pMars.DllWrapper
{
    public class pMarsDllParser : ParserBase
    {
        public override void InitParser(Rules aRules)
        {
            base.InitParser(aRules);
            //touch DLL
            pMarsDll.pMarsFreeParsed();
        }

        public override IWarrior Parse(string fileName, IConsole err)
        {
            string errFile = Path.GetTempFileName();
            IWarrior res = Parse(fileName, errFile);
            if (res == null)
            {
                string errors = File.ReadAllText(errFile);
                err.ErrorWriteLine(errors);
                File.Delete(errFile);
            }
            return res;
        }

        public override IWarrior Parse(string fileName, string errFileName)
        {
            List<string> r = pMarsDll.BuildParams(rules, true, null, fileName);

            Warrior warrior;
            try
            {
                pMarsDll.PmarsWarrior dllWarrior;
                dllWarrior = pMarsDll.pMarsParse(r.Count, r.ToArray(), errFileName);
                if (dllWarrior == null) return null;
                warrior = pMarsDll.ConvertWarrior(fileName, dllWarrior, rules);
            }
            catch (Exception ex)
            {
                StreamWriter err = new StreamWriter(errFileName, true);
                err.WriteLine("pMars.DllWrapper exited with exception " + ex.ToString() + "\n");
                err.Close();
                return null;
            }


            pMarsDll.pMarsFreeParsed();

            return warrior;
        }

        public override string Name
        {
            get { return GetType().Namespace; }
        }

        public override string Version
        {
            get { return ModuleRegister.GetVersion(GetType()); }
        }
    }
}