// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine.Engine
{
    public class EngineObserver : EngineSteps, ICoreEvents
    {
        public CoreEventRecord[] CoreEvents
        {
            get
            {
                return coreEvents;
            }
        }

        public void UiTickDone()
        {
            foreach (CoreEventRecord record in coreEvents)
            {
                switch (record.Level)
                {
                    case CoreEventsLevel.Flash:
                    case CoreEventsLevel.Fade:
                        record.Level--;
                        break;
                    case CoreEventsLevel.Clean:
                        record.Event = InstructionEvent.None;
                        record.Level--;
                        break;
                }
            }
        }

        protected override void InitializeRound()
        {
            base.InitializeRound();
            coreEvents = new CoreEventRecord[Project.Rules.CoreSize];
            for (int a = 0; a < Project.Rules.CoreSize; a++)
            {
                coreEvents[a] = new CoreEventRecord();
            }
        }

        protected override void AfterWrite(int address, Column column)
        {
            base.AfterWrite(address, column);
            coreEvents[address].Event |= InstructionEvent.Write;
            coreEvents[address].Level = CoreEventsLevel.Flash;
            coreEvents[address].Touched = activeWarrior;
            coreEvents[address].Version = ++version;
        }

        protected override void BeforeRead(int address, Column column)
        {
            base.BeforeRead(address, column);
            coreEvents[address].Event |= InstructionEvent.Read;
            coreEvents[address].Level = CoreEventsLevel.Flash;
            coreEvents[address].Touched = activeWarrior;
            coreEvents[address].Version = ++version;
        }

        protected override void Died(int address)
        {
            base.Died(address);
            coreEvents[address].Event |= InstructionEvent.Died;
            coreEvents[address].Level = CoreEventsLevel.Flash;
            coreEvents[address].Touched = activeWarrior;
            coreEvents[address].Version = ++version;
        }

        protected override void PerformInstruction(int address)
        {
            base.PerformInstruction(address);
            coreEvents[address].Event |= InstructionEvent.Execute;
            coreEvents[address].Level = CoreEventsLevel.Flash;
            coreEvents[address].Touched = activeWarrior;
            coreEvents[address].Executed = activeWarrior;
            coreEvents[address].Version = ++version;
        }

        protected CoreEventRecord[] coreEvents;
        protected long version;

    }
}
