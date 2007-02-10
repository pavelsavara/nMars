// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public enum StepResult
    {
        Continue = 0,
        NextRound = 1,
        Finished = 2,
        Start = 3,
    }

    [ComVisible(true)]
    public enum RoundResult
    {
        Tie,
        Win,
        Loss,
    }

    [ComVisible(true)]
    public enum ScoreFormula
    {
        Standard, // (W*W-1)/S
    }

    [ComVisible(true)]
    public class MatchResult
    {
        #region Public Methods

        public MatchResult(MatchResult source)
        {
            warriorsCount = source.warriorsCount;
            rounds = source.rounds;
            formula = source.formula;
            results = new RoundResult[warriorsCount,rounds];
            for (int w = 0; w < warriorsCount; w++)
            {
                for (int r = 0; r < rounds; r++)
                {
                    results[w, r] = source.results[w, r];
                }
            }
        }

        public MatchResult(IProject project)
        {
            warriorsCount = project.Rules.WarriorsCount;
            rounds = project.Rules.Rounds;
            formula = project.Rules.ScoreFormula;
            results = new RoundResult[warriorsCount,rounds];
        }

        public void ComputePoints()
        {
            score = new int[warriorsCount];
            wins = new int[warriorsCount];
            ties = new int[warriorsCount];
            looses = new int[warriorsCount];
            for (int r = 0; r < rounds; r++)
            {
                int survivers = 0;
                for (int w = 0; w < warriorsCount; w++)
                {
                    switch (results[w, r])
                    {
                        case RoundResult.Win:
                            wins[w]++;
                            survivers++;
                            break;
                        case RoundResult.Tie:
                            ties[w]++;
                            survivers++;
                            break;
                        case RoundResult.Loss:
                            looses[w]++;
                            break;
                    }
                }
                for (int w = 0; w < warriorsCount; w++)
                {
                    switch (formula)
                    {
                        case ScoreFormula.Standard:
                            if (results[w, r] != RoundResult.Loss)
                            {
                                score[w] += (warriorsCount * warriorsCount - 1) / survivers;
                            }
                            break;
                        default:
                            throw new NotImplementedException("Formula not imlemented");
                    }
                }
            }
        }

        public void Dump(ISimpleOutput output, IProject project)
        {
            IList<ResultsHelper> res = PrepareResults(project, project.EngineOptions.SortResults);
            for (int w = 0; w < res.Count; w++)
            {
                IWarrior warrior = res[w].warrior;
                output.WriteLine(string.Format("{0} by {1} scores {2}", warrior.Name, warrior.Author, res[w].score));
            }
            if (res.Count == 2)
            {
                int idx = res[0].originalIndex;
                output.WriteLine(string.Format("Results: {0} {1} {2}", wins[idx], looses[idx], ties[idx]));
            }
        }

        #endregion

        #region Helpers

        private IList<ResultsHelper> PrepareResults(IProject project, bool sort)
        {
            List<ResultsHelper> res = new List<ResultsHelper>();
            for (int w = 0; w < warriorsCount; w++)
            {
                IWarrior warrior = project.Warriors[w];
                ResultsHelper r = new ResultsHelper();
                r.originalIndex = w;
                r.score = score[w];
                r.warrior = warrior;
                res.Add(r);
            }
            if (sort)
                res.Sort();
            return res;
        }

        struct ResultsHelper : IComparable
        {
            public IWarrior warrior;
            public int score;
            public int originalIndex;

            public int CompareTo(object obj)
            {
                ResultsHelper r = (ResultsHelper)obj;
                return score.CompareTo(r.score);
            }
        }

        #endregion

        #region Extensions

        public static bool operator !=(MatchResult a, MatchResult b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(MatchResult a, MatchResult b)
        {
            return a.Equals(b);
        }

        public override bool Equals(object obj)
        {
            MatchResult res = obj as MatchResult;
            /*
            if (project.Rules != res.project.Rules)
                throw new InvalidOperationException("Cannot compare different results with rules");
            */
            for (int w = 0; w < warriorsCount; w++)
            {
                /*
                for (int r = 0; r < rules.Rounds; r++)
                {
                    if (results[w, r] != res.results[w, r])
                        return false;
                }
                */
                if (score[w] != res.score[w])
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return results.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Variables

        public RoundResult[,] results;
        public int[] score;
        public int[] wins;
        public int[] looses;
        public int[] ties;
        public int warriorsCount;
        public int rounds;
        public ScoreFormula formula;

        #endregion
    }
}