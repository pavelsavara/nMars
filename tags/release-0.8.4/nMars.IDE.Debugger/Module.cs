// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.IDE.Debugger
{
    class Module : BaseModule, IIDEPluginModule, IShellModule
    {
        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion

        public IIDEPlugin CreateIDEPlugin()
        {
            if (application==null)
            {
                application = new IDEDebuggerApplication();
                application.Module = this;
            }
            return application;
        }

        public IShell CreateShell()
        {
            if (application == null)
            {
                application = new IDEDebuggerApplication();
                application.Module = this;
            }
            return application;
        }

        private static IDEDebuggerApplication application;
    }
}