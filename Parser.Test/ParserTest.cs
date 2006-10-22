// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using nMars;
using nMars.pMarsDll;
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
            IParser nparser = new pMarsDllParser(Rules.DefaultRules);
            //IParser nparser = new nMarsParser(Rules.DefaultRules);
            IParser pparser = new pMarsParser(Rules.DefaultRules);
            string basePath = Path.GetFullPath(@"Warriors");
            if (!Directory.Exists(basePath))
            {
                basePath = Path.GetFullPath(@"..\Warriors");
            }
            if (!Directory.Exists(basePath))
            {
                basePath = Path.GetFullPath(@"..\..\Warriors");
            }
            if (!Directory.Exists(basePath))
            {
                basePath = Path.GetFullPath(@"..\..\..\Warriors");
            }
            if (!Directory.Exists(basePath))
            {
                throw new ApplicationException("Could not find Warrirors at: " + basePath);
            }
            if (Directory.Exists(basePath + @"\_problems\"))
            {
                try
                {
                    Directory.Delete(basePath + @"\_problems\", true);
                }
                catch(Exception)
                {
                    //swalow
                }
            }
            
            Directory.CreateDirectory(basePath + @"\_problems\");

            List<string> files =
                new List<string>(Directory.GetFiles(basePath, "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(basePath, "*.red", SearchOption.AllDirectories));
            files.Sort();
            bool allOK = true;
            foreach (string file in files)
            {
                Console.Write("Reading {0}          \r", file);
                allOK &= LoadDumpOne(file, basePath, nparser, pparser);
            }
            if (!allOK)
                throw new ParserException("Some warriors failed.");
        }

        private static bool LoadDumpOne(string file, string basePath, IParser nparser, IParser pparser)
        {
            IWarrior nw;
            IWarrior pw;
            string problemsPath = basePath + @"\_problems\" + Path.GetFileNameWithoutExtension(file);
            pw = pparser.Parse(file, problemsPath + ".pErr");
            nw = nparser.Parse(file, problemsPath + ".nErr");

            if (nw == null && pw == null)
            {
                //both failed
            }
            else if (pw == null)
            {
                nw.Dump(problemsPath + ".nDmp", DumpOptions.NoOffset);
            }
            else if (nw == null)
            {
                pw.Dump(problemsPath + ".pDmp", DumpOptions.NoOffset);
            }
            else if (!Warrior.Equals(nw, pw))
            {
                nw.Dump(problemsPath + ".nDmp", DumpOptions.NoOffset);
                pw.Dump(problemsPath + ".pDmp", DumpOptions.NoOffset);
                nw = nparser.Parse(file, problemsPath + ".nErr");
            }
            else
            {
                // no problem
                return true;
            }
            File.Copy(file, problemsPath + ".red", true);
            return false;
        }
    }
}