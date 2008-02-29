// This file is part of nMars - Core War MARS for .NET 
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
        /// Asynchronous wrapper around engine
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

        /// <summary>
        /// Caching wrapper around parser
        /// </summary>
        public IParser CachingParser
        {
            get
            {
                return cachingParser;
            }
        }

        /// <summary>
        /// Name of parser which should be loaded
        /// </summary>
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

        /// <summary>
        /// Name of engine which should be loaded
        /// </summary>
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

        #endregion

        #region Variables

        private IParser parser;
        private IEngine engine;
        private IAsyncEngine asyncEngineWrapper;
        private IParser cachingParser;
        private string parserName = "nMars.Parser";
        private string engineName = "nMars.Engine";

        #endregion
    }
}