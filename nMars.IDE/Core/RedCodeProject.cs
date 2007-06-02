// This file is part of nMars - Core War MARS for .NET 
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
            Project.EngineOptions.InitRoundBefore = true;
            Project.Rules.WarriorsCount = 0;
        }

        private RedCodeProject(string aFileName)
        {
            fileName = aFileName;
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
            IDEApplication.Instance.SolutionExplorer.ReloadSolution();
            return res;
        }

        public override void Load()
        {
            //TODO: solve lost files
            Project = Project.LoadXml(FileName);

            if (Project.WarriorFiles.Count > 0)
            {
                foreach (string documentFile in Project.WarriorFiles)
                {
                    //TODO: other document types
                    ProjectDocument document = ProjectDocument.Load(documentFile, "WarriorDocument"); 
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
                IDEApplication.Instance.Editors.Remove(Editor);
                Editor = null;
            }
            IDEApplication.Instance.SolutionExplorer.ReloadSolution();
        }

        public override void Open()
        {
            if (!MonoCheck.IsMonoRuntime)
            {
                InitializeNonMono();
            }
        }

        private void InitializeNonMono()
        {
#if !MONO
            if (Editor == null)
            {
                Editor = new ProjectEditor(this);
                Editor.Attach(IDEApplication.Instance.MainForm.tabDocuments, Name);
            }
            else
            {
                Editor.ActivateControl();
            }
#endif
        }

        public void Add(ProjectDocument document)
        {
            if (document != null && !Documents.ContainsValue(document))
            {
                Documents.Add(document.FileName, document);
                Project.WarriorFiles.Add(document.FileName);
                document.Project = this;
                IsModified = true;
                IDEApplication.Instance.SolutionExplorer.ReloadSolution();
                Project.Rules.WarriorsCount++;
            }
        }

        public void Remove(ProjectDocument document, bool delete)
        {
            document.Project = null;
            Documents.Remove(document.FileName);
            Project.WarriorFiles.Remove(document.FileName);
            IsModified = true;
            IDEApplication.Instance.SolutionExplorer.ReloadSolution();
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
                CheckPropertyChanged("Rounds", ref Project.Rules.Rounds, ref value);
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
                CheckPropertyChanged("MaxCycles", ref Project.Rules.MaxCycles, ref value);
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
                CheckPropertyChanged("MaxProcesses", ref Project.Rules.MaxProcesses, ref value);
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
                CheckPropertyChanged("MaxLength", ref Project.Rules.MaxLength, ref value);
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
                CheckPropertyChanged("MinDistance", ref Project.Rules.MinDistance, ref value);
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
                CheckPropertyChanged("WarriorsCount", ref Project.Rules.WarriorsCount, ref value);
            }
        }

        public int CoreSize
        {
            get
            {
                return Project.Rules.CoreSize;
            }
            set
            {
                CheckPropertyChanged("CoreSize", ref Project.Rules.CoreSize, ref value);
            }
        }

        public int PSpaceSize
        {
            get
            {
                return Project.Rules.PSpaceSize;
            }
            set
            {
                CheckPropertyChanged("PSpaceSize", ref Project.Rules.PSpaceSize, ref value);
            }
        }

        public string EngineMode
        {
            get
            {
                return Project.EngineOptions.EngineMode.ToString();
            }
            set
            {
                string old = Project.EngineOptions.EngineMode.ToString();
                Project.EngineOptions.EngineMode = (EngineMode)Enum.Parse(typeof(EngineMode), value);
                CheckPropertyChanged("EngineMode", ref old, ref value);
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
            IDEApplication.Instance.SolutionExplorer.ReloadSolution();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}