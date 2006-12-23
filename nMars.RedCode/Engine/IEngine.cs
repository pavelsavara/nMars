// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{

    #region Basic

    [ComVisible(true)]
    public interface IEngine : IComponent
    {
        /// <summary>
        /// Run complete round
        /// </summary>
        MatchResult Run(IProject project);

        /// <summary>
        /// return current project
        /// </summary>
        IProject Project { get; }

        ISimpleOutput Output { set;}
    }

    [ComVisible(true)]
    public interface IStepEngine : IEngine
    {
        /// <summary>
        /// Initialize the engine
        /// </summary>
        void BeginMatch(IProject project);

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
        /// returns result of last step
        /// </summary>
        StepResult LastStepResult { get; }
    }

    #endregion 

    #region Extensions

    public interface IRunningWarrior : IWarrior
    {
        IRunningInstruction NextInstruction { get; }
        int NextInstructionAddress { get; }
        IRunningInstruction PrevInstruction { get; }
        int PreviousInstructionAddress { get; }
        int LiveTasksCount { get; }
        int DeadTasksCount { get; }
        IList<int> Tasks { get; }
        int TasksCount { get; }
        IPSpace PSpace { get; }
        int LastResult { get; }
        int PSpaceIndex { get; }
        int WarriorIndex { get; }
    }

    public interface IRunningInstruction : IInstruction
    {
        int Address { get; }
        string ToString();
        IRunningWarrior OriginalOwner { get; }
    }

    public interface ICoreView
    {
        IRunningInstruction this[int address] { get; }
        int this[int address, Column reg] { get; }
        int CoreSize { get; }
    }

    public interface ICoreEdit : ICoreView
    {
        new IRunningInstruction this[int address] { get; set; }
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
        MatchResult Results { get; }
    }

    public interface ITaskView
    {
        IList<IList<int>> Tasks { get; }
        int TasksCount { get; }
        int NextWarriorIndex { get; }
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
        IRunningWarrior NextWarrior { get; }
        IRunningInstruction NextInstruction { get; }
        IRunningInstruction LastInstruction { get; }
    }

    public interface IStepBackEngine
    {
        StepResult PrevStep();
        bool CanStepBack { get; }
    }

    public class CheckBreakEventArgs : EventArgs
    {
        public bool Break = false;
    }

    public delegate void CheckBreak(CheckBreakEventArgs args);

    public interface IBreakpointsEngine
    {
        event CheckBreak CheckBreak;
    }

    public interface IStuntEngine
    {
        /// <summary>
        /// sleep miliseconds on each step
        /// </summary>
        int Brake { get; set;}
    }
    
    public delegate void EngineStoppedCallback(bool finished);

    public interface IAsyncEngine : IStepEngine, IStuntEngine, IStepBackEngine
    {
        void BeginMatch(IProject project, EngineStoppedCallback callback);
        void Run(IProject project, EngineStoppedCallback callback);
        void Continue();
        void Pause();
        void Wait();
        void Quit();
        void Kill();
        bool IsLive { get;}
        bool IsPaused { get;}
    }

    public interface IDebuggerEngine : IStepEngine, IStepBackEngine, IBreakpointsEngine, IStuntEngine, IAsyncEngine, ITaskView,
                                       ITimeView, ICoreView, IStatusView, IExtendedStepEngine, ICoreEvents
    {
    }


    public interface ICoreDump : ITaskView, IStatusView, IScoreView
    {
        IRunningInstruction this[int address] { get; }
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

    [Flags]
    public enum InstructionEvent
    {
        None = 0,
        Read = 1,
        Write = 2,
        Died = 4,
        Execute = 8,
    }

    public enum CoreEventsLevel
    {
        None,
        Clean,
        Fade,
        Flash,
    }

    public interface ICoreEvents
    {
        InstructionEvent[] Events { get; }
        CoreEventsLevel[] EventLevels { get; }
        IRunningWarrior[] EventWarriors { get; }
        IRunningWarrior[] ExecutedWarriors { get; }
    }

    #endregion
}