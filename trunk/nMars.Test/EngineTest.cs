// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using nMars;
using nMars.RedCode;
using nMars.Engine;
using NUnit.Framework;
using pMars.DllWrapper;

namespace nMars.Test
{
    public class EngineDifferException : Exception
    {
        public EngineDifferException(string message, int fromCycle, bool precise)
            : base(message)
        {
            if (precise)
            {
                this.fromCycle = fromCycle;
                toCycle = fromCycle;
            }
            else
            {
                this.fromCycle = fromCycle - 200;
                if (this.fromCycle < 0) this.fromCycle = 0;
                toCycle = fromCycle;
            }
        }

        public EngineDifferException(string message, int fromCycle, int toCycle)
            : base(message)
        {
            this.fromCycle = fromCycle;
            this.toCycle = toCycle;
        }

        public int fromCycle;
        public int toCycle;
    }

    [TestFixture]
    public class EngineTest
    {
        IParser pparser;
        IParser nparser;
        IExtendedStepEngine engineOne;
        IExtendedStepEngine engineTwo;
        PSpaces spaces;
        Random random;
        string basePath;
        string problemsPath;
        int[] forcedArdresses;
        Rules rules;


        private void Init()
        {
            rules = Rules.DefaultRules;
            pparser = new pMarsDllParser();
            pparser.InitParser(rules);
            nparser = new nMarsParser();
            nparser.InitParser(rules);
            engineOne = new pMarsDllEngine();
            engineTwo = new Engine.Engine();
            spaces = new PSpaces();
            random = new Random(0);

            basePath = Utils.GetWarrirorsDirectory();
            problemsPath = Utils.CleanProblems(basePath, "!problems");

            forcedArdresses = new int[2];
            forcedArdresses[0] = 0;
            forcedArdresses[1] = rules.CoreSize/2;
        }

        [Test]
        public void Single()
        {
            Init();
            rules.WarriorsCount = 1;
            LoadRunOne(Path.Combine(Path.Combine(basePath, "corewin"), "irongate.red"));
        }

        [Test]
        public void Pair()
        {
            Init();
            LoadRunPair(Path.Combine(Path.Combine(basePath, "kendall"), "BackfromtheGrave.red"),
                        Path.Combine(Path.Combine(basePath, "kendall"), "BigBrother.red"));
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
            for (int i = 0; i < files.Count; i += 2)
            {
                try
                {
                    LoadRunPair(files[i], files[i + 1]);
                }
                catch (EngineDifferException)
                {
                    allOK = false;
                }
                catch (ParserException)
                {
                    //swallow
                }
            }
            if (!allOK)
                throw new EngineDifferException("Some warriors failed.", int.MaxValue, int.MaxValue);
        }

        private void LoadRunOne(string fileOne)
        {
            IWarrior warriorOne;
            string shortOne = Path.GetFileNameWithoutExtension(fileOne);
            string midleOne = fileOne.Substring(basePath.Length);
            Console.Write("Reading {0}      \r", midleOne);
            string problemsPathOne = Path.Combine(problemsPath, shortOne); 
            warriorOne = pparser.Parse(fileOne, problemsPathOne + ".pErr");
            IWarrior[] project = new IWarrior[1];
            project[0] = warriorOne;

            RunProject(project);
        }

        private void LoadRunPair(string fileOne, string fileTwo)
        {
            IWarrior pwarriorOne;
            IWarrior pwarriorTwo;
            IWarrior nwarriorOne;
            IWarrior nwarriorTwo;
            string shortOne = Path.GetFileNameWithoutExtension(fileOne);
            string shortTwo = Path.GetFileNameWithoutExtension(fileTwo);
            string midleOne = fileOne.Substring(basePath.Length);
            string midleTwo = fileTwo.Substring(basePath.Length);
            Console.Write("Reading {0} and {1}         \r", midleOne, midleTwo);
            string problemsPathOne = Path.Combine(problemsPath, shortOne);
            string problemsPathTwo = Path.Combine(problemsPath, shortTwo);
            pwarriorOne = pparser.Parse(fileOne, problemsPathOne + ".pErr1");
            pwarriorTwo = pparser.Parse(fileTwo, problemsPathTwo + ".nErr2");
            nwarriorOne = pparser.Parse(fileOne, problemsPathOne + ".pErr1");
            nwarriorTwo = pparser.Parse(fileTwo, problemsPathTwo + ".nErr2");
            IWarrior[] pproject = new IWarrior[2];
            IWarrior[] nproject = new IWarrior[2];
            pproject[0] = pwarriorOne;
            pproject[1] = pwarriorTwo;
            nproject[0] = nwarriorOne;
            nproject[1] = nwarriorTwo;
            CheckWarriors(nproject, pproject);
            RunProject(pproject);
        }

