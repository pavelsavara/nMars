// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineTasks : EnginePlacement, ITaskView, ITimeView, IStatusView, ICoreDump
    {
        #region Events

        protected override void InitializeMatch(IProject project)
        {
            base.InitializeMatch(project);
            starter = 0;
            round = 0;
        }

        protected override void InitializeRound()
        {
            base.InitializeRound();

            cycles = 0;
            cyclesLeft = rules.MaxCycles * rules.WarriorsCount;

            liveWarriors = new Queue<EngineWarrior>();
            int warriorIndex = starter;
            while (liveWarriors.Count < rules.WarriorsCount)
            {
                EngineWarrior engineWarrior = warriors[warriorIndex];
                engineWarrior.StartOrder = liveWarriors.Count;
                engineWarrior.Result = RoundResult.Tie;
                liveWarriors.Enqueue(engineWarrior);

                //first task
                engineWarrior.Tasks.Clear();
                engineWarrior.Tasks.Enqueue(mod(engineWarrior.LoadAddress + engineWarrior.StartOffset));

                incWarrior(ref warriorIndex);
            }

            ResetCache();
        }

        protected virtual void InitializeCycle(int Ip)
        {
            ResetCache();
            int nextInstructionAddress = NextInstructionAddress;
            lastInstruction = new EngineInstruction(core[nextInstructionAddress], nextInstructionAddress);
        }

        protected virtual void FinalizeCycle()
        {
        }

        protected override void FinalizeRound()
        {
            incWarrior(ref starter);
            base.FinalizeRound();
        }

        protected override void FinalizeMatch()
        {
            ResetCache();
            base.FinalizeMatch();
        }

        #endregion

        #region Interfaces

        public int Round
        {
            get { return round; }
        }

        public int Cycles
        {
            get { return cycles; }
        }

        public int CyclesLeft
        {
            get { return cyclesLeft; }
        }

        public int TasksCount
        {
            get
            {
                int res = 0;
                foreach (IRunningWarrior warrior in warriors)
                {
                    res += warrior.TasksCount;
                }
                return res;
            }
        }

        public IList<IEnumerable<int>> Tasks
        {
            get
            {
                CopyTasks();
                return tasksCopy;
            }
        }

        public int NextWarriorIndex
        {
            get { return liveWarriors.Peek().WarriorIndex; }
        }

        IRunningWarrior ITimeView.NextWarrior
        {
            get
            {
                if (liveWarriors.Count == 0)
                    return null;
                return liveWarriors.Peek();
            }
        }

        private EngineWarrior NextWarrior
        {
            get
            {
                if (liveWarriors.Count == 0)
                    return null;
                return liveWarriors.Peek();
            }
        }

        public IRunningInstruction LastInstruction
        {
            get { return lastInstruction; }
        }

        public IRunningInstruction NextInstruction
        {
            get
            {
                if (NextWarrior == null || NextWarrior.TasksCount == 0)
                    return null;
                return core[NextWarrior.Tasks.Peek()];
            }
        }

        public int NextInstructionAddress
        {
            get
            {
                if (NextWarrior == null || NextWarrior.TasksCount == 0)
                    return -1;
                return NextWarrior.Tasks.Peek();
            }
        }

        public int LiveWarriorsCount
        {
            get { return liveWarriors.Count; }
        }

        public int WarriorsCount
        {
            get { return rules.WarriorsCount; }
        }

        public MatchResult Results
        {
            get { return results; }
        }

        public IEnumerable<IRunningWarrior> LiveWarriors
        {
            get
            {
                return (IEnumerable<IRunningWarrior>)liveWarriors;
            }
        }


        #endregion

        #region Caches

        private List<IEnumerable<int>> tasksCopy;
        private bool tasksCopyLoaded = false;
        private IRunningInstruction lastInstruction;

        private void CopyTasks()
        {
            if (!tasksCopyLoaded)
            {
                tasksCopy = new List<IEnumerable<int>>(rules.WarriorsCount);
                foreach (IRunningWarrior warrior in warriors)
                {
                    tasksCopy.Add(warrior.Tasks);
                }
                tasksCopyLoaded = true;
            }
        }

        private void ResetCache()
        {
            tasksCopyLoaded = false;
            lastInstruction = null;
            tasksCopy = null;
        }

        #endregion

        #region Variables

        protected Queue<EngineWarrior> liveWarriors;
        private int starter;
        protected int cycles;
        protected int cyclesLeft;
        protected int round;
        protected MatchResult results;

        #endregion
    }
}