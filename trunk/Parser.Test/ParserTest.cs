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
        IParser nparser;
        IParser pparser;
        string basePath;

        void Init()
        {
            nparser = new nMarsParser();
            pparser = new pMarsDllParser();
            //pparser = new pMarsParser(Rules.DefaultRules);
            basePath = Path.GetFullPath(@"Warriors");
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
                catch (Exception)
                {
                    //swalow
                }
            }

            Directory.CreateDirectory(basePath + @"\_problems\");
        }

        [Test]
        public void Single()
        {
            Init();
            if (!LoadDumpOne(basePath + @"\warriors\corewin\irongate.red"))
                throw new ParserException("Some warriors failed.");
        }

        [Test]
        public void Full()
        {
            Init();

            List<string> files =
                new List<string>(Directory.GetFiles(basePath, "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(basePath, "*.red", SearchOption.AllDirectories));
            files.Sort();
            bool allOK = true;
            foreach (string file in files)
            {
                allOK &= LoadDumpOne(file);
            }
            if (!allOK)
                throw new ParserException("Some warriors failed.");
        }

        private bool LoadDumpOne(string file)
        {
            string shortName = Path.GetFileNameWithoutExtension(file);
            Console.Write("Reading {0}          \r", shortName);
            string problemsPath = basePath + @"\_problems\" + shortName;
            IWarrior pw = pparser.Parse(file, problemsPath + ".pErr");
            IWarrior nw = nparser.Parse(file, problemsPath + ".nErr");

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