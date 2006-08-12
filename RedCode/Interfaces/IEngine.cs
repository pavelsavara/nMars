using System;
using System.Collections.Generic;

namespace nMars.RedCode
{
    public interface IEngine
    {
        /// <summary>
        /// Run complete round
        /// </summary>
        IList<FightResult> Run(IList<IWarrior> wariors, Rules rules, IPSpaces pSpaces, Random random, IList<int> forcedAddresses);
    }
}