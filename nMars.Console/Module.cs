// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.Console.Properties;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Console
{
    public class Module : BaseModule, IModule
    {
        static int Main(string[] args)
        {
            try
            {
                ConsoleCfg consoleConfig = new ConsoleCfg();
                consoleConfig.Reload();
                ComponentLoader components=new ComponentLoader();
                components.ParserName = consoleConfig.DefaultParser;
                components.EngineName = consoleConfig.DefaultEngine;
                WrappedConsole console = new WrappedConsole();
                Project project = CommandLine.Prepare(args, components, console);
                return CommandLine.Exec(components, console, project);
            }
            catch (Exception ex)
            {
                System.Console.Error.WriteLine(ex.Message);
                System.Console.Error.WriteLine();
                System.Console.Error.WriteLine(ex.StackTrace);
                return -255;
            }
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}