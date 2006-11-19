// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    class EngineEvent
    {
        public EngineEvent(int cycles, int cyclesLeft, int ip, EngineWarrior warrior)
        {
            Cycles = cycles;
            CyclesLeft = cyclesLeft;
            Ip = ip;
            Warrior = warrior;
            instructionsChanged = new Stack<EngineInstruction>();
        }

        public int Ip;
        public int Cycles;
        public int CyclesLeft;
        public Stack<EngineInstruction> instructionsChanged;
        public EngineWarrior Warrior;
        public bool Split;
        public bool Died;
    }
    
    public class EngineObserver : EngineSteps
    {
        protected override void InitializeRound()
        {
            base.InitializeRound();
            History=new Stack<EngineEvent>();
            CurrentEvent = null;
        }
        
        protected override void FinalizeRound()
        {
            base.FinalizeRound();
            History = null;
            CurrentEvent = null;
        }

        protected override void FinalizeCycle()
        {
            base.FinalizeCycle();
            if (CurrentEvent!=null)
            {
                History.Push(CurrentEvent);
                CurrentEvent = null;
            }
        }

        protected override void BeforeWrite(int address, Column column)
        {
            CreateEvent();
            CurrentEvent.instructionsChanged.Push(new EngineInstruction(core[address], address));
        }

        protected override void Died(EngineWarrior warrior)
        {
            CreateEvent();
            CurrentEvent.Died = true;
        }

        protected override void Split(EngineWarrior warrior)
        {
            CreateEvent();
            CurrentEvent.Split = true;
        }

        private void CreateEvent()
        {
            if (CurrentEvent == null)
            {
                CurrentEvent = new EngineEvent(cycles, cyclesLeft, reg.ip, lastStepWarrior);
            }
        }
        private Stack<EngineEvent> History;
        private EngineEvent CurrentEvent;
    }
}
