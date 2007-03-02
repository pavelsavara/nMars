// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.Console.Properties;
using nMars.RedCode;
using nMars.RedCode.Modules;

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
                System.Console.Error.WriteLine(ex.StackTrace);
                do
                {
                    System.Console.Error.WriteLine();
                    System.Console.Error.WriteLine(ex.GetType().ToString());
                    System.Console.Error.WriteLine(ex.Message);
                    ex = ex.InnerException;
                    if (ex == null)
                        break;
                } while (true);
                return -255;
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