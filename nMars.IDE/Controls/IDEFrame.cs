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
            page.Controls.Add(this);
            frame = aFrame;
            frame.TabPages.Add(page);
            frame.Selected += new TabControlEventHandler(frame_Selected);
        }

        public virtual void Detach()
        {
            frame.TabPages.Remove(page);
            frame.Selected -= new TabControlEventHandler(frame_Selected);
        }

        public virtual void ActivateControl()
        {
            page.BackColor = Color.WhiteSmoke;
            frame.SelectedTab = page;
        }

        public virtual void DeactivateControl()
        {
            page.BackColor = Color.DarkGray;
        }

        protected TabControl frame;
        protected TabPage page;
    }
}