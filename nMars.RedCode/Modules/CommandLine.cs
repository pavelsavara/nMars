// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    public class CommandLine
    {
        public static int ParserMain(string[] args, ComponentSetup setup, IProject project)
        {
            int res;
            List<string> files;
            if (setup == null)
                setup = new ComponentSetup();
            if (project == null)
                project = new Project();

            res = ParseParams(args, out files, project);
            if (res <= 0)
                return res;

            res = RunParser(files, setup.Parser, project);
            return res;
        }

        public static int EngineMain(string[] args, ComponentSetup setup, IProject project)
        {
            int res;
            List<string> files;
            if (setup == null)
                setup = new ComponentSetup();
            if (project == null)
                project = new Project();

            res = ParseParams(args, out files, project);
            if (res <= 0)
                return res;

            project.Rules.WarriorsCount = files.Count;
            res = RunParser(files, setup.Parser, project);
            if (res <= 0)
                return res;

            MatchResult match = setup.Engine.Run(project);
            match.Dump(Console.Out, project);
            return 0;
        }

        public static int DebuggerMain(string[] args, ComponentSetup setup, IProject project)
        {
            int res;
            List<string> files;
            if (setup == null)
                setup = new ComponentSetup();
            if (project == null)
                project = new Project();

            IDebuggerEngine engine = setup.Engine as IDebuggerEngine;
            if (engine == null)
                throw new ApplicationException("Unable to create DebuggerEngine");

            res = ParseParams(args, out files, project);
            if (res <= 0)
                return res;

            project.Rules.WarriorsCount = files.Count;
            res = RunParser(files, setup.Parser, project);
            if (res <= 0)
                return res;
            setup.Debugger.Init(engine, null, null);
            MatchResult match = setup.Debugger.Run(project);
            match.Dump(Console.Out, project);
            return 0;
        }

        private static int RunParser(List<string> files, IParser parser, IProject project)
        {
            parser.InitParser(project.Rules);
            foreach (string file in files)
            {
                IWarrior warrior = parser.Parse(file, Console.Error);
                if (warrior == null)
                    return -1;
                if (project.ParserOptions.DumpFiles)
                {
                    StreamWriter sw = new StreamWriter(Path.ChangeExtension(file, project.ParserOptions.DumpExt));
                    warrior.Dump(sw, project.ParserOptions);
                    sw.Close();
                }
                if (!project.ParserOptions.Brief)
                {
                    warrior.Dump(Console.Out, project.ParserOptions);
                }
                project.Warriors.Add(warrior);
            }
            return project.Warriors.Count;
        }

        private static int ParseParams(string[] args, out List<string> files, IProject project)
        {
            files = new List<string>();

            if (args.Length == 0)
            {
                PrintParserHelp();
                return 0;
            }

            for (int p = 0; p < args.Length; p++)
            {
                string param = args[p];
                switch (param)
                {
                    case "-h":
                        PrintParserHelp();
                        return 0;
                    case "-p":
                        if (!ReadNumber(args, ref p, out project.Rules.MaxProcesses))
                        {
                            return -1;
                        }
                        break;
                    case "-s":
                        if (!ReadNumber(args, ref p, out project.Rules.CoreSize))
                        {
                            return -1;
                        }
                        break;
                    case "-r":
                        if (!ReadNumber(args, ref p, out project.Rules.Rounds))
                        {
                            return -1;
                        }
                        break;
                    case "-c":
                        if (!ReadNumber(args, ref p, out project.Rules.MaxCycles))
                        {
                            return -1;
                        }
                        break;
                    case "-l":
                        if (!ReadNumber(args, ref p, out project.Rules.MaxLength))
                        {
                            return -1;
                        }
                        break;
                    case "-d":
                        if (!ReadNumber(args, ref p, out project.Rules.MinDistance))
                        {
                            return -1;
                        }
                        break;
                    case "-S":
                        if (!ReadNumber(args, ref p, out project.Rules.PSpaceSize))
                        {
                            return -1;
                        }
                        break;
                    case "-ue":
                        if (args.Length < p + 1)
                        {
                            Console.WriteLine("Invalid parameter -u");
                            return -1;
                        }
                        p++;
                        project.ParserOptions.DumpExt = args[p];
                        project.ParserOptions.DumpFiles = true;
                        break;
                    case "-uo":
                        project.ParserOptions.Offset = true;
                        break;
                    case "-b":
                        project.ParserOptions.Brief = true;
                        break;
                    case "-ul":
                        project.ParserOptions.Labels = true;
                        break;
                    case "-ux":
                        project.ParserOptions.XmlFormat = true;
                        break;
                    case "-uc":
                        project.ParserOptions.Comments = true;
                        break;
                    default:
                        if (File.Exists(param))
                        {
                            files.Add(param);
                        }
                        else
                        {
                            Console.WriteLine("Invalid file name " + param);
                            return -1;
                        }
                        break;
                }
            }
            project.Rules.WarriorsCount = files.Count;
            return files.Count;
        }

        private static bool ReadNumber(string[] args, ref int p, out int number)
        {
            if (args.Length < p + 1 || !Int32.TryParse(args[p + 1], out number))
            {
                Console.WriteLine("Invalid parameter " + args[p]);
                number = -1;
                return false;
            }
            p++;
            return true;
        }

        private static void PrintParserHelp()
        {
            Console.WriteLine("Usage   : nMars.Module.exe [options] file1 [files]");
            Console.WriteLine();
            Console.WriteLine("Rules :");
            Console.WriteLine("  -r # Rounds to play [1]");
            Console.WriteLine("  -s # Size of core [8000]");
            Console.WriteLine("  -c # Cycles until tie [80000]");
            Console.WriteLine("  -p # Max. processes [8000]");
            Console.WriteLine("  -l # Max. warrior length [100]");
            Console.WriteLine("  -d # Min. warriors distance");
            Console.WriteLine("  -S # Size of P-space [500]");
            Console.WriteLine();
            Console.WriteLine("Parser :");
            Console.WriteLine("  -b        Brief/silent parser mode");
            Console.WriteLine("  -ue .ext  Dump to files next by original warrior with extension");
            Console.WriteLine("  -uo       Dump with offset [off]");
            Console.WriteLine("  -ul       Dump with labels [off]");
            Console.WriteLine("  -uc       Dump with comments [off]");
            Console.WriteLine("  -ux       Dump xml");
            Console.WriteLine();
        }
    }
}