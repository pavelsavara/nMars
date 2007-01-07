// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;

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
    public delegate void ConsoleCommandEntered(string commandLine);

    public interface IConsole : ISimpleOutput
    {
        Stream ErrorStream { get; }
        Stream OutStream { get; }
        Stream InputStream { get; }
        event ConsoleCommandEntered CommandEntered;
    }
}