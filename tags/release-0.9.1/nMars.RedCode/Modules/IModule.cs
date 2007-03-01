// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Reflection;
using System.Runtime.InteropServices;

namespace nMars.RedCode.Modules
{
    /// <summary>
    /// abstract interface of components
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Source module
        /// </summary>
        IModule Module { get; }
    }


    public abstract class BaseComponent : IComponent
    {
        public IModule Module
        {
            get
            {
                return module;
            }
            set
            {
                module = value;
            }
        }
        private IModule module;
    }

    /// <summary>
    /// Module interface, name and version of module
    /// </summary>
    public interface IModule
    {
        /// <summary>
        /// Name of module
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Version of module assembly
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Version without build info
        /// </summary>
        string MajorMinorVersion { get; }
    }

    /// <summary>
    /// Module containing engine, engine factory
    /// </summary>
    public interface IEngineModule : IModule
    {
        /// <summary>
        /// Engine factory
        /// </summary>
        /// <returns>engine instance</returns>
        IEngine CreateEngine();
    }

    /// <summary>
    /// Module containing engine, engine factory
    /// </summary>
    public interface IEngineWrapperModule : IModule
    {
        /// <summary>
        /// Engine factory
        /// </summary>
        /// <returns>engine instance</returns>
        IEngine CreateEngine(IEngine engine);
    }

    /// <summary>
    /// Module containing parser, parser factory
    /// </summary>
    public interface IParserModule : IModule
    {
        /// <summary>
        /// Parser factory
        /// </summary>
        /// <returns>parser instance</returns>
        IParser CreateParser();
    }

    /// <summary>
    /// Module containing parser wrapper, parser wrapper factory
    /// </summary>
    public interface IParserWrapperModule : IModule
    {
        /// <summary>
        /// Parser factory
        /// </summary>
        /// <returns>parser instance</returns>
        IParser CreateParser(IParser parser);
    }

    /// <summary>
    /// Module containing parser, parser factory
    /// </summary>
    public interface IShellModule : IModule
    {
        /// <summary>
        /// Shell factory
        /// </summary>
        /// <returns>shell instance</returns>
        IShell CreateShell();
    }

    /// <summary>
    /// Ide module interface
    /// </summary>
    public interface IIDEPluginModule : IModule
    {
        /// <summary>
        /// Called during startup
        /// </summary>
        IIDEPlugin CreateIDEPlugin();
    }

    /// <summary>
    /// Abstract base of modules
    /// </summary>
    public abstract class BaseModule : IModule
    {
        /// <summary>
        /// Name of module
        /// </summary>
        public virtual string Name
        {
            get { return GetType().Namespace; }
        }

        /// <summary>
        /// Version of module assembly
        /// </summary>
        public virtual string Version
        {
            get { return GetType().Assembly.GetName().Version.ToString(); }
        }

        /// <summary>
        /// Version without build info
        /// </summary>
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