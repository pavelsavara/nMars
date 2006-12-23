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
        public InstructionEvent[] Events
        {
            get
            {
                return coreEvents;
            }
        }

        public CoreEventsLevel[] EventLevels
        {
            get
            {
                return coreLevels;
            }
        }

        public IRunningWarrior[] EventWarriors
        {
            get
            {
                return coreEventWarriors;
            }
        }

        public IRunningWarrior[] ExecutedWarriors
        {
            get
            {
                return coreExcecutedWarriors;
            }
        }

        protected override void InitializeRound()
        {
            base.InitializeRound();
            coreEvents = new InstructionEvent[Project.Rules.CoreSize];
            coreLevels = new CoreEventsLevel[Project.Rules.CoreSize];
            coreEventWarriors = new IRunningWarrior[Project.Rules.CoreSize];
            coreExcecutedWarriors = new IRunningWarrior[Project.Rules.CoreSize];
            for(int a=0;a<Project.Rules.CoreSize;a++)
            {
                coreLevels[a] = CoreEventsLevel.Clean;
            }
        }

        protected override void AfterWrite(int address, Column column)
        {
            base.AfterWrite(address, column);
            coreEvents[address] |= InstructionEvent.Write;
            coreLevels[address] = CoreEventsLevel.Flash;
            coreEventWarriors[address] = activeWarrior;
        }

        protected override void BeforeRead(int address, Column column)
        {
            base.BeforeRead(address, column);
            coreEvents[address] |= InstructionEvent.Read;
            coreLevels[address] = CoreEventsLevel.Flash;
            coreEventWarriors[address] = activeWarrior;
        }

        protected override void Died(int address)
        {
            base.Died(address);
            coreEvents[address] |= InstructionEvent.Died;
            coreLevels[address] = CoreEventsLevel.Flash;
            coreEventWarriors[address] = activeWarrior;
        }

        protected override void PerformInstruction(int ip)
        {
            base.PerformInstruction(ip);
            coreEvents[ip] |= InstructionEvent.Execute;
            coreLevels[ip] = CoreEventsLevel.Flash;
            coreEventWarriors[ip] = activeWarrior;
            coreExcecutedWarriors[ip] = activeWarrior;
        }

        protected InstructionEvent[] coreEvents;
        protected CoreEventsLevel[] coreLevels;
        protected IRunningWarrior[] coreEventWarriors;
        protected IRunningWarrior[] coreExcecutedWarriors;

    }
}
