// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using nMars.RedCode;
using nMars.RedCode.Modules;
using nMars.RedCode.Utils;

namespace nMars.IDE.Core
{
    public class RedCodeSolution : Document
    {
        #region Construction

        public RedCodeSolution()
        {
            solution=new Solution();
            solution.Components.ParserName = IDEApplication.Settings.DefaultParser;
            solution.Components.EngineName = IDEApplication.Settings.DefaultEngine;
        }

        #endregion

        #region Public

        public ComponentLoader Components
        {
            get
            {
                return solution.Components;
            }
        }
        
        public static RedCodeSolution Load(string fileName)
        {
            RedCodeSolution solution = new RedCodeSolution();
            solution.FileName = fileName;
            solution.Load();
            solution.IsNew = false;
            solution.IsModified = false;
            return solution;
        }

        public static RedCodeSolution New()
        {
            RedCodeSolution solution = new RedCodeSolution();
            SolutionCounter++;
            solution.FileName = "NewSolution" + SolutionCounter + ".nmsln";
            solution.IsNew = true;
            solution.IsModified = false;
            return solution;
        }

        public override bool Save()
        {
            bool res = true;
            RedCodeProject[] values = new RedCodeProject[Projects.Values.Count];
            Projects.Values.CopyTo(values, 0);
            foreach (RedCodeProject project in values)
            {
                res &= project.Save();
            }
            if (IsModified)
            {
                if (IsNew)
                {
                    res = ChooseName("nmsln", "Solution");
                }
                if (res)
                {
                    solution.SaveXml(FileName);
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
            //TODO: solve lost files
            solution = Solution.LoadXml(FileName);

            if (solution.ProjectFiles.Count > 0)
            {
                foreach (string projectFile in solution.ProjectFiles)
                {
                    if (File.Exists(projectFile))
                    {
                        RedCodeProject project = RedCodeProject.Load(projectFile);
                        Projects[projectFile] = project;
                        project.Solution = this;
                    }
                }
                if (solution.ActiveProject != null && Projects.ContainsKey(solution.ActiveProject))
                {
                    ActiveProject = Projects[solution.ActiveProject];
                    IDEApplication.ActiveProject = ActiveProject;
                }
                else if (Projects.Count > 0)
                {
                    ActiveProject = Projects[solution.ProjectFiles[0]];
                    IDEApplication.ActiveProject = ActiveProject;
                }
            }
            IsModified = false;
            IsNew = false;
        }

        public override bool Closing()
        {
            foreach (RedCodeProject project in Projects.Values)
            {
                if (!project.Closing())
                {
                    return false;
                }
            }
            return base.Closing();
        }

        public override void Close()
        {
        }

        public override void Open()
        {
        }

        public RedCodeProject ActiveProject
        {
            get { return activeProject; }
            set
            {
                if (value == null)
                {
                    activeProject = null;
                }
                else
                {
                    if (!Projects.ContainsValue(value))
                    {
                        throw new InvalidOperationException("Project is not member of solution");
                    }
                    activeProject = value;
                    if (activeProject ==null)
                    {
                        solution.ActiveProject = null;
                    }
                    else
                    {
                        solution.ActiveProject = value.FileName;
                    }
                }
                IDEApplication.ActiveProject = ActiveProject;
                IsModified = true;
            }
        }

        public void Add(RedCodeProject project)
        {
            project.Solution = this;
            Projects.Add(project.FileName, project);
            solution.ProjectFiles.Add(project.FileName);
            if (Projects.Count == 1)
            {
                ActiveProject = project;
                IDEApplication.ActiveProject = ActiveProject;
            }
            IsModified = true;
            IDEApplication.SolutionExplorer.ReloadSolution();
        }

        public void Remove(RedCodeProject project, bool delete)
        {
            project.Solution = null;
            Projects.Remove(project.FileName);
            solution.ProjectFiles.Remove(project.FileName);
            IsModified = true;
            if (Projects.Count == 0)
            {
                ActiveProject = null;
                IDEApplication.ActiveProject = ActiveProject;
            }
            else
            {
                Dictionary<string, RedCodeProject>.ValueCollection.Enumerator enumerator =
                    Projects.Values.GetEnumerator();
                enumerator.MoveNext();
                ActiveProject = enumerator.Current;
                IDEApplication.ActiveProject = ActiveProject;
            }

            IDEApplication.SolutionExplorer.ReloadSolution();
            if (delete && File.Exists(project.FileName))
            {
                File.Delete(project.FileName);
            }
            IDEApplication.SolutionExplorer.ReloadSolution();
        }

        public void Move(RedCodeProject project, string newFileName)
        {
            Projects.Remove(project.FileName);
            solution.ProjectFiles.Remove(project.FileName);
            Projects.Add(newFileName, project);
            solution.ProjectFiles.Add(newFileName);
        }

        #endregion

        #region Variables

        private Solution solution;
        private RedCodeProject activeProject;
        public Dictionary<string, RedCodeProject> Projects = new Dictionary<string, RedCodeProject>();

        public static int SolutionCounter = 0;
        #endregion
    }
}