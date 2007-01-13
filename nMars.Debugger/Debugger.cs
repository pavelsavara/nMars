// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Debugger
{
    public class Debugger
    {
        #region Construction

        public Debugger(ISimpleOutput aConsole)
        {
            console = aConsole;
        }

        #endregion

        #region Operating

        protected bool StartEngine(bool onlyInit)
        {
            if (ActiveEngine == null)
            {
                ParseResult result = components.Parser.Parse(project, console);

                if (result.Succesfull)
                {
                    if (project.EngineOptions.Brake == executeBrake)
                    {
                        components.Engine.Run(project, console);
                    }
                    else
                    {
                        ActiveEngine = components.AsyncEngineWrapper;
                        ActiveEngine.BeginMatch(project, onEngineStoppedAsync);
                        console.WriteLine(runningString);
                        OnAfterStartEngine(false, onlyInit);
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                ActiveEngine.Brake = project.EngineOptions.Brake;
                if (ActiveEngine.IsPaused)
                {
                    OnAfterStartEngine(true, onlyInit);
                }
            }
            return true;
        }

        protected virtual void OnAfterStartEngine(bool justContinue, bool onlyInit)
        {
            if (!onlyInit)
            {
                ActiveEngine.Continue(false);
            }
        }

        /// <summary>
        /// Redirection thru MainForm on derived class
        /// </summary>
        protected virtual void onEngineStoppedAsync(bool finished)
        {
            OnEngineStopped(finished);
        }

        protected virtual void OnEngineStopped(bool finished)
        {
            if (ActiveEngine == null)
                return;

            if (finished)
            {
                ActiveEngine.EndMatch(console);
                ActiveEngine = null;
                //console.WriteLine(stopedString);
            }
            else
            {
                console.WriteLine(pausedString);
            }
        }

        public virtual bool Stop()
        {
            if (ActiveEngine == null || !ActiveEngine.IsLive)
                return false;

            ActiveEngine.Quit(false);
            console.WriteLine(stopString);
            return true;
        }

        public virtual bool Pause()
        {
            if (ActiveEngine == null || ActiveEngine.IsPaused)
                return false;

            ActiveEngine.Pause(false);
            return true;
        }

        public virtual bool Continue()
        {
            if (ActiveEngine == null || !ActiveEngine.IsPaused)
                return false;

            ActiveEngine.Continue(false);
            console.WriteLine(runningString);
            return true;
        }

        public virtual bool Step()
        {
            if (ActiveEngine == null || !ActiveEngine.IsPaused)
                return false;

            if (ActiveEngine.LastStepResult == StepResult.Finished)
            {
                ActiveEngine.Continue(false);
            }
            else
            {
                ActiveEngine.NextStep();
                console.WriteLine(stepString);
            }
            return true;
        }

        public virtual bool StepThread()
        {
            //TODO
            return false;
        }

        public virtual bool StepWarrior()
        {
            //TODO
            return false;
        }

        public virtual bool Back()
        {
            if (ActiveEngine == null || !ActiveEngine.IsPaused|| !ActiveEngine.CanStepBack)
                return false;

            ActiveEngine.PrevStep();
            console.WriteLine(backString);
            return true;
        }

        #endregion

        #region Properties

        public int Brake
        {
            get { return ActiveEngine.Brake; }
            set { ActiveEngine.Brake = value; }
        }

        public Project Project
        {
            get { return project; }
            set { project = value; }
        }

        public ComponentLoader Components
        {
            get { return components; }
            set { components = value; }
        }

        public ISimpleOutput Console
        {
            get { return console; }
            set { console = value; }
        }

        public IAsyncEngine ActiveEngine
        {
            get { return activeEngine; }
            set { activeEngine = value; }
        }

        #endregion

        #region Variables

        const string runningString = "=Running=";
        const string pausedString = "=Paused=";
        const string backString = "=Back=";
        const string stopString = "=Stop=";
        const string stepString = "=Step=";

        public const int slowRunBrake = 400;
        public const int normalRunBrake = 10;
        public const int fastRunBrake = 1;
        public const int executeBrake = -1;

        private IAsyncEngine activeEngine;
        private ISimpleOutput console;

        private Project project;
        private ComponentLoader components;

        #endregion
    }
}
