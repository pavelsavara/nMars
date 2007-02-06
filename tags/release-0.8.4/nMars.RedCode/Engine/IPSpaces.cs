// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

namespace nMars.RedCode
{
    public interface IPSpace
    {
        int this[int index] { get; set; }
        int Size { get; }
    }
}