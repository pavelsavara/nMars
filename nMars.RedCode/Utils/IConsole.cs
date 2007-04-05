// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    public interface ISimpleOutput
    {
        void Clear();
        void WriteLine(string text);
        void Write(string text);
        void ErrorWriteLine(string text);
    }

    /// <summary>
    /// Command for application shell
    /// </summary>
    /// <param name="commandLine">command line</param>
    public delegate void ConsoleCommandEntered(string commandLine, ref bool processed, ref bool quit);

    public interface IShellPrompt
    {
        event ConsoleCommandEntered CommandEntered;
    }

    public interface IConsole : ISimpleOutput, IShellPrompt
    {
        Stream ErrorStream { get; }
        Stream OutStream { get; }
    }

    public interface IShell : IComponent
    {
        void Attach(IConsole console, IList<IShell> allShells);
        void Register(object aplication, string name);
        IProject Project { get; set;}
        ComponentLoader Components { get; set;}
        IAsyncEngine Engine { set;}
        bool PrintErrors { set;}
        void Detach();
    }
}