// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Windows.Forms;
using nMars.IDE.Core;

namespace nMars.IDE
{
    public enum IDEMode
    {
        Edit,
        Debug,
    }

    public interface IControl
    {
        void Attach(TabControl frame, string name);
        void Detach();
        void ChangingMode(IDEMode newMode);
        void ActivateControl();
        void DeactivateControl();
    }

    public interface IEditor : IControl
    {
        bool Closing();
        void Save();
        void Open();
        Document Document { get; }
    }

    public interface IDebugWatch : IControl
    {
        void WatchCore();
        void Resume();
        void Pause();
    }
}