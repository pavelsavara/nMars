// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public class Core : ICoreView, ITaskView, ITimeView
    {
        protected Core()
        {
        }

        protected void InitRound()
        {
            CleanCore();
            if (forcedAddresses != null)
            {
                PlaceWarriors(sourceWarriors);
            }
            else
            {
                RandomlyPlaceWarriors(sourceWarriors);
            }
        }

        protected void CleanCore()
        {
            core = new EngineInstruction[rules.CoreSize];
            liveWarriors = new Queue<EngineWarrior>();
            warriors = new List<EngineWarrior>();
            iWarriors = new List<IWarrior>();
            tasksCopyLoaded = false;
            cyclesLeft = rules.MaxCycles*rules.WarriorsCount;
            for (int a = 0; a < rules.CoreSize; a++)
            {
                core[a] = EngineInstruction.DefaultInstruction;
                core[a].Address = a;
            }
            cycles = 0;
        }

        private void PlaceWarriors(IList<IWarrior> aWarriors)
        {
            for (int i = 0; i < aWarriors.Count; i++)
            {
                IWarrior warrior = aWarriors[i];
                int loadAddress = forcedAddresses[i];
                //add warrior
                EngineWarrior engineWarrior = new EngineWarrior(warrior, this, warriors.Count, loadAddress);
                liveWarriors.Enqueue(engineWarrior);
                warriors.Add(engineWarrior);
                iWarriors.Add(engineWarrior);
            }
        }

        private void RandomlyPlaceWarriors(IList<IWarrior> aWarriors)
        {
            foreach (IWarrior warrior in aWarriors)
            {
                int loadAddress;
                bool conflict;

                //search for free space
                do
                {
                    conflict = false;
                    loadAddress = random.Next(CoreSize);
                    for (int a = loadAddress; a < loadAddress + warrior.Length; a++)
                    {
                        if (!core[mod(a)].IsEmpty)
                        {
                            conflict = true;
                            break;
                        }
                    }
                } while (conflict);


                //add warrior
                EngineWarrior engineWarrior = new EngineWarrior(warrior, this, warriors.Count, loadAddress);
                liveWarriors.Enqueue(engineWarrior);
                warriors.Add(engineWarrior);
                iWarriors.Add(engineWarrior);
            }
        }

        protected int predec(ref int address)
        {
            address = mod(address - 1);
            return address;
        }

        protected void postinc(ref int address)
        {
            address = mod(address + 1);
        }

        protected bool decz(ref int address)
        {
            address = mod(address - 1);
            return address == 1;
        }

        protected void dec(ref int address)
        {
            address = mod(address - 1);
        }

        public int wrap(int value)
        {
            return Instruction.Wrap(value, CoreSize);
        }

        public int mod(int value)
        {
            return Instruction.Mod(value, CoreSize);
        }

        /// <returns>T- should die</returns>
        protected bool oper(ref int res, int a, int b, Operation op)
        {
            switch (op)
            {
                case Operation.ADD:
                    res = a + b;
                    if (res >= CoreSize) res -= CoreSize;
                    break;
                case Operation.SUB:
                    res = a - b;
                    if (res < 0) res += CoreSize;
                    break;
                case Operation.MUL:
                    res = a*b;
                    res %= CoreSize;
                    break;
                case Operation.MOD:
                    if (b == 0) return true;
                    res = a%b;
                    break;
                case Operation.DIV:
                    if (b == 0) return true;
                    res = a/b;
                    break;
                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
            return false;
        }

        public int CoreSize
        {
            get { return rules.CoreSize; }
        }

        IInstruction ICoreView.this[int address]
        {
            get { return core[mod(address)]; }
        }

        public IList<IList<int>> Tasks
        {
            get
            {
                CopyTasks();
                return tasksCopy;
            }
        }

        private List<IList<int>> tasksCopy;
        protected bool tasksCopyLoaded = false;

        private void CopyTasks()
        {
            if (!tasksCopyLoaded)
            {
                tasksCopy = new List<IList<int>>(WarriorsCount);
                foreach (IRunningWarrior warrior in warriors)
                {
                    tasksCopy.Add(warrior.Tasks);
                }
                tasksCopyLoaded = true;
            }
        }

        public int NextWarriorIndex
        {
            get { return liveWarriors.Peek().Index; }
        }

        IWarrior ITaskView.NextWarrior
        {
            get { return liveWarriors.Peek(); }
        }

        protected EngineWarrior NextWarrior
        {
            get { return liveWarriors.Peek(); }
        }

        public IInstruction NextInstruction
        {
            get { return core[NextWarrior.Tasks.Peek()]; }
        }

        public int LiveWarriorsCount
        {
            get { return liveWarriors.Count; }
        }

        public IInstruction LastInstruction
        {
            get { return lastInstruction; }
        }

        protected IInstruction lastInstruction = null;


        public int WarriorsCount
        {
            get { return warriors.Count; }
        }

        public IList<IWarrior> Warriors
        {
            get { return iWarriors; }
        }

        internal Rules Rules
        {
            get { return rules; }
        }

        internal IPSpaces PSpaces
        {
            get { return pSpaces; }
        }

        public int Cycles
        {
            get { return cycles; }
        }

        public int CyclesLeft
        {
            get { return cyclesLeft; }
        }

        public int Round
        {
            get { return round; }
        }

        internal EngineInstruction[] core;
        protected Random random;
        protected IList<int> forcedAddresses;

        protected IList<EngineWarrior> warriors;
        protected IList<IWarrior> iWarriors;
        protected IList<IWarrior> sourceWarriors;
        protected Queue<EngineWarrior> liveWarriors;
        protected Rules rules;
        protected IPSpaces pSpaces;
        protected int cycles;
        protected int cyclesLeft;
        protected int round;
    }
}