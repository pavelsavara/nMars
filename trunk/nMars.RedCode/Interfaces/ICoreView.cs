// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public interface ICoreView
    {
        IInstruction this[int address] { get; }
        int CoreSize { get; }
        int Round { get; }
        int Cycles { get; }
        int CyclesLeft { get; }
        int LiveWarriorsCount { get; }
    }
}