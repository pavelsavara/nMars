// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;

namespace nMars.RedCode
{
    public interface IDebugger : IEngine
    {
        void Attach(IDebuggerEngine engine, IDebuggerShell shell, IDebuggerPrompt prompt);
        void CoreDump(TextWriter tw);
        void Step();
        void Step(int count);
        void StepBack();
        void StepBack(int count);
        void Continue();
        void Break();
        void Quit();
        void Restart();
        void List(int from, int length);
        int Speed { get; set;}
        bool Echo { get; set;}
    }

    public interface IDebuggerPrompt
    {
        void Init(IDebugger debugger, IDebuggerEngine engine);
        string GetCommand();
        void Clear();
        TextWriter Error { get;}
        TextWriter Out { get;}
        Stream ErrorStream { get;}
        Stream OutStream { get;}
        Stream InputStream { get;}
        void PaintCore(bool running);
    }

    public interface IDebuggerShell
    {
        void Init(IDebugger debugger, IDebuggerEngine engine, IDebuggerPrompt prompt);
        bool ProcessCommand(ref string command);
    }

}
