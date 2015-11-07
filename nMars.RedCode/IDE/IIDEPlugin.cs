// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    public interface IIDEPlugin : IComponent
    {
        void Load();
        void RefreshControls();
        void Unload();
    }
}
