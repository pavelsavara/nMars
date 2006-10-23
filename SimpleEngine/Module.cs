// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.CommandLine;
using nMars.RedCode.Modules;

namespace nMars.SimpleEngine
{
    class Module : IEngineModule
    {
        public static int Main(string[] args)
        {
            return CommandLine.EngineMain(args, name);
        }

        static Module()
        {
            instance = new Module();
            ModuleRegister.Register(instance);
        }

        public string Name
        {
            get { return name; }
        }

        public string Executable
        {
            get { return executable; }
        }

        public IEngine CreateEngine(Rules rules)
        {
            return new Engine();
        }

        private static Module instance;
        private static string name = "nMars.SimpleEngine";
        private static string executable = "nMarsSimpleEngine";
    }
}