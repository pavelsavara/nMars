// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    class Engine : EngineSteps, IStepBackEngine
    {
        public void PrevStep()
        {
            if (!CanStepBack)
                throw new InvalidOperationException("Cannot step back now");

        }

        public bool CanStepBack
        {
            get
            {
                return (lastStepResult == StepResult.Continue);
            }
        }

        protected override void BeforeWrite(int address, Column column)
        {
        }

        protected override void AfterWrite(int address, Column column)
        {
        }

        protected override void Died(EngineWarrior warrior)
        {
        }

        protected override void Split(EngineWarrior warrior)
        {
        }
    }
}
