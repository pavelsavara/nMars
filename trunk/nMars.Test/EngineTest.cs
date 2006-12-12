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
            LoadRunPair(Path.Combine(basePath, "clear/twinshot.rc"), Path.Combine(basePath, "corewin/bluefunk.red"), 0);
        }

        [Test]
        public void Full()
        {
            Init();

            List<string> files = new List<string>(Directory.GetFiles(basePath, "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(basePath, "*.red", SearchOption.AllDirectories));
            files.Sort();
            bool allOK = true;
            int c = 0;
            for (int i = 0; i < files.Count; i++)
            {
                for (int j = 0; j < files.Count; j++)
                {
                    try
                    {
                        LoadRunPair(files[i], files[j], c);
                        c++;
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
            }
            if (!allOK)
                throw new EngineDifferException("Some warriors failed.", null);
        }

        [Test]
        public void Random(int count)
        {
            Init();

            List<string> files = new List<string>(Directory.GetFiles(basePath, "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(basePath, "*.red", SearchOption.AllDirectories));
            files.Sort();
            Random r=new Random();
            
            bool allOK = true;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    LoadRunPair(files[r.Next(files.Count)], files[r.Next(files.Count)], i);
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
#if DEBUG
            rules.Rounds = 3;
#else
            rules.Rounds = 7;
#endif

            pparser = new CachingParser(ModuleRegister.CreateParser("pMars.DllWrapper"));
            pparser.InitParser(rules);

            engines = new ComparingEngine();
        }

        private void LoadRunOne(string fileOne)
        {
            IWarrior pwarriorOne;
            string shortOne = Path.GetFileNameWithoutExtension(fileOne);
            string midleOne = fileOne.Substring(basePath.Length);
            Console.Write("Fighting {0}      \r", midleOne);
            string problemsPathOne = Path.Combine(problemsPath, shortOne);
            pwarriorOne = pparser.Parse(fileOne, problemsPathOne + ".pErr");
            if (pwarriorOne == null)
                return;
            Project pproject = new Project(rules);
            pproject.EngineOptions = EngineOptions.ConstantRandom;
            pproject.Warriors.Add(pwarriorOne);

            engines.Run(pproject);
        }

        private void LoadRunPair(string fileOne, string fileTwo, int counter)
        {
            IWarrior pwarriorOne;
            IWarrior pwarriorTwo;
            string shortOne = Path.GetFileNameWithoutExtension(fileOne);
            string shortTwo = Path.GetFileNameWithoutExtension(fileTwo);
            string midleOne = fileOne.Substring(basePath.Length);
            string midleTwo = fileTwo.Substring(basePath.Length);
            string problemsPathOne = Path.Combine(problemsPath, shortOne);
            string problemsPathTwo = Path.Combine(problemsPath, shortTwo);
            pwarriorOne = pparser.Parse(fileOne, problemsPathOne + ".pErr1");
            pwarriorTwo = pparser.Parse(fileTwo, problemsPathTwo + ".pErr2");
            if (pwarriorOne == null || pwarriorTwo == null)
                return;
            Console.Write("{2} Fighting {0} and {1}         \r", pwarriorOne.Name, pwarriorTwo.Name, counter);
            Project pproject = new Project(rules);
            pproject.EngineOptions = EngineOptions.ConstantRandom;
            pproject.Warriors.Add(pwarriorOne);
            pproject.Warriors.Add(pwarriorTwo);
            try
            {
                engines.Run(pproject);
            }
            catch (EngineDifferException)
            {
                Console.WriteLine();
                Console.WriteLine(pwarriorOne.Name); 
                Console.WriteLine(pwarriorTwo.Name);
                File.Copy(fileOne, problemsPathOne + ".red", true);
                File.Copy(fileTwo, problemsPathTwo + ".red", true);
                throw;
            }
        }

        IParser pparser;
        string basePath;
        string problemsPath;
        Rules rules;
        ComparingEngine engines;
    }
}