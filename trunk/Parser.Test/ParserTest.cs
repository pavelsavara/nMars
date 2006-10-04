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

            foreach (string file in Directory.GetFiles(@"rc", "*.?Dmp", SearchOption.AllDirectories))
            {
                File.Delete(file);
            }
            foreach (string file in Directory.GetFiles(@"rc", "*.?Err", SearchOption.AllDirectories))
            {
                File.Delete(file);
            }
             
            
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
            nw = nparser.Parse(file, Path.ChangeExtension(file, ".nErr"));
            pw = pparser.Parse(file, Path.ChangeExtension(file, ".pErr"));

            if (nw==null && pw==null) return;
            if (pw==null)
            {
                nw.Dump(Path.ChangeExtension(file, ".nDmp"), DumpOptions.NoOffset);
                return;
            }

            if (nw == null)
            {
                pw.Dump(Path.ChangeExtension(file, ".pDmp"), DumpOptions.NoOffset);
                return;
            }

            if (!Warrior.Equals(nw, pw))
            {
                nw.Dump(Path.ChangeExtension(file, ".nDmp"), DumpOptions.NoOffset);
                pw.Dump(Path.ChangeExtension(file, ".pDmp"), DumpOptions.NoOffset);
            }
        }
    }
}