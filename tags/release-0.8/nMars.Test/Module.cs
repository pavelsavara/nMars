// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Test
{
    class Module : IEngineModule
    {
        public static int Main(string[] args)
        {
            try
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
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine();
                Console.Error.WriteLine(ex.StackTrace);
                return -1;
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