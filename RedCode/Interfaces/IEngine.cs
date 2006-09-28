// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

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