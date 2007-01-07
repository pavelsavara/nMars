// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Test
{
    class Module : BaseModule, IEngineModule
    {
        public static int Main(string[] args)
        {
            try
            {
                int res = 0;
                if (args.Length!=0)
                {
                    ComponentLoader components = EngineTest.InitComponents();
                    WrappedConsole console = new WrappedConsole();
                    Project project = CommandLine.Prepare(args, components, console);
                    if (project!=null)
                    {
                        project.EngineOptions.DumpResults = false;
                        project.EngineOptions.StatusLine = false;
                        project.ParserOptions.Brief = true;
                        project.ParserOptions.StatusLine = false;
                    }
                    res = CommandLine.Exec(components, console, project);
                }
                else
                {
                    //MainParser();
                    MainEngine();
                }
                if (res == 0)
                    Console.WriteLine("No errors");
                return res;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.WriteLine();
                Console.Error.WriteLine(ex.StackTrace);
                return -255;
            }
        }

        public static void MainEngine()
        {
            EngineTest test = new EngineTest();
            //test.Single();
            test.Pair();
            test.Random(100000);
            test.Full();
        }

        public static void MainParser()
        {
            ParserTest test = new ParserTest();
            test.Full();
        }


        public IEngine CreateEngine()
        {
            return CreateEngine();
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}