using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using nMars.IDE.Controls;
using nMars.IDE.Core;
using nMars.IDE.Forms;
using nMars.RedCode;

namespace nMars.IDE
{
    public class Application
    {
        #region Construction

        public Application()
        {
            ApplicationInstance = this;
        }

        public int Run()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();


            Console = new Console();
            Console.Attach(mainForm.tabBottom, "Console");

            SolutionExplorer = new SolutionExplorer();
            SolutionExplorer.Attach(mainForm.tabExplorers, "Solution");
            
            Settings=new IDESettings();
            Settings.Reload();
            if (Settings.RecentProjects == null)
            {
                Settings.RecentProjects =new List<string>();
            }
            if (Settings.RecentProjects.Count != 0
                && Settings.LoadRecentProject 
                && File.Exists(Settings.RecentProjects[Settings.RecentProjects.Count - 1]))
            {
                LoadSolution(Settings.RecentProjects[Settings.RecentProjects.Count - 1]);
            }
            else
            {
                NewSolution();
            }
            mainForm.RefreshRecent();
            RefreshUI();
            
            System.Windows.Forms.Application.Run(mainForm);
            Settings.Save();
            return 0;
        }

        public static bool ClosingApplication()
        {
            foreach (IEditor editor in Editors)
            {
                if (!editor.Closing())
                {
                    return false;
                }
            }
            bool res=SaveSolution();
            RefreshUI();
            return res;
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
            RefreshUI();
        }

        public static void OpenNewWarrior()
        {
            WarriorDocument warrior = WarriorDocument.New();
            warrior.Open();
            RefreshUI();
        }

