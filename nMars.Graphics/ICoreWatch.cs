using System;
using System.Collections.Generic;
using System.Text;
using nMars.Graphics.Controls;
using nMars.RedCode;

namespace nMars.Graphics
{
    public interface ICoreWatch
    {
        void Attach(IAsyncEngine engine);
        void Detach();
        void RepaintView();
    }
}
