using System;
using System.Collections.Generic;
using System.Text;

namespace nMars.Engine.Engine
{
    public class EngineObserver : EngineSteps
    {
        public delegate void AfterWriteDelegate(int address, nMars.RedCode.Column column);
        public event AfterWriteDelegate AfterWriteEvent;

        protected override void AfterWrite(int address, nMars.RedCode.Column column)
        {
            if (AfterWriteEvent!=null)
            {
                AfterWriteEvent.Invoke(address, column);
            }
            base.AfterWrite(address, column);
        }

        protected override void BeforeWrite(int address, nMars.RedCode.Column column)
        {
            base.BeforeWrite(address, column);
        }

        protected override void BeforeRead(int address, nMars.RedCode.Column column)
        {
            base.BeforeRead(address, column);
        }

        protected override void Died(EngineWarrior warrior)
        {
            base.Died(warrior);
        }

        protected override void Split(EngineWarrior warrior)
        {
            base.Split(warrior);
        }

        protected override void FinalizeRound()
        {
            base.FinalizeRound();
        }
    }
}
