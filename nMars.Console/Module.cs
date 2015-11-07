// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.Console.Properties;
using nMars.RedCode;
using nMars.RedCode.Modules;
using nMars.RedCode.Utils;

namespace nMars.Console
{
    class Module : BaseModule, IModule
    {
        static int Main(string[] args)
        {
            try
            {
                return ConsoleApplication.ConsoleMain(args);
            }
            catch (Exception ex)
            {
                return ExceptionHandler.DumpException(ex);
            }
        }


        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}