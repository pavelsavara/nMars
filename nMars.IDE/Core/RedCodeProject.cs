// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using nMars.IDE.Controls;
using nMars.RedCode;
using nMars.RedCode.Utils;

namespace nMars.IDE.Core
{
    public class RedCodeProject : Document, INotifyPropertyChanged

    {
        #region Construction

        public RedCodeProject()
        {
            Project=new Project();
            Project.ParserOptions = ParserOptions.Ide;
            Project.EngineOptions.StatusLine = true;
        }

        private RedCodeProject(string filename)
        {
            FileName = filename;
            Load();
            IsNew = false;
            IsModified = false;
        }

        #endregion

        #region Public

        public static RedCodeProject Load(string fileName)
        {
            RedCodeProject project = new RedCodeProject(fileName);
            return project;
        }

        public static RedCodeProject New()
        {
            RedCodeProject project = new RedCodeProject();
            ProjectCounter++;
            project.Project.Rules.WarriorsCount = 0;
            project.FileName = "NewProject" + ProjectCounter + ".nmproj";
            project.IsNew = true;
            project.IsModified = false;
            return project;
        }

        public static RedCodeProject Load(string fileName, RedCodeSolution solution)
        {
            if (solution.Projects.ContainsKey(fileName))
            {
                return solution.Projects[fileName];
            }
            RedCodeProject project = Load(fileName);
            solution.Add(project);
            return project;
        }

        public static RedCodeProject New(RedCodeSolution solution)
        {
            RedCodeProject project = New();
            solution.Add(project);
            return project;
        }

        public override bool Save()
        {
            bool res = true;
            if (IsModified)
            {
                if (IsNew)
                {
                    res = ChooseName("nmproj", "Project");
                }
                if (res)
                {
                    Project.SaveXml(FileName);
                    IsModified = false;
                    IsNew = false;
                }
            }
            else
            {
                res = true;
            }
            IDEApplication.SolutionExplorer.ReloadSolution();
            return res;
        }

        public override void Load()
        {
            Project = Project.LoadXml(FileName);

            if (Project.WarriorFiles.Count > 0)
            {
                foreach (string documentFile in Project.WarriorFiles)
                {
                    ProjectDocument document = ProjectDocument.Load(documentFile, "WarriorDocument"); //TODO
                    Documents[documentFile] = document;
                    document.Project = this;
                }
            }
            IsModified = false;
            IsNew = false;
        }

        public override string FileName
        {
            set
            {
                if (Solution != null)
                {
                    Solution.Move(this, value);
                }
                fileName = value;
            }
        }

        public override void Close()
        {
            if (Editor != null)
            {
                Editor.Detach();
                IDEApplication.Editors.Remove(Editor);
                Editor = null;
            }
            IDEApplication.SolutionExplorer.ReloadSolution();
        }

        public override void Open()
        {
            if (Editor == null)
            {
                Editor = new ProjectEditor(this);
                Editor.Attach(IDEApplication.MainForm.tabDocuments, Name);
            }
            else
            {
                Editor.ActivateControl();
            }
        }

        public void Add(ProjectDocument document)
        {
            if (document != null && !Documents.ContainsValue(document))
            {
                Documents.Add(document.FileName, document);
                Project.WarriorFiles.Add(document.FileName);
                document.Project = this;
                IsModified = true;
                IDEApplication.SolutionExplorer.ReloadSolution();
                Project.Rules.WarriorsCount++;
            }
        }

        public void Remove(ProjectDocument document, bool delete)
        {
            document.Project = null;
            Documents.Remove(document.FileName);
            Project.WarriorFiles.Remove(document.FileName);
            IsModified = true;
            IDEApplication.SolutionExplorer.ReloadSolution();
            Project.Rules.WarriorsCount--;
            if (delete && File.Exists(document.FileName))
            {
                File.Delete(document.FileName);
            }
        }

        public void Move(ProjectDocument document, string newFileName)
        {
            Documents.Remove(document.FileName);
            Project.WarriorFiles.Remove(document.FileName);

            Documents.Add(newFileName, document);
            Project.WarriorFiles.Add(newFileName);
        }

        public void Activate(ProjectDocument document)
        {
            if (Project.InactiveWarriorFiles.Contains(document.FileName))
            {
                Project.InactiveWarriorFiles.Remove(document.FileName);
                Project.WarriorFiles.Remove(document.FileName);
                Project.WarriorFiles.Insert(0, document.FileName);
                Project.Rules.WarriorsCount--;
            }
        }

        public void Deactivate(ProjectDocument document)
        {
            if (!Project.InactiveWarriorFiles.Contains(document.FileName))
            {
                Project.InactiveWarriorFiles.Add(document.FileName);
                Project.WarriorFiles.Remove(document.FileName);
                Project.WarriorFiles.Add(document.FileName);
                Project.Rules.WarriorsCount++;
            }
        }
        #endregion

        #region Variables

        public override bool IsModified
        {
            get
            {
                return base.IsModified;
            }
            set
            {
                if (value && Solution.IsNew)
                {
                    Solution.IsModified = true;
                }
                base.IsModified = value;
            }
        }

        public Project Project;

        [XmlIgnore]
        public RedCodeSolution Solution;

        [XmlIgnore]
        public Dictionary<string, ProjectDocument> Documents = new Dictionary<string, ProjectDocument>();

        public static int ProjectCounter = 0;
        #endregion

        #region Rule Property Forwarding

        public int Rounds
        {
            get
            {
                return Project.Rules.Rounds;
            }
            set
            {
                CheckPropertyChanged<int>("Rounds", ref Project.Rules.Rounds, ref value);
            }
        }

        public int MaxCycles
        {
            get
            {
                return Project.Rules.MaxCycles;
            }
            set
            {
                CheckPropertyChanged<int>("MaxCycles", ref Project.Rules.MaxCycles, ref value);
            }
        }

        public int MaxProcesses
        {
            get
            {
                return Project.Rules.MaxProcesses;
            }
            set
            {
                CheckPropertyChanged<int>("MaxProcesses", ref Project.Rules.MaxProcesses, ref value);
            }
        }

        public int MaxLength
        {
            get
            {
                return Project.Rules.MaxLength;
            }
            set
            {
                CheckPropertyChanged<int>("MaxLength", ref Project.Rules.MaxLength, ref value);
            }
        }

        public int MinDistance
        {
            get
            {
                return Project.Rules.MinDistance;
            }
            set
            {
                CheckPropertyChanged<int>("MinDistance", ref Project.Rules.MinDistance, ref value);
            }
        }

        public int WarriorsCount
        {
            get
            {
                return Project.Rules.WarriorsCount;
            }
            set
            {
                CheckPropertyChanged<int>("WarriorsCount", ref Project.Rules.WarriorsCount, ref value);
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private bool CheckPropertyChanged<T>(string propertyName, ref T oldValue, ref T newValue)
        {
            if (oldValue == null && newValue == null)
            {
                return false;
            }

            if ((oldValue == null && newValue != null) || !oldValue.Equals((T)newValue))
            {
                oldValue = newValue;

                FirePropertyChanged(propertyName);

                return true;
            }

            return false;
        }

        private void FirePropertyChanged(string propertyName)
        {
            IsModified = true;
            IDEApplication.SolutionExplorer.ReloadSolution();
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}