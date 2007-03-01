// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.ShellPy
{
    class Module : BaseModule, IShellModule
    {
        public IShell CreateShell()
        {
            ShellPy py = new ShellPy();
            py.Module = this;
            return py;
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}