// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Drawing;
using System.Windows.Forms;

namespace nMars.IDE.Controls
{
    public partial class IDEPanel : TabControl
    {
        public IDEPanel()
        {
            InitializeComponent();
            DrawItem += new DrawItemEventHandler(frame_DrawItem);
        }
    
        private void frame_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush ForeBrush = Brushes.Black;
            Brush BackBrush;
            if (e.Index == SelectedIndex)
            {
                BackBrush = Brushes.White;
            }
            else
            {
                BackBrush = Brushes.LightGray;
            }

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            e.Graphics.FillRectangle(BackBrush, e.Bounds);
            Rectangle r = e.Bounds;
            r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
            e.Graphics.DrawString(Controls[e.Index].Text, e.Font, ForeBrush, r, sf);
            //Dispose objects
            sf.Dispose();
        }
    }
}
