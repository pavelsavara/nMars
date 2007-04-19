// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public class RulesException : Exception
    {
        public RulesException(string message)
            : base(message)
        {
        }
    }

    [ComVisible(true)]
    public enum ICWStandard
    {
        ICWS88,
        ICWS94,
    }

    [Serializable]
    [ComVisible(true)]
    public class Rules
    {
        public Rules()
        {
        }

        public Rules(Rules src)
        {
            CoreSize = src.CoreSize;
            PSpaceSize = src.PSpaceSize;
            MaxCycles = src.MaxCycles;
            MaxLength = src.MaxLength;
            MaxProcesses = src.MaxProcesses;
            EnablePSpace = src.EnablePSpace;
            MinDistance = src.MinDistance;
            Rounds = src.Rounds;
            WarriorsCount = src.WarriorsCount;
            Version = src.Version;
            ScoreFormula = src.ScoreFormula;
            ICWSStandard = src.ICWSStandard;
        }

        [XmlAttribute]
        public int WarriorsCount = 2;

        [XmlAttribute]
        public int Rounds = 1;

        [XmlAttribute]
        public int MaxCycles = 80000;

        [XmlAttribute]
        public int CoreSize = 8000;

        [XmlAttribute]
        public int PSpaceSize = 500; // coreSize / 16 

        [XmlAttribute]
        public bool EnablePSpace = true;

        [XmlAttribute]
        public int MaxProcesses = 1000;

        [XmlAttribute]
        public int MaxLength = 100;

        [XmlAttribute]
        public int MinDistance = 100;

        [XmlAttribute]
        public int Version = 93;

        [XmlAttribute]
        public ScoreFormula ScoreFormula = ScoreFormula.Standard;

        [XmlAttribute]
        public ICWStandard ICWSStandard = ICWStandard.ICWS94;

        public static Rules DefaultRules
        {
            get { return new Rules(); }
        }

        public static Rules SingleRules
        {
            get
            {
                Rules rules = new Rules();
                rules.WarriorsCount = 1;
                return rules;
            }
        }

        public override bool Equals(object obj)
        {
            Rules r2 = obj as Rules;
            if (CoreSize != r2.CoreSize) return false;
            if (PSpaceSize != r2.PSpaceSize) return false;
            if (MaxCycles != r2.MaxCycles) return false;
            if (MaxLength != r2.MaxLength) return false;
            if (MaxProcesses != r2.MaxProcesses) return false;
            if (EnablePSpace != r2.EnablePSpace) return false;
            if (MinDistance != r2.MinDistance) return false;
            if (Rounds != r2.Rounds) return false;
            if (WarriorsCount != r2.WarriorsCount) return false;
            if (Version != r2.Version) return false;
            return true;
        }
    }
}