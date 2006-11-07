// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public enum FightResult
    {
        Win,
        Tie,
        Loose,
    }

    [ComVisible(true)]
    public class MatchResult : IComparable
    {
        public MatchResult(Rules rules)
        {
            this.rules = rules;
            results = new FightResult[rules.WarriorsCount,rules.Rounds];
            points = new int[rules.WarriorsCount];
        }

        public void ComputePoints()
        {
            //TODO
            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                for (int r = 0; r < rules.Rounds; r++)
                {
                    switch (rules.ScoreFormula)
                    {
                        case PointsFormula.Standard:
                            points[w] += 1;
                            break;
                    }
                }
            }
        }
        
        public void Dump(TextWriter tw)
        {
            tw.WriteLine("Results: //TODO");
        }

        public FightResult[,] results;
        public int[] points;
        private Rules rules;

        public int CompareTo(object obj)
        {
            MatchResult res = obj as MatchResult;
            if (rules != res.rules) return -1;
            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                if (points[w] != res.points[w]) return -1;
                for (int r = 0; r < rules.Rounds; r++)
                {
                    if (results[w, r] != res.results[w, r]) return -1;
                }
            }
            return 0;
        }
    }
}