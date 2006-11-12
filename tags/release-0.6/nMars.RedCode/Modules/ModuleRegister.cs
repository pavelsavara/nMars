// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace nMars.RedCode.Modules
{
    public class ModuleRegister
    {
        public static void Register(IModule module)
        {
            lock (modules)
            {
                modules.Add(module.Name, module);
            }
        }

        public static IModule FindModule(string name)
        {
            lock (modules)
            {
                if (!modules.ContainsKey(name))
                {
                    Assembly a = Assembly.Load(name);
                    a.CreateInstance(name + ".Module");
                }
                return modules[name];
            }
        }
        
        public static IEngine CreateEngine(string engineName)
        {
            IEngineModule engineModule = FindModule(engineName) as IEngineModule;
            if (engineModule == null)
            {
                throw new FileNotFoundException("Cannot find module or interface");
            }
            return engineModule.CreateEngine();
        }

        public static IParser CreateParser(string parserName)
        {
            IParserModule parserModule = FindModule(parserName) as IParserModule;
            if (parserModule==null)
            {
                throw new FileNotFoundException("Cannot find module or interface");
            }
            return parserModule.CreateParser();
        }

        static private Dictionary<string, IModule> modules = new Dictionary<string, IModule>();
    }
}