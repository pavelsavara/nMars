using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class AsyncHub : UserControl, ISimpleOutput
    {
        public AsyncHub()
        {
            InitializeComponent();
        }

        #region ISimpleOutput

        public void Clear()
        {
            this.Invoke(new voidDelegate(clear));
        }

        public void WriteLine(string text)
        {
            this.Invoke(new stringDelegate(writeLine), text);
        }


        public void Write(string text)
        {
            this.Invoke(new stringDelegate(write), text);
        }

        public void ErrorWriteLine(string text)
        {
            this.Invoke(new stringDelegate(errorWriteLine), text);
        }

        private delegate void voidDelegate();
        private delegate void stringDelegate(string text);

        private void clear()
        {
            Application.Console.Clear();
        }
        
        private void writeLine(string text)
        {
            Application.Console.WriteLine(text);
        }
        
        private void write(string text)
        {
            Application.Console.Write(text);
        }
        
        private void errorWriteLine(string text)
        {
            Application.Console.ErrorWriteLine(text);
        }
        #endregion

        #region Engine

        private void matchFinishedCallback()
        {
            Application.MatchFinished();
        }

        public void MatchFinishedCallback()
        {
            this.Invoke(new voidDelegate(matchFinishedCallback));
        }

        #endregion

    }
}
