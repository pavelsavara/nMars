// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
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
            coreEvents = new CoreEventRecord[coreSize];
            for (int a = 0; a < coreSize; a++)
            {
                coreEvents[a] = new CoreEventRecord();
            }
        }

        protected override void AfterWrite(int address, Column column)
        {
            base.AfterWrite(address, column);
            CoreEventRecord evnt = coreEvents[address];
            evnt.Level = CoreEventsLevel.Flash;
            evnt.Touched = activeWarrior;
            if (column == Column.All)
            {
                evnt.Died = null;
                evnt.Executed = null;
                evnt.WrittenInstruction = activeWarrior;
                evnt.WrittenData = activeWarrior;
                evnt.Event |= InstructionEvent.WrittenInstruction;
                evnt.Event |= InstructionEvent.WrittenData;
            }
            else
            {
                evnt.WrittenData = activeWarrior;
                evnt.Event |= InstructionEvent.WrittenData;
            }
            evnt.Version = ++version;
            evnt.Cycle = cycle;
        }

        protected override void BeforeRead(int address, Column column)
        {
            base.BeforeRead(address, column);
            CoreEventRecord evnt = coreEvents[address];
            evnt.Event |= InstructionEvent.Read;
            evnt.Level = CoreEventsLevel.Flash;
            evnt.Touched = activeWarrior;
            evnt.Read = activeWarrior;
            evnt.Version = ++version;
            evnt.Cycle = cycle;
            evnt.Level = CoreEventsLevel.Clean;
        }

        protected override void Died(int address)
        {
            base.Died(address);
            CoreEventRecord evnt = coreEvents[address];
            evnt.Event |= InstructionEvent.Died;
            evnt.Level = CoreEventsLevel.Flash;
            evnt.Touched = activeWarrior;
            evnt.Died = activeWarrior;
            evnt.Version = ++version;
            evnt.Cycle = cycle;
        }

        protected override void PerformInstruction(int address)
        {
            base.PerformInstruction(address);
            CoreEventRecord evnt = coreEvents[address];
            evnt.Event |= InstructionEvent.Executed;
            evnt.Level = CoreEventsLevel.Flash;
            evnt.Touched = activeWarrior;
            evnt.Executed = activeWarrior;
            evnt.Version = ++version;
            evnt.Cycle = cycle;
        }

        protected CoreEventRecord[] coreEvents;
        protected long version;

    }
}
