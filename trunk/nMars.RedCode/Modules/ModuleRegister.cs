// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace nMars.RedCode.Modules
{
    public class ModuleRegister
    {
        public static void Register(IModule module, string name)
        {
            lock (modules)
            {
                modules.Add(name, module);
            }
        }

        public static void Register(IModule module)
        {
            lock (modules)
            {
                modules.Add(module.Name, module);
            }
        }

        private static IModule FindModule(string assembly, string name)
        {
            lock (modules)
            {
                if (!modules.ContainsKey(assembly))
                {
                    try
                    {
                        Assembly a = Assembly.Load(assembly);
                        a.CreateInstance(assembly + ".Module");
                    }
                    catch(Exception)
                    {
                        return null;
                    }
                }
                return modules[name];
            }
        }
        
        public static string BasePath
        {
            get
            {
                return Path.GetDirectoryName(typeof(ModuleRegister).Module.FullyQualifiedName);
            }
        }

        public static IEngine CreateEngine(string engineName)
        {
            return CreateEngine(engineName, engineName);
        }
        
        public static IEngine CreateEngine(string assembly, string engineName)
        {
            IEngineModule engineModule = FindModule(assembly, engineName) as IEngineModule;
            if (engineModule == null)
            {
                throw new FileNotFoundException("Cannot find module or interface");
            }
            return engineModule.CreateEngine();
        }

        public static IParser CreateParser(string parserName)
        {
            return CreateParser(parserName, parserName);
        }

        public static IParser CreateParser(string assembly, string parserName)
        {
            IParserModule parserModule = FindModule(assembly, parserName) as IParserModule;
            if (parserModule==null)
            {
                throw new FileNotFoundException("Cannot find module or interface");
            }
            return parserModule.CreateParser();
        }

        public static IDebugger CreateDebugger(string name)
        {
            return CreateDebugger(name, name);
        }

        public static IDebugger CreateDebugger( string assembly, string name)
        {
            IDebuggerModule debuggerModule = FindModule(assembly, name) as IDebuggerModule;
            if (debuggerModule == null)
            {
                throw new FileNotFoundException("Cannot find module or interface");
            }
            return debuggerModule.CreateDebugger();
        }

        public static IDebuggerShell CreateShell(string name)
        {
            return CreateShell(name, name);
        }

        public static IDebuggerShell CreateShell(string assembly, string name)
        {
            IDebuggerShellModule debuggerModule = FindModule(assembly, name) as IDebuggerShellModule;
            if (debuggerModule == null)
            {
                throw new FileNotFoundException("Cannot find module or interface");
            }
            return debuggerModule.CreateShell();
        }

        static private Dictionary<string, IModule> modules = new Dictionary<string, IModule>();
    }
}