// This file is part of nMars - Core War MARS for .NET 
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
        public static ComponentLoader InitComponents()
        {
            ComponentLoader components = new ComponentLoader();
            components.Parser = CreateParserInternal();
            components.Engine = CreateEngineInternal();
            return components;
        }

        public static CachingParser CreateParserInternal()
        {
            IParser pmarsParser = ModuleRegister.CreateParser("pMars.DllWrapper");
            return new CachingParser(pmarsParser);
        }

        public static IEngine CreateEngineInternal()
        {
            IExtendedStepEngine engineOne = ModuleRegister.CreateEngine("pMars.DllWrapper") as IExtendedStepEngine;
            IExtendedStepEngine engineTwo = ModuleRegister.CreateEngine("nMars.Fngine") as IExtendedStepEngine;
            /*
             */

            /*
            IExtendedStepEngine engineOne = ModuleRegister.CreateEngine("pMars.DllWrapper") as IExtendedStepEngine;
            IExtendedStepEngine engineTwo = ModuleRegister.CreateEngine("nMars.Engine-StepBack") as IExtendedStepEngine;
             */
            return new ComparingEngine(engineOne, engineTwo);
        }

        public EngineTest()
        {
            components = InitComponents();
        }

        private ComponentLoader components;

        [Test]
        public void Single()
        {
            Console.WriteLine("Single");
            Init();
            rules.WarriorsCount = 1;
            LoadRunOne(Path.Combine(basePath, "0test/bad.red"));
            Console.WriteLine("\nDone");
        }

        [Test]
        public void Pair()
        {
            Console.WriteLine("Pair");
            Init();
            LoadRunPair(
                Path.Combine(basePath, @"0test\1.red"),
                Path.Combine(basePath, @"pycorewar\Koenigstuhl\94\aggression.red"), 0);
            Console.WriteLine("\nDone");
        }

        [Test]
        public void Full()
        {
            Console.WriteLine("Full");
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
            Console.WriteLine("\nDone");
            if (!allOK)
                throw new EngineDifferException("Some warriors failed.", null);
        }

        [Test]
        public void Random(int count)
        {
            Console.WriteLine("Random");
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
            Console.WriteLine("\nDone");
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
        }

        private void LoadRunOne(string fileOne)
        {
            string midleOne = fileOne.Substring(basePath.Length);
            Console.Write("Fighting {0}      \r", midleOne);
            Project pproject = new Project(rules, fileOne);
            pproject.ParserOptions.Instructions = false;
            pproject.ParserOptions.StatusLine = false;
            ParseResult pr = components.Parser.Parse(pproject, null);
            if (!pr.Succesfull)
                return;

            components.Engine.Run(pproject, null);
        }

        private void LoadRunPair(string fileOne, string fileTwo, int counter)
        {
            string shortOne = Path.GetFileNameWithoutExtension(fileOne);
            string shortTwo = Path.GetFileNameWithoutExtension(fileTwo);
            string problemsPathOne = Path.Combine(problemsPath, shortOne);
            string problemsPathTwo = Path.Combine(problemsPath, shortTwo);

            Project pproject = new Project(rules);
            pproject.ParserOptions.Instructions = false;
            pproject.ParserOptions.StatusLine = false;
            pproject.WarriorFiles.Add(fileOne);
            pproject.WarriorFiles.Add(fileTwo);

            ParseResult pr = components.Parser.Parse(pproject, null);
            if (!pr.Succesfull)
                return;

            string name1 = pproject.Warriors[0].Name;
            string name2 = pproject.Warriors[1].Name;
            name1 = name1.Substring(0, Math.Min(name1.Length, 20));
            name2 = name2.Substring(0, Math.Min(name2.Length, 20));
            Console.Write("{2} Fighting {0} and {1}         \r", name1, name2, counter);
            try
            {
                components.Engine.Run(pproject, null);
            }
            catch (EngineDifferException)
            {
                Console.WriteLine();
                Console.WriteLine(pproject.Warriors[0].FileName);
                Console.WriteLine(pproject.Warriors[1].FileName);
                //File.Copy(fileOne, problemsPathOne + ".red", true);
                //File.Copy(fileTwo, problemsPathTwo + ".red", true);
                pproject.SaveXml(Path.Combine(problemsPath, "EngineDiffer" + counter + ".nmproj"));
                throw;
            }
        }

        string basePath;
        string problemsPath;
        Rules rules;
    }
}