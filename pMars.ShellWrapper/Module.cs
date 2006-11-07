// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.Modules;

namespace pMars.ShellWrapper
{
    class Module : IParserModule
    {
        public static int Main(string[] args)
        {
            return CommandLine.ParserMain(args, typeof(Module).Namespace);
        }

        public IParser CreateParser()
        {
            return new pMarsParser();
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        public string Name
        {
            get { return typeof(Module).Namespace; }
        }

        #endregion
    }
}