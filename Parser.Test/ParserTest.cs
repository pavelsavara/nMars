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
            string basePath = Path.GetFullPath(@"Warriors");
            Directory.CreateDirectory(basePath + @"\_problems\");

            foreach (string file in Directory.GetFiles(basePath, "*.?Dmp", SearchOption.AllDirectories))
            {
                File.Delete(file);
            }
            foreach (string file in Directory.GetFiles(basePath, "*.?Err", SearchOption.AllDirectories))
            {
                File.Delete(file);
            }
             
            
            List<string> files =
                new List<string>(Directory.GetFiles(basePath, "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(basePath, "*.red", SearchOption.AllDirectories));
            files.Sort();

            foreach (string file in files)
            {
                Console.Write("Reading {0}          \r", file);
                LoadDumpOne(file, basePath, nparser, pparser);
            }
        }

        private static void LoadDumpOne(string file, string basePath, nMarsParser nparser, pMarsParser pparser)
        {
            IWarrior nw;
            IWarrior pw;
            string problemsPath = basePath + @"\_problems\" + Path.GetFileNameWithoutExtension(file);
            nw = nparser.Parse(file, problemsPath + ".nErr");
            pw = pparser.Parse(file, problemsPath + ".pErr");

            if (nw==null && pw==null)
            {
                //both failed
            }
            else if (pw==null)
            {
                nw.Dump(Path.ChangeExtension(file, ".nDmp"), DumpOptions.NoOffset);
            }
            else if (nw == null)
            {
                pw.Dump(Path.ChangeExtension(file, ".pDmp"), DumpOptions.NoOffset);
            }
            else if (!Warrior.Equals(nw, pw))
            {
                nw.Dump(Path.ChangeExtension(file, ".nDmp"), DumpOptions.NoOffset);
                pw.Dump(Path.ChangeExtension(file, ".pDmp"), DumpOptions.NoOffset);
            }
            else
            {
                // no problem
                return;
            }
            File.Copy(file, problemsPath+".red", true);
        }
    }
}