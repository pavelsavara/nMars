// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using nMars.RedCode;

namespace nMars
{
    public class pMarsParser : ParserRoot
    {
        public pMarsParser(Rules rules)
        {
            this.rules = rules;
        }

        public override IWarrior Parse(string fileName, TextWriter err)
        {
            StringBuilder agrs = new StringBuilder();
            agrs.Append("-r 0 -k ");
            agrs.Append("-p ");
            agrs.Append(rules.maxProcesses.ToString());
            agrs.Append(" -s ");
            agrs.Append(rules.coreSize.ToString());
            agrs.Append(" -c ");
            agrs.Append(rules.maxCycles.ToString());
            agrs.Append(" -l ");
            agrs.Append(rules.maxLength.ToString());
            agrs.Append(" -d ");
            agrs.Append(rules.minDistance.ToString());
            agrs.Append(" -S ");
            agrs.Append(rules.pSpaceSize.ToString());
            agrs.Append(" ");
            agrs.Append(Path.GetFileName(fileName));

            Process pmarsv = new Process();
            pmarsv.StartInfo = new ProcessStartInfo(pmarsvPath, agrs.ToString());
            pmarsv.StartInfo.UseShellExecute = false;
            pmarsv.StartInfo.RedirectStandardOutput = true;
            pmarsv.StartInfo.RedirectStandardError = true;
            pmarsv.StartInfo.WorkingDirectory = Path.GetDirectoryName(fileName);
            try
            {
                pmarsv.Start();
                pmarsv.WaitForExit();
            }
            catch(Exception ex)
            {
                err.WriteLine("PMARSV.EXE wrapper exited with exception " + ex.ToString() + "\n");
                return null;
            }
            if (pmarsv.ExitCode != 0)
            {
                err.WriteLine("PMARSV.EXE exited with error #" + pmarsv.ExitCode.ToString() + "\n");
                string errline = pmarsv.StandardError.ReadLine();
                while (errline != null)
                {
                    err.WriteLine(errline);
                    errline = pmarsv.StandardError.ReadLine();
                }
                pmarsv.StandardOutput.Close();
                pmarsv.StandardError.Close();
                return null;
            }
            Warrior warrior = new Warrior(rules);
            warrior.Name = Path.GetFileNameWithoutExtension(fileName);

            string line = pmarsv.StandardOutput.ReadLine();
            while (line != null)
            {
                ParseLine(line, warrior);
                line = pmarsv.StandardOutput.ReadLine();
            }
            pmarsv.StandardError.Close();
            pmarsv.StandardOutput.Close();
            if (warrior.Length==0)
            {
                return null;
            }
            return warrior;
        }

        private void ParseLine(string line, Warrior warrior)
        {
            if (line.Length == 0) return;
            if (line.StartsWith("Program "))
            {
                string[] arr = line.Split('"');
                warrior.Name = arr[1];
                warrior.Author = arr[3];
                return;
            }
            if (line.StartsWith("       ORG")) return;

            string label = line.Substring(0, 7);
            string operation = line.Substring(7, 3);
            string modifier = line.Substring(11, 2);
            string modeA = line.Substring(14, 1);
            string valueA = line.Substring(15, 6);
            string modeB = line.Substring(23, 1);
            string valueB = line.Substring(24, 6);
            Operation op = OperationHelper.Parse(operation);
            Modifier modi = (Modifier) Enum.Parse(typeof (Modifier), modifier);
            Mode modA = ModeHelper.Parse(modeA);
            Mode modB = ModeHelper.Parse(modeB);
            int valA = Int32.Parse(valueA);
            int valB = Int32.Parse(valueB);
            if (label == "START  ")
            {
                warrior.StartOffset = warrior.Length;
            }
            Instruction instr = new Instruction(op, modi, modA, valA, modB, valB);
            warrior.Instructions.Add(instr);
        }

        private string pmarsvPath
        {
            get
            {
                string module = typeof (pMarsParser).Assembly.Location;
                string path=Path.Combine(Path.GetDirectoryName(module), pmarsvName);
                if (File.Exists(path)) return path;
                path = Path.Combine(Directory.GetCurrentDirectory(), pmarsvName);
                if (File.Exists(path)) return path;
                return pmarsvName;
            }
        }

        private static string pmarsvName = "PMARSV.EXE";
    }
}