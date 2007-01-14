// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;
using System.Xml.Serialization;

namespace nMars.RedCode.Modules
{
    /// <summary>
    /// Basic Components loader
    /// </summary>
    public class ComponentLoader
    {
        #region Public

        /// <summary>
        /// Parser Component
        /// </summary>
        [XmlIgnore]
        public IParser Parser
        {
            get
            {
                if (parser == null)
                    LoadParser();
                return parser;
            }
            set
            {
                parser = value;
                cachingParser = null;
            }
        }

        /// <summary>
        /// Engine Component
        /// </summary>
        [XmlIgnore]
        public IEngine Engine
        {
            get
            {
                if (engine == null)
                    LoadEngine();
                return engine;
            }
            set
            {
                engine = value;
                asyncEngineWrapper = null;
            }
        }

        /// <summary>
        /// Engine Component
        /// </summary>
        [XmlIgnore]
        public IShell Shell
        {
            get
            {
                if (engine == null)
                    LoadShell();
                return shell;
            }
            set
            {
                shell = value;
            }
        }

        /// <summary>
        /// Asynchronous wrapper
        /// </summary>
        [XmlIgnore]
        public IAsyncEngine AsyncEngineWrapper
        {
            get
            {
                if (asyncEngineWrapper == null)
                {
                    IDebuggerEngine debuggerEngine = Engine as IDebuggerEngine;
                    if (debuggerEngine!=null)
                    {
                        asyncEngineWrapper = new AsyncEngine(debuggerEngine);
                    }
                    else
                    {
                        throw new EngineException("Engine must implement IDebuggerEngine");
                    }
                }
                return asyncEngineWrapper;
            }
        }

        public IParser CachingParser
        {
            get
            {
                return cachingParser;
            }
        }

        private IAsyncEngine asyncEngineWrapper;
        private IParser cachingParser;

        private string parserName = "nMars.Parser";
        private string engineName = "nMars.Engine";
        private string shellName = "nMars.Debugger";
        public string ParserName
        {
            get
            {
                return parserName;
            }
            set
            {
                parserName = value;
                Parser = null;
            }
        }
        public string EngineName
        {
            get
            {
                return engineName;
            }
            set
            {
                engineName = value;
                Engine = null;
            }
        }

        public string ShellName
        {
            get
            {
                return shellName;
            }
            set
            {
                shellName = value;
                Shell = null;
            }
        }

        #endregion

        #region Helpers

        private void LoadParser()
        {
            try
            {
                parser = ModuleRegister.CreateParser(ParserName);
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }

        private void LoadEngine()
        {
            try
            {
                engine = ModuleRegister.CreateEngine(EngineName);
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }

        private void LoadShell()
        {
            try
            {
                shell = ModuleRegister.CreateShell(ShellName);
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }

        #endregion

        #region Variables

        private IParser parser;
        private IEngine engine;
        private IShell shell;

        #endregion
    }
}