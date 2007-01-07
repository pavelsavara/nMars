// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace nMars.RedCode.Modules
{
    public class ModuleRegister
    {
        #region Registration & Loading

        public static void Register(IModule module, string name)
        {
            lock (Modules)
            {
                Modules.Add(name, module);
            }
        }

        public static void Register(IModule module)
        {
            lock (Modules)
            {
                Modules.Add(module.Name, module);
            }
        }

        public static void SearchForModules()
        {
            SearchForModules(BasePath);
        }

        public static void SearchForModules(string path)
        {
            foreach (string dllFile in Directory.GetFiles(path, "*.dll"))
            {
                try
                {
                    Assembly a = Assembly.ReflectionOnlyLoadFrom(dllFile);
                    foreach (Type type in a.GetTypes())
                    {
                        if (type.IsSubclassOf(typeof(IModule)))
                        {
                            Assembly.Load(type.Assembly.FullName);
                        }
                    }
                }
                catch(FileLoadException)
                {
                    //swallow
                }
                catch(BadImageFormatException)
                {
                    //swallow
                }
            }
        }

        public static string BasePath
        {
            get { return Path.GetDirectoryName(typeof(ModuleRegister).Module.FullyQualifiedName); }
        }

        public static string GetVersion(Type type)
        {
            return type.Assembly.GetName().Version.ToString();
        }

        public static string GetVersionInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IModule module in Modules.Values)
            {
                sb.Append(module.Name);
                sb.Append(" ");
                sb.Append(module.Version);
                sb.Append("\n");
            }
            return sb.ToString();
        }

        static public Dictionary<string, IModule> Modules = new Dictionary<string, IModule>();

        #endregion

        #region Usage

        public static IModule GetModule(IComponent component)
        {
            string name = component.GetType().Assembly.GetName().FullName;
            string namespc = name.Substring(0, name.IndexOf(','));
            if (Modules.ContainsKey(namespc))
            {
                return Modules[namespc];
            }
            return null;
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
            if (parserModule == null)
            {
                throw new FileNotFoundException("Cannot find module or interface");
            }
            return parserModule.CreateParser();
        }

        public static IDebugger CreateDebugger(string name)
        {
            return CreateDebugger(name, name);
        }

        public static IDebugger CreateDebugger(string assembly, string name)
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

        #endregion

        #region Helper

        private static IModule FindModule(string assembly, string name)
        {
            lock (Modules)
            {
                if (!Modules.ContainsKey(assembly))
                {
                    try
                    {
                        Assembly a = Assembly.Load(assembly);
                        a.CreateInstance(assembly + ".Module");
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
                return Modules[name];
            }
        }

        #endregion
    }
}