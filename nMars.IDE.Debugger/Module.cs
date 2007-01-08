// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.IDE.Debugger
{
    class Module : BaseModule, IIDEPluginModule
    {
        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion

        public IIDEPlugin CreateIDEPlugin()
        {
            return new IDEDebuggerApplication();
        }
    }
}