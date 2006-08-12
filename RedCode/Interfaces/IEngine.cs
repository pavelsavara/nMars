using System;
using System.Collections.Generic;

namespace nMars.RedCode
{
    public interface IEngine
    {
        /// <summary>
        /// Run complete match
        /// </summary>
        /// <param name="wariors"></param>
        /// <param name="rules"></param>
        /// <param name="random"></param>
        /// <returns></returns>
        IList<FightResult> Run(IList<IWarrior> wariors, Rules rules, Random random);
    }
}