        private void RunProject(IWarrior[] project)
        {
            bool res;
            int fromCycle = int.MaxValue;
            int toCycle = int.MaxValue;
            do
            {
                res = true;
                try
                {
                    CompareEngines(project, fromCycle, toCycle);
                }
                catch (EngineDifferException e)
                {
                    if (e.fromCycle >= 0)
                    {
                        fromCycle = e.fromCycle;
                        toCycle = e.toCycle;
                    }
                    res = false;
                }
            } while (!res);
        }

        private void CompareEngines(IWarrior[] project, int fromCycle, int toCycle)
        {
            engineOne.BeginMatch(rules, project, spaces, random, forcedArdresses);
            engineTwo.BeginMatch(rules, project, spaces, random, forcedArdresses);


            MatchResult matchOne;
            MatchResult matchTwo;
            try
            {
                CheckWarriors(engineOne.Warriors, engineTwo.Warriors);
                ExpensiveCheck(false);
                while (Step(fromCycle, toCycle))
                {
                }
                ExpensiveCheck(false);
            }
            finally
            {
                matchOne = engineOne.EndMatch();
                matchTwo = engineTwo.EndMatch();
            }


            if (matchOne == matchTwo)
            {
                throw new EngineDifferException("Score", int.MaxValue, int.MaxValue);
            }
        }

        private bool Step(int fromCycle, int toCycle)
        {
            if (toCycle <= engineOne.Cycles + 1)
            {
            }
            StepResult resOne = engineOne.NextStep();
            StepResult resTwo = engineTwo.NextStep();
            bool range = (engineOne.Cycles >= fromCycle && engineOne.Cycles <= toCycle);

            CheapCheck(resOne, resTwo, range);
            if (engineOne.Cycles%200 == 0 || range)
            {
                ExpensiveCheck(range);
            }

            if (resOne == StepResult.Finished)
            {
                return false;
            }
            return true;
        }

        private void CheapCheck(StepResult resOne, StepResult resTwo, bool precise)
        {
            if (resOne != resTwo)
            {
                throw new EngineDifferException("StepRes", engineOne.Cycles, precise);
            }
            if (engineOne.Round != engineTwo.Round)
            {
                throw new EngineDifferException("Round", engineOne.Cycles, precise);
            }
            if (engineOne.LiveWarriorsCount != engineTwo.LiveWarriorsCount)
            {
                throw new EngineDifferException("Died", engineOne.Cycles, precise);
            }
            if (engineOne.Cycles != engineTwo.Cycles)
            {
                throw new EngineDifferException("Cycle", engineOne.Cycles, precise);
            }
            if (engineOne.CyclesLeft != engineTwo.CyclesLeft)
            {
                throw new EngineDifferException("CyclesLeft", engineOne.Cycles, precise);
            }
            if (engineOne.NextWarriorIndex != engineTwo.NextWarriorIndex)
            {
                throw new EngineDifferException("Cheating", engineOne.Cycles, precise);
            }
        }

        private void ExpensiveCheck(bool precise)
        {
            for (int a = 0; a < rules.CoreSize; a++)
            {
                IInstruction iOne = engineOne[a];
                IInstruction iTwo = engineTwo[a];
                if (!iOne.Equals(iTwo))
                {
                    throw new EngineDifferException("Core", engineOne.Cycles, precise);
                }
            }
            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                IList<int> tasksOne = engineOne.Tasks[w];
                IList<int> tasksTwo = engineTwo.Tasks[w];
                if (tasksOne.Count != tasksTwo.Count)
                {
                    throw new EngineDifferException("Task Died", engineOne.Cycles, precise);
                }
                for (int t = 0; t < tasksOne.Count; t++)
                {
                    int taskOne = tasksOne[t];
                    int taskTwo = tasksTwo[t];
                    if (taskOne != taskTwo)
                    {
                        throw new EngineDifferException("Bad IP", engineOne.Cycles, precise);
                    }
                }
            }
        }

        private void CheckWarriors(IList<IWarrior> warriorsOne, IList<IWarrior> warriorsTwo)
        {
            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                if (warriorsOne[w] == null || warriorsTwo[w] == null)
                    throw new ParserException("Warriror not loaded");

                if (!Warrior.Equals(warriorsOne[w], warriorsTwo[w]))
                {
                    throw new ParserException("Different warriors");
                }
            }
        }
    }
}