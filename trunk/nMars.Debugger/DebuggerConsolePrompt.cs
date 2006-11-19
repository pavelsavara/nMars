using System;
using System.IO;
using nMars.RedCode;

namespace nMars.Debugger
{
    class DebuggerConsolePrompt : IDebuggerPrompt
    {
        public void Init(IDebugger aDebugger, IDebuggerEngine aEngine)
        {
            engine = aEngine;
        }

        public void PaintCore(bool running)
        {
            IRunningWarrior w = engine.NextWarrior;
            IRunningInstruction i = engine.NextInstruction;
            if (i != null && w != null)
            {
                Console.WriteLine("{0,20} ({1,3}): {2}", w.Name, w.TasksCount, i.ToString());
            }
        }

        public string GetCommand()
        {
            Console.Write(">");
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
    }
}
