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
        public Debugger(ISimpleOutput aConsole)
        {
            console = aConsole;
        }


        public virtual bool Run(Project project, ComponentLoader components, EngineStoppedCallback engineStopped)
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
                        ActiveEngine = components.Engine as IAsyncEngine;
                        ActiveEngine.BeginMatch(project, engineStopped);
                        console.WriteLine(runningString);
                        RunContinueImpl(true);
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
                    RunContinueImpl(false);
                }
            }
            return true;
        }

        protected virtual void RunContinueImpl(bool start)
        {
            ActiveEngine.Continue();
        }

        public int Brake
        {
            get
            {
                return ActiveEngine.Brake;
            }
            set
            {
                ActiveEngine.Brake = value;
            }
        }


        protected virtual bool engineStopped(bool finished)
        {
            if (ActiveEngine == null)
                return false;

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
            return true;
        }

        public virtual bool Stop()
        {
            if (ActiveEngine == null || !ActiveEngine.IsLive)
                return false;

            ActiveEngine.Quit();
            return true;
        }

        public virtual bool Pause()
        {
            if (ActiveEngine == null || ActiveEngine.IsPaused)
                return false;

            ActiveEngine.Pause();
            return true;
        }

        public virtual bool Continue()
        {
            if (ActiveEngine == null || !ActiveEngine.IsPaused)
                return false;

            ActiveEngine.Continue();
            console.WriteLine(runningString);
            return true;
        }

        public virtual bool Step()
        {
            if (ActiveEngine == null || !ActiveEngine.IsPaused)
                return false;

            ActiveEngine.NextStep();
            console.WriteLine(stepString);
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

        const string runningString = "=Running=";
        const string pausedString = "=Paused=";
        const string backString = "=Back=";
        const string stepString = "=Step=";

        public const int slowRunBrake = 400;
        public const int normalRunBrake = 10;
        public const int fastRunBrake = 1;
        public const int executeBrake = -1;

        public IAsyncEngine ActiveEngine;
        protected ISimpleOutput console;
    }
}
