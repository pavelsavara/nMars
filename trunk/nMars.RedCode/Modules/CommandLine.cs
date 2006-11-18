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
        public static int ParserMain(string[] args, string parserName)
        {
            int res;
            string dumpext;
            bool dumpFiles;
            List<string> files;
            ParserOptions parserOptions;
            EngineOptions engineOptions;
            Project project = new Project();
            project.Rules = new Rules();

            res = ParseParams(args, out dumpext, out dumpFiles, out files, out parserOptions, out engineOptions, project, parserName);
            if (res <= 0)
                return res;

            res = RunParser(dumpext, dumpFiles, files, parserOptions, parserName, project);
            return res;
        }

        public static int EngineMain(string[] args, string engineName, string parserName)
        {
            int res;
            string dumpext;
            bool dumpFiles;
            List<string> files;
            ParserOptions parserOptions;
            EngineOptions engineOptions;
            Project project = new Project();
            project.Rules = new Rules();

            res = ParseParams(args, out dumpext, out dumpFiles, out files, out parserOptions, out engineOptions, project, engineName);
            if (res <= 0)
                return res;

            project.Rules.WarriorsCount = files.Count;
            res = RunParser(dumpext, dumpFiles, files, parserOptions, parserName, project);
            if (res <= 0)
                return res;
            IEngine engine = ModuleRegister.CreateEngine(engineName);
            MatchResult match = engine.Run(project, null);
            match.Dump(Console.Out, engineOptions, project);
            return 0;
        }

        private static int RunParser(string dumpext, bool dumpFiles, List<string> files, ParserOptions options,
                                     string parserName, Project project)
        {
            IParser parser = ModuleRegister.CreateParser(parserName);
            parser.InitParser(project.Rules);
            foreach (string file in files)
            {
                IWarrior warrior = parser.Parse(file, Console.Error);
                if (warrior == null)
                    return -1;
                if (dumpFiles)
                {
                    StreamWriter sw = new StreamWriter(Path.ChangeExtension(file, dumpext));
                    warrior.Dump(sw, options);
                    sw.Close();
                }
                if (!options.Brief)
                {
                    warrior.Dump(Console.Out, options);
                }
                project.Warriors.Add(warrior);
            }
            return project.Warriors.Count;
        }

        private static int ParseParams(string[] args, out string dumpext, out bool dumpFiles,
                                       out List<string> files, 
                                       out ParserOptions parserOptions, out EngineOptions engineOptions
                                       , Project project,
                                       string moduleName)
        {
            files = new List<string>();
            parserOptions = new ParserOptions();
            engineOptions = new EngineOptions();
            dumpFiles = false;
            dumpext = ".dmp";

            if (args.Length == 0)
            {
                PrintParserHelp(moduleName + ".exe");
                return 0;
            }

            for (int p = 0; p < args.Length; p++)
            {
                string param = args[p];
                switch (param)
                {
                    case "-h":
                        PrintParserHelp(moduleName + ".exe");
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
                        dumpext = args[p];
                        dumpFiles = true;
                        break;
                    case "-uo":
                        parserOptions.Offset = true;
                        break;
                    case "-b":
                        parserOptions.Brief = true;
                        break;
                    case "-ul":
                        parserOptions.Labels = true;
                        break;
                    case "-ux":
                        parserOptions.XmlFormat = true;
                        break;
                    case "-uc":
                        parserOptions.Comments = true;
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

        private static void PrintParserHelp(string execName)
        {
            Console.WriteLine("Usage   : " + execName + " [options] file1 [files]");
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