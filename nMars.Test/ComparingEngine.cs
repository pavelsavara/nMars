// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Test
{

    #region Helper Classes

    public class Check
    {
        public Check(int round, int cycle, bool precise)
        {
            if (precise)
            {
                Round = round;
                FromCycle = cycle;
                ToCycle = cycle;
                Step = 1;
            }
            else
            {
                Round = round;
                FromCycle = cycle - 200;
                Step = 200;
                if (FromCycle < 0)
                    FromCycle = 0;
                ToCycle = cycle;
            }
            if (cycle == 0 && Round > 0)
            {
                Round = 0;
            }
        }

        public Check(int round, int fromCycle, int toCycle, int step)
        {
            FromCycle = fromCycle;
            ToCycle = toCycle;
            Step = step;
            Round = round;
        }

        public int FromCycle;
        public int ToCycle;
        public int Step;
        public int Round;
        public static Check Optimistic = new Check(0, int.MaxValue, int.MaxValue, 37777);
    }

    public class EngineDifferException : Exception
    {
        public EngineDifferException(string message, Check check)
            : base(message)
        {
            Check = check;
        }

        public Check Check;
    }

    #endregion

    class ComparingEngine : IEngine
    {
        public MatchResult Run(IProject aProject)
        {
            project = (Project)aProject;
            Init();
            project.ForcedAddresses = forcedArdresses;

            Check check = Check.Optimistic;
#if DEBUG
            // this loop restarts test with more and more precise check setting to isolate bugs in engine
            bool res;
            do
            {
                res = true;
                try
                {
                    CompareEngines(check);
                }
                catch (EngineDifferException e)
                {
                    check = e.Check;
                    res = false;
                }
            } while (!res);
#else
            CompareEngines(check);
#endif
            return matchTwo;
        }

        private void Init()
        {
            project.EngineOptions.Random = new Random(0);
            project.EngineOptions.DumpResults = false;

            engineOne = ModuleRegister.CreateEngine("pMars.DllWrapper") as IExtendedStepEngine;
            engineTwo = ModuleRegister.CreateEngine("nMars.Engine", "nMars.Engine-StepForward") as IExtendedStepEngine;
            engineOne.Output = output;
            engineTwo.Output = output;

            forcedArdresses = new List<int>();
            forcedArdresses.Add(0);
            forcedArdresses.Add(4231);
        }

        #region Loop

        private void CompareEngines(Check check)
        {
            engineOne.BeginMatch(project);
            engineTwo.BeginMatch(project);

            try
            {
                CheckWarriors(project.Rules, engineOne.Warriors, engineTwo.Warriors);
                ExpensiveCheck(false);
                while (Step(check))
                {
                }
                ExpensiveCheck(false);
            }
            finally
            {
                matchOne = engineOne.EndMatch();
                matchTwo = engineTwo.EndMatch();
            }

            if (matchOne != matchTwo)
            {
                throw new EngineDifferException("Score", Check.Optimistic);
            }
        }

        private bool Step(Check check)
        {
            bool stop = (check.Step == 1) && (engineOne.Round == check.Round) && (check.ToCycle <= engineOne.Cycles + 1);
            if (stop)
            {
                // set debuger breakpoint here, this will stop before error ocurs
                ExpensiveCheck(true);
            }
            StepResult resOne = engineOne.NextStep();
            StepResult resTwo = engineTwo.NextStep();
            bool range = (engineOne.Cycles >= check.FromCycle && engineOne.Cycles <= check.ToCycle &&
                          engineOne.Round == check.Round);
            bool step = (check.Step != 1) && (engineOne.Cycles % check.Step == 0) && (engineOne.Round >= check.Round);

            CheapCheck(resOne, resTwo, check, range);
            if (stop || step || range || resOne == StepResult.NextRound)
            {
                ExpensiveCheck(range);
            }

            if (resOne == StepResult.Finished)
            {
                return false;
            }
            return true;
        }

        public IProject Project
        {
            get { return project; }
        }

        public ISimpleOutput Output
        {
            set { output = value; }
        }

        #endregion

        #region Tests

        private void CheapCheck(StepResult resOne, StepResult resTwo, Check origCheck, bool precise)
        {
            if (resOne != resTwo)
            {
                throw new EngineDifferException("StepRes",
                                                new Check(0, origCheck.FromCycle, origCheck.ToCycle, origCheck.Step / 2));
            }
            if (engineOne.Cycles != engineTwo.Cycles)
            {
                throw new EngineDifferException("Cycle", new Check(engineOne.Round, engineOne.Cycles, precise));
            }
            if (engineOne.Round != engineTwo.Round)
            {
                throw new EngineDifferException("Round", new Check(engineOne.Round, engineOne.Cycles, precise));
            }
            if (engineOne.LiveWarriorsCount != engineTwo.LiveWarriorsCount)
            {
                throw new EngineDifferException("Died", new Check(engineOne.Round, engineOne.Cycles, precise));
            }
            if (engineOne.CyclesLeft != engineTwo.CyclesLeft)
            {
                throw new EngineDifferException("CyclesLeft", new Check(engineOne.Round, engineOne.Cycles, precise));
            }
            if (engineOne.NextWarriorIndex != engineTwo.NextWarriorIndex)
            {
                throw new EngineDifferException("Cheating", new Check(engineOne.Round, engineOne.Cycles, precise));
            }
        }

        private void ExpensiveCheck(bool precise)
        {
            for (int a = 0; a < project.Rules.CoreSize; a++)
            {
                IInstruction iOne = engineOne[a];
                IInstruction iTwo = engineTwo[a];
                if (!iOne.Equals(iTwo))
                {
                    throw new EngineDifferException("Core", new Check(engineOne.Round, engineOne.Cycles, precise));
                }
            }
            IList<IPSpace> psapacesOne = engineOne.PSpaces;
            IList<IPSpace> psapacesTwo = engineTwo.PSpaces;
            for (int w = 0; w < project.Rules.WarriorsCount; w++)
            {
                if (!psapacesOne[w].Equals(psapacesTwo[w]))
                {
                    throw new EngineDifferException("PSpaces", new Check(engineOne.Round, engineOne.Cycles, precise));
                }

                if (engineOne.LastResults[w] != engineTwo.LastResults[w])
                {
                    throw new EngineDifferException("LastResult", new Check(engineOne.Round, engineOne.Cycles, precise));
                }
                if (engineOne.PSPaceIndexes[w] != engineTwo.PSPaceIndexes[w])
                {
                    throw new EngineDifferException("PSPaceIndexes",
                                                    new Check(engineOne.Round, engineOne.Cycles, precise));
                }
                if (engineOne.Warriors[w].Pin != engineTwo.Warriors[w].Pin)
                {
                    throw new EngineDifferException("Pin", new Check(engineOne.Round, engineOne.Cycles, precise));
                }
                IList<int> tasksOne = engineOne.Tasks[w];
                IList<int> tasksTwo = engineTwo.Tasks[w];
                if (tasksOne.Count != tasksTwo.Count)
                {
                    throw new EngineDifferException("Task Died", new Check(engineOne.Round, engineOne.Cycles, precise));
                }
                for (int t = 0; t < tasksOne.Count; t++)
                {
                    int taskOne = tasksOne[t];
                    int taskTwo = tasksTwo[t];
                    if (taskOne != taskTwo)
                    {
                        throw new EngineDifferException("Bad IP", new Check(engineOne.Round, engineOne.Cycles, precise));
                    }
                }
            }
        }

        public static void CheckWarriors(Rules rules, IList<IWarrior> warriorsOne, IList<IWarrior> warriorsTwo)
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

        #endregion

        #region Variables

        IExtendedStepEngine engineOne;
        IExtendedStepEngine engineTwo;
        MatchResult matchOne;
        MatchResult matchTwo;
        Project project;
        List<int> forcedArdresses;
        private ISimpleOutput output;

        #endregion
    }
}