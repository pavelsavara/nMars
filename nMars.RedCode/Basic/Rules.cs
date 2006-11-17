// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;

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
    public class EngineOptions
    {
        public bool KOTHFormat = false;
        public bool Permutate = false;
        public static EngineOptions DefaultOptions
        {
            get
            {
                return new EngineOptions();
            }
        }
    }

    [ComVisible(true)]
    public enum ICWStandard
    {
        ICWS88,
        ICWS94,
    }

    [ComVisible(true)]
    public enum PointsFormula
    {
        Standard, // (W*W-1)/S
    }

    [Serializable]
    [ComVisible(true)]
    public class Rules
    {
        public int CoreSize = 8000;
        public int PSpaceSize = 500; // coreSize / 16 
        public int MaxCycles = 80000;
        public int MaxLength = 100;
        public int MaxProcesses = 1000;
        public bool EnablePSpace = true;
        public int MinDistance = 100;
        public int Rounds = 1;
        public int WarriorsCount = 2;
        public int Version = 60;
        public PointsFormula ScoreFormula = PointsFormula.Standard;
        public ICWStandard ICWSStandard = ICWStandard.ICWS94;

        public static Rules DefaultRules
        {
            get { return new Rules(); }
        }

        public static bool operator !=(Rules a, Rules b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(Rules a, Rules b)
        {
            return a.Equals(b);
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