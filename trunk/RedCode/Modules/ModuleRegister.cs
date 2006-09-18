using System;
using System.Collections.Generic;
using System.Text;

namespace nMars.RedCode.Modules
{
    public class ModuleRegister
    {
        public static void Register(IModule module)
        {
            lock(modules)
            {
                modules.Add(module.Name,module);
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
