// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

namespace nMars.RedCode
{
    public interface IExtendedWarrior : IWarrior
    {
        string GetLabels(int instructionOffset);
        string GetComment(int instructionOffset);
        string GetOriginalInstruction(int instructionOffset);
        string GetExtendedLine(int instructionOffset, DumpOptions options);
    }
}