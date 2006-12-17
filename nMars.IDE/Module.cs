// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode.Modules;

namespace nMars.IDE
{
    class Module : BaseModule, IIDEModule
    {
        [STAThread]
        public static int Main(string[] args)
        {
            Application app = new Application();
            return app.Main();
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}