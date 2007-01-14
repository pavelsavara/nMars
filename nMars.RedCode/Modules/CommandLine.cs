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
    /// <summary>
    /// Event of parsing commandline parameters
    /// </summary>
    public delegate void ParseArgsDelegate(Project project, string[] args, ref int position, ref bool processed);
    /// <summary>
    /// Event of printing help and logos
    /// </summary>
    public delegate void CommandlineEventDelegate(ISimpleOutput console);

    /// <summary>
    /// Commandline user interface, customizable thru events and configuration file
    /// </summary>
    public class CommandLine
    {
        /// <summary>
        /// Main procedure of commandline user interface
        /// </summary>
        public static Project Prepare(string[] args, ComponentLoader components, ISimpleOutput console, out bool interactive, out string saveProjectFile)
        {
            bool nologo;
            saveProjectFile=null;
            interactive=false;

            Project project;
            try
            {
                project = ParseArguments(args, out nologo, out interactive, out saveProjectFile, components);
            }
            catch(ArgumentException ex)
            {
                if (ex.Message == "versions")
                {
                    PrintVersions(console);
                }
                else if (ex.Message == "help")
                {
                    PrintHelp(console);
                }
                else if (ex.Message == "Please provide valid arguments")
                {
                    PrintHelp(console);
                    console.WriteLine("");
                    console.ErrorWriteLine(ex.Message);
                }
                else
                {
                    console.ErrorWriteLine(ex.Message);
                }
                return null;
            }

            if (project.WarriorFiles.Count == 0)
            {
                PrintHelp(console);
                return null;
            }

            if (!nologo)
                PrintLogo(console);

            return project;
        }
        public static ParseResult Parse(ComponentLoader components, ISimpleOutput console, Project project)
        {
            if (project == null)
            {
                return null;
            }

            if (components.Parser != null)
            {
                return components.Parser.Parse(project, console);
            }
            else
            {
                console.ErrorWriteLine("Parser not found:" + components.ParserName);
                return null;
            }
        }

        public static void Run(ComponentLoader components, ISimpleOutput console, Project project)
        {
            if (project.Rules.Rounds > 0)
            {
                if (components.Engine != null)
                {
                    components.Engine.Run(project, console);
                }
                else
                {
                    console.ErrorWriteLine("Engine not found:" + components.EngineName);
                }
            }
        }

        #region Parse Arguments

        public static event ParseArgsDelegate ParseArgsEvent;


        /// <summary>
        /// Parse pmars compatible commandline options
        /// </summary>
        /// <param name="args">pmars compatible arguments</param>
        /// <returns></returns>
        public static Project ParseArguments(string args)
        {
            bool nologo;
            bool interactive;
            string saveProjectFile;
            string[] argsar = args.Split(separ);
            return ParseArguments(argsar, out nologo, out interactive, out saveProjectFile, null);
        }
        private static readonly char[] separ = { ' ', '\t', '\r', '\n' };

        /// <summary>
        /// Parse pmars compatible commandline options
        /// </summary>
        public static Project ParseArguments(string[] args, out bool nologo, out bool interactive, out string saveProjectFile, ComponentLoader components)
        {
            Project project = new Project();
            saveProjectFile = null;
            nologo = false;
            interactive = false;

            if (args.Length == 0)
            {
                throw new ArgumentException("Please provide valid arguments");
            }

            for (int p = 0; p < args.Length; p++)
            {
                string param = args[p];
                switch (param)
                {
                    case "-h":
                        throw new ArgumentException("help");
                    case "-v":
                        throw new ArgumentException("versions");
                    case "-e":
                        interactive = true;
                        break;
                    case "-p":
                        ReadNumber(args, ref p, out project.Rules.MaxProcesses);
                        break;
                    case "-s":
                        ReadNumber(args, ref p, out project.Rules.CoreSize);
                        break;
                    case "-r":
                        ReadNumber(args, ref p, out project.Rules.Rounds);
                        break;
                    case "-c":
                        ReadNumber(args, ref p, out project.Rules.MaxCycles);
                        break;
                    case "-l":
                        ReadNumber(args, ref p, out project.Rules.MaxLength);
                        break;
                    case "-d":
                        ReadNumber(args, ref p, out project.Rules.MinDistance);
                        break;
                    case "-S":
                        ReadNumber(args, ref p, out project.Rules.PSpaceSize);
                        break;
                    case "-ue":
                        if (args.Length < p + 1)
                        {
                            throw new ArgumentException("Invalid parameter -ue");
                        }
                        p++;
                        project.ParserOptions.DumpExt = args[p];
                        project.ParserOptions.DumpFiles = true;
                        break;
                    case "-@":
                        if (args.Length < p + 1)
                        {
                            throw new ArgumentException("Invalid parameter -@ missing argument");
                        }
                        p++;
                        if (!File.Exists(args[p]))
                        {
                            throw new ArgumentException("Invalid file name -@" + args[p]);
                        }
                        project = Project.ImportPmars(args[p]);
                        nologo = project.ParserOptions.Brief;
                        break;
                    case "-@l":
                        if (args.Length < p + 1)
                        {
                            throw new ArgumentException("Invalid parameter -@x missing argument");
                        }
                        p++;
                        if (!File.Exists(args[p]))
                        {
                            throw new ArgumentException("Invalid file name -@x" + args[p]);
                        }
                        project = Project.LoadXml(args[p]);
                        nologo = project.ParserOptions.Brief;
                        break;
                    case "-@s":
                        if (args.Length < p + 1)
                        {
                            throw new ArgumentException("Invalid parameter -@x missing argument");
                        }
                        p++;
                        saveProjectFile = args[p];
                        break;
                    case "-nP":
                        if (args.Length < p + 1)
                        {
                            throw new ArgumentException("Invalid parameter -@nP missing argument");
                        }
                        p++;
                        components.ParserName = args[p];
                        components.Parser = null;
                        break;
                    case "-nE":
                        if (args.Length < p + 1)
                        {
                            throw new ArgumentException("Invalid parameter -@nE missing argument");
                        }
                        p++;
                        components.EngineName = args[p];
                        components.Engine = null;
                        break;
                    case "-uo":
                        project.ParserOptions.Offset = true;
                        break;
                    case "-b":
                        project.ParserOptions.Brief = true;
                        project.ParserOptions.StatusLine = false;
                        project.ParserOptions.Header = false;
                        nologo = true;
                        break;
                    case "-bs":
                        project.ParserOptions.StatusLine = !project.ParserOptions.StatusLine;
                        break;
                    case "-bh":
                        project.ParserOptions.Header = !project.ParserOptions.Header;
                        break;
                    case "-bl":
                        nologo = true;
                        break;
                    case "-f":
                        int fix;
                        ReadNumber(args, ref p, out fix);
                        project.EngineOptions.ForcedAddresses=new List<int>();
                        project.EngineOptions.ForcedAddresses.Add(0);
                        project.EngineOptions.ForcedAddresses.Add(fix);
                        break;
                    case "-br":
                        nologo = true;
                        project.EngineOptions.DumpResults = false;
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
                        bool processed = false;
                        if (ParseArgsEvent!=null)
                            ParseArgsEvent.Invoke(project, args, ref p, ref processed);

                        if (!processed)
                        {
                            if (File.Exists(param))
                            {
                                project.WarriorFiles.Add(param);
                                project.Rules.WarriorsCount = project.WarriorFiles.Count;
                            }
                            else
                            {
                                if (param.StartsWith("-"))
                                {
                                    throw new ArgumentException("Invalid parameter " + param);
                                }
                                else
                                {
                                    throw new ArgumentException("Invalid file name " + Path.GetFullPath(param));
                                }
                            }
                        }
                        break;
                }
            }

            return project;
        }

        private static bool ReadNumber(string[] args, ref int p, out int number)
        {
            if (args.Length < p + 1 || !Int32.TryParse(args[p + 1], out number))
            {
                throw new ArgumentException("Invalid parameter " + args[p]);
            }
            p++;
            return true;
        }

        #endregion

        #region Help

        public static event CommandlineEventDelegate DumpHelpEvent;
        public static event CommandlineEventDelegate DumpLogoEvent;

        private static void PrintVersions(ISimpleOutput console)
        {
            string version = ModuleRegister.GetVersionInfo();
            string logo = "http://sourceforge.net/projects/nmars\r\n\r\n" +
                "2007 Published under LGPL http://www.gnu.org/licenses/lgpl.txt\r\n" + "by Pavel Savara (pavel.savara@gmail.com)\r\n\r\n";
            console.WriteLine(logo + version);
        }

        private static void PrintHelp(ISimpleOutput console)
        {
            PrintLogo(console);
            console.WriteLine("");
            console.WriteLine("Usage: nMars.exe [options] file1 [files ..]");
            console.WriteLine("");
            console.WriteLine("General:");
            console.WriteLine("  -@  file  load options from text file (pMars compatible)");
            console.WriteLine("  -@l file  load project from xml file");
            console.WriteLine("  -@s file  save project to xml file, (use .nmproj extension)");
            console.WriteLine("  -nP name  Change parser component");
            console.WriteLine("  -nE name  Change engine component");
            console.WriteLine("  -v        Component versions");
            console.WriteLine("");
            console.WriteLine("Rules:");
            console.WriteLine("  -r #      Rounds to play [1]");
            console.WriteLine("  -s #      Size of core [8000]");
            console.WriteLine("  -c #      Cycles until tie [80000]");
            console.WriteLine("  -p #      Max. processes [8000]");
            console.WriteLine("  -l #      Max. warrior length [100]");
            console.WriteLine("  -d #      Min. warriors distance");
            console.WriteLine("  -S #      Size of P-space [500]");
            console.WriteLine("  -f #      Fixed position series");
            console.WriteLine("");
            console.WriteLine("Dumps:");
            console.WriteLine("  -b        Brief/silent parser mode");
            console.WriteLine("  -bh       No header");
            console.WriteLine("  -bl       No logo");
            console.WriteLine("  -bs       No status");
            console.WriteLine("  -br       No match results");
            console.WriteLine("  -ue .ext  Dump warriors to files with extension");
            console.WriteLine("  -uo       Dump format with offset [off]");
            console.WriteLine("  -ul       Dump format with labels [off]");
            console.WriteLine("  -uc       Dump format with comments [off]");
            console.WriteLine("  -ux       Dump format xml");
            if (DumpHelpEvent != null)
                DumpHelpEvent.Invoke(console);
            console.WriteLine("");
        }

        private static void PrintLogo(ISimpleOutput console)
        {
            console.WriteLine("nMars.exe " + new Module().Version + " - http://sourceforge.net/projects/nmars");
            if (DumpLogoEvent != null)
                DumpLogoEvent.Invoke(console);
            console.WriteLine("");
        }

        #endregion
    }
}