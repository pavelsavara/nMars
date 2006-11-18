// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineTasks : EnginePlacement, ITaskView, ITimeView, IStatusView, ICoreDump 
    {
        #region Events

        protected override void InitializeMatch(IProject project, EngineOptions options)
        {
            base.InitializeMatch(project, options);
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

        protected virtual void InitializeCycle()
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

        public IList<IList<int>> Tasks
        {
            get
            {
                CopyTasks();
                return tasksCopy;
            }
        }

        public int NextWarriorIndex
        {
            get { return liveWarriors.Peek().Index; }
        }

        private EngineWarrior NextWarrior
        {
            get { return liveWarriors.Peek(); }
        }

        public IInstruction LastInstruction
        {
            get { return lastInstruction; }
        }

        public IInstruction NextInstruction
        {
            get { return core[NextWarrior.Tasks.Peek()]; }
        }

        public int NextInstructionAddress
        {
            get { return NextWarrior.Tasks.Peek(); }
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
            get
            {
                return results;
            }
        }

        #endregion

        #region Caches

        private List<IList<int>> tasksCopy;
        private bool tasksCopyLoaded = false;
        private IInstruction lastInstruction;

        private void CopyTasks()
        {
            if (!tasksCopyLoaded)
            {
                tasksCopy = new List<IList<int>>(rules.WarriorsCount);
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
