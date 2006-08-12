using System;

namespace nMars.RedCode
{
    public class StepEventArgs : EventArgs
    {
        public int oldAddress;
        public int newAddress;
        public IWarrior warrior;
    }

    public class SPLEventArgs : StepEventArgs
    {
        public int splitAddress;
    }

    public delegate void AfterStep(StepEventArgs args);

    public delegate void AfterSPL(SPLEventArgs args);

    public interface IObservedEngine
    {
        event AfterStep OnAfterStep;
        event AfterSPL OnAfterSPL;
    }
}