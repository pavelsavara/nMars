// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.CommandLine;
using nMars.RedCode.Modules;

namespace pMars.ShellWrapper
{
    class Module : IParserModule
    {
        public static int Main(string[] args)
        {
            return CommandLine.ParserMain(args, name);
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

        public IParser CreateParser()
        {
            return new pMarsParser();
        }

        private static Module instance;
        private static string name = "pMarsShellParser";
        private static string executable = "pMarsShellParser";
    }
}