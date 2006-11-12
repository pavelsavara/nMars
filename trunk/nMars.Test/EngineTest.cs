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
    public class EngineTest
    {

        [Test]
        public void Single()
        {
            Init();
            rules.WarriorsCount = 1;
            LoadRunOne(Path.Combine(basePath, "redcoder/validate.red "));
        }

        [Test]
        public void Pair()
        {
            Init();
            LoadRunPair(Path.Combine(basePath, "clear/twinshot.rc"),
                        Path.Combine(basePath, "corewin/bluefunk.red"));
        }

        [Test]
        public void Full()
        {
            Init();

            List<string> files = new List<string>(Directory.GetFiles(basePath, "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(basePath, "*.red", SearchOption.AllDirectories));
            files.Sort();
            bool allOK = true;
            for (int i = 0; i < files.Count; i += 2)
            {
                try
                {
                    LoadRunPair(files[i], files[i + 1]);
                }
                catch (EngineDifferException)
                {
                    Console.WriteLine("\nFailed");
                    allOK = false;
                }
                catch (ParserException)
                {
                    //swallow
                }
            }
            if (!allOK)
                throw new EngineDifferException("Some warriors failed.", null);
        }
        
        private void Init()
        {
            basePath = Utils.GetWarrirorsDirectory();
            problemsPath = Utils.CleanProblems(basePath, "!problems");

            rules = Rules.DefaultRules;
            rules.Rounds = 3;

            pparser = ModuleRegister.CreateParser("pMars.DllWrapper");
            pparser.InitParser(rules);
            
            engines=new ComparingEngine();

        }

        private void LoadRunOne(string fileOne)
        {
            IWarrior warriorOne;
            string shortOne = Path.GetFileNameWithoutExtension(fileOne);
            string midleOne = fileOne.Substring(basePath.Length);
            Console.Write("Reading {0}      \r", midleOne);
            string problemsPathOne = Path.Combine(problemsPath, shortOne);
            warriorOne = pparser.Parse(fileOne, problemsPathOne + ".pErr");
            Project pproject = new Project(rules);
            pproject.Warriors.Add(warriorOne);

            engines.Run(pproject, random);
        }

        private void LoadRunPair(string fileOne, string fileTwo)
        {
            IWarrior pwarriorOne;
            IWarrior pwarriorTwo;
            string shortOne = Path.GetFileNameWithoutExtension(fileOne);
            string shortTwo = Path.GetFileNameWithoutExtension(fileTwo);
            string midleOne = fileOne.Substring(basePath.Length);
            string midleTwo = fileTwo.Substring(basePath.Length);
            Console.Write("Reading {0} and {1}         \r", midleOne, midleTwo);
            string problemsPathOne = Path.Combine(problemsPath, shortOne);
            string problemsPathTwo = Path.Combine(problemsPath, shortTwo);
            pwarriorOne = pparser.Parse(fileOne, problemsPathOne + ".pErr1");
            pwarriorTwo = pparser.Parse(fileTwo, problemsPathTwo + ".pErr2");
            Project pproject = new Project(rules);
            pproject.Warriors.Add(pwarriorOne);
            pproject.Warriors.Add(pwarriorTwo);
            try
            {
                engines.Run(pproject, random);
            }
            catch(EngineDifferException)
            {
                File.Copy(fileOne, problemsPathOne + ".red", true);
                File.Copy(fileTwo, problemsPathTwo + ".red", true);
                throw;
            }
        }

        IParser pparser;
        string basePath;
        string problemsPath;
        Rules rules;
        Random random=new Random(0); //always same sequence
        ComparingEngine engines;

    }
}