// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Debugger
{
    class Module : IDebuggerModule
    {
        public static int Main(string[] args)
        {
            try
            {
                return CommandLine.DebuggerMain(args, "nMars.Engine", "nMars.Engine-StepBack", "nMars.Parser", "nMars.Parser", "nMars.Debugger", "nMars.Debugger");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                return -1;
            }
        }

        public IDebugger CreateDebugger()
        {
            return new Debugger();
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
            ModuleRegister.Register(new DebuggerShellModule());
        }

        public string Name
        {
            get { return typeof(Module).Namespace; }
        }

        #endregion
    }

    class DebuggerShellModule : IDebuggerShellModule
    {
        public IDebuggerShell CreateShell()
        {
            return new DebuggerShell();
        }

        public string Name
        {
            get { return typeof(Module).Namespace + "-Shell"; }
        }
    }
}