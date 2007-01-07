// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using nMars.RedCode;
using nMars.RedCode.Utils;

namespace nMars.IDE.Core
{
    public class RedCodeProject : Document
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
            if (!IsNew || ChooseName("nmproj", "Project"))
            {
                Project.SaveXml(FileName);
            }
            else
            {
                res = false;
            }
            IsModified = false;
            IsNew = false;
            Application.SolutionExplorer.ReloadSolution();
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
        }

        public override void Open()
        {
        }

        public void Add(ProjectDocument document)
        {
            if (document != null && !Documents.ContainsValue(document))
            {
                Documents.Add(document.FileName, document);
                Project.WarriorFiles.Add(document.FileName);
                document.Project = this;
                IsModified = true;
                Application.SolutionExplorer.ReloadSolution();
            }
        }

        public void Remove(ProjectDocument document, bool delete)
        {
            document.Project = null;
            Documents.Remove(document.FileName);
            Project.WarriorFiles.Remove(document.FileName);
            IsModified = true;
            Application.SolutionExplorer.ReloadSolution();
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

        #endregion

        #region Variables

        public Project Project;

        [XmlIgnore]
        public RedCodeSolution Solution;

        [XmlIgnore]
        public Dictionary<string, ProjectDocument> Documents = new Dictionary<string, ProjectDocument>();

        public static int ProjectCounter = 0;
        #endregion
    }
}