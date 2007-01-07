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

namespace nMars.IDE
{
    public class Application
    {
        #region Construction

        public Application()
        {
            ApplicationInstance = this;
        }

        public int Main()
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
            MainForm.RefreshRecent();
            RefreshUI();
            
            System.Windows.Forms.Application.Run(MainForm);
            Settings.Save();
            return 0;
        }

        public static bool ClosingApplication()
        {
            if (ActiveEngine !=null && ActiveEngine.IsLive)
            {
                ActiveEngine.Kill();
            }
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
                MainForm.RefreshRecent();
                RefreshUI();
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
            MainForm.RefreshUI();
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

            ActiveSolution.Components.Parser.Parse(ActiveProject.Project, Console);
            
            RefreshUI();
        }


        public static void Run(RedCodeProject project, int brake)
        {
            if (ActiveSolution.ActiveProject.Documents.Count == 0)
                return;

            if (ActiveEngine == null)
            {
                ParseResult result = ActiveSolution.Components.Parser.Parse(ActiveProject.Project, Console);

                if (result.Succesfull)
                {
                    ActiveProject.Project.EngineOptions.Brake = brake;
                    if (brake == executeBrake)
                    {
                        ActiveSolution.Components.Engine.Run(ActiveProject.Project, Console.GetAsyncWrapper());
                    }
                    else
                    {
                        Console.WriteLine("========== Running ==========");
                        ActiveEngine = ActiveSolution.Components.Engine as IAsyncEngine;
                        ActiveEngine.BeginMatch(ActiveProject.Project, engineStopped);
                        BeginWatch();
                        ActiveEngine.Continue();
                    }
                }
            }
            else
            {
                ActiveEngine.Brake = brake;
                if (ActiveEngine.IsPaused)
                {
                    ActiveEngine.Continue();
                    Console.WriteLine("========== Running ==========");
                    ResumeWatch();
                }
            }
            ActiveBrake = brake;
            MainForm.RefreshUI();
        }

        private static void EngineStopped(bool finished)
        {
            if (ActiveEngine==null)
                return;
            if (finished)
            {
                ActiveEngine.EndMatch(Console.GetAsyncWrapper());
                ActiveEngine = null;
                EndWatch();
            }
            else
            {
                Console.WriteLine("========== Paused ==========");
                PauseWatch();
            }
            MainForm.RefreshUI();
        }

        public static void Stop()
        {
            if (ActiveEngine == null)
                return;

            ActiveEngine.Quit();
        }

        public static void Pause()
        {
            if (ActiveEngine == null)
                return;

            ActiveEngine.Pause();
        }

        public static void Continue()
        {
            if (ActiveEngine == null)
                return;

            ActiveEngine.Continue();
            Console.WriteLine("========== Running ==========");
            ResumeWatch();
        }

        public static void Step()
        {
            if (ActiveEngine == null)
                return;

            ActiveEngine.NextStep();
            WatchTick();
            Console.WriteLine("========== Step ==========");
        }

        public static void StepThread()
        {
            //TODO
        }

        public static void StepWarrior()
        {
            //TODO
        }

        public static void Back()
        {
            if (ActiveEngine == null || !ActiveEngine.CanStepBack)
                return;

            ActiveEngine.PrevStep();
            WatchTick();
            Console.WriteLine("========== Back ==========");
        }

        private delegate void boolDelegate(bool logical);

        private static void engineStopped(bool finished)
        {
            MainForm.Invoke(new boolDelegate(EngineStopped), finished);
        }

        #endregion

        #region Watch Core

        private static void BeginWatch()
        {
            DebugOverview=new DebugOverview();
            DebugOverview.Attach(MainForm.tabBottom, "Debug Overview");
            DebugMemoryListing=new DebugMemoryListing();
            DebugMemoryListing.Attach(MainForm.tabExplorers, "Memory Listing");
            DebugMemoryGraph=new DebugMemoryGraph();
            DebugMemoryGraph.Attach(MainForm.tabDocuments, "Memory Graph");
            DebugOverview.ActivateControl();
            DebugMemoryListing.ActivateControl();
            DebugMemoryGraph.ActivateControl();
            MainForm.timerDebugWatch.Enabled = true;
        }

        public static void PauseWatch()
        {
            MainForm.timerDebugWatch.Enabled = false;
            DebugOverview.Pause();
            DebugMemoryListing.Pause();
            DebugMemoryGraph.Pause();
            //WatchTick();
        }

        public static void ResumeWatch()
        {
            DebugOverview.Resume();
            DebugMemoryListing.Resume();
            DebugMemoryGraph.Resume();
            MainForm.timerDebugWatch.Enabled = true;
        }

        public static void WatchTick()
        {
            if (ActiveEngine == null || DebugOverview == null)
                return;

            lock (ActiveEngine)
            {
                DebugOverview.RepaintView();
                DebugMemoryListing.RepaintView();
                DebugMemoryGraph.RepaintView();
                ActiveEngine.UiTickDone();
            }
        }

        private static void EndWatch()
        {
            MainForm.timerDebugWatch.Enabled = false;
            DebugOverview.Detach();
            DebugMemoryListing.Detach();
            DebugMemoryGraph.Detach();
            ActiveBrake = executeBrake;
        }

        public const int slowRunBrake = 400;
        public const int normalRunBrake = 10;
        public const int fastRunBrake = 1;
        public const int executeBrake = -1;

        public static void ShowAddress(int address)
        {
            DebugMemoryListing.ShowAddress(address);
        }

        public static void EditCell(int address)
        {
            //TODO breakpoints + cell values, 
            // dialog and tabs ?
        }

        #endregion

        #region Variables

        public static RedCodeSolution ActiveSolution;
        public static RedCodeProject ActiveProject;
        public static Application ApplicationInstance;
        public static IAsyncEngine ActiveEngine;
        public static int ActiveBrake = executeBrake;

        //editors
        public static List<IEditor> Editors = new List<IEditor>();
        public static IEditor ActiveEditor;

        //UI
        public static SolutionExplorer SolutionExplorer;
        public static Console Console;
        public static MainForm MainForm;
        public static DebugOverview DebugOverview;
        public static DebugMemoryListing DebugMemoryListing;
        public static DebugMemoryGraph DebugMemoryGraph;
        
        //setting
        internal static IDESettings Settings;

        #endregion
    }
}