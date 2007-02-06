// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.ComponentModel;
using System.Windows.Forms;
using nMars.IDE.Core;
using nMars.IDE.Forms;
using nMars.RedCode;

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
            IDEApplication.Instance.Editors.Insert(0, this);
            redCodeProjectBindingSource.DataSource = project;
            breakPointsBindingSource.DataSource = project.Project.BreakPoints;
            ActivateControl();
        }


        public override void ActivateControl()
        {
            base.ActivateControl();
            if (IDEApplication.Instance.ActiveEditor != this)
            {
                IDEApplication.Instance.ActiveEditor = this;
                IDEApplication.Instance.MainForm.CycleDocuments(true);
            }
        }

        public override void DeactivateControl()
        {
            base.DeactivateControl();
            if (IDEApplication.Instance.ActiveEditor == this)
            {
                IDEApplication.Instance.ActiveEditor = null;
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

        private void breakPointsBindingSource_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            ExecuteAddressBreakPoint point = new ExecuteAddressBreakPoint(0);
            BreakPointEditor.EditBreakPoint(point);
            e.NewObject = point;
        }

        private void breakPointsBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded
                || e.ListChangedType == ListChangedType.ItemChanged
                || e.ListChangedType == ListChangedType.ItemDeleted
                )
            {
                project.IsModified = true;
            }
        }
    }
}
