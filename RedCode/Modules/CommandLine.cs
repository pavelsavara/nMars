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
            Rules rules=new Rules();
            List<string> files=new List<string>();
            bool dump = false;

            for(int p=0;p<args.Length;p++)
            {
                string param = args[p];
                switch(param)
                {
                    case "-h":
                        Console.WriteLine("Usage : "+parserModule.Executable+" [options] file1 [files]\n");
                        Console.WriteLine("Options :\n");
                        Console.WriteLine("-h   this help page\n");
                        Console.WriteLine("-p # Max. processes [8000]\n");
                        Console.WriteLine("-s # Size of core [8000]\n");
                        Console.WriteLine("\n");
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
                        dump = true;
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
                if (dump)
                {
                    StreamWriter sw =new StreamWriter(Path.ChangeExtension(file, ".dmp"));
                    warrior.Dump(sw);
                    sw.Close();
                }
            }
            return 0;
        }

        public static int EngineMain(string[] args, string engineName)
        {
            throw new NotImplementedException();
        }
    }
}
