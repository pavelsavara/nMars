// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;
using System.Text;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    public class ParserException : Exception
    {
        public ParserException(string message)
            : base(message)
        {
        }
    }

    public interface IParser
    {
        IWarrior Parse(string fileName);
        IWarrior Parse(string fileName, TextWriter err);
        IWarrior Parse(string fileName, string errFileName);
    }

    public abstract class ParserRoot : IParser
    {
        public abstract IWarrior Parse(string fileName, TextWriter err);

        public IWarrior Parse(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            IWarrior res = Parse(fileName, sw);
            sw.Close();
            if (sb.Length>0)
            {
                throw new ParserException(sb.ToString());
            }
            return res;
        }

        public IWarrior Parse(string fileName, string errFileName)
        {
            MemoryStream ms=new MemoryStream();
            StreamWriter sw=new StreamWriter(ms);
            IWarrior res=Parse(fileName, sw);
            sw.Flush();
            
            if (res==null)
            {
                Stream fs = File.Create(errFileName);
                ms.WriteTo(fs);
                fs.Close();
            }
            sw.Close();
            return res;
        }
        protected Rules rules;
    }

    public interface IParserModule : IModule
    {
        IParser CreateParser(Rules rules);
    }
}