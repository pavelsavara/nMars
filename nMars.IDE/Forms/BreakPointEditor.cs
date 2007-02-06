using System;
using System.Windows.Forms;
using nMars.IDE.Controls;
using nMars.RedCode;

namespace nMars.IDE.Forms
{
    public partial class BreakPointEditor : Form
    {
        public static void EditBreakPoint(BreakPoint breakPoint)
        {
            BreakPointEditor form=new BreakPointEditor();
            if (breakPoint is ExecuteAddressBreakPoint)
            {
                ExecuteAddressBreakPoint bp = breakPoint as ExecuteAddressBreakPoint;

                
                ExecuteAddressBreakPointEditor editor = new ExecuteAddressBreakPointEditor();
                editor.ExecuteAddressBreakPoint=new ExecuteAddressBreakPoint(bp.Address);
                editor.Attach(form.Panels, "Execute Address BreakPoint");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    bp.Address = editor.ExecuteAddressBreakPoint.Address;
                }
            }
        }


        public BreakPointEditor()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}