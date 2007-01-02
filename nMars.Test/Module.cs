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
            if (args.Length == 0)
            {
                try
                {
                    //MainParser();
                    MainEngine();
                    return 0;
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                    Console.Error.WriteLine();
                    Console.Error.WriteLine(ex.StackTrace);
                    return -1;
                }
            }
            else
            {
                return CommandLine.EngineMain(args, null, null);
            }
        }

        public static void MainEngine()
        {
            EngineTest test = new EngineTest();
            test.Random(10000);
            test.Full();
        }

        public static void MainParser()
        {
            ParserTest test = new ParserTest();
            test.Full();
        }

        public IEngine CreateEngine()
        {
            return new ComparingEngine();
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}