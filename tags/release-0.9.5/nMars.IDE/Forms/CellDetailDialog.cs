// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Windows.Forms;
using nMars.Graphics;
using nMars.RedCode;

namespace nMars.IDE.Forms
{
    public partial class CellDetailDialog : Form
    {
        public CellDetailDialog()
        {
            InitializeComponent();
        }

        public IAsyncEngine Engine;
        public IProject Project;
        public int Address;
        private CoreEventBreakpoint breakpoint;

        private void CellDetailDialog_Load(object sender, System.EventArgs e)
        {
            textBoxAddress.Text = Address.ToString();
            textBoxCell.Text = Engine[Address].GetLine(ParserOptions.Pure, false);
            textBoxInfo.Text = MemoryPainter.GetMemoryTooltip(Engine, Address);
            breakpoint = CoreEventBreakpoint.FindByAddress(Project.BreakPoints, Address);
            if (breakpoint!=null)
            {
                checkBoxBreakExec.Checked = (breakpoint.Event & InstructionEvent.Executed) != InstructionEvent.None;
                checkBoxBreakDeath.Checked = (breakpoint.Event & InstructionEvent.Died) != InstructionEvent.None;
                checkBoxBreakRead.Checked = (breakpoint.Event & InstructionEvent.Read) != InstructionEvent.None;
                checkBoxBreakWriteData.Checked = (breakpoint.Event & InstructionEvent.WrittenData) != InstructionEvent.None;
                checkBoxBreakWriteInstruction.Checked = (breakpoint.Event & InstructionEvent.WrittenInstruction) != InstructionEvent.None;
            }
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            InstructionEvent ev= InstructionEvent.None;
            ev |= checkBoxBreakExec.Checked ? InstructionEvent.Executed : InstructionEvent.None;
            ev |= checkBoxBreakDeath.Checked ? InstructionEvent.Died : InstructionEvent.None;
            ev |= checkBoxBreakRead.Checked ? InstructionEvent.Read : InstructionEvent.None;
            ev |= checkBoxBreakWriteData.Checked ? InstructionEvent.WrittenData : InstructionEvent.None;
            ev |= checkBoxBreakWriteInstruction.Checked ? InstructionEvent.WrittenInstruction : InstructionEvent.None;

            if (ev == InstructionEvent.None)
            {
                if (breakpoint != null)
                {
                    Project.BreakPoints.Remove(breakpoint);
                }
            }
            else
            {
                if (breakpoint==null)
                {
                    breakpoint=new CoreEventBreakpoint(ev, Address);
                    Project.BreakPoints.Add(breakpoint);
                    IDEApplication.Instance.ActiveProject.IsModified = true;
                }
                else
                {
                    breakpoint.Event = ev;
                }
            }
            Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}