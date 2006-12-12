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
            page.Controls.Add(this);
            frame = aFrame;
            frame.TabPages.Add(page);
            frame.Selecting += new TabControlCancelEventHandler(frame_Selecting);
            frame.Selected += new TabControlEventHandler(frame_Selected);
            frame.DrawItem +=new DrawItemEventHandler(frame_DrawItem);
            frame.DrawMode = TabDrawMode.OwnerDrawFixed;
        }


        public virtual void Detach()
        {
            frame.TabPages.Remove(page);
            frame.Selecting -= new TabControlCancelEventHandler(frame_Selecting);
            frame.Selected -= new TabControlEventHandler(frame_Selected);
            frame.DrawItem -= new DrawItemEventHandler(frame_DrawItem);
        }

        public virtual void ActivateControl()
        {
            frame.SelectedTab = page;
        }

        public virtual void DeactivateControl()
        {
        }

        private void frame_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font TabFont = e.Font;
            Brush BackBrush;
            Brush ForeBrush = new SolidBrush(Color.Black);
            if (e.Index == frame.SelectedIndex)
            {
                BackBrush = new SolidBrush(Color.White);
            }
            else
            {
                BackBrush = new SolidBrush(frame.BackColor);
            }
            
            string TabName = frame.TabPages[e.Index].Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            e.Graphics.FillRectangle(BackBrush, e.Bounds);
            Rectangle r = e.Bounds;
            r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
            e.Graphics.DrawString(TabName, TabFont, ForeBrush, r, sf);
            //Dispose objects
            sf.Dispose();
            BackBrush.Dispose();
            ForeBrush.Dispose();
        }        
        
        protected TabControl frame;
        protected TabPage page;
    }
}