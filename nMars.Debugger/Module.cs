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
                ComponentSetup setup=new ComponentSetup();
                setup.LoadEngine("nMars.Engine", "nMars.Engine-Async");
                
                Project project=new Project();
                project.ParserOptions.Brief = true;
                
                return CommandLine.DebuggerMain(args, setup, project);
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