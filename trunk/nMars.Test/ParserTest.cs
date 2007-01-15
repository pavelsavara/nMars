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
        private Rules rules = Rules.DefaultRules;

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
            if (!LoadDumpOne(Path.Combine(basePath, @"beppe\rnd5\EADON5.RED")))
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
            Project pp = new Project(rules, file);
            Project np = new Project(rules, file);
            ParseResult pr = pparser.Parse(pp, null);
            ParseResult nr = nparser.Parse(np, null);

            if (!nr.Succesfull && !pr.Succesfull)
            {
                //both failed
                return true;
            }
            else if (!pr.Succesfull)
            {
                if (pr.Messages.Count != 0)
                    File.WriteAllText(problemsPathFile + ".pErr", pr.Dump());
                np.Warriors[0].Dump(problemsPathFile + ".nDmp", ParserOptions.NoOffset);
            }
            else if (!nr.Succesfull)
            {
                if (nr.Messages.Count != 0)
                    File.WriteAllText(problemsPathFile + ".nErr", nr.Dump());
                pp.Warriors[0].Dump(problemsPathFile + ".pDmp", ParserOptions.NoOffset);
            }
            else if (!Warrior.Equals(np.Warriors[0], pp.Warriors[0]))
            {
                if (pr.Messages.Count!=0) 
                    File.WriteAllText(problemsPathFile + ".pErr", pr.Dump());
                if (nr.Messages.Count != 0)
                    File.WriteAllText(problemsPathFile + ".nErr", nr.Dump());
                np.Warriors[0].Wrap();
                pp.Warriors[0].Wrap();
                np.Warriors[0].Dump(problemsPathFile + ".nDmp", ParserOptions.NoOffset);
                pp.Warriors[0].Dump(problemsPathFile + ".pDmp", ParserOptions.NoOffset);
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