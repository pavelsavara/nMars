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
            public EngineEvent(EngineInstruction executedInstruction, int cycles, int cyclesLeft, int ip, EngineWarrior warrior, StepResult prevStepResult)
            {
                ExecutedInstruction = executedInstruction;
                Cycles = cycles;
                CyclesLeft = cyclesLeft;
                Ip = ip;
                Warrior = warrior;
                PrevStepResult = prevStepResult;
                instructionsChanged = new Stack<EngineInstruction>();
            }

            public int Ip;
            public EngineInstruction ExecutedInstruction;
            public int Cycles;
            public int CyclesLeft;
            public Stack<EngineInstruction> instructionsChanged;
            public int PSpaceValue;
            public int PSpaceAddress = -1;
            public EngineWarrior Warrior;
            public bool Split;
            public bool Died;
            public StepResult PrevStepResult;

            public override string ToString()
            {
                return ExecutedInstruction + " " + instructionsChanged.Count;
            }
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

        protected override void InitializeCycle(int Ip)
        {
            base.InitializeCycle(Ip);
            CurrentEvent = new EngineEvent(core[Ip], cycle, cyclesLeft, Ip, activeWarrior, lastStepResult);
        }

        protected override void FinalizeCycle()
        {
            base.FinalizeCycle();
            History.Push(CurrentEvent);
            CurrentEvent = null;
        }

        protected override void BeforeWritePSpace(int address)
        {
            CurrentEvent.PSpaceAddress = address;
            CurrentEvent.PSpaceValue = PSpaces[activeWarrior.WarriorIndex][address];
        }

        protected override void BeforeWrite(int address, Column column)
        {
            CurrentEvent.instructionsChanged.Push(new EngineInstruction(core[address], address));
            base.BeforeWrite(address, column);
        }

        protected override void Died(int address)
        {
            CurrentEvent.Died = true;
            base.Died(address);
        }

        protected override void Split(int addressTo)
        {
            CurrentEvent.Split = true;
            base.Split(addressTo);
        }

        #endregion

        #region Variables

        protected Stack<EngineEvent> History;
        private EngineEvent CurrentEvent;

        #endregion
    }
}