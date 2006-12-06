// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

namespace nMars.RedCode
{
    public interface IProject
    {
        Rules Rules { get; }
        IList<IWarrior> Warriors { get; }
        IList<int> ForcedAddresses { get; }
        EngineOptions EngineOptions { get; set; }
        ParserOptions ParserOptions { get; set; }
    }
}