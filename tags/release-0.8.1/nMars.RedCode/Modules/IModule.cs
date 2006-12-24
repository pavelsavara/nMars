// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Reflection;
using System.Runtime.InteropServices;

namespace nMars.RedCode.Modules
{
    public interface IComponent
    {
    }

    [ComVisible(true)]
    public interface IModule
    {
        string Name { get; }
        string Version { get; }
        string MajorMinorVersion { get; }
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

    [ComVisible(true)]
    public interface IIDEModule : IModule
    {
    }

    [ComVisible(true)]
    public abstract class BaseModule : IModule
    {
        public virtual string Name
        {
            get { return GetType().Namespace; }
        }

        public virtual string Version
        {
            get { return GetType().Assembly.GetName().Version.ToString(); }
        }

        public virtual string MajorMinorVersion
        {
            get
            {
                AssemblyName name = GetType().Assembly.GetName();
                return name.Version.Major.ToString() + "." + name.Version.Minor.ToString();
            }
        }
    }
}