using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using nMars.Parser;
using nMars.Parser.Warrior;
using nMars.RedCode;
using NUnit.Framework;

namespace Parser.Test
{
    [TestFixture]
    public class ParserTest
    {
        [Test]
        public void Loader()
        {
            List<IWarrior> wariors = new List<IWarrior>();
            nMars.Parser.Parser parser = new nMars.Parser.Parser(Rules.DefaultRules);
            XmlSerializer ser = new XmlSerializer(typeof (ExtendedWarrior));
            List<string> files =
                new List<string>(Directory.GetFiles(@"..\..\..\rc", "*.rc", SearchOption.AllDirectories));
            files.AddRange(Directory.GetFiles(@"..\..\..\rc", "*.red", SearchOption.AllDirectories));
            files.Sort();

            foreach (string s in files)
            {
                Console.Write("Reading {0}          \r", s);
                wariors.Add(LoadDumpOne(s, parser, ser));
            }
        }


        private static IWarrior LoadDumpOne(string s, nMars.Parser.Parser parser, XmlSerializer ser)
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
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
            return w;
        }
    }
}