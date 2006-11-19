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

        public bool ProcessCommand(ref string command)
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
                    debugger.Step();
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
                case "stepback":
                case "back":
                case "b":
                    debugger.StepBack();
                    break;
                default:
                    res = false;
                    break;
            }
            lastCommand = command;
            return res;
        }

        private string lastCommand;
        private IDebugger debugger;
        private IDebuggerEngine engine;
        private IDebuggerPrompt prompt;
    }
}
