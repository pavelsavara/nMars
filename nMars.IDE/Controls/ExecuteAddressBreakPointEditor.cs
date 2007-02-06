using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using nMars.IDE.Controls;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class ExecuteAddressBreakPointEditor : IDEFrame
    {
        public ExecuteAddressBreakPointEditor()
        {
            InitializeComponent();
        }

        public ExecuteAddressBreakPoint ExecuteAddressBreakPoint;

        public override void Attach(TabControl frame, string name)
        {
            bindingSource.DataSource = ExecuteAddressBreakPoint;
            base.Attach(frame, name);
        }
    }
}
