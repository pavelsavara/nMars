// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

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

    public interface IObservedEventsEngine : ICoreView
    {
        event AfterStep OnAfterStep;
        event AfterSPL OnAfterSPL;
    }
}