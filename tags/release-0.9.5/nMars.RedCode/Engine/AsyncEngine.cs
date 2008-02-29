// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Threading;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    /// <summary>
    /// Asynchronous wrapper around IDebuggerEngine
    /// </summary>
    public class AsyncEngine : BaseComponent, IEngine, IDisposable, IDebuggerEngine, IAsyncEngine
    {
        #region Construction

        public AsyncEngine(IDebuggerEngine aEngine)
        {
            engine = aEngine;
            pause = true;
            running = false;
            live = false;
            brake = 0;
        }

        private void InitWorker()
        {
            worker = new Thread(new ThreadStart(OuterLoop));
            signalRun = new ManualResetEvent(false);
            signalPaused = new ManualResetEvent(true);
            signalRunning = new ManualResetEvent(false);
            pause = true;
            quit = false;
            running = false;
            worker.Start();
        }

        public void Dispose()
        {
            worker.Interrupt();
            signalRun.Close();
            signalPaused.Close();
            signalRunning.Close();
        }

        #endregion

        #region Synchronization

        public void Continue(bool wait)
        {
            lock (this)
            {
                pause = false;
                signalRun.Set();
            }
            if (wait)
                signalRunning.WaitOne();
        }

        public void Pause(bool wait)
        {
            lock (this)
            {
                signalRun.Reset();
                pause = true;
            }
            if (wait)
                signalPaused.WaitOne();
        }

        public void Wait()
        {
            while (true)
            {
                signalPaused.WaitOne();
                lock (this)
                {
                    if (!running || stepResult == StepResult.Finished)
                        break;
                }
                signalRun.WaitOne();
            }
        }

        public void Quit(bool wait)
        {
            lock (this)
            {
                quit = true;
            }
            Continue(wait);
        }

        public void Kill()
        {
            lock (this)
            {
                worker.Interrupt();
                running = false;
                live = false;
            }
        }

        public void Run(IProject project, EngineStoppedCallback callback)
        {
            BeginMatch(project, callback);
            Continue(false);
        }

        public MatchResult Run(IProject project, ISimpleOutput console)
        {
            BeginMatch(project);
            Continue(false);
            return EndMatch(console);
        }

        public void BeginMatch(IProject project)
        {
            BeginMatch(project, null);
        }

        public void BeginMatch(IProject project, EngineStoppedCallback callback)
        {
            engineStoppedCallback = callback;
            brake = project.EngineOptions.Brake;
            lock (this)
            {
                engine.BeginMatch(project);
            }
            InitWorker();
        }

        public MatchResult EndMatch(ISimpleOutput console)
        {
            Wait();
            lock (this)
            {
                return engine.EndMatch(console);
            }
        }

        public StepResult PrevStep()
        {
            lock (this)
            {
                if (running)
                    throw new InvalidOperationException("Can't make steps on running engine");
                stepResult = engine.PrevStep();
                return stepResult;
            }
        }


        public StepResult NextStep()
        {
            lock (this)
            {
                if (running)
                    throw new InvalidOperationException("Can't make steps on running engine");

                //TODO
                stepResult = engine.NextStep();
                return stepResult;
            }
        }

        public bool IsLive 
        { 
            get
            {
                return live;
            }
        }

        public bool IsPaused
        {
            get
            {
                return pause;
            }
        }

        #endregion

        #region Loop

        /// <summary>
        /// External loop, solving ThreadInterrupted problems
        /// </summary>
        private void OuterLoop()
        {
            try
            {
                Loop();
            }
            catch (ThreadInterruptedException)
            {
                live = false;
                running = false;
                signalPaused.Set();
                signalRunning.Reset();
                //swallow
            }
            catch (Exception)
            {
                live = false;
                running = false;
                signalPaused.Set();
                signalRunning.Reset();
                throw;
            }
        }

        /// <summary>
        /// Loop body + stoping
        /// </summary>
        private void Loop()
        {
            live = true;
            signalRun.WaitOne();

            running = true;
            signalRunning.Set();
            do
            {
                if (LoopBody())
                    break;
            } while (stepResult != StepResult.Finished);
            lock (this)
            {
                live = false;
                running = false;
                signalPaused.Set();
                signalRunning.Reset();
            }
            if (engineStoppedCallback != null)
            {
                engineStoppedCallback.Invoke(true, null, null);
            }
        }

        /// <returns>True to quit loop</returns>
        private bool LoopBody()
        {
            lock (this)
            {
                SlowdownLoop(); // warning! intentional inversed lock inside
                if (quit) 
                    return true;
                if (pause)
                {
                    if (PauseLoop(null, null)) // warning! intentional inversed lock inside
                        return true;
                }

                //step
                stepResult = engine.NextStep();

                if (stepResult != StepResult.Finished)
                {
                    string reason;
                    BreakPoint breakPoint = Project.BreakPoints.ShouldBreak(engine, out reason);
                    if (breakPoint!=null)
                    {
                        signalRun.Reset();
                        pause = true;
                        if (PauseLoop(breakPoint, reason)) // warning! intentional inversed lock inside
                            return true;
                    }
                }
            }
            return false;
        }

        /// <returns>True to quit loop</returns>
        private bool PauseLoop(BreakPoint breakPoint, string reason)
        {
            running = false;
            signalRunning.Reset();
            signalPaused.Set();
            {
                try
                {
                    //inversed lock
                    Monitor.Exit(this);
                    if (engineStoppedCallback != null)
                    {
                        engineStoppedCallback.Invoke(false, breakPoint, reason);
                    }
                    signalRun.WaitOne();
                }
                finally
                {
                    Monitor.Enter(this);
                    //inversed lock end
                }
            }
            if (quit || stepResult == StepResult.Finished)
            {
                return true;
            }
            pause = false;
            running = true;
            signalPaused.Reset();
            signalRunning.Set();
            return false;
        }

        private void SlowdownLoop()
        {
            if (brake > 100 || (brake > 0 && engine.Cycle % (100/brake) == 0))
            {
                try
                {
                    //inversed lock
                    Monitor.Exit(this);
                    Thread.Sleep(brake);
                }
                finally
                {
                    Monitor.Enter(this);
                    //inversed lock end
                }
            }
        }

        #endregion

        #region Interfaces

        public bool CanStepBack
        {
            get
            {
                lock (this)
                {
                    if (running)
                        throw new InvalidOperationException("Can't make steps on running engine");
                    return engine.CanStepBack;
                }
            }
        }

        public IProject Project
        {
            get
            {
                return engine.Project;
            }
        }

        public IList<IEnumerable<int>> Tasks
        {
            get
            {
                lock (this)
                {
                    return engine.Tasks;
                }
            }
        }

        public int TasksCount
        {
            get { return engine.TasksCount; }
        }

        public int NextWarriorIndex
        {
            get { return engine.NextWarriorIndex; }
        }

        public IRunningWarrior NextWarrior
        {
            get { return engine.NextWarrior; }
        }

        public IRunningInstruction NextInstruction
        {
            get { return engine.NextInstruction; }
        }

        public IRunningInstruction LastInstruction
        {
            get { return engine.LastInstruction; }
        }

        public IRunningInstruction this[int address]
        {
            get { return engine[address]; }
        }

        public int this[int address, Column reg]
        {
            get { return engine[address, reg]; }
        }

        public int CoreSize
        {
            get { return engine.CoreSize; }
        }

        public StepResult LastStepResult
        {
            get
            {
                return engine.LastStepResult;
            }
        }

        public IList<IRunningWarrior> RunningWarriors
        {
            get
            {
                lock (this)
                {
                    return engine.RunningWarriors;
                }
            }
        }

        public IEnumerable<IRunningWarrior> LiveWarriors
        {
            get
            {
                lock (this)
                {
                    return engine.RunningWarriors;
                }
            }
        }

        public IList<IWarrior> Warriors
        {
            get
            {
                lock (this)
                {
                    return engine.Warriors;
                }
            }
        }

        public int Round
        {
            get
            {
                return engine.Round;
            }
        }

        public int Cycle
        {
            get
            {
                return engine.Cycle;
            }
        }

        public int CyclesLeft
        {
            get
            {
                return engine.CyclesLeft;
            }
        }

        public int LiveWarriorsCount
        {
            get
            {
                return engine.LiveWarriorsCount;
            }
        }

        public int WarriorsCount
        {
            get
            {
                return engine.WarriorsCount;
            }
        }

        public IList<IPSpace> PSpaces
        {
            get
            {
                lock (this)
                {
                    return engine.PSpaces;
                }
            }
        }

        public IList<int> LastResults
        {
            get
            {
                lock (this)
                {
                    return engine.LastResults;
                }
            }
        }

        public IList<int> PSPaceIndexes
        {
            get
            {
                lock (this)
                {
                    return engine.PSPaceIndexes;
                }
            }
        }

        public int Brake
        {
            get
            {
                return brake;
            }
            set
            {
                lock (this)
                {
                    brake = value;
                }
            }
        }

        /// <remarks>Not synchronized! Use lock on this instance</remarks>
        public CoreEventRecord[] CoreEvents
        {
            get
            {
                return engine.CoreEvents;
            }
        }

        public void UiTickDone()
        {
            engine.UiTickDone();
        }

        #endregion

        #region Variables

        private IDebuggerEngine engine;
        private Thread worker;
        private ManualResetEvent signalRun;
        private ManualResetEvent signalPaused;
        private ManualResetEvent signalRunning;
        private StepResult stepResult;
        private bool running;
        private bool live;
        private bool pause;
        private bool quit;
        private int brake;
        private EngineStoppedCallback engineStoppedCallback;

        #endregion
    }
}