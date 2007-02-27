// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Xml.Serialization;

namespace nMars.RedCode
{
    /// <summary>
    /// Parser options about outputs
    /// </summary>
    public class ParserOptions
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ParserOptions()
        {
        }

        /// <summary>
        /// Initializing constructor
        /// </summary>
        public ParserOptions(bool offset, bool labels, bool expressions, bool comments, bool metainfo, bool instructions, bool xml, bool header, bool status)
        {
            Offset = offset;
            Labels = labels;
            Metainfo = metainfo;
            Expressions = expressions;
            Comments = comments;
            Instructions = instructions;
            XmlFormat = xml;
            Header = header;
            StatusLine = status;
        }

        [XmlAttribute]
        public bool StatusLine = false;

        [XmlAttribute]
        public bool Header = true;

        [XmlAttribute]
        public bool Instructions = true;

        [XmlAttribute]
        public bool Metainfo = false;

        [XmlAttribute]
        public ParseMessageLevel ErrorLevel = ParseMessageLevel.AllMessages;

        [XmlAttribute]
        public bool Offset = false;

        [XmlAttribute]
        public bool Labels = false;

        [XmlAttribute]
        public bool Comments = false;

        [XmlAttribute]
        public bool Expressions = false;

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
            get { return new ParserOptions(true, true, true, true, true, true, false, false, false); }
        }

        public static ParserOptions NoExpressions
        {
            get { return new ParserOptions(false, true, false, true, true, true, false, false, false); }
        }

        public static ParserOptions Pure
        {
            get { return new ParserOptions(false, false, false, false, false, true, false, false, false); }
        }

        public static ParserOptions WithOffset
        {
            get { return new ParserOptions(true, true, true, true, true, true, false, false, false); }
        }

        public static ParserOptions Xml
        {
            get { return new ParserOptions(true, true, true, true, true, true, true, false, false); }
        }

        public static ParserOptions Engine
        {
            get { return new ParserOptions(false, false, false, false, false, true, false, false, false); }
        }

        public static ParserOptions Ide
        {
            get { return new ParserOptions(false, false, false, false, false, false, false, false, true); }
        }
    }
}