using System;
using System.IO;
using System.Threading;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Debugger
{
    class Debugger : IDebugger
    {
        public void Init(IDebuggerEngine aEngine, IDebuggerShell aShell, IDebuggerPrompt aPrompt)
        {
            engine = aEngine;
            prompt = aPrompt;
            shell = aShell;
            if (prompt == null)
            {
                prompt = new DebuggerConsolePrompt();
            }

            if (shell == null)
            {
                try
                {
                    shell = ModuleRegister.CreateShell("nMars.DbgShellPy");
                }
                catch (FileNotFoundException)
                {
                    //swallow
                }
            }
            if (shell == null)
            {
                shell = new DebuggerShell();
            }
            prompt.Init(this, engine, shell);
            shell.Init(this, engine, prompt);
            echo = false;
            speed = 0;
            aEngine.CheckBreak += CallBack;
        }

        public MatchResult Run(IProject aProject)
        {
            project = aProject;
            quit = false;
            engine.BeginMatch(project);
            do
            {
                AskPrompt();
            } while (!quit);

            engine.Quit();
            return engine.EndMatch();
        }

        private void AskPrompt()
        {
            try
            {
                string command = prompt.GetCommand();
                shell.ProcessCommand(ref command, true);
            }
            catch (DebuggerException e)
            {
                prompt.ErrorWriteLine(e.Message);
            }
        }

        private void CallBack(CheckBreakEventArgs args)
        {
            EchoStep();
            Slow();
        }

        private void Slow()
        {
            if (speed != 0)
            {
                Thread.Sleep(speed);
            }
        }

        private void EchoStep()
        {
            if (!echo) return;
            prompt.WriteLine(shell.EchoString);
        }

        #region Interfaces

        public void CoreDump(TextWriter tw)
        {
            throw new NotImplementedException();
        }

        public void List(int from, int length)
        {
            for (int a = from; a < from + length; a++)
            {
                prompt.WriteLine(engine[a].ToString());
            }
        }

        public void PrevStep()
        {
            engine.PrevStep();
        }

        public void NextStep()
        {
            engine.NextStep();
        }

        public void NextStep(int count)
        {
            while (engine.LastStepResult != StepResult.Finished && count > 0)
            {
                count--;
                engine.NextStep();
            }
        }

        public void PrevStep(int count)
        {
            while (engine.LastStepResult != StepResult.Finished && count > 0)
            {
                count--;
                engine.PrevStep();
            }
        }

        public void Continue()
        {
            engine.Continue();
        }

        public void Pause()
        {
            engine.Pause();
        }

        public void Quit()
        {
            quit = true;
        }

        public void Restart()
        {
            engine.Pause();
            lock (engine)
            {
                engine.BeginMatch(project);
            }
        }

        public event CheckBreak CheckBreak
        {
            add
            {
                lock (engine)
                {
                    engine.CheckBreak += value;
                }
            }
            remove
            {
                lock (engine)
                {
                    engine.CheckBreak -= value;
                }
            }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool Echo
        {
            get { return echo; }
            set { echo = value; }
        }

        public IProject Project
        {
            get { return project; }
        }

        #endregion

        #region Variables

        private IDebuggerEngine engine;
        private IDebuggerShell shell;
        private IDebuggerPrompt prompt;
        private bool echo;
        private int speed;
        private bool quit;
        private IProject project;

        #endregion
    }
}