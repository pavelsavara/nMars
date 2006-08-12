using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using nMars.Parser;
using nMars.RedCode;
using nMars.SimpleEngine;

namespace Starter
{
    internal class Program
    {
        private static void LoaderTest()
        {
            List<IWarrior> wariors = new List<IWarrior>();
            RedCodeParser parser = new RedCodeParser(Rules.DefaultRules);
            XmlSerializer ser = new XmlSerializer(typeof (ExtendedWarrior));

            foreach (string s in Directory.GetFiles(@"..\..\..\rc", "*.rc", SearchOption.AllDirectories))
            {
                Console.WriteLine("Reading {0}", s);
                wariors.Add(LoadDumpOne(s, parser, ser));
            }
        }

        private static IWarrior LoadDumpOne(string s, RedCodeParser parser, XmlSerializer ser)
        {
            IWarrior w = null;
            try
            {
                w = parser.Load(s);
                IExtendedWarrior exw = w as IExtendedWarrior;

                if (ser != null)
                {
                    StreamWriter sw = new StreamWriter(Path.ChangeExtension(s, ".xml"));
                    ser.Serialize(sw, w);
                    sw.Close();
                }

                StreamWriter swd = new StreamWriter(Path.ChangeExtension(s, ".dmp"));
                if (exw != null)
                {
                    exw.Dump(swd);
                }
                else
                {
                    w.Dump(swd);
                }
                swd.Close();
            }
            catch (ParserException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return w;
        }

        private static void Main()
        {
            Rules rules = new Rules();
            rules.CoreSize = 40;
            Engine se = new Engine();
            RedCodeParser parser = new RedCodeParser(rules);
            List<IWarrior> rr = new List<IWarrior>();
            List<int> forcedaddr=new List<int>();
            rr.Add(parser.Load(@"D:\Zamboch\Zdrojaky\nMars\rc\redcoder\stone.rc"));
            forcedaddr.Add(10);
            //rr.Add(parser.Load(@"..\..\..\rc\blur\Ikarus.rc"));
            //rr.Add(parser.Load(@"..\..\..\rc\scanner\mischief.rc"));
            PSpaces spaces = new PSpaces();
            Random r = new Random(0);
            se.Run(rr, rules, spaces, r, forcedaddr);
        }
    }
}