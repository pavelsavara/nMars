// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;
using System.Reflection;

namespace nMars.RedCode.Modules
{
    public class ComponentSetup
    {
        #region Construction

        public ComponentSetup()
        {
            Assembly a = Assembly.GetEntryAssembly();
            string name = a.FullName.Substring(0, a.FullName.IndexOf(','));
            LoadParser(name, name);
            LoadEngine(name, name);
            LoadDebugger(name, name);
        }

        #endregion

        #region Public

        public IParser Parser
        {
            get
            {
                if (parser == null)
                    LoadParser(ParserAssembly, ParserName);
                return parser;
            }
        }

        public IEngine Engine
        {
            get
            {
                if (engine == null)
                    LoadEngine(EngineAssembly, EngineName);
                return engine;
            }
        }

        public IDebugger Debugger
        {
            get
            {
                if (debugger == null)
                    LoadDebugger(DebuggerAssembly, DebuggerName);
                return debugger;
            }
        }

        public string ParserName;
        public string EngineName;
        public string DebuggerName;
        public string ShellName;

        public string ParserAssembly = "nMars.Parser";
        public string EngineAssembly = "nMars.Engine";
        public string DebuggerAssembly = "nMars.Debugger";
        public string ShellAssembly = "nMars.Debugger";

        #endregion

        #region Helpers

        private void LoadParser(string parserAssembly, string parserName)
        {
            try
            {
                if (parserName == null)
                {
                    parser = ModuleRegister.CreateParser(parserAssembly, parserAssembly);
                }
                else
                {
                    parser = ModuleRegister.CreateParser(parserAssembly, parserName);
                }
                ParserAssembly = parserAssembly;
                ParserName = parserName;
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }

        private void LoadEngine(string engineAssembly, string engineName)
        {
            try
            {
                if (engineName == null)
                {
                    engine = ModuleRegister.CreateEngine(engineAssembly, engineAssembly);
                }
                else
                {
                    engine = ModuleRegister.CreateEngine(engineAssembly, engineName);
                }
                EngineAssembly = engineAssembly;
                EngineName = engineName;
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }

        private void LoadDebugger(string debuggerAssembly, string debuggerName)
        {
            try
            {
                if (debuggerName == null)
                {
                    debugger = ModuleRegister.CreateDebugger(debuggerAssembly, debuggerAssembly);
                }
                else
                {
                    debugger = ModuleRegister.CreateDebugger(debuggerAssembly, debuggerName);
                }
                DebuggerAssembly = debuggerAssembly;
                DebuggerName = debuggerName;
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
        private IDebugger debugger;

        #endregion
    }
}