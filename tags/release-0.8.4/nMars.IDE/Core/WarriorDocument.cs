// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;
using nMars.IDE.Controls;
using nMars.RedCode;

namespace nMars.IDE.Core
{
    public class WarriorDocument : TextDocument
    {
        public static WarriorDocument Load(string fileName)
        {
            WarriorDocument warrior = new WarriorDocument();
            warrior.FileName = fileName;
            warrior.IsNew = false;
            warrior.IsModified = false;
            return warrior;
        }

        public static WarriorDocument Load(string fileName, RedCodeProject project)
        {
            if (project.Documents.ContainsKey(fileName))
            {
                return project.Documents[fileName] as WarriorDocument;
            }
            WarriorDocument res = Load(fileName);
            project.Add(res);
            return res;
        }

        public static WarriorDocument New()
        {
            WarriorDocument warrior = new WarriorDocument();
            DocCounter++;
            warrior.FileName = "NewWarrior" + DocCounter + ".red";
            warrior.IsNew = true;
            warrior.IsModified = false;
            return warrior;
        }

        public static WarriorDocument New(RedCodeProject project)
        {
            WarriorDocument res = New();
            project.Add(res);
            return res;
        }

        public override bool Save()
        {
            bool res = true;
            if (Editor != null && (!IsNew || ChooseName("red", "Warrior")))
            {
                StreamWriter sw = new StreamWriter(FileName, false);
                sw.Write(Editor.EditedText);
                sw.Close();
                IsModified = false;
                IsNew = false;
                Editor.PageName = Name;
                IDEApplication.SolutionExplorer.ReloadSolution();
            }
            else
            {
                res = false;
            }
            return res;
        }

        public override string FileName
        {
            set
            {
                if (Project != null)
                {
                    Project.Move(this, value);
                }
                fileName = value;
            }
        }

        public override void Close()
        {
            if (IsNew && Project != null)
            {
                Project.Remove(this, false);
            }
            IsNew = false;
            IsModified = false;
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
                Editor = new TextEditor(this);
                if (!IsNew)
                {
                    StreamReader sr = new StreamReader(FileName);
                    Editor.EditedText = sr.ReadToEnd();
                    sr.Close();
                }
                //?? IsModified = false;
                Editor.Attach(IDEApplication.MainForm.tabDocuments, Name);
            }
            else
            {
                Editor.ActivateControl();
            }
        }

        public override void Load()
        {
        }

        public IWarrior Warrior;
    }
}