using System.Windows.Forms;
using nMars.IDE.Core;

namespace nMars.IDE.Controls
{
    public partial class TextEditor : IDEFrame, IEditor
    {
        public TextEditor(TextDocument document)
        {
            InitializeComponent();
            this.document = document;
            document.Editor = this;
        }

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, document.Name);
            Application.Editors.Insert(0, this);
            ActivateControl();
        }


        public override void ActivateControl()
        {
            base.ActivateControl();
            if (Application.ActiveEditor != this)
            {
                Application.ActiveEditor = this;
                Application.MainForm.CycleDocuments(true);
            }
            textBox.Focus();
        }

        public override void DeactivateControl()
        {
            base.DeactivateControl();
            if (Application.ActiveEditor == this)
            {
                Application.ActiveEditor = null;
            }
        }

        #region Load & Save

        public void Save()
        {
            document.Save();
        }

        public void Open()
        {
            document.Open();
        }

        public bool Closing()
        {
            return document.Closing();
        }

        public string EditedText
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public string PageName
        {
            get { return page.Text; }
            set { page.Text = value; }
        }

        Document IEditor.Document
        {
            get { return document; }
        }

        #endregion

        #region Variables

        private TextDocument document;

        #endregion

        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            if (!document.IsModified)
            {
                document.IsModified = true;
                Application.RefreshUI();
                PageName = document.Name;
            }
        }

        public override string ToString()
        {
            return document.Name;
        }
    }
}