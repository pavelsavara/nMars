using System;
using System.Collections.Generic;
using System.IO;
using nMars.RedCode.Modules;

namespace nMars.RedCode.CommandLine
{
    public class CommandLine
    {
        public static int ParserMain(string[] args, string parserName)
        {
            IParserModule parserModule = ModuleRegister.FindModule(parserName) as IParserModule;

            if (args.Length == 0)
            {
                PrintParserHelp(parserModule.Executable);
                return 0;
            }

            Rules rules=new Rules();
            List<string> files=new List<string>();
            bool dumpFiles = false;
            DumpOptions options=new DumpOptions();
            string dumpext = ".dmp";

            for(int p=0;p<args.Length;p++)
            {
                string param = args[p];
                switch(param)
                {
                    case "-h":
                        PrintParserHelp(parserModule.Executable);
                        return 0;
                    case "-p":
                        if(args.Length<p+1 || !Int32.TryParse(args[p+1], out rules.maxProcesses) )
                        {
                            Console.WriteLine("Invalid parameter -p");
                            return -1;
                        }
                        p++;
                        break;
                    case "-s":
                        if (args.Length < p + 1 || !Int32.TryParse(args[p + 1], out rules.coreSize))
                        {
                            Console.WriteLine("Invalid parameter -s");
                            return -1;
                        }
                        p++;
                        break;
                    case "-u":
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
                        options.Offset = true;
                        break;
                    case "-ul":
                        options.Labels = true;
                        break;
                    case "-uc":
                        options.Comments = true;
                        break;
                    default:
                        if (File.Exists(param))
                        {
                            files.Add(param);
                        }
                        else
                        {
                            Console.WriteLine("Invalid file name "+param);
                            return -1;
                        }
                        break;
                }
            }
            IParser parser = parserModule.CreateParser(rules);
            foreach (string file in files)
            {
                IWarrior warrior = parser.Parse(file);
                if (dumpFiles)
                {
                    StreamWriter sw =new StreamWriter(Path.ChangeExtension(file, dumpext));
                    warrior.Dump(sw, options);
                    sw.Close();
                }
                else
                {
                    warrior.Dump(Console.Out, options);
                }
            }
            return 0;
        }

        private static void PrintParserHelp(string execName)
        {
            Console.WriteLine("Usage   : "+execName+" [options] file1 [files]");
            Console.WriteLine();
            Console.WriteLine("Options :");
            Console.WriteLine("-h        This help page");
            Console.WriteLine("-p #      Max. processes [8000]");
            Console.WriteLine("-s #      Size of core [8000]");
            Console.WriteLine("-u .ext   Dump to files with extension");
            Console.WriteLine("-uo       Dump with offset [off]");
            Console.WriteLine("-ul       Dump with labels [off]");
            Console.WriteLine("-uc       Dump with comments [off]");
            Console.WriteLine();
        }

        public static int EngineMain(string[] args, string engineName)
        {
            throw new NotImplementedException();
        }
    }
}
