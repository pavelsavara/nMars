// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using nMars.RedCode;

namespace pMars.DllWrapper
{
    public class pMarsDllEngine : IEngine, ICoreView, ITaskView, IPSpacesView, IWarriorsView, IExtendedStepEngine
    {
        #region Steps

        public MatchResult Run(IProject aProject)
        {
            BeginMatch(aProject);
            while (NextStep() != StepResult.Finished)
            {
            }
            return EndMatch();
        }

        public void BeginMatch(IProject aProject)
        {
            project = aProject;
            cycles = 0;
            rules = project.Rules;
            results = new MatchResult(project);
            string[] names = new string[project.Warriors.Count];
            for (int w = 0; w < project.Warriors.Count; w++)
            {
                names[w] = project.Warriors[w].FileName;
            }
            List<string> r = pMarsDll.BuildParams(rules, false, project.ForcedAddresses, names);

            errFile = Path.GetTempFileName();
            int res = pMarsDll.pMarsBeginMatch(r.Count, r.ToArray(), errFile);
            if (res != 0)
            {
                string errors = "";
                try
                {
                    errors = File.ReadAllText(errFile);
                    File.Delete(errFile);
                }
                catch (Exception)
                {
                    //swalow
                }
                throw new ParserException(errors);
            }
            pMarsDll.pMarsWatchMatch(out dllCore, out dllCoreSize, out dllCyclesLeft, out dllRound, out dllWarriors,
                                     out dllWarriorsCout, out dllPSpaces, out dllWarrirorsLeft, out dllNextWarrior,
                                     out dllTasksStart, out dllTasksEnd);
            dllDataLinked = true;
        }

        public MatchResult EndMatch()
        {
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
            dllPSpaces = IntPtr.Zero;
            dllCoreLoaded = false;
            dllTasksLoaded = false;
            dllWarriorsLoaded = false;
            dllDataLinked = false;
            lastInstruction = null;
            try
            {
                File.Delete(errFile);
            }
            catch (Exception)
            {
                // swallow
            }
            return results;
        }

        public StepResult NextStep()
        {
            if (lastInstructionWatchMode)
            {
                //copy instruction
                int currentInstructionAddress = Tasks[NextWarriorIndex][0];
                lastInstruction = this[currentInstructionAddress];
            }

            lastStepResult = (StepResult)pMarsDll.pMarsStepMatch();
            dllCoreLoaded = false;
            dllTasksLoaded = false;
            dllWarriorsLoaded = false;
            cycles++;

            if (lastStepResult > StepResult.Continue)
            {
                int foundAlive = -1;
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    int tasks = Tasks[w].Count;
                    if (tasks > 0)
                    {
                        if (foundAlive != -1)
                        {
                            results.results[w, Round - 1] = RoundResult.Tie;
                            results.results[foundAlive, Round - 1] = RoundResult.Tie;
                        }
                        else
                        {
                            results.results[w, Round - 1] = RoundResult.Win;
                            foundAlive = w;
                        }
                    }
                    else
                    {
                        results.results[w, Round - 1] = RoundResult.Loss;
                    }
                }

                if (lastStepResult != StepResult.Finished)
                {
                    cycles = 0;
                }
                else
                {
                    pMarsDll.pMarsResultsMatch();
                    dllWarriorsLoaded = false;
                    CopyWarriors();
                    results.score = new int[rules.WarriorsCount];
                    for (int w = 0; w < rules.WarriorsCount; w++)
                    {
                        results.score[w] = warriorsDllCopy[w].totalScore;
                    }
                }
            }
            return lastStepResult;
        }

        #endregion

        #region Helpers

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
                runningWarriorsCopy = new List<IRunningWarrior>(dllWarriorsCout);
                pMarsDll.FillWarrirors(warriorsDllCopy, dllWarriors, dllWarriorsCout);

                warriorsCopy = new List<IWarrior>(dllWarriorsCout);
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    DllWarrior warrior = pMarsDll.ConvertWarrior(null, warriorsDllCopy[w], rules);
                    warriorsCopy.Add(warrior);
                    runningWarriorsCopy.Add(warrior);
                }
                dllWarriorsLoaded = true;
            }
        }

        #endregion

        #region Interfaces

        public IRunningInstruction this[int address]
        {
            get
            {
                CopyCore();
                return (IRunningInstruction)coreCopy[address];
            }
        }

        public int this[int address, Column reg]
        {
            get
            {
                CopyCore();
                switch (reg)
                {
                    case Column.A:
                        return coreCopy[address].ValueA;
                    case Column.B:
                        return coreCopy[address].ValueB;
                    default:
                        throw new ApplicationException("Unknown register");
                }
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

        public int WarriorsCount
        {
            get { throw new NotImplementedException(); }
        }

        public IList<IList<int>> Tasks
        {
            get
            {
                CopyTasks();
                return tasksCopy;
            }
        }

        IList<IRunningWarrior> IWarriorsView.RunningWarriors
        {
            get { throw new NotImplementedException(); }
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

        public IRunningWarrior NextWarrior
        {
            get
            {
                CopyWarriors();
                return runningWarriorsCopy[NextWarriorIndex];
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


        public IRunningInstruction LastInstruction
        {
            get
            {
                //lastInstructionWatchMode = true;
                return lastInstruction;
            }
        }

        public IRunningInstruction NextInstruction
        {
            get
            {
                CopyWarriors();
                CopyCore();
                CopyTasks();
                int address = pMarsDll.InstructionAddress(warriorsDllCopy[NextWarriorIndex].taskHead);
                return (IRunningInstruction)coreCopy[address];
            }
        }

        public IList<IPSpace> PSpaces
        {
            get
            {
                CopyWarriors();
                List<IPSpace> res = pMarsDll.FillPSpace(rules, warriorsDllCopy, dllPSpaces);
                return res;
            }
        }

        public IList<int> LastResults
        {
            get
            {
                CopyWarriors();
                List<int> res = new List<int>();
                foreach (pMarsDll.PmarsWarrior warrior in warriorsDllCopy)
                {
                    res.Add(warrior.lastResult);
                }
                return res;
            }
        }

        public IList<int> PSPaceIndexes
        {
            get
            {
                CopyWarriors();
                List<int> res = new List<int>();
                foreach (pMarsDll.PmarsWarrior warrior in warriorsDllCopy)
                {
                    res.Add(warrior.pSpaceIndex);
                }
                return res;
            }
        }

        public StepResult LastStepResult
        {
            get { return lastStepResult; }
        }

        public IProject Project
        {
            get { return project; }
        }

        #endregion

        #region Dll Variables

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
        private List<IRunningWarrior> runningWarriorsCopy = null;
        private bool dllWarriorsLoaded = false;
        private IntPtr dllNextWarrior;
        private IntPtr dllPSpaces;

        private IntPtr dllTasksStart;
        private IntPtr dllTasksEnd;
        private List<IList<int>> tasksCopy = null;
        private bool dllTasksLoaded = false;

        #endregion

        #region Variables

        private MatchResult results;
        private Rules rules;
        protected int cycles;
        string errFile;
        private IRunningInstruction lastInstruction = null;
        private IProject project;
        StepResult lastStepResult;

        #endregion
    }
}