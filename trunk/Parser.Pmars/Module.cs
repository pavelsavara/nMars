using nMars;
using nMars.RedCode;
using nMars.RedCode.CommandLine;
using nMars.RedCode.Modules;

namespace nMars.pMars
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

        public IParser CreateParser(Rules rules)
        {
            return new pMarsParser(rules);
        }

        private static Module instance;
        private static string name = "pMarsParser";
        private static string executable = "pMarsParser";
    }
}
