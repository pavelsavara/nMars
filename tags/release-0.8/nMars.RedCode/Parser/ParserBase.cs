// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;
using System.Text;

namespace nMars.RedCode
{
    public abstract class ParserBase : IParser
    {
        public abstract IWarrior Parse(string fileName, TextWriter err);

        public virtual void InitParser(Rules aRules)
        {
            rules = aRules;
        }

        public IWarrior Parse(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            IWarrior res = Parse(fileName, sw);
            sw.Close();
            if (sb.Length > 0)
            {
                throw new ParserException(sb.ToString());
            }
            return res;
        }

        public virtual IWarrior Parse(string fileName, string errFileName)
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            IWarrior res = Parse(fileName, sw);
            sw.Flush();

            if (res == null)
            {
                Stream fs = File.Create(errFileName);
                ms.WriteTo(fs);
                fs.Close();
            }
            sw.Close();
            return res;
        }

        protected Rules rules = Rules.DefaultRules;
    }
}
