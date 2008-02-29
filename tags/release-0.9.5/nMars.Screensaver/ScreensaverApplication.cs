// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using nMars.Screensaver.Properties;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Screensaver
{
    class ScreensaverApplication
    {
        public static int ScreensaverMain()
        {
            ScreensaverCfg screensaverCfg = new ScreensaverCfg();
            screensaverCfg.Reload();
            LoadPlugins(screensaverCfg);

            ComponentLoader components = new ComponentLoader();
            components.ParserName = screensaverCfg.DefaultParser;
            components.EngineName = screensaverCfg.DefaultEngine;

            bool interactive;
            string saveProjectFile;
            Project project = CommandLine.Prepare(new string[] { "-@l", screensaverCfg.Project }, components, null, out interactive, out saveProjectFile);
            if (project == null)
                return -1;
            if (project.EngineOptions.EngineMode != EngineMode.Match)
            {
                project.Rules.WarriorsCount = 2;
            }

            ParseResult result = CommandLine.Parse(components, null, project);
            if (result == null || !result.Succesfull)
                return -2;

            CommandLine.Run(components, null, project);

            return 0;
        }

        private static void LoadPlugins(ScreensaverCfg consoleConfig)
        {
            if (consoleConfig.KnownComponents == null)
            {
                List<string> known = new List<string>();
                known.Add("nMars.Parser");
                known.Add("nMars.Engine");
                consoleConfig["KnownComponents"] = known;
            }

            foreach (string component in consoleConfig.KnownComponents)
            {
                if (component!="nMars.ShellPy") //is slow
                {
                    IModule module = ModuleRegister.FindModule(component);
                    IShellModule shellModule = module as IShellModule;
                    if (shellModule != null)
                    {
                        IShell shell = shellModule.CreateShell();
                        Shells.Add(shell);
                    }
                }
            }
        }

        private static List<IShell> Shells = new List<IShell>();
    }
}
