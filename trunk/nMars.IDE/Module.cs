// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode.Modules;
using nMars.RedCode.Utils;

namespace nMars.IDE
{
    class Module : BaseModule
    {
        [STAThread]
        public static int Main(string[] args)
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            if (Mono.IsMonoRuntime)
            {
                Console.WriteLine("Running on mono, some features will be disabled.");
            }

            IDEApplication app = new IDEApplication();
            return app.Main(args);
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}