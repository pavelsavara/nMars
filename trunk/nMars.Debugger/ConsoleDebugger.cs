using System;
using System.Collections.Generic;
using System.Text;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Debugger
{
    class ConsoleDebugger : Debugger
    {
        #region Operations

        public void Run(int brake)
        {
            Project.EngineOptions.Brake = brake;
            Run();
        }

        public void Run()
        {
            Start(false);
        }

        public override bool Step()
        {
            if (Engine==null || !Engine.IsLive)
            {
                Project.EngineOptions.Brake = slowRunBrake;
                Start(true);
                return true;
            }
            else
            {
                return base.Step();
            }
        }
        
        #endregion

        #region CommandLine

        static ConsoleDebugger()
        {
            CommandLine.DumpHelpEvent += new CommandlineEventDelegate(OnDumpHelpEvent);
        }

        static void OnDumpHelpEvent(ISimpleOutput console)
        {
            console.WriteLine("");
            console.WriteLine("Debugger:");
            console.WriteLine("  -e        Interactive debugger mode");
        }

        #endregion
    }
}
