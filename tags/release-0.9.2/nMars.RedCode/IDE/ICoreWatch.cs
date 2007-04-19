// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;

namespace nMars.RedCode
{
    public interface ICoreWatch
    {
        void Attach(IAsyncEngine engine);
        void Detach();
        void RepaintView();
    }
}
