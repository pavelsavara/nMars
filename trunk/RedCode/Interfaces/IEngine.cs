using System;
using System.Collections.Generic;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    public interface IEngine
    {
        /// <summary>
        /// Run complete round
        /// </summary>
        IList<FightResult> Run(IList<IWarrior> wariors, IPSpaces pSpaces, Random random, IList<int> forcedAddresses);
    }

    public interface IEngineModule : IModule
    {
        IEngine CreateEngine(Rules rules);
    }
}