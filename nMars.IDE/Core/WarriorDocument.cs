// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;
using System.Reflection;
using nMars.IDE.Controls;
using nMars.RedCode;
using nMars.RedCode.Modules;

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
                IDEApplication.Instance.SolutionExplorer.ReloadSolution();
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
                IDEApplication.Instance.Editors.Remove(Editor);
                Editor = null;
            }
            IDEApplication.Instance.SolutionExplorer.ReloadSolution();
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
                else
                {
                    string templateOverride = Path.Combine(ModuleRegister.BasePath,"template.red");
                    if (File.Exists(templateOverride))
                    {
                        StreamReader sr = new StreamReader(templateOverride);
                        Editor.EditedText = sr.ReadToEnd();
                        sr.Close();
                    }
                    else
                    {
                        Assembly assembly = typeof(WarriorDocument).Assembly;
                        Stream template = assembly.GetManifestResourceStream("nMars.IDE.Resources.template.red");
                        StreamReader reader = new StreamReader(template);
                        Editor.EditedText = reader.ReadToEnd();
                        reader.Close();
                    }
                }
                //?? IsModified = false;
                Editor.Attach(IDEApplication.Instance.MainForm.tabDocuments, Name);
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