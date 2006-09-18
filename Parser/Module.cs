using nMars.RedCode;
using nMars.RedCode.CommandLine;
using nMars.RedCode.Modules;

namespace nMars.Parser
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
            return new Parser(rules);
        }

        private static Module instance;
        private static string name = "nMars.Parser";
        private static string executable = "nMarsParser";
    }
}
