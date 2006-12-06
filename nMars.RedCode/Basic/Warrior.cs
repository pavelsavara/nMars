// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace nMars.RedCode
{
    [Serializable]
    public class Warrior : IWarrior, IXmlSerializable
    {
        #region Connstruction

        protected Warrior()
        {
        }

        public Warrior(Rules rules)
        {
            Instructions = new List<IInstruction>();
            StartOffset = 0;
            Rules = rules;
        }

        #endregion

        #region Dumping

        public void Dump(IConsole output)
        {
            Dump(output, ParserOptions.Default);
        }

        public virtual void Dump(IConsole output, ParserOptions options)
        {
            if (options.XmlFormat)
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(output.OutStream, this);
            }
            else
            {
                output.WriteLine("Program \"" + Name + "\" (length " + Length.ToString() + ") by \"" + Author + "\"");
                output.WriteLine("");
                output.WriteLine("       ORG      START");
                for (int a = 0; a < Instructions.Count; a++)
                {
                    output.WriteLine(Instructions[a].GetLine(options, a == StartOffset));
                }
            }
            output.WriteLine("");
        }

        public virtual void Dump(string fileName, ParserOptions options)
        {
            StreamWriter sw = new StreamWriter(fileName);
            Dump(new WrappedTextWriter(sw), options);
            sw.Close();
        }

        #endregion

        #region Interface

        int IWarrior.StartOffset
        {
            get { return StartOffset; }
        }

        string IWarrior.Name
        {
            get { return Name; }
        }

        string IWarrior.Author
        {
            get { return Author; }
        }

        string IWarrior.Date
        {
            get { return Date; }
        }

        string IWarrior.Version
        {
            get { return Version; }
        }

        string IWarrior.FileName
        {
            get { return FileName; }
        }

        int IWarrior.Pin
        {
            get { return Pin; }
        }

        Rules IWarrior.Rules
        {
            get { return Rules; }
        }

        IInstruction IWarrior.this[int offset]
        {
            get { return Instructions[offset]; }
        }

        IList<IInstruction> IWarrior.Instructions
        {
            get { return Instructions; }
        }

        public int Length
        {
            get { return Instructions.Count; }
        }

        #endregion

        #region Extensions

        public override string ToString()
        {
            return Name;
        }

        public static bool Equals(IWarrior a, IWarrior b)
        {
            if (a.Length != b.Length) return false;
            if (a.StartOffset != b.StartOffset) return false;
            //if (a.Pin != b.Pin) return false;
            //if (a.Name != b.Name) return false;
            //if (a.Author != b.Author) return false;
            for (int adr = 0; adr < b.Length; adr++)
            {
                if (!a[adr].Equals(b[adr])) return false;
            }
            return true;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            string t;
            Name = reader.ReadElementString("Name");
            Author = reader.ReadElementString("Author");
            Date = reader.ReadElementString("Date");
            Version = reader.ReadElementString("Version");
            t = reader.ReadElementString("Pin");
            if (t != null) Pin = Int32.Parse(t);
            t = reader.ReadElementString("StartOffset");
            if (t != null) StartOffset = Int32.Parse(t);
            reader.ReadElementString("StartOffset");
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.ReadStartElement("Instruction");
                Instruction i = new Instruction();
                i.Operation = OperationHelper.Parse(reader.ReadElementString("Operation"));
                i.Modifier = (Modifier)Enum.Parse(typeof(Modifier), reader.ReadElementString("Modifier"));
                i.ModeA = ModeHelper.Parse(reader.ReadElementString("ModeA"));
                i.ValueA = Int32.Parse(reader.ReadElementString("ValueA"));
                i.ModeB = ModeHelper.Parse(reader.ReadElementString("ModeB"));
                i.ValueB = Int32.Parse(reader.ReadElementString("ValueB"));
                Instructions.Add(i);
                reader.ReadEndElement();
                reader.MoveToContent();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            if (Name != null) writer.WriteAttributeString("Name", Name);
            if (Author != null) writer.WriteAttributeString("Author", Author);
            if (Date != null) writer.WriteAttributeString("Date", Date);
            if (Version != null) writer.WriteAttributeString("Version", Version);
            if (Pin != PSpace.UNSHARED) writer.WriteAttributeString("Pin", Pin.ToString());
            if (StartOffset != 0) writer.WriteAttributeString("StartOffset", StartOffset.ToString());
            foreach (IInstruction i in Instructions)
            {
                writer.WriteStartElement("Instruction");
                writer.WriteAttributeString("Operation", i.Operation.ToString());
                writer.WriteAttributeString("Modifier", i.Modifier.ToString());
                writer.WriteAttributeString("ModeA", ModeHelper.ToString(i.ModeA));
                writer.WriteAttributeString("ValueA", i.ValueA.ToString());
                writer.WriteAttributeString("ModeB", ModeHelper.ToString(i.ModeB));
                writer.WriteAttributeString("ValueB", i.ValueB.ToString());
                writer.WriteEndElement();
            }
        }

        #endregion

        #region Variables

        public List<IInstruction> Instructions;
        public int StartOffset;
        public string Name = "";
        public string Author = "Anonymous";
        public string Date = "";
        public string Version = "";
        public int Pin = PSpace.UNSHARED;
        public string FileName = null;
        public Rules Rules;

        #endregion
    }
}