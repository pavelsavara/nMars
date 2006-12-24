// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Engine
{
    class Module : BaseModule, IEngineModule
    {
        public static int Main(string[] args)
        {
            try
            {
                return CommandLine.EngineMain(args, null, null);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return -1;
            }
        }

        public IEngine CreateEngine()
        {
            return new EngineASync();
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
            ModuleRegister.Register(new StepBackModule());
            ModuleRegister.Register(new StepForwardModule());
        }

        #endregion
    }

    class StepBackModule : BaseModule, IEngineModule
    {
        public IEngine CreateEngine()
        {
            return new EngineStepBack();
        }

        public override string Name
        {
            get { return typeof(Module).Namespace + "-StepBack"; }
        }
    }

    class StepForwardModule : BaseModule, IEngineModule
    {
        public IEngine CreateEngine()
        {
            return new EngineSteps();
        }

        public override string Name
        {
            get { return typeof(Module).Namespace + "-StepForward"; }
        }
    }
}