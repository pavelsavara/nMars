// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using nMars.RedCode;

namespace pMars.DllWrapper
{
    class pMarsDllParser : BaseParser
    {
        public pMarsDllParser()
        {
            //touch DLL
            pMarsDll.pMarsFreeParsed();
        }

        protected override IWarrior Parse(string fileName)
        {
            string errFileName = Path.GetTempFileName();

            List<string> r = pMarsDll.BuildParams(project.Rules, true, null, fileName);

            try
            {
                IntPtr warrirorPtr = pMarsDll.pMarsParse(r.Count, r.ToArray(), errFileName);
                pMarsDll.PmarsWarrior dllWarrior =
                    (pMarsDll.PmarsWarrior)Marshal.PtrToStructure(warrirorPtr, typeof(pMarsDll.PmarsWarrior));
                if (dllWarrior == null)
                {
                    result.Succesfull = false;
                    return null;
                }
                ParseError(fileName, errFileName);
                return pMarsDll.ConvertWarrior(fileName, dllWarrior, project.Rules);
            }
            catch (Exception ex)
            {
                StreamWriter err = new StreamWriter(errFileName, true);
                err.WriteLine("pMars.DllWrapper exited with exception " + ex + "\n");
                err.Close();
                result.Succesfull = false;
                return null;
            }
            finally
            {
                pMarsDll.pMarsFreeParsed();
            }
        }

        private bool ParseError(string fileName, string errFileName)
        {
            bool r = true;
            if (File.Exists(errFileName))
            {
                StreamReader sr = new StreamReader(errFileName);
                do
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        if (line.StartsWith("Error in line"))
                        {
                            int sep = line.IndexOf(':');

                            ParserMessage message = new ParserMessage();
                            message.Level = ParseMessageLevel.Error;
                            message.Message = line.Substring(sep + 1) + "\n" + sr.ReadLine();
                            message.FileName = fileName;
                            string num = line.Substring(13, sep - 13);
                            int.TryParse(num, out message.Line);
                            if (console != null && message.Level > project.ParserOptions.ErrorLevel)
                                console.ErrorWriteLine(message.Message);
                            r = false;
                        }
                        else if (line.StartsWith("Warning:"))
                        {
                            ParserMessage message = new ParserMessage();
                            message.Level = ParseMessageLevel.Warning;
                            message.Message = sr.ReadLine();
                            message.FileName = fileName;
                            if (console != null && message.Level > project.ParserOptions.ErrorLevel)
                                console.ErrorWriteLine(message.Message);
                        }
                        //else skip
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                sr.Close();
                File.Delete(errFileName);
            }
            return r;
        }
    }
}