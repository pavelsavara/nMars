// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Engine
{
    class Module : IEngineModule
    {
        public static int Main(string[] args)
        {
            try
            {
                return CommandLine.EngineMain(args, typeof(Module).Namespace, "nMars.Parser");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return -1;
            }
        }

        public IEngine CreateEngine()
        {
            return new EngineSteps();
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