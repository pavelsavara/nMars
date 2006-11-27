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
        public ComponentSetup()
        {
            Assembly a = Assembly.GetEntryAssembly();
            string name = a.FullName.Substring(0, a.FullName.IndexOf(','));
            LoadParser(name, name);
            LoadEngine(name, name);
            LoadDebugger(name, name);
        }

        public ComponentSetup(IParser parser)
        {
            this.parser = parser;
        }

        public ComponentSetup(IEngine engine)
        {
            this.engine = engine;
        }

        public ComponentSetup(IDebugger debugger)
        {
            this.debugger = debugger;
        }

        public void LoadParser(string parserAssembly, string parserName)
        {
            try
            {
                parser = ModuleRegister.CreateParser(parserAssembly, parserName);
            }
            catch(FileNotFoundException)
            {
                //swallow
            }
        }
        
        public void LoadEngine(string engineAssembly, string engineName)
        {
            try
            {
                engine = ModuleRegister.CreateEngine(engineAssembly, engineName);
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }
        
        public void LoadDebugger(string debuggerAssembly, string debuggerName)
        {
            try
            {
                debugger = ModuleRegister.CreateDebugger(debuggerAssembly, debuggerName);
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }
        
        public IParser Parser
        {
            get
            {
                if (parser == null)
                    LoadParser("nMars.Parser", "nMars.Parser");
                return parser;
            }
        }

        public IEngine Engine
        {
            get
            {
                if (engine == null)
                    LoadEngine("nMars.Engine", "nMars.Engine");
                return engine;
            }
        }

        public IDebugger Debugger
        {
            get
            {
                if (debugger == null)
                    LoadDebugger("nMars.Debugger", "nMars.Debugger");
                return debugger;
            }
        }
        
        private IParser parser;
        private IEngine engine;
        private IDebugger debugger;
    }
}
