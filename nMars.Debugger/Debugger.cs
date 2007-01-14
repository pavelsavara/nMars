// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Debugger
{
    public class Debugger : BaseComponent, IShell
    {

        #region Operating

        protected bool Start(bool onlyInit)
        {
            if (Engine == null || !Engine.IsLive)
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
                        Engine = components.AsyncEngineWrapper;
                        Engine.BeginMatch(project, onEngineStoppedAsync);
                        if (onlyInit)
                            console.WriteLine(startString);
                        else
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
                Engine.Brake = project.EngineOptions.Brake;
                if (Engine.IsPaused)
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
                Engine.Continue(false);
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
            if (Engine == null)
                return;

            if (finished)
            {
                Engine.EndMatch(console);
                Engine = null;
                //console.WriteLine(stopedString);
            }
            else
            {
                console.WriteLine(pausedString);
            }
        }

        public virtual bool Stop()
        {
            if (Engine == null || !Engine.IsLive)
                return false;

            Engine.Quit(false);
            console.WriteLine(stopString);
            return true;
        }

        public virtual bool Restart()
        {
            if (!Stop())
                return false;
            if (!Start(true))
                return false;
            return true;
        }

        public virtual bool Pause()
        {
            if (Engine == null || Engine.IsPaused)
                return false;

            Engine.Pause(false);
            return true;
        }

        public virtual bool Continue()
        {
            if (Engine == null || !Engine.IsPaused)
                return false;

            Engine.Continue(false);
            console.WriteLine(runningString);
            return true;
        }

        public virtual bool Step(int count)
        {
            while (count > 0)
            {
                count--;
                Step();
            }
            return true;
        }

        public virtual bool Step()
        {
            if (Engine == null || !Engine.IsPaused)
                return false;

            if (Engine.LastStepResult == StepResult.Finished && Engine.Cycles!=0)
            {
                Engine.Continue(false);
            }
            else
            {
                Engine.NextStep();
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

        public virtual bool Back(int count)
        {
            while (count > 0)
            {
                count--;
                Back();
            }
            return true;
        }

        public virtual bool Back()
        {
            if (Engine == null || !Engine.IsPaused|| !Engine.CanStepBack)
                return false;

            Engine.PrevStep();
            console.WriteLine(backString);
            return true;
        }

        #endregion

        #region Shell

        public virtual void Attach(IConsole aConsole, IList<IShell> allShells)
        {
            console = aConsole;
            console.CommandEntered += new ConsoleCommandEntered(ConsoleCommandEntered);
            foreach (IShell shell in allShells)
            {
                shell.Register(this, "debugger");
            }
        }

        public void Register(object aplication, string name)
        {
        }

        public virtual void Detach()
        {
            console.CommandEntered -= new ConsoleCommandEntered(ConsoleCommandEntered);
        }

        public void ConsoleCommandEntered(string command, ref bool processed, ref bool quit)
        {
            if (processed)
                return;

            switch (command.ToLower())
            {
                case "clear":
                case "cl":
                    console.Clear();
                    processed = true;
                    break;
                case "list":
                case "l":
                    List();
                    processed = true;
                    break;
                case "continue":
                case "c":
                case "go":
                case "g":
                    Continue();
                    break;
                case "run":
                    Project.EngineOptions.Brake = normalRunBrake;
                    Start(false);
                    processed = true;
                    break;
                case "slow":
                    Project.EngineOptions.Brake = slowRunBrake;
                    Start(false);
                    processed = true;
                    break;
                case "fast":
                    Project.EngineOptions.Brake = fastRunBrake;
                    Start(false);
                    processed = true;
                    break;
                case "stop":
                    Stop();
                    processed = true;
                    break;
                case "pause":
                case "break":
                    Pause();
                    processed = true;
                    break;
                case "step":
                case "start":
                case "s":
                    Step();
                    processed = true;
                    break;
                case "back":
                    Back();
                    processed = true;
                    break;
                case "quit":
                case "exit":
                case "q":
                    Engine.Quit(false);
                    processed = true;
                    quit = true;
                    break;
            }
        }

        public void List()
        {
            if (Engine!=null &&Engine.IsLive)
                List(Engine.NextInstruction.Address - 1, 10);
            else 
                console.ErrorWriteLine("Engine is not running");
        }

        public void List(int from, int length)
        {
            if (Engine != null && Engine.IsLive)
            {
                for (int a = from; a < from + length; a++)
                {
                    console.WriteLine(Engine[a].ToString());
                }
            }
            else
                console.ErrorWriteLine("Engine is not running");
        }

        #endregion

        #region Properties

        public int Brake
        {
            get { return Engine.Brake; }
            set { Engine.Brake = value; }
        }

        public IProject Project
        {
            get { return project; }
            set { project = value; }
        }

        public ComponentLoader Components
        {
            get { return components; }
            set { components = value; }
        }

        public bool PrintErrors
        {
            set { }
        }

        public IConsole Console
        {
            get { return console; }
            set { console = value; }
        }

        public IAsyncEngine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        #endregion

        #region Variables

        const string startString = "=Start=";
        const string runningString = "=Running=";
        const string pausedString = "=Paused=";
        const string backString = "=Back=";
        const string stopString = "=Stop=";
        const string stepString = "=Step=";

        public const int slowRunBrake = 400;
        public const int normalRunBrake = 10;
        public const int fastRunBrake = 1;
        public const int executeBrake = -1;

        private IAsyncEngine engine;
        private IConsole console;

        private IProject project;
        private ComponentLoader components;

        #endregion
    }
}
