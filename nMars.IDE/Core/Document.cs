// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using nMars.IDE.Controls;
using nMars.IDE.Forms;

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
        [XmlIgnore]
        public IEditor Editor;

        [XmlIgnore]
        public virtual bool IsModified
        {
            get
            {
                return isModified;
            }
            set
            {
                isModified = value;
            }
        }
        private bool isModified;

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
            MainForm mainForm = IDEApplication.Instance.MainForm;
            mainForm.saveDialog.Title = "Save " + title;
            mainForm.saveDialog.DefaultExt = ext;
            mainForm.saveDialog.Filter = title + " files|*." + ext;
            mainForm.saveDialog.FilterIndex = 1;
            mainForm.saveDialog.FileName = FileName;
            mainForm.saveDialog.AddExtension = true;
            mainForm.saveDialog.CreatePrompt = false;
            DialogResult dr = mainForm.saveDialog.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                return false;
            }
            FileName = mainForm.saveDialog.FileName;
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
        [XmlIgnore]
        public new TextEditor Editor
        {
            get
            {
                return base.Editor as TextEditor;
            }
            set
            {
                base.Editor = value;
            }
        }
    }
}