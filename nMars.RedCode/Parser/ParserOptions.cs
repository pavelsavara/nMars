// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public class ParserOptions
    {
        public ParserOptions()
        {
        }

        public ParserOptions(bool offset, bool labels, bool comments, bool xml, bool brief)
        {
            Offset = offset;
            Labels = labels;
            Comments = comments;
            XmlFormat = xml;
            Brief = brief;
        }

        public bool Brief = false;
        public bool Offset = false;
        public bool Labels = false;
        public bool Comments = false;
        public bool XmlFormat = false;

        public static readonly ParserOptions Default = new ParserOptions();
        public static readonly ParserOptions Full = new ParserOptions(true, true, true, false, false);
        public static readonly ParserOptions NoOffset = new ParserOptions(false, true, true, false, false);
        public static readonly ParserOptions Xml = new ParserOptions(true, true, true, true, false);
    }
}
