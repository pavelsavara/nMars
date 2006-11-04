// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

namespace nMars.RedCode.Modules
{
    public interface IModule
    {
        string Name { get; }
        string Executable { get; }
    }
}