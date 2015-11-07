// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public interface IInstruction
    {
        string GetLine(ParserOptions options, bool start);
        void Wrap(int coreSize);
        Operation Operation { get; }
        Modifier Modifier { get; }
        Mode ModeA { get; }
        int ValueA { get; }
        Mode ModeB { get; }
        int ValueB { get; }
    }

    [ComVisible(true)]
    public interface IExtendedInstruction : IInstruction
    {
        string Label { get; }
        string Comment { get; }
    }
}