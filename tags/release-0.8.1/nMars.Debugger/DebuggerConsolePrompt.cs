// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

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