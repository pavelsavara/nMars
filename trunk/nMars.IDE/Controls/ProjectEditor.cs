using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using nMars.IDE.Core;

namespace nMars.IDE.Controls
{
    public partial class ProjectEditor : IDEFrame, IEditor
    {
        public ProjectEditor(RedCodeProject aProject)
        {
            project = aProject;
            project.Editor = this;
            InitializeComponent();
        }
        private RedCodeProject project;

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, project.Name);
            IDEApplication.Editors.Insert(0, this);
            this.redCodeProjectBindingSource.DataSource = project;
            ActivateControl();
        }


        public override void ActivateControl()
        {
            base.ActivateControl();
            if (IDEApplication.ActiveEditor != this)
            {
                IDEApplication.ActiveEditor = this;
                IDEApplication.MainForm.CycleDocuments(true);
            }
        }

        public override void DeactivateControl()
        {
            base.DeactivateControl();
            if (IDEApplication.ActiveEditor == this)
            {
                IDEApplication.ActiveEditor = null;
            }
        }

        public bool Closing()
        {
            return project.Closing();
        }

        public void Save()
        {
            project.Save();
        }

        public void Open()
        {
            project.Open();
        }

        public Document Document
        {
            get
            {
                return project;
            }
        }
    }
}
