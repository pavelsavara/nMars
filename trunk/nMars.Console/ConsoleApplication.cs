using System;
using System.Collections.Generic;
using System.Text;
using nMars.Console.Properties;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Console
{
    class ConsoleApplication
    {
        public static int ConsoleMain(string[] args)
        {
            WrappedConsole console = new WrappedConsole();

            ConsoleCfg consoleConfig = new ConsoleCfg();
            consoleConfig.Reload();
            LoadPlugins(consoleConfig);

            ComponentLoader components = new ComponentLoader();
            components.ParserName = consoleConfig.DefaultParser;
            components.EngineName = consoleConfig.DefaultEngine;

            bool interactive;
            string saveProjectFile;
            Project project = CommandLine.Prepare(args, components, console, out interactive, out saveProjectFile);
            if (project == null)
                return -1;
            if (interactive)
            {
                if (consoleConfig.KnownComponents.Contains("nMars.ShellPy"))
                {
                    IShell shellpy = ModuleRegister.CreateShell("nMars.ShellPy");
                    Shells.Add(shellpy);
                }
                components.EngineName = consoleConfig.DefaultDebugEngine;
                IShell defaultShell = null;
                foreach (IShell shell in Shells)
                {
                    shell.Attach(console, Shells);
                    shell.Project = project;
                    shell.Components = components;
                    shell.PrintErrors = true;
                    shell.Engine = components.AsyncEngineWrapper;
                    shell.Register(components.AsyncEngineWrapper, "engine");
                    if (shell.Module.Name == components.ShellName)
                    {
                        defaultShell = shell;
                    }
                }
                console.Inject("step");
                console.Interactive();
                foreach (IShell shell in Shells)
                {
                    shell.Detach();
                }
            }
            else
            {
                ParseResult result = CommandLine.Parse(components, console, project);
                if (result == null || !result.Succesfull)
                    return -2;

                CommandLine.Run(components, console, project);
            }
            if (saveProjectFile != null)
                project.SaveXml(saveProjectFile);
            return 0;
        }

        private static void LoadPlugins(ConsoleCfg consoleConfig)
        {
            if (consoleConfig.KnownComponents == null)
            {
                List<string> known = new List<string>();
                known.Add("nMars.Parser");
                known.Add("nMars.Engine");
                known.Add("nMars.Debugger");
                known.Add("nMars.ShellPy");
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
