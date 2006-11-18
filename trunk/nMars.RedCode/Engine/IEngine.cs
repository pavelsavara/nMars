// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{

    #region Basic

    [ComVisible(true)]
    public interface IEngine
    {
        /// <summary>
        /// Run complete round
        /// </summary>
        MatchResult Run(IProject project, EngineOptions options);
    }

    [ComVisible(true)]
    public interface IStepEngine : IEngine
    {
        /// <summary>
        /// Initialize the engine
        /// </summary>
        void BeginMatch(IProject project, EngineOptions options);

        /// <summary>
        /// make step
        /// </summary>
        /// <returns>true when there is next step to process</returns>
        StepResult NextStep();

        /// <summary>
        /// returns results of the match
        /// </summary>
        MatchResult EndMatch();

        /// <summary>
        /// return current project
        /// </summary>
        IProject Project { get;}
    }

    #endregion 

    #region Extensions

    public interface IRunningWarrior : IWarrior
    {
        IInstruction NextInstruction { get; }
        int NextInstructionIndex { get; }
        IInstruction PreviousInstruction { get; }
        int PreviousInstructionIndex { get; }
        int LiveTasksCount { get; }
        IList<int> Tasks { get; }
        IPSpace PSpace { get; }
        int LastResult { get; }
        int PSpaceIndex { get; }
    }

    public interface ICoreView
    {
        IInstruction this[int address] { get; }
        int this[int address, Column reg] { get; }
        int CoreSize { get; }
    }

    public interface ICoreEdit : ICoreView
    {
        new IInstruction this[int address] { get; set; }
        new int this[int address, Column reg] { get; set; }
    }


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
    public interface IScoreView
    {
        MatchResult Results { get;}
    }

    public interface ITaskView
    {
        IList<IList<int>> Tasks { get; }
        int NextWarriorIndex { get; }
        //IWarrior NextWarrior { get; }
    }

    public interface IPSpacesView
    {
        IList<IPSpace> PSpaces { get; }
        IList<int> LastResults { get; }
        IList<int> PSPaceIndexes { get; }
    }

    public interface IWarriorsView
    {
        IList<IRunningWarrior> RunningWarriors { get; }
        IList<IWarrior> Warriors { get; }
    }

    public interface ITimeView
    {
        IInstruction LastInstruction { get; }
        IInstruction NextInstruction { get; }
    }

    public interface IStepBackEngine
    {
        void PrevStep();
        bool CanStepBack { get;}
    }

    public interface ICoreDump : ITaskView, IStatusView, IScoreView
    {
        IInstruction this[int address] { get; }
        int CoreSize { get; }
    }

    public interface ICoreLoad
    {
        //TODO
        IInstruction this[int address] { set; }
    }

    public interface IExtendedStepEngine : IStepEngine, ICoreView, ITaskView, IWarriorsView, ITimeView, IStatusView,
                                           IPSpacesView
    {
    }

    #endregion
}