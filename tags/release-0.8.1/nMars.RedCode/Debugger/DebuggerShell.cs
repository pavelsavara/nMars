// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;

namespace nMars.Debugger
{
    public class DebuggerShell : IDebuggerShell
    {
        public void Init(IDebugger aDebugger, IDebuggerEngine aEngine, IDebuggerPrompt aPrompt)
        {
            debugger = aDebugger;
            engine = aEngine;
            prompt = aPrompt;
            lastCommand = "";
        }

        public bool ProcessCommand(ref string command, bool printErrors)
        {
            bool res = true;
            if (command.Trim() == "")
            {
                command = lastCommand;
            }
            switch (command.Trim())
            {
                case "clear":
                case "cl":
                    prompt.Clear();
                    break;
                case "list":
                case "l":
                    debugger.List(engine.NextInstruction.Address - 1, 10);
                    break;
                case "step":
                case "s":
                    debugger.NextStep();
                    break;
                case "continue":
                case "c":
                case "go":
                case "g":
                    debugger.Continue();
                    break;
                case "quit":
                case "exit":
                case "q":
                    debugger.Quit();
                    break;
                case "restart":
                case "re":
                    debugger.Restart();
                    break;
                case "back":
                case "b":
                    debugger.PrevStep();
                    break;
                case "echo":
                    debugger.Echo = !debugger.Echo;
                    break;
                default:
                    if (printErrors)
                    {
                        prompt.ErrorWriteLine("Unknown command");
                    }
                    res = false;
                    break;
            }
            lastCommand = command;
            return res;
        }

        public string EchoString
        {
            get
            {
                lock (engine)
                {
                    IRunningWarrior w = engine.NextWarrior;
                    IRunningInstruction i = engine.NextInstruction;
                    if (i != null && w != null)
                    {
                        return string.Format("{0,20} ({1,3}): {2}", w.Name, w.TasksCount, i.ToString());
                    }
                }
                return null;
            }
        }

        public string PromptString
        {
            get { return ">"; }
        }

        private string lastCommand;
        private IDebugger debugger;
        private IDebuggerEngine engine;
        private IDebuggerPrompt prompt;
    }
}