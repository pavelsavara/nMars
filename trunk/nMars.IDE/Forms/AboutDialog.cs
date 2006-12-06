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
            string version = ModuleRegister.GetVersionInfo().Replace("\n", "<br>");
            string page = nMars.IDE.Properties.Resources.About.Replace("$Ver$", version);
            webBrowser.Navigate("about:blank");
            webBrowser.Document.Write(page);
        }

        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            string target = e.Url.AbsoluteUri;
            if (target != "about:blank")
            {
                e.Cancel = true;
                try
                {
                    System.Diagnostics.Process.Start(target);
                }
                catch (Exception)
                {
                    //swallow
                }
            }
        }
    }
}