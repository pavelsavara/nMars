// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public interface IExtendedWarrior : IWarrior
    {
        string GetLabels(int instructionOffset);
        string GetComment(int instructionOffset);
        string GetOriginalInstruction(int instructionOffset);
        string GetExtendedLine(int instructionOffset, DumpOptions options);
    }
}