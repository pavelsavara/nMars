using System;
using System.Collections.Generic;
using System.IO;
using nMars.RedCode;
using NUnit.Framework;

namespace Parser.Test
{
    [TestFixture]
    public class ParserTest
    {
        [Test]
        public void Loader()
        {
            nMars.Parser.Parser nparser = new nMars.Parser.Parser(Rules.DefaultRules);
            Pmars.Parser.Parser pparser = new Pmars.Parser.Parser(Rules.DefaultRules);
            List<string> files =
                new List<string>(Directory.GetFiles(@"..\..\..\rc", "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(@"..\..\..\rc", "*.red", SearchOption.AllDirectories));
            files.Sort();

            foreach (string file in files)
            {
                Console.Write("Reading {0}          \r", file);
                LoadDumpOne(file, nparser, pparser);
            }
        }

        private static void LoadDumpOne(string file, nMars.Parser.Parser nparser, Pmars.Parser.Parser pparser)
        {
            IWarrior nw;
            IWarrior pw;
            try
            {
                pw = pparser.Parse(file);
            }
            catch (ParserExceptionBase ex)
            {
                Console.WriteLine();
                Console.WriteLine("PmarsParser : " + ex.Message);
                return;
            }

            try
            {
                nw = nparser.Parse(file);
            }
            catch (ParserExceptionBase ex)
            {
                Console.WriteLine();
                Console.WriteLine("nMarsParser : " +  ex.Message);
                return;
            }
            
            if (!Warrior.Equals(nw, pw))
            {
                Console.WriteLine();
                Console.WriteLine("Warriors doesn't match");

                StreamWriter nswd = new StreamWriter(Path.ChangeExtension(file, ".nDmp"));
                nw.Dump(nswd);
                nswd.Close();

                StreamWriter pswd = new StreamWriter(Path.ChangeExtension(file, ".pDmp"));
                pw.Dump(pswd);
                pswd.Close();
            }
        }
    }
}