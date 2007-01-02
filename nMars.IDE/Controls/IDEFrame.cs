// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Drawing;
using System.Windows.Forms;

namespace nMars.IDE.Controls
{
    public partial class IDEFrame : UserControl, IControl
    {
        public IDEFrame()
        {
            InitializeComponent();
        }

        void frame_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage != page)
            {
                DeactivateControl();
            }
        }

        void frame_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == page)
            {
                ActivateControl();
            }
        }

        public virtual void Attach(TabControl aFrame, string name)
        {
            Dock = DockStyle.Fill;
            page = new TabPage(name);
            Text = name;
            page.Controls.Add(this);
            frame = aFrame;
            frame.TabPages.Add(page);
            frame.Selecting += new TabControlCancelEventHandler(frame_Selecting);
            frame.Selected += new TabControlEventHandler(frame_Selected);
            frame.DrawMode = TabDrawMode.OwnerDrawFixed;
        }


        public virtual void Detach()
        {
            frame.TabPages.Remove(page);
            frame.Selecting -= new TabControlCancelEventHandler(frame_Selecting);
            frame.Selected -= new TabControlEventHandler(frame_Selected);
        }

        public virtual void ActivateControl()
        {
            frame.SelectedTab = page;
        }

        public virtual void DeactivateControl()
        {
        }

        public virtual void ChangingMode(IDEMode newMode)
        {
        }

        protected TabControl frame;
        protected TabPage page;
    }
}