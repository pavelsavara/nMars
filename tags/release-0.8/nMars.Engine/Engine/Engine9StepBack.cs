using System;
using System.Collections.Generic;
using System.Text;
using nMars.RedCode;

namespace nMars.Engine
{
    class EngineStepBack : EngineObserver, IStepBackEngine, IDebuggerEngine
    {
        public StepResult PrevStep()
        {
            if (!CanStepBack)
                throw new InvalidOperationException("Cannot step back now");
            //TODO
            throw new NotImplementedException();
        }

        public bool CanStepBack
        {
            get
            {
                return (lastStepResult == StepResult.Continue);
            }
        }
    }
}
