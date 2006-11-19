using System;
using System.IO;
using System.Threading;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Debugger
{
    class Debugger : IDebugger
    {
        public void Attach(IDebuggerEngine aEngine, IDebuggerShell aShell, IDebuggerPrompt aPrompt)
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
                catch(FileNotFoundException)
                {
                    //swallow
                }
                
            }
            if (shell == null)
            {
                shell = new DebuggerShell();
            }
            prompt.Init(this, engine);
            shell.Init(this, engine, prompt);
            breakpoint = true;
            echo = false;
        }

        public MatchResult Run(IProject project)
        {
            MatchResult res;
            do
            {
                quitMatch = false;
                restart = false;

                res = RunMatch(project);
                if (!restart && !quitDebugger)
                {
                    prompt.Out.WriteLine();
                    prompt.Out.WriteLine("Match is finished, type 'restart' to restart match.");
                    Prompt();
                    breakpoint = true;
                }
            } while (restart && !quitDebugger);
            return res;
        }

        private MatchResult RunMatch(IProject project)
        {
            MatchResult res;
            lastStepResult = StepResult.Continue;
            engine.BeginMatch(project);
            do
            {
                if (CheckBreak())
                {
                    if (echo)
                    {
                        prompt.PaintCore(false);
                    }
                    Prompt();
                }
                else
                {
                    if (echo)
                    {
                        prompt.PaintCore(true);
                    }
                    lastStepResult = engine.NextStep();
                    if (speed > 0)
                    {
                        Thread.Sleep(speed);
                    }
                }
            } while (lastStepResult != StepResult.Finished && !quitMatch);
            
            if (echo)
            {
                prompt.PaintCore(false);
            }
            res = engine.EndMatch();
            return res;
        }

        private bool CheckBreak()
        {
            return breakpoint;
        }

        private void Prompt()
        {
            try
            {
                string command = prompt.GetCommand();
                if (!shell.ProcessCommand(ref command))
                {
                    prompt.Error.WriteLine("Unknown command");
                }
            }
            catch (DebuggerException e)
            {
                prompt.Error.WriteLine(e.Message);
            }
        }

        public void CoreDump(TextWriter tw)
        {
            throw new NotImplementedException();
        }

        public void Step()
        {
            Step(1);
        }

        public void Step(int count)
        {
            while (lastStepResult != StepResult.Finished && !quitMatch && count > 0)
            {
                count--;
                lastStepResult = engine.NextStep();
            }
        }

        public void StepBack()
        {
            StepBack(1);
        }

        public void StepBack(int count)
        {
            while (engine.CanStepBack && lastStepResult != StepResult.Finished && !quitMatch && count > 0)
            {
                count--;
                lastStepResult = engine.PrevStep();
            }
        }

        public void Continue()
        {
            breakpoint = false;
        }

        public void Break()
        {
            breakpoint = true;
        }

        public void Quit()
        {
            quitMatch = true;
            quitDebugger = true;
        }

        public void Restart()
        {
            quitMatch = true;
            restart = true;
        }

        public void List(int from, int lenght)
        {
            for (int a = from; a < from + lenght; a++)
            {
                prompt.Out.WriteLine(engine[a].ToString());
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

        private IDebuggerEngine engine;
        private IDebuggerShell shell;
        private IDebuggerPrompt prompt;
        private StepResult lastStepResult;
        private bool breakpoint;
        private bool quitMatch;
        private bool quitDebugger;
        private bool restart;
        private bool echo;
        private int speed;
    }
}
