// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

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
            Rules = new Rules();
            ParserOptions = new ParserOptions();
            EngineOptions = new EngineOptions();
            ParserOptions.Brief = true;
            ParserOptions.Status = true;
        }

        #endregion

        #region Public

        public static RedCodeProject Load(string fileName)
        {
            RedCodeProject project = new RedCodeProject();
            project.FileName = fileName;
            project.Load();
            project.IsNew = false;
            project.IsModified = false;
            return project;
        }

        public static RedCodeProject New()
        {
            RedCodeProject project = new RedCodeProject();
            DocCounter++;
            project.FileName = "NewProject" + DocCounter.ToString() + ".redProj";
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
            if (!IsNew || ChooseName("redProj", "Project"))
            {
                StreamWriter sw = new StreamWriter(FileName);
                rcpSerializer.Serialize(sw, this);
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
            RedCodeProject doc = rcpSerializer.Deserialize(sr) as RedCodeProject;
            sr.Close();

            if (doc.Documents.Keys.Count > 0)
            {
                string[] keys = new string[doc.Documents.Keys.Count];
                doc.Documents.Keys.CopyTo(keys, 0);
                foreach (string documentFile in keys)
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
                document.Project = this;
                IsModified = true;
                Application.SolutionExplorer.ReloadSolution();
            }
        }

        public void Remove(ProjectDocument document, bool delete)
        {
            document.Project = null;
            Documents.Remove(document.FileName);
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
            Documents.Add(newFileName, document);
        }

        #endregion

        #region XML

        private static XmlSerializer rcpSerializerCached;

        private static XmlSerializer rcpSerializer
        {
            get
            {
                if (rcpSerializerCached == null)
                {
                    rcpSerializerCached = new XmlSerializer(typeof(RedCodeProject));
                }
                return rcpSerializerCached;
            }
        }

        #endregion

        #region Variables

        [XmlIgnore]
        public RedCodeSolution Solution;

        public EngineOptions EngineOptions;

        public ParserOptions ParserOptions;

        public Rules Rules;
        public KeySerializableDictionary<ProjectDocument> Documents = new KeySerializableDictionary<ProjectDocument>();

        #endregion
    }
}