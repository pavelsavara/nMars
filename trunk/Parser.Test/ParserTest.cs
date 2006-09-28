// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using nMars;
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
            nMarsParser nparser = new nMarsParser(Rules.DefaultRules);
            pMarsParser pparser = new pMarsParser(Rules.DefaultRules);
            List<string> files =
                new List<string>(Directory.GetFiles(@"rc", "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(@"rc", "*.red", SearchOption.AllDirectories));
            files.Sort();

            foreach (string file in files)
            {
                Console.Write("Reading {0}          \r", file);
                LoadDumpOne(file, nparser, pparser);
            }
        }

        private static void LoadDumpOne(string file, nMarsParser nparser, pMarsParser pparser)
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
                Console.WriteLine("nMarsParser : " + ex.Message);
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