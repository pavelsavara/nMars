// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace pMars.DllWrapper
{
    class Module : IParserModule, IEngineModule
    {
        public static int Main(string[] args)
        {
            try
            {
                return CommandLine.EngineMain(args, typeof(Module).Namespace, typeof(Module).Namespace);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return -1;
            }
        }

        public IParser CreateParser()
        {
            return new pMarsDllParser();
        }

        public IEngine CreateEngine()
        {
            return new pMarsDllEngine();
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