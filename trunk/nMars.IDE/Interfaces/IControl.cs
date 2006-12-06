using System.Windows.Forms;
using nMars.IDE.Core;

namespace nMars.IDE
{
    public interface IControl
    {
        void Attach(TabControl frame, string name);
        void Detach();
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
}