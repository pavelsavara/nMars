using System;
using nMars.RedCode;

namespace nMars.Debugger
{
    class DebuggerConsolePrompt : WrappedConsole, IDebuggerPrompt
    {
        public void Init(IDebugger aDebugger, IDebuggerEngine aEngine, IDebuggerShell aShell)
        {
            engine = aEngine;
            debugger = aDebugger;
            shell = aShell;
        }

        public override string GetCommand()
        {
            Console.Write(shell.PromptString);
            return Console.ReadLine();
        }

        private IDebuggerEngine engine;
        private IDebugger debugger;
        private IDebuggerShell shell;
    }
}