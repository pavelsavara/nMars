// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Test
{
    class Module : IEngineModule
    {
        public static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                EngineTest test=new EngineTest();
                test.Full();
                return 0;
            }
            else
            {
                return CommandLine.EngineMain(args, typeof(Module).Namespace, "pMars.DllWrapper");
            }
        }

        public IEngine CreateEngine()
        {
            return new ComparingEngine();
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