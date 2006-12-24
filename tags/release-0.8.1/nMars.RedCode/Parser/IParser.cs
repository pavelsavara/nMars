// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;
using System.Runtime.InteropServices;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public interface IParser : IComponent
    {
        void InitParser(Rules aRules);
        IWarrior Parse(string fileName);
        IWarrior Parse(string fileName, ISimpleOutput err);
        IWarrior Parse(string fileName, TextWriter err);
        IWarrior Parse(string fileName, string errFileName);
    }
}