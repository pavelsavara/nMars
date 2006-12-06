// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using System.Text;

namespace nMars.RedCode
{
    public abstract class ParserBase : IParser
    {
        public static int RunParser(IList<string> files, IParser parser, IProject project, IConsole output)
        {
            int res = 0;
            parser.InitParser(project.Rules);
            foreach (string file in files)
            {
                IWarrior warrior = RunParser(file, parser, project.ParserOptions, output);
                if (warrior != null)
                {
                    project.Warriors.Add(warrior);
                    res++;
                }
            }
            if (project.ParserOptions.Status)
            {
                output.WriteLine("Compiled " + files.Count.ToString() + " warriors, " + (files.Count - res).ToString() +
                                 " failed");
            }
            return res;
        }

        public static int RunParser(IList<string> files, IParser parser, Rules rules, ParserOptions options,
                                    IConsole output)
        {
            int res = 0;
            parser.InitParser(rules);
            foreach (string file in files)
            {
                IWarrior warrior = RunParser(file, parser, options, output);
                if (warrior != null)
                {
                    res++;
                }
            }
            if (options.Status)
            {
                output.WriteLine("Compiled " + files.Count.ToString() + "warriors, " + (files.Count - res).ToString() +
                                 "failed");
            }
            return res;
        }

        private static IWarrior RunParser(string file, IParser parser, ParserOptions options, IConsole output)
        {
            IWarrior warrior = parser.Parse(file, output);
            if (warrior != null)
            {
                if (options.DumpFiles)
                {
                    StreamWriter sw = new StreamWriter(Path.ChangeExtension(file, options.DumpExt));
                    warrior.Dump(new WrappedTextWriter(sw), options);
                    sw.Close();
                }
                if (!options.Brief)
                {
                    warrior.Dump(output, options);
                }
            }
            return warrior;
        }

        public abstract IWarrior Parse(string fileName, IConsole err);
        public abstract string Name { get; }
        public abstract string Version { get; }

        public virtual void InitParser(Rules aRules)
        {
            rules = aRules;
        }

        public IWarrior Parse(string fileName, TextWriter err)
        {
            WrappedTextWriter wtw = new WrappedTextWriter(err);
            return Parse(fileName, wtw);
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