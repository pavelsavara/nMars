using System.Collections.Generic;
using System.IO;
using nMars.RedCode;

namespace pMars.DllWrapper
{
    public class pMarsDllParser : ParserRoot
    {
        public override IWarrior Parse(string fileName, TextWriter err)
        {
            string errFile = Path.GetTempFileName();
            IWarrior res = Parse(fileName, errFile);
            if (res == null)
            {
                string errors = File.ReadAllText(errFile);
                err.Write(errors);
                File.Delete(errFile);
            }
            return res;
        }

        public override IWarrior Parse(string fileName, string errFileName)
        {
            List<string> r = pMarsDll.BuildParams(rules, true, null, fileName);

            pMarsDll.PmarsWarrior w = pMarsDll.pMarsParse(r.Count, r.ToArray(), errFileName);
            if (w == null) return null;

            Warrior warrior = pMarsDll.ConvertWarrior(fileName, w, rules);

            pMarsDll.pMarsFreeParsed();

            return warrior;
        }
    }
}