// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;
using nMars.RedCode.Utils;

namespace nMars.Screensaver
{
    class Module : BaseModule
    {
        public static int Main(string[] args)
        {
            string param = "/s";
            if (args.Length>0)
                param = args[0];
            switch(param)
            {
                case "/s":

                    try
                    {
                        return ScreensaverApplication.ScreensaverMain();
                    }
                    catch (Exception ex)
                    {
                        return ExceptionHandler.DumpException(ex);
                    }
                    
                    
                    break;
                case "/p":
                    break;
                case "/c":
                    break;
            }
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