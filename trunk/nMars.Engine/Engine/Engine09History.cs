// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using nMars.Engine;
using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineHistory : EngineObserver
    {
        #region Event class

        protected class EngineEvent
        {
            public EngineEvent(int cycles, int cyclesLeft, int ip, EngineWarrior warrior, StepResult prevStepResult)
            {
                Cycles = cycles;
                CyclesLeft = cyclesLeft;
                Ip = ip;
                Warrior = warrior;
                PrevStepResult = prevStepResult;
                instructionsChanged = new Stack<EngineInstruction>();
            }

            public int Ip;
            public int Cycles;
            public int CyclesLeft;
            public Stack<EngineInstruction> instructionsChanged;
            public EngineWarrior Warrior;
            public bool Split;
            public bool Died;
            public StepResult PrevStepResult;
        }

        #endregion

        #region Events

        protected override void InitializeRound()
        {
            base.InitializeRound();
            History = new Stack<EngineEvent>();
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
            if (CurrentEvent != null)
            {
                History.Push(CurrentEvent);
                CurrentEvent = null;
            }
        }

        protected override void BeforeWrite(int address, Column column)
        {
            CreateEvent();
            CurrentEvent.instructionsChanged.Push(new EngineInstruction(core[address], address));
            base.BeforeWrite(address, column);
        }

        protected override void Died(int address)
        {
            CreateEvent();
            CurrentEvent.Died = true;
            base.Died(address);
        }

        protected override void Split(int addressTo)
        {
            CreateEvent();
            CurrentEvent.Split = true;
            base.Split(addressTo);
        }

        private void CreateEvent()
        {
            if (CurrentEvent == null)
            {
                CurrentEvent = new EngineEvent(cycles, cyclesLeft, reg.ip, activeWarrior, lastStepResult);
            }
        }

        #endregion

        #region Variables

        protected Stack<EngineEvent> History;
        private EngineEvent CurrentEvent;

        #endregion
    }
}