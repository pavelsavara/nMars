// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

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
                return modules[name];
            }
        }

        static private Dictionary<string, IModule> modules = new Dictionary<string, IModule>();
    }
}