using System;
using System.IO;
using nMars.RedCode;

namespace nMars.Debugger
{
    class DebuggerConsolePrompt : IDebuggerPrompt
    {
        public void Init(IDebugger aDebugger, IDebuggerEngine aEngine, IDebuggerShell aShell)
        {
            engine = aEngine;
            debugger = aDebugger;
            shell = aShell;
        }

        public void PaintCore(bool running)
        {
        }

        public string GetCommand()
        {
            Console.Write(shell.PromptString);
            return Console.ReadLine();
        }

        public void Clear()
        {
            Console.Clear();
        }


        public TextWriter Out
        {
            get
            {
                return Console.Out;
            }
        }

        public Stream ErrorStream
        {
            get
            {
                return Console.OpenStandardError();
            }
        }

        public Stream OutStream
        {
            get
            {
                return Console.OpenStandardOutput();
            }
        }

        public Stream InputStream
        {
            get
            {
                return Console.OpenStandardInput();
            }
        }

        public TextWriter Error 
        { 
            get
            {
                return Console.Error;
            } 
        }

        private IDebuggerEngine engine;
        private IDebugger debugger;
        private IDebuggerShell shell;
    }
}
