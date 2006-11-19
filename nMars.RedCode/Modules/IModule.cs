// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Runtime.InteropServices;

namespace nMars.RedCode.Modules
{
    [ComVisible(true)]
    public interface IModule
    {
        string Name { get; }
    }

    [ComVisible(true)]
    public interface IEngineModule : IModule
    {
        IEngine CreateEngine();
    }

    [ComVisible(true)]
    public interface IParserModule : IModule
    {
        IParser CreateParser();
    }
    
    [ComVisible(true)]
    public interface IDebuggerModule : IModule
    {
        IDebugger CreateDebugger();
    }
    
    [ComVisible(true)]
    public interface IDebuggerShellModule : IModule
    {
        IDebuggerShell CreateShell();
    }
}