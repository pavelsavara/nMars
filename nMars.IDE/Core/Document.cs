using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using nMars.IDE.Controls;

namespace nMars.IDE.Core
{
    public abstract class Document
    {
        [XmlIgnore]
        public virtual string Name
        {
            get
            {
                if (IsModified)
                {
                    return Path.GetFileNameWithoutExtension(FileName) + "*";
                }
                return Path.GetFileNameWithoutExtension(FileName);
            }
        }

        [XmlIgnore]
        public virtual string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        protected string fileName;
        protected IEditor Editor;

        [XmlIgnore]
        public bool IsModified;

        [XmlIgnore]
        public bool IsNew;

        public static int DocCounter = 0;

        /// <returns>T=can close</returns>
        public abstract bool Save();

        public abstract void Load();
        public abstract void Close();
        public abstract void Open();

        public virtual bool Closing()
        {
            if (IsModified)
            {
                DialogResult dr =
                    MessageBox.Show(FileName + " is modified. Would you like to save changes ?", "Unsaved file",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    return false;
                }
                else if (dr == DialogResult.Yes)
                {
                    return Save();
                }
            }
            return true;
        }

        protected bool ChooseName(string ext, string title)
        {
            Application.MainForm.saveDialog.Title = "Save " + title;
            Application.MainForm.saveDialog.DefaultExt = ext;
            Application.MainForm.saveDialog.Filter = title + " files|*." + ext;
            Application.MainForm.saveDialog.FilterIndex = 1;
            Application.MainForm.saveDialog.FileName = FileName;
            Application.MainForm.saveDialog.AddExtension = true;
            Application.MainForm.saveDialog.CreatePrompt = false;
            DialogResult dr = Application.MainForm.saveDialog.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                return false;
            }
            FileName = Application.MainForm.saveDialog.FileName;
            return true;
        }
    }

    public abstract class ProjectDocument : Document
    {
        public static ProjectDocument Load(string fileName, string docType)
        {
            if (docType == "WarriorDocument")
            {
                return WarriorDocument.Load(fileName);
            }
            throw new ArgumentException("Unkown type");
        }

        public RedCodeProject Project;
    }

    public abstract class TextDocument : ProjectDocument
    {
        public new TextEditor Editor;
    }
}