// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using nMars.RedCode;
using nMars.RedCode.Modules;
using NUnit.Framework;

namespace nMars.Test
{
    [TestFixture]
    public class ParserTest
    {
        IParser nparser;
        IParser pparser;
        string basePath;
        string problemsPath;

        void Init()
        {
            nparser = ModuleRegister.CreateParser("nMars.Parser");
            pparser = ModuleRegister.CreateParser("pMars.DllWrapper");
            //pparser = new pMarsParser(Rules.DefaultRules);

            basePath = Utils.GetWarrirorsDirectory();
            problemsPath = Utils.CleanProblems(basePath, "_problems");
        }

        [Test]
        public void Single()
        {
            Init();
            if (!LoadDumpOne(Path.Combine(Path.Combine(basePath, "corewin"), "irongate.red")))
                throw new ParserException("Some warriors failed.");
        }

        [Test]
        public void Full()
        {
            Init();

            List<string> files = new List<string>(Directory.GetFiles(basePath, "*.rc", SearchOption.AllDirectories));
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
            string problemsPathFile = Path.Combine(problemsPath, shortName);
            string midleName = file.Substring(basePath.Length);
            Console.WriteLine("Reading {0}          ", midleName);
            IWarrior pw = pparser.Parse(file, problemsPathFile + ".pErr");
            IWarrior nw = nparser.Parse(file, problemsPathFile + ".nErr");

            if (nw == null && pw == null)
            {
                //both failed
            }
            else if (pw == null)
            {
                nw.Dump(problemsPathFile + ".nDmp", ParserOptions.NoOffset);
            }
            else if (nw == null)
            {
                pw.Dump(problemsPathFile + ".pDmp", ParserOptions.NoOffset);
            }
            else if (!Warrior.Equals(nw, pw))
            {
                nw.Dump(problemsPathFile + ".nDmp", ParserOptions.NoOffset);
                pw.Dump(problemsPathFile + ".pDmp", ParserOptions.NoOffset);
            }
            else
            {
                // no problem
                return true;
            }
            File.Copy(file, problemsPathFile + ".red", true);
            return false;
        }
    }
}