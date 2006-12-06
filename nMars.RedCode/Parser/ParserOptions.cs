// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public class ParserOptions
    {
        public ParserOptions()
        {
        }

        public ParserOptions(bool offset, bool labels, bool comments, bool xml, bool brief, bool status)
        {
            Offset = offset;
            Labels = labels;
            Comments = comments;
            XmlFormat = xml;
            Brief = brief;
            Status = status;
        }

        [XmlAttribute]
        public bool Status = true;

        [XmlAttribute]
        public bool Header = true;

        [XmlAttribute]
        public bool Brief = false;

        [XmlAttribute]
        public bool Offset = false;

        [XmlAttribute]
        public bool Labels = false;

        [XmlAttribute]
        public bool Comments = false;

        [XmlAttribute]
        public bool XmlFormat = false;

        [XmlAttribute]
        public string DumpExt = ".dmp";

        [XmlAttribute]
        public bool DumpFiles = false;

        public static ParserOptions Default
        {
            get { return new ParserOptions(); }
        }

        public static ParserOptions Full
        {
            get { return new ParserOptions(true, true, true, false, false, true); }
        }

        public static ParserOptions NoOffset
        {
            get { return new ParserOptions(false, true, true, false, false, false); }
        }

        public static ParserOptions Xml
        {
            get { return new ParserOptions(true, true, true, true, false, false); }
        }

        public static ParserOptions Engine
        {
            get { return new ParserOptions(false, false, false, false, true, false); }
        }

        public static ParserOptions Ide
        {
            get { return new ParserOptions(false, false, false, false, true, true); }
        }
    }
}