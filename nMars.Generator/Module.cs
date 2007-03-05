// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode.Modules;

namespace nMars.Generator
{
    class Module : BaseModule
    {
        public static int Main(string[] args)
        {
            //EngineTest et=new EngineTest();
            Gen et = new Gen();
            et.Generate();
            return 0;
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}