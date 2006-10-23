// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public interface IEngine
    {
        /// <summary>
        /// Run complete round
        /// </summary>
        FightResult[] Run(Rules aRules, IWarrior[] wariors, IPSpaces aPSpaces, Random random, int[] forcedAddresses);
    }

    [ComVisible(true)]
    public interface IEngineModule : IModule
    {
        IEngine CreateEngine(Rules rules);
    }
}