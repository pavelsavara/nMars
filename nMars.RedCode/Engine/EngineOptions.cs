// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public class EngineOptions
    {
        [XmlAttribute]
        public bool KOTHFormat = false;

        [XmlAttribute]
        public bool Permutate = false;

        [XmlAttribute]
        public bool SortResults = true;

        [XmlIgnore]
        public Random Random = new Random();

        public int Brake = 0;

        public static EngineOptions Default
        {
            get { return new EngineOptions(); }
        }

        public static EngineOptions ConstantRandom
        {
            get
            {
                EngineOptions e = new EngineOptions();
                e.Random = new Random(0);
                return e;
            }
        }
    }
}