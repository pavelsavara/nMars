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
            ComponentSetup = new ComponentSetup();
            ComponentSetup.ShellAssembly = "nMars.DbgShellPy";
            ComponentSetup.ShellName = "nMars.DbgShellPy";
        }

        #endregion

        #region Public
        
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
            DocCounter++;
            solution.FileName = "NewSolution" + DocCounter.ToString() + ".redSln";
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
            if (!IsNew || ChooseName("redSln", "Solution"))
            {
                StreamWriter sw = new StreamWriter(FileName);
                rcsSerializer.Serialize(sw, this);
                sw.Close();
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
            StreamReader sr = new StreamReader(FileName);
            RedCodeSolution doc = rcsSerializer.Deserialize(sr) as RedCodeSolution;
            sr.Close();

            if (doc.Projects.Keys.Count>0)
            {
                string[] keys = new string[doc.Projects.Keys.Count];
                doc.Projects.Keys.CopyTo(keys, 0);
                foreach (string projectFile in keys)
                {
                    if (File.Exists(projectFile))
                    {
                        RedCodeProject project = RedCodeProject.Load(projectFile);
                        Projects[projectFile] = project;
                        project.Solution = this;
                    }
                }
                string[] loadedkeys = new string[Projects.Keys.Count];
                Projects.Keys.CopyTo(loadedkeys, 0);
                if (doc.activeProjectFileName != null && Projects.ContainsKey(doc.activeProjectFileName))
                {
                    ActiveProject = Projects[doc.activeProjectFileName];
                }
                else if (Projects.Count > 0)
                {
                    ActiveProject = Projects[loadedkeys[0]];
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

        [XmlIgnore]
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
                        activeProjectFileName = null;
                    }
                    else
                    {
                        activeProjectFileName = value.FileName;
                    }
                }
                IsModified = true;
            }
        }

        public void Add(RedCodeProject project)
        {
            project.Solution = this;
            Projects.Add(project.FileName, project);
            if (Projects.Count == 1)
            {
                ActiveProject = project;
            }
            Application.SolutionExplorer.ReloadSolution();
            IsModified = true;
        }

        public void Remove(RedCodeProject project, bool delete)
        {
            project.Solution = null;
            Projects.Remove(project.FileName);
            IsModified = true;
            if (Projects.Count == 0)
            {
                ActiveProject = null;
            }
            else
            {
                Dictionary<string, RedCodeProject>.ValueCollection.Enumerator enumerator =
                    Projects.Values.GetEnumerator();
                enumerator.MoveNext();
                ActiveProject = enumerator.Current;
            }

            Application.SolutionExplorer.ReloadSolution();
            if (delete && File.Exists(project.FileName))
            {
                File.Delete(project.FileName);
            }
        }

        public void Move(RedCodeProject project, string newFileName)
        {
            Projects.Remove(project.FileName);
            Projects.Add(newFileName, project);
        }

        #endregion

        #region XML

        private static XmlSerializer rcsSerializerCached;

        private static XmlSerializer rcsSerializer
        {
            get
            {
                if (rcsSerializerCached == null)
                {
                    rcsSerializerCached = new XmlSerializer(typeof(RedCodeSolution));
                }
                return rcsSerializerCached;
            }
        }

        #endregion

        #region Variables

        [XmlIgnore]
        private RedCodeProject activeProject;

        [XmlAttribute("ActiveProject")]
        private string activeProjectFileName = null;

        public ComponentSetup ComponentSetup = new ComponentSetup();
        public KeySerializableDictionary<RedCodeProject> Projects = new KeySerializableDictionary<RedCodeProject>();

        #endregion
    }
}