// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace nMars.RedCode
{
    public enum EngineMode
    {
        Match,
        TournamentNoSelf,
        TournamentWithSelf,
        FirstVersusOthers,
    }

    [ComVisible(true)]
    public class EngineOptions
    {
        public EngineOptions()
        {
        }

        public EngineOptions(EngineOptions src)
        {
            KOTHFormat = src.KOTHFormat;
            Permutate = src.Permutate;
            SortResults = src.SortResults;
            DumpResults = src.DumpResults;
            StatusLine = src.StatusLine;
            Random = src.Random;
            InitRoundBefore = src.InitRoundBefore;
            Brake = src.Brake;
            EngineMode = src.EngineMode;
            EngineMode = src.EngineMode;
            if (src.ForcedAddresses!=null)
                ForcedAddresses = new List<int>(src.ForcedAddresses);
        }

        [XmlAttribute]
        public bool KOTHFormat = false;

        [XmlAttribute]
        public bool Permutate = false;

        [XmlAttribute]
        public bool SortResults = true;

        [XmlAttribute]
        public bool DumpResults = true;

        [XmlAttribute]
        public bool StatusLine = false;

        [XmlIgnore]
        public Random Random = new Random();

        [XmlIgnore]
        public bool InitRoundBefore = false;

        [XmlAttribute]
        public int Brake = 0;

        [XmlAttribute]
        public EngineMode EngineMode = EngineMode.Match;

        public List<int> ForcedAddresses = null;

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