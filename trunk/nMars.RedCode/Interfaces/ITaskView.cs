// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public interface IStatusView
    {
        int Round { get; }
        int Cycles { get; }
        int CyclesLeft { get; }
        int LiveWarriorsCount { get; }
        int WarriorsCount { get; }
    }
    
    [ComVisible(true)]
    public interface ITaskView
    {
        IList<IList<int>> Tasks { get; }
        int NextWarriorIndex { get; }
        IWarrior NextWarrior { get; }
    }

    [ComVisible(true)]
    public interface IWarriorsView
    {
        IList<IRunningWarrior> RunningWarriors { get; }
        IList<IWarrior> Warriors { get; }
    }

    [ComVisible(true)]
    public interface ITimeView
    {
        IInstruction LastInstruction { get; }
        IInstruction NextInstruction { get; }
        //IList<IInstruction> HistoricInstructions { get;}
    }
}