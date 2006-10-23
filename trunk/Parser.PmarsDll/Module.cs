// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.CommandLine;
using nMars.RedCode.Modules;

namespace nMars.pMarsDll
{
    class Module : IParserModule, IEngineModule
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

        public IParser CreateParser(Rules rules)
        {
            return new pMarsDllParser(rules);
        }

        public IEngine CreateEngine(Rules rules)
        {
            return new pMarsDllEngine();
        }

        private static Module instance;
        private static string name = "pMarsDll";
        private static string executable = "pMarsDll";

    }
}