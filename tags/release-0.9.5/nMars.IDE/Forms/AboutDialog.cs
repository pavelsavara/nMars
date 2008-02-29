// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Windows.Forms;
using nMars.RedCode.Modules;

namespace nMars.IDE.Forms
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            Icon = nMars.IDE.Properties.Resources.IDEsmall;
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            string version = ModuleRegister.GetVersionInfo();
            string logo = "http://sourceforge.net/projects/nmars\r\n\r\n" + 
                "2007 Published under LGPL http://www.gnu.org/licenses/lgpl.txt\r\n" + "by Pavel Savara (pavel.savara@gmail.com)\r\n\r\n";
            textBox.Text = logo + version;
        }
    }
}