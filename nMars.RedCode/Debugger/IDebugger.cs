// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.ComponentModel;
using System.IO;
using IComponent=nMars.RedCode.Modules.IComponent;

namespace nMars.RedCode
{
    public interface IDebugger : IEngine
    {
        void Init(IDebuggerEngine engine, IDebuggerShell shell, IDebuggerPrompt prompt);
        void CoreDump(TextWriter tw);
        void NextStep();
        void NextStep(int count);
        void PrevStep();
        void PrevStep(int count);
        void Continue();
        void Pause();
        void Quit();
        void Restart();
        void List(int from, int length);
        int Speed { get; set; }
        bool Echo { get; set; }
        event CheckBreak CheckBreak;
    }

    public interface IDebuggerPrompt : IConsole, IComponent
    {
        void Init(IDebugger debugger, IDebuggerEngine engine, IDebuggerShell aShell);
    }

    public interface IDebuggerShell : IComponent
    {
        void Init(IDebugger debugger, IDebuggerEngine engine, IDebuggerPrompt prompt);
        bool ProcessCommand(ref string command, bool printErrors);
        string EchoString { get; }
        string PromptString { get; }
    }
}