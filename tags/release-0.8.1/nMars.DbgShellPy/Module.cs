// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.DbgShellPy
{
    class Module : BaseModule, IDebuggerShellModule
    {
        public IDebuggerShell CreateShell()
        {
            return new DebuggerShellPy();
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}