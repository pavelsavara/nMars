using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using nMars.RedCode;

namespace pMars.DllWrapper
{
    public class pMarsDllEngine : IEngine, IExtendedStepEngine
    {
        public MatchResult Run(Rules aRules, IWarrior[] aWarriors, IPSpaces aPSpaces, Random aRandom,
                               int[] forcedAddresses)
        {
            BeginMatch(aRules, aWarriors, aPSpaces, aRandom, forcedAddresses);
            while (NextStep() != StepResult.Finished)
            {
            }
            return EndMatch();
        }

        public void BeginMatch(Rules aRules, IWarrior[] aWariors, IPSpaces aPSpaces, Random aRandom,
                               int[] forcedAddresses)
        {
            cycles = 0;
            rules = aRules;
            results = new MatchResult(rules);
            string[] names = new string[aWariors.Length];
            for (int w = 0; w < aWariors.Length; w++)
            {
                names[w] = aWariors[w].FileName;
            }
            List<string> r = pMarsDll.BuildParams(rules, false, forcedAddresses, names);

            string errFile = Path.GetTempFileName();
            int res = pMarsDll.pMarsBeginMatch(r.Count, r.ToArray(), errFile);
            if (res != 0)
            {
                string errors = File.ReadAllText(errFile);
                File.Delete(errFile);
                throw new ParserException(errors);
            }
            pMarsDll.pMarsWatchMatch(out dllCore, out dllCoreSize, out dllCyclesLeft, out dllRound,
                                     out dllWarriors, out dllWarriorsCout, out dllWarrirorsLeft, out dllNextWarrior,
                                     out dllTasksStart, out dllTasksEnd);
            dllDataLinked = true;
        }

        public MatchResult EndMatch()
        {
            results.ComputePoints();
            pMarsDll.pMarsEndMatch();
            dllCore = IntPtr.Zero;
            dllCoreSize = 0;
            dllCyclesLeft = IntPtr.Zero;
            dllRound = IntPtr.Zero;
            dllWarriors = IntPtr.Zero;
            dllWarriorsCout = 0;
            dllWarrirorsLeft = IntPtr.Zero;
            dllNextWarrior = IntPtr.Zero;
            dllTasksStart = IntPtr.Zero;
            dllTasksEnd = IntPtr.Zero;
            dllCoreLoaded = false;
            dllTasksLoaded = false;
            dllWarriorsLoaded = false;
            dllDataLinked = false;
            lastInstruction = null;
            return results;
        }

        private bool lastInstructionWatchMode = false;
        private bool dllDataLinked = false;
        private IntPtr dllCore;
        private int dllCoreSize;
        private List<IInstruction> coreCopy = null;
        private bool dllCoreLoaded = false;
        private IntPtr dllCyclesLeft;
        private IntPtr dllRound;

        private IntPtr dllWarriors;
        private int dllWarriorsCout;
        private IntPtr dllWarrirorsLeft;
        private List<pMarsDll.PmarsWarrior> warriorsDllCopy = null;
        private List<IWarrior> warriorsCopy = null;
        private bool dllWarriorsLoaded = false;
        private IntPtr dllNextWarrior;

        private IntPtr dllTasksStart;
        private IntPtr dllTasksEnd;
        private List<IList<int>> tasksCopy = null;
        private bool dllTasksLoaded = false;


        public StepResult NextStep()
        {
            if (lastInstructionWatchMode)
            {
                //copy instruction
                int currentInstructionAddress = Tasks[NextWarriorIndex][0];
                lastInstruction = this[currentInstructionAddress];
            }

            StepResult res = (StepResult) pMarsDll.pMarsStepMatch();
            dllCoreLoaded = false;
            dllTasksLoaded = false;
            dllWarriorsLoaded = false;
            cycles++;

            if (res > StepResult.Continue)
            {
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    results.results[w, Round - 1] = FightResult.Tie; //TODO
                }
                if (res != StepResult.Finished)
                {
                    cycles = 0;
                }
            }
            return res;
        }

        private void CopyCore()
        {
            if (!dllDataLinked) throw new InvalidOperationException("Too early from debuger Watch window");

            //copy core
            if (!dllCoreLoaded)
            {
                coreCopy = new List<IInstruction>(dllCoreSize);
                pMarsDll.FillInstructions(coreCopy, dllCore, dllCoreSize, rules.CoreSize);
                dllCoreLoaded = true;
            }
        }

        private void CopyTasks()
        {
            if (!dllDataLinked) throw new InvalidOperationException("Too early from debuger Watch window");

            //copy tasks
            if (!dllTasksLoaded)
            {
                CopyWarriors();
                tasksCopy = new List<IList<int>>(dllWarriorsCout);
                for (int w = 0; w < dllWarriorsCout; w++)
                {
                    pMarsDll.PmarsWarrior warriror = warriorsDllCopy[w];
                    List<int> tasks = new List<int>(warriror.tasks);
                    pMarsDll.FillTasks(tasks, warriror.taskHead, warriror.taskTail, dllTasksStart, dllTasksEnd,
                                       warriror.tasks);
                    tasksCopy.Add(tasks);
                }
                dllTasksLoaded = true;
            }
        }

        private void CopyWarriors()
        {
            if (!dllDataLinked) throw new InvalidOperationException("Too early from debuger Watch window");

            //copy warrirors
            if (!dllWarriorsLoaded)
            {
                warriorsDllCopy = new List<pMarsDll.PmarsWarrior>(dllWarriorsCout);
                pMarsDll.FillWarrirors(warriorsDllCopy, dllWarriors, dllWarriorsCout);

                warriorsCopy = new List<IWarrior>(dllWarriorsCout);
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    Warrior warrior = pMarsDll.ConvertWarrior(null, warriorsDllCopy[w], rules);
                    warriorsCopy.Add(warrior);
                }
                dllWarriorsLoaded = true;
            }
        }

        public IInstruction this[int offset]
        {
            get
            {
                CopyCore();
                return coreCopy[offset];
            }
        }

        public int CoreSize
        {
            get { return dllCoreSize; }
        }

        public int LiveWarriorsCount
        {
            get { return Marshal.ReadInt32(dllWarrirorsLeft); }
        }

        public IList<IList<int>> Tasks
        {
            get
            {
                CopyTasks();
                return tasksCopy;
            }
        }

        public IList<IWarrior> Warriors
        {
            get
            {
                CopyWarriors();
                return warriorsCopy;
            }
        }

        public int NextWarriorIndex
        {
            get { return pMarsDll.WarrirorIndex(dllWarriors, dllNextWarrior); }
        }

        public IWarrior NextWarrior
        {
            get
            {
                CopyWarriors();
                return warriorsCopy[NextWarriorIndex];
            }
        }

        public int CyclesLeft
        {
            get { return Marshal.ReadInt32(dllCyclesLeft); }
        }

        public int Cycles
        {
            get { return cycles; }
        }

        public int Round
        {
            get { return Marshal.ReadInt32(dllRound) - 1; }
        }

        private MatchResult results;
        private Rules rules;
        protected int cycles;

        public IInstruction LastInstruction
        {
            get
            {
                //lastInstructionWatchMode = true;
                return lastInstruction;
            }
        }

        public IInstruction NextInstruction
        {
            get
            {
                CopyWarriors();
                CopyCore();
                CopyTasks();
                int address = pMarsDll.InstructionAddress(warriorsDllCopy[NextWarriorIndex].taskHead);
                return coreCopy[address];
            }
        }

        private IInstruction lastInstruction = null;
    }
}