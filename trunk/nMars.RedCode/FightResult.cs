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
    public class MatchResult
    {
        public MatchResult(Rules rules)
        {
            this.rules = rules;
            results = new FightResult[rules.WarriorsCount,rules.Rounds];
            score = new int[rules.WarriorsCount];
            wins = new int[rules.WarriorsCount];
            ties = new int[rules.WarriorsCount];
            looses = new int[rules.WarriorsCount];
        }

        public static bool operator !=(MatchResult a, MatchResult b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(MatchResult a, MatchResult b)
        {
            return a.Equals(b);
        }

        public void ComputePoints()
        {
            //TODO
            for (int r = 0; r < rules.Rounds; r++)
            {
                int survivers = 0;
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    switch (results[w, r])
                    {
                        case FightResult.Win:
                            wins[w]++;
                            survivers++;
                            break;
                        case FightResult.Tie:
                            ties[w]++;
                            survivers++;
                            break;
                        case FightResult.Loose:
                            looses[w]++;
                            break;
                    }
                }
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    switch (rules.ScoreFormula)
                    {
                        case PointsFormula.Standard:
                            if (results[w, r] != FightResult.Loose)
                            {
                                score[w] += (rules.WarriorsCount * rules.WarriorsCount - 1) / survivers;
                            }
                            break;
                        default:
                            throw new NotImplementedException("Formula not imlemented");
                    }
                }
            }
        }

        public void Dump(TextWriter tw)
        {
            tw.WriteLine("Results: //TODO");
        }

        public FightResult[,] results;
        public int[] score;
        public int[] wins;
        public int[] looses;
        public int[] ties;
        private Rules rules;

        public override bool Equals(object obj)
        {
            MatchResult res = obj as MatchResult;
            if (rules != res.rules)
                throw new InvalidOperationException("Cannot compare different results with rules");

            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                for (int r = 0; r < rules.Rounds; r++)
                {
                    if (results[w, r] != res.results[w, r])
                        return false;
                }
                if (score[w] != res.score[w])
                    return false;
            }
            return true;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}