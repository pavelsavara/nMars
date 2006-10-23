using System.Collections.Generic;
using System.IO;
using nMars.RedCode;

namespace nMars.pMarsDll
{
    public class pMarsDllParser : ParserRoot
    {

        public pMarsDllParser(Rules rules)
        {
            InitParser(rules);
        }

        public override IWarrior Parse(string fileName, TextWriter err)
        {
            string errFile=Path.GetTempFileName();
            IWarrior res = Parse(fileName, errFile);
            if (res==null)
            {
                string errors = File.ReadAllText(errFile);
                err.Write(errors);
                File.Delete(errFile);
            }
            return res;
        }
        
        public override IWarrior Parse(string fileName, string errFileName)
        {
            List<string> r = pMarsDll.BuildParams(rules, true, fileName);

            pMarsDll.WarriorStruct w = pMarsDll.pMarsParse(r.Count, r.ToArray(), errFileName);
            if (w == null) return null;
            
            //convert
            Warrior warrior=new Warrior(rules);
            warrior.StartOffset = w.offset;
            warrior.Name = w.name;
            warrior.Author = w.authorName;
            warrior.Date = w.date;
            warrior.Version = w.version;
            warrior.FileName = fileName;
            pMarsDll.FillInstructions(warrior.Instructions, w.instBank, w.instLen, rules.coreSize);

            return warrior;
        }

    }
}
