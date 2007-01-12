// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Threading;
using nMars.RedCode;

namespace nMars.RedCode
{
    /// <summary>
    /// Asynchronous wrapper around IDebuggerEngine
    /// </summary>
    public class AsyncEngine : IEngine, IDisposable, IDebuggerEngine, IAsyncEngine
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
            worker = new Thread(new ThreadStart(WorkerLoop));
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

        public void Continue()
        {
            lock (this)
            {
                pause = false;
                signalRun.Set();
            }
            signalRunning.WaitOne();
        }

        public void Pause()
        {
            lock (this)
            {
                signalRun.Reset();
                pause = true;
            }
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

        public void Quit()
        {
            lock (this)
            {
                quit = true;
            }
            Continue();
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
            Continue();
        }

        public MatchResult Run(IProject project, ISimpleOutput console)
        {
            BeginMatch(project);
            Continue();
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
                CheckBreakEventArgs args = new CheckBreakEventArgs();
                if (CheckBreak != null)
                    CheckBreak(args);
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
                return !running;
            }
        }

        #endregion

        #region Loop

        private void WorkerLoop()
        {
            // warning! intentional inversed lock inside
            try
            {
                live = true;
                signalRun.WaitOne();

                running = true;
                signalRunning.Set();
                CheckBreakEventArgs args = new CheckBreakEventArgs();
                do
                {
                    if (CheckBreak != null)
                        CheckBreak(args);
                    lock (this)
                    {
                        if (brake > 0)
                        {
                            if (brake > 100 || engine.Cycles % (100/brake) == 0)
                            {
                                try
                                {
                                    Monitor.Exit(this);
                                    Thread.Sleep(brake);
                                }
                                finally
                                {
                                    Monitor.Enter(this);
                                }
                            }
                        }
                        if (quit)
                        {
                            break;
                        }
                        if (pause || args.Break)
                        {
                            args.Break = false;
                            running = false;
                            signalRunning.Reset();
                            signalPaused.Set();
                            {
                                try
                                {
                                    Monitor.Exit(this);
                                    if (engineStoppedCallback != null)
                                    {
                                        engineStoppedCallback.Invoke(false);
                                    }
                                    signalRun.WaitOne();
                                }
                                finally
                                {
                                    Monitor.Enter(this);
                                }
                            }
                            if (quit || stepResult == StepResult.Finished)
                            {
                                break;
                            }
                            pause = false;
                            running = true;
                            signalPaused.Reset();
                            signalRunning.Set();
                        }
                        stepResult = engine.NextStep();
                    }
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
                    engineStoppedCallback.Invoke(true);
                }
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
                lock (this)
                {
                    return engine.Project;
                }
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
            get
            {
                lock (this)
                {
                    return engine.TasksCount;
                }
            }
        }

        public int NextWarriorIndex
        {
            get
            {
                lock (this)
                {
                    return engine.NextWarriorIndex;
                }
            }
        }

        public IRunningWarrior NextWarrior
        {
            get
            {
                lock (this)
                {
                    return engine.NextWarrior;
                }
            }
        }

        public IRunningInstruction NextInstruction
        {
            get
            {
                lock (this)
                {
                    return engine.NextInstruction;
                }
            }
        }

        public IRunningInstruction LastInstruction
        {
            get
            {
                lock (this)
                {
                    return engine.LastInstruction;
                }
            }
        }

        public IRunningInstruction this[int address]
        {
            get
            {
                lock (this)
                {
                    return engine[address];
                }
            }
        }

        public int this[int address, Column reg]
        {
            get
            {
                lock (this)
                {
                    return engine[address, reg];
                }
            }
        }

        public int CoreSize
        {
            get
            {
                lock (this)
                {
                    return engine.CoreSize;
                }
            }
        }

        public StepResult LastStepResult
        {
            get
            {
                lock (this)
                {
                    return engine.LastStepResult;
                }
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
                lock (this)
                {
                    return engine.Round;
                }
            }
        }

        public int Cycles
        {
            get
            {
                lock (this)
                {
                    return engine.Cycles;
                }
            }
        }

        public int CyclesLeft
        {
            get
            {
                lock (this)
                {
                    return engine.CyclesLeft;
                }
            }
        }

        public int LiveWarriorsCount
        {
            get
            {
                lock (this)
                {
                    return engine.LiveWarriorsCount;
                }
            }
        }

        public int WarriorsCount
        {
            get
            {
                lock (this)
                {
                    return engine.WarriorsCount;
                }
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
                lock (this)
                {
                    return brake;
                }
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

        public event CheckBreak CheckBreak;
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