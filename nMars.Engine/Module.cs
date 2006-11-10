// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Engine
{
    class Module : IEngineModule
    {
        public static int Main(string[] args)
        {
            return CommandLine.EngineMain(args, typeof(Module).Namespace, "nMars.Parser");
        }

        public IEngine CreateEngine()
        {
            return new Engine();
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