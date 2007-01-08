// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using nMars.IDE.Controls;
using nMars.IDE.Core;
using nMars.IDE.Forms;
using nMars.IDE.Properties;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.IDE
{
    public class IDEApplication
    {
        #region Construction

        public int Main(string[] args)
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();


            Console = new Console();
            Console.Attach(MainForm.tabBottom, "Console");

            SolutionExplorer = new SolutionExplorer();
            SolutionExplorer.Attach(MainForm.tabExplorers, "Solution");
            
            Settings=new IDESettings();
            Settings.Reload();
            if (Settings.RecentProjects == null)
            {
                Settings.RecentProjects =new List<string>();
            }

            if (args.Length>0)
            {
                NewSolution(args);
            }
            else
            {
                if (Settings.RecentProjects.Count != 0
                    && Settings.LoadRecentProject 
                    && File.Exists(Settings.RecentProjects[Settings.RecentProjects.Count - 1]))
                {
                    LoadSolution(Settings.RecentProjects[Settings.RecentProjects.Count - 1]);
                }
                else
                {
                    NewSolution(null);
                }
            }
            debuggerPlugin = ModuleRegister.CreateIDEPlugin("nMars.IDE.Debugger");
            debuggerPlugin.Load();


            MainForm.RefreshRecent();
            IDEApplication.RefreshControls();
            
            System.Windows.Forms.Application.Run(MainForm);
            Settings.Save();
            return 0;
        }

        public static bool ClosingApplication()
        {
            debuggerPlugin.Unload();

            foreach (IEditor editor in Editors)
            {
                if (!editor.Closing())
                {
                    return false;
                }
            }
            bool res=SaveSolution();
            RefreshControls();
            return res;
        }

        public static void RefreshControls()
        {
            bool openEditor = IDEApplication.ActiveEditor != null;
            bool openWarrior = openEditor && IDEApplication.ActiveEditor.Document is WarriorDocument;
            MainForm.saveWarriorToolStripMenuItem.Enabled = openWarrior;
            MainForm.compileWarriorToolStripMenuItem.Enabled = openWarrior;
            MainForm.closeWarriorToolStripMenuItem.Enabled = openWarrior;
            MainForm.lbDocClose.Visible = openEditor;

            bool warrior = IDEApplication.ActiveEditor != null;
            MainForm.compileWarriorToolStripMenuItem.Enabled = warrior;

            if (debuggerPlugin!=null)
                debuggerPlugin.RefreshControls();
            //? SolutionExplorer.ReloadSolution();
        }

        #endregion

        #region Documents

        public static void SaveAll()
        {
            foreach (IEditor editor in Editors)
            {
                editor.Save();
            }
            SaveSolution();
            RefreshControls();
        }

        public static void OpenNewWarrior()
        {
            WarriorDocument warrior = WarriorDocument.New();
            warrior.Open();
            RefreshControls();
        }

        public static void OpenExistingWarrior()
        {
            MainForm.openDialog.Title = "Open existing warriors";
            MainForm.openDialog.Multiselect = true;
            MainForm.openDialog.Filter = "Warrior Sources|*.red;*.rc|All Files|*.*";
            MainForm.openDialog.FilterIndex = 1;
            MainForm.openDialog.DefaultExt = "red";
            DialogResult dr = MainForm.openDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (string fileName in MainForm.openDialog.FileNames)
                {
                    OpenExistingWarrior(fileName);
                }
            }
            RefreshControls();
        }

        public static void ActivateDocument(ProjectDocument document)
        {
            document.Open();
            RefreshControls();
        }

        public static void OpenExistingWarrior(string filename)
        {
            WarriorDocument.Load(filename).Open();
            RefreshControls();
        }

        public static bool SaveDocument(Document doc)
        {
            bool res = doc.Save();
            RefreshControls();
            return res;
        }

        public static void CloseDocument(Document doc)
        {
            if (doc.Closing())
            {
                doc.Close();
            }
            RefreshControls();
        }

        public static void AddExistingWarrior(RedCodeProject project)
        {
            MainForm.openDialog.Title = "Open existing warriors";
            MainForm.openDialog.Multiselect = true;
            MainForm.openDialog.Filter = "Warrior Sources|*.red;*.rc|All Files|*.*";
            MainForm.openDialog.FilterIndex = 1;
            MainForm.openDialog.DefaultExt = "red";
            DialogResult dr = MainForm.openDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (string fileName in MainForm.openDialog.FileNames)
                {
                    WarriorDocument.Load(fileName, project);
                }
            }
            RefreshControls();
        }

        public static void AddNewWarrior(RedCodeProject project)
        {
            WarriorDocument.New(project).Open();
            RefreshControls();
        }

        public static void RemoveWarrior(WarriorDocument warrior, bool delete)
        {
            if (warrior.Closing())
            {
                warrior.Close();
                if (warrior.Project != null)
                {
                    warrior.Project.Remove(warrior, delete);
                }
            }
            RefreshControls();
        }


        public static void AddIntoProject(ProjectDocument document)
        {
            ActiveSolution.ActiveProject.Add(document);
            RefreshControls();
        }

        public static void RemoveFromProject(ProjectDocument document)
        {
            document.Project.Remove(document, false);
            RefreshControls();
        }

        #endregion

        #region Projects

        public static void AddNewProject()
        {
            RedCodeProject.New(ActiveSolution);
            RefreshControls();
        }

        public static void RemoveProject(RedCodeProject project, bool delete)
        {
            ActiveSolution.Remove(project, delete);
            RefreshControls();
        }

        public static void AddExistingProject()
        {
            MainForm.openDialog.Title = "Add existing project";
            MainForm.openDialog.Multiselect = false;
            MainForm.openDialog.Filter = "Warrior Project|*.redProj";
            MainForm.openDialog.FilterIndex = 1;
            MainForm.openDialog.DefaultExt = "redProj";
            DialogResult dr = MainForm.openDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                RedCodeProject.Load(MainForm.openDialog.FileName, ActiveSolution);
            }
            RefreshControls();
        }

        public static bool SaveProject(RedCodeProject project)
        {
            bool res = project.Save();
            RefreshControls();
            return res;
        }

        public static void SetProjectActive(RedCodeProject project)
        {
            ActiveSolution.ActiveProject = project;
            RefreshControls();
        }


        public static bool SaveSolution()
        {
            bool res=ActiveSolution.Save();
            if (res)
            {
                AddRecentProject(ActiveSolution.FileName);
            }
            RefreshControls();
            return res;
        }

        private static void AddRecentProject(string filename)
        {
            int idx = Settings.RecentProjects.IndexOf(filename);
            if (idx != -1 && idx != (Settings.RecentProjects.Count - 1))
            {
                Settings.RecentProjects.RemoveAt(idx);
            }
            Settings.RecentProjects.Add(ActiveSolution.FileName);
            Settings.Save();
            MainForm.RefreshRecent();
        }

        public static void OpenSolution()
        {
            if (ActiveSolution.Closing())
            {
                ActiveSolution.Close();
                MainForm.openDialog.Title = "Open existing solution";
                MainForm.openDialog.Multiselect = false;
                MainForm.openDialog.Filter = "Warrior Solution|*.redSln";
                MainForm.openDialog.FilterIndex = 1;
                MainForm.openDialog.DefaultExt = "redSln";
                DialogResult dr = MainForm.openDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    LoadSolution(MainForm.openDialog.FileName);
                    AddRecentProject(MainForm.openDialog.FileName);
                }
            }
            RefreshControls();
        }

        public static void OpenSolution(string fileName)
        {
            if (ActiveSolution==null || ActiveSolution.Closing())
            {
                if (ActiveSolution != null)
                    ActiveSolution.Close();
                LoadSolution(fileName);
            }
        }
        
        public static void LoadSolution(string fileName)
        {
            if (File.Exists(fileName))
            {
                ActiveSolution = RedCodeSolution.Load(fileName);
                SolutionExplorer.ReloadSolution();
                AddRecentProject(fileName);
                MainForm.RefreshRecent();
                RefreshControls();
            }
            else
            {
                if (Settings.RecentProjects.Contains(fileName))
                {
                    Settings.RecentProjects.Remove(fileName);
                    MainForm.RefreshRecent();
                }
            }
        }

        public static void CloseSolution()
        {
            if (ActiveSolution == null || ActiveSolution.Closing())
            {
                if (ActiveSolution != null)
                    ActiveSolution.Close();
                NewSolution(null);
            }
            RefreshControls();
        }

        private static void NewSolution(string[] args)
        {
            ActiveSolution = RedCodeSolution.New();
            AddNewProject();
            ActiveSolution.IsModified = false;
            if (args!=null && args.Length>0)
            {
                ActiveProject.Project = CommandLine.Prepare(args, ActiveSolution.Components, Console);
            }
            SolutionExplorer.ReloadSolution();
            RefreshControls();
        }

        #endregion

        #region Compile & Run

        public static void Compile(WarriorDocument warrior)
        {
            if (warrior == null)
                return;
            warrior.Save();
            string[] files = new string[1];
            files[0] = warrior.FileName;

            if (warrior.Project!=null)
            {
                ActiveSolution.Components.Parser.Parse(warrior.Project.Project, Console);
            }
            else
            {
                Project tmpProj=new Project(Rules.DefaultRules, warrior.FileName);
                tmpProj.ParserOptions = ParserOptions.Ide;
                ActiveSolution.Components.Parser.Parse(tmpProj, Console);
            }
            
            RefreshControls();
        }

        public static void Compile(RedCodeProject project)
        {
            foreach (IEditor editor in Editors)
            {
                if (editor.Document is ProjectDocument && (editor.Document as ProjectDocument).Project == project)
                {
                    editor.Save();
                }
            }

            ActiveSolution.Components.Parser.Parse(ActiveProject.Project, Console);
            
            RefreshControls();
        }

        #endregion

        #region Variables

        public static RedCodeSolution ActiveSolution;
        public static RedCodeProject ActiveProject;

        //editors
        public static List<IEditor> Editors = new List<IEditor>();
        public static IEditor ActiveEditor;

        //UI
        public static SolutionExplorer SolutionExplorer;
        public static Console Console;
        public static MainForm MainForm;
        
        //setting
        internal static IDESettings Settings;

        private static IIDEPlugin debuggerPlugin;

        #endregion
    }
}