        public static void OpenExistingWarrior()
        {
            mainForm.openDialog.Title = "Open existing warriors";
            mainForm.openDialog.Multiselect = true;
            mainForm.openDialog.Filter = "Warrior Sources|*.red;*.rc|All Files|*.*";
            mainForm.openDialog.FilterIndex = 1;
            mainForm.openDialog.DefaultExt = "red";
            DialogResult dr = mainForm.openDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (string fileName in mainForm.openDialog.FileNames)
                {
                    OpenExistingWarrior(fileName);
                }
            }
            RefreshUI();
        }

        public static void ActivateDocument(ProjectDocument document)
        {
            document.Open();
            RefreshUI();
        }

        public static void OpenExistingWarrior(string filename)
        {
            WarriorDocument.Load(filename).Open();
            RefreshUI();
        }

        public static bool SaveDocument(Document doc)
        {
            bool res = doc.Save();
            RefreshUI();
            return res;
        }

        public static void CloseDocument(Document doc)
        {
            if (doc.Closing())
            {
                doc.Close();
            }
            RefreshUI();
        }

        public static void AddExistingWarrior(RedCodeProject project)
        {
            mainForm.openDialog.Title = "Open existing warriors";
            mainForm.openDialog.Multiselect = true;
            mainForm.openDialog.Filter = "Warrior Sources|*.red;*.rc|All Files|*.*";
            mainForm.openDialog.FilterIndex = 1;
            mainForm.openDialog.DefaultExt = "red";
            DialogResult dr = mainForm.openDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (string fileName in mainForm.openDialog.FileNames)
                {
                    WarriorDocument.Load(fileName, project);
                }
            }
            RefreshUI();
        }

        public static void AddNewWarrior(RedCodeProject project)
        {
            WarriorDocument.New(project).Open();
            RefreshUI();
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
            RefreshUI();
        }


        public static void AddIntoProject(ProjectDocument document)
        {
            ActiveSolution.ActiveProject.Add(document);
            RefreshUI();
        }

        public static void RemoveFromProject(ProjectDocument document)
        {
            document.Project.Remove(document, false);
            RefreshUI();
        }

        #endregion

        #region Projects

        public static void AddNewProject()
        {
            RedCodeProject.New(ActiveSolution);
            RefreshUI();
        }

        public static void RemoveProject(RedCodeProject project, bool delete)
        {
            ActiveSolution.Remove(project, delete);
            RefreshUI();
        }

        public static void AddExistingProject()
        {
            mainForm.openDialog.Title = "Add existing project";
            mainForm.openDialog.Multiselect = false;
            mainForm.openDialog.Filter = "Warrior Project|*.redProj";
            mainForm.openDialog.FilterIndex = 1;
            mainForm.openDialog.DefaultExt = "redProj";
            DialogResult dr = mainForm.openDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                RedCodeProject.Load(mainForm.openDialog.FileName, ActiveSolution);
            }
            RefreshUI();
        }

        public static bool SaveProject(RedCodeProject project)
        {
            bool res = project.Save();
            RefreshUI();
            return res;
        }

        public static void SetProjectActive(RedCodeProject project)
        {
            ActiveSolution.ActiveProject = project;
            RefreshUI();
        }


        public static bool SaveSolution()
        {
            bool res=ActiveSolution.Save();
            if (res)
            {
                AddRecentProject(ActiveSolution.FileName);
            }
            RefreshUI();
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
            mainForm.RefreshRecent();
        }

        public static void OpenSolution()
        {
            if (ActiveSolution.Closing())
            {
                ActiveSolution.Close();
                mainForm.openDialog.Title = "Open existing solution";
                mainForm.openDialog.Multiselect = false;
                mainForm.openDialog.Filter = "Warrior Solution|*.redSln";
                mainForm.openDialog.FilterIndex = 1;
                mainForm.openDialog.DefaultExt = "redSln";
                DialogResult dr = mainForm.openDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    LoadSolution(mainForm.openDialog.FileName);
                    AddRecentProject(mainForm.openDialog.FileName);
                }
            }
            RefreshUI();
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
                mainForm.RefreshRecent();
                RefreshUI();
            }
            else
            {
                if (Settings.RecentProjects.Contains(fileName))
                {
                    Settings.RecentProjects.Remove(fileName);
                    mainForm.RefreshRecent();
                }
            }
        }

        public static void CloseSolution()
        {
            if (ActiveSolution == null || ActiveSolution.Closing())
            {
                if (ActiveSolution != null)
                    ActiveSolution.Close();
                NewSolution();
            }
            RefreshUI();
        }

        private static void NewSolution()
        {
            ActiveSolution = RedCodeSolution.New();
            AddNewProject();
            ActiveSolution.IsModified = false;
            SolutionExplorer.ReloadSolution();
            RefreshUI();
        }

        public static void RefreshUI()
        {
            mainForm.RefreshUI();
            //? SolutionExplorer.ReloadSolution();
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
            CommandLine.RunParser(files, ActiveSolution.ComponentSetup.Parser, Rules.DefaultRules, ParserOptions.Ide,
                                 Console);
            RefreshUI();
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
            string[] a = new string[project.Documents.Keys.Count];
            project.Documents.Keys.CopyTo(a, 0);
            CommandLine.RunParser(a, ActiveSolution.ComponentSetup.Parser, ActiveSolution.ActiveProject.Rules,
                                 ActiveSolution.ActiveProject.ParserOptions, Console);
            RefreshUI();
        }

        public static void Start(RedCodeProject project)
        {
            if (ActiveSolution.ActiveProject.Documents.Count==0)
                return;
            RedCodeProject pd = ActiveSolution.ActiveProject;
            Project p = new Project(new Rules(pd.Rules));
            p.EngineOptions = pd.EngineOptions;
            p.ParserOptions = pd.ParserOptions;
            string[] files=new string[pd.Documents.Count];
            pd.Documents.Keys.CopyTo(files, 0);
            if (CommandLine.RunParser(files, ActiveSolution.ComponentSetup.Parser, p, Console) > 0)
            {
                ActiveSolution.ComponentSetup.DebuggerEngine.Run(p, mainForm.AsyncHub.MatchFinishedCallback);
            }
        }

        public static void MatchFinished()
        {
            MatchResult match = ActiveSolution.ComponentSetup.DebuggerEngine.EndMatch();
            match.Dump(Console, ActiveSolution.ComponentSetup.DebuggerEngine.Project);
        }

        
        #endregion

        #region Variables

        public static RedCodeSolution ActiveSolution;
        public static Application ApplicationInstance;
        public static IEngine ActiveEngine;
        //TODO public static bool PendingOperation; disble controls

        //editors
        public static List<IEditor> Editors = new List<IEditor>();
        public static IEditor ActiveEditor;

        //UI
        public static SolutionExplorer SolutionExplorer;
        public static Console Console;
        public static MainForm mainForm;
        
        //setting
        public static IDESettings Settings;

        #endregion
    }
}