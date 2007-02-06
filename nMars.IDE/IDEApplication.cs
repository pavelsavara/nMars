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
    public partial class IDEApplication
    {
        #region Construction

        public IDEApplication()
        {
            Instance = this;
        }

        public int Main(string[] args)
        {
            //basic components
            MainForm = new MainForm();

            ConsoleControl = new Console();
            ConsoleControl.Attach(MainForm.tabBottom, "Console");

            SolutionExplorer = new SolutionExplorer();
            SolutionExplorer.Attach(MainForm.tabExplorers, "Solution");
            
            Settings=new IDESettings();
            Settings.Reload();

            //plugins
            LoadDebugger();
            LoadPlugins();

            //recent projects
            if (Settings.RecentProjects == null)
            {
                Settings.RecentProjects = new List<string>();
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

            InitShells();

            //run
            MainForm.RefreshRecent();
            RefreshControls();
            Application.Run(MainForm);

            //shutdown
            Settings.Save();

            //unload plugins
            UnloadPlugins();
            UnloadDebugger();
            return 0;
        }

        public bool ClosingApplication()
        {
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

        public void RefreshControls()
        {
            bool openEditor = ActiveEditor != null;
            bool openWarrior = openEditor && ActiveEditor.Document is WarriorDocument;
            MainForm.saveWarriorToolStripMenuItem.Enabled = openWarrior;
            MainForm.compileWarriorToolStripMenuItem.Enabled = openWarrior;
            MainForm.closeWarriorToolStripMenuItem.Enabled = openWarrior;
            MainForm.lbDocClose.Visible = openEditor;

            bool warrior = ActiveEditor != null;
            MainForm.compileWarriorToolStripMenuItem.Enabled = warrior;

            RefreshControlsDebugger();
            //? SolutionExplorer.ReloadSolution();
        }

        #endregion

        #region Plugins

        private void UnloadPlugins()
        {
            foreach (IIDEPlugin plugin in IdePlugins)
            {
                plugin.Unload();
            }
        }

        private void LoadPlugins()
        {
            if (Settings.KnownComponents==null)
            {
                List<string> known = new List<string>();
                known.Add("nMars.Parser");
                known.Add("nMars.Engine-StepBack");
                known.Add("nMars.Debugger");
                known.Add("nMars.ShellPy");
                Settings["KnownComponents"] = known;
            }

            foreach (string component in Settings.KnownComponents)
            {
                IModule module = ModuleRegister.FindModule(component);
                IIDEPluginModule ideModule = module as IIDEPluginModule;
                if (ideModule != null)
                {
                    IIDEPlugin plugin = ideModule.CreateIDEPlugin();
                    IdePlugins.Add(plugin);
                    plugin.Load();
                }
                IShellModule shellModule = module as IShellModule;
                if (shellModule != null)
                {
                    if (shellModule.Name != "nMars.Debugger")
                    {
                        Shells.Add(shellModule.CreateShell());
                    }
                }
            }
            Shells.Add(this);
        }

        private void InitShells()
        {
            IConsole console = ConsoleControl.GetAsyncWrapper();
            foreach (IShell shell in Shells)
            {
                shell.Engine = ActiveSolution.Components.AsyncEngineWrapper;
                shell.Components = ActiveSolution.Components;
                shell.PrintErrors = true;
                shell.Project = ActiveProject.Project;
                shell.Attach(console, Shells);
            }
        }

        #endregion

        #region Documents

        public void SaveAll()
        {
            foreach (IEditor editor in Editors)
            {
                editor.Save();
            }
            SaveSolution();
            RefreshControls();
        }

        public void OpenNewWarrior()
        {
            WarriorDocument warrior = WarriorDocument.New();
            warrior.Open();
            RefreshControls();
        }

        public void OpenExistingWarrior()
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

        public void ActivateDocument(Document document)
        {
            document.Open();
            RefreshControls();
        }

        public void OpenExistingWarrior(string filename)
        {
            WarriorDocument.Load(filename).Open();
            RefreshControls();
        }

        public bool SaveDocument(Document doc)
        {
            bool res = doc.Save();
            RefreshControls();
            return res;
        }

        public void CloseDocument(Document doc)
        {
            if (doc.Closing())
            {
                doc.Close();
            }
            RefreshControls();
        }

        public void AddExistingWarrior(RedCodeProject project)
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

        public void AddNewWarrior(RedCodeProject project)
        {
            WarriorDocument.New(project).Open();
            RefreshControls();
        }

        public void RemoveWarrior(WarriorDocument warrior, bool delete)
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


        public void AddIntoProject(ProjectDocument document)
        {
            ActiveProject.Add(document);
            RefreshControls();
        }

        public void RemoveFromProject(ProjectDocument document)
        {
            document.Project.Remove(document, false);
            RefreshControls();
        }

        #endregion

        #region Projects

        public void AddNewProject()
        {
            RedCodeProject.New(ActiveSolution);
            RefreshControls();
        }

        public void RemoveProject(RedCodeProject project, bool delete)
        {
            ActiveSolution.Remove(project, delete);
            RefreshControls();
        }

        public void AddExistingProject()
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

        public bool SaveProject(RedCodeProject project)
        {
            bool res = project.Save();
            RefreshControls();
            return res;
        }

        public void SetProjectActive(RedCodeProject project)
        {
            ActiveProject = project;
            RefreshControls();
        }


        public bool SaveSolution()
        {
            bool res=ActiveSolution.Save();
            if (res)
            {
                AddRecentProject(ActiveSolution.FileName);
            }
            RefreshControls();
            return res;
        }

        private void AddRecentProject(string filename)
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

        public void OpenSolution()
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

        public void OpenSolution(string fileName)
        {
            if (ActiveSolution==null || ActiveSolution.Closing())
            {
                if (ActiveSolution != null)
                    ActiveSolution.Close();
                LoadSolution(fileName);
            }
        }
        
        public void LoadSolution(string fileName)
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

        public void CloseSolution()
        {
            if (ActiveSolution == null || ActiveSolution.Closing())
            {
                if (ActiveSolution != null)
                    ActiveSolution.Close();
                NewSolution(null);
            }
            RefreshControls();
        }

        private void NewSolution(string[] args)
        {
            ActiveSolution = RedCodeSolution.New();
            AddNewProject();
            ActiveSolution.IsModified = false;
            if (args != null && args.Length > 0)
            {
                bool interactive;
                string saveProjectFile;
                ActiveProject.Project = CommandLine.Prepare(args, ActiveSolution.Components, ConsoleControl, out interactive, out saveProjectFile);
            }
            SolutionExplorer.ReloadSolution();
            RefreshControls();
        }

        #endregion

        #region Compile & Run

        public void Compile(WarriorDocument warrior)
        {
            if (warrior == null)
                return;
            warrior.Save();
            string[] files = new string[1];
            files[0] = warrior.FileName;

            if (warrior.Project!=null)
            {
                ActiveSolution.Components.Parser.Parse(warrior.Project.Project, ConsoleControl);
            }
            else
            {
                Project tmpProj=new Project(Rules.DefaultRules, warrior.FileName);
                tmpProj.ParserOptions = ParserOptions.Ide;
                ActiveSolution.Components.Parser.Parse(tmpProj, ConsoleControl);
            }
            
            RefreshControls();
        }

        public void Compile(RedCodeProject project)
        {
            foreach (IEditor editor in Editors)
            {
                if (editor.Document is ProjectDocument && (editor.Document as ProjectDocument).Project == project)
                {
                    editor.Save();
                }
            }

            ActiveSolution.Components.Parser.Parse(ActiveProject.Project, ConsoleControl);
            
            RefreshControls();
        }

        #endregion

        #region Variables

        public RedCodeSolution ActiveSolution
        {
            get
            {
                return activeSolution;
            }
            set
            {
                activeSolution = value;
                foreach (IShell shell in Shells)
                {
                    shell.Engine = value.Components.AsyncEngineWrapper;
                    shell.Components = value.Components;
                    shell.PrintErrors = true;
                    if (ActiveProject != null)
                        shell.Project = ActiveProject.Project;
                    else
                        shell.Project = null;
                }
            }
        }
        
        public RedCodeProject ActiveProject
        {
            get
            {
                return activeProject;
            }
            set
            {
                activeProject = value;
                foreach (IShell shell in Shells)
                {
                    shell.Project = value.Project;
                }
            }
        }

        private RedCodeProject activeProject = null;
        public RedCodeSolution activeSolution = null;

        //editors
        public List<IEditor> Editors = new List<IEditor>();
        public IEditor ActiveEditor;

        //UI
        public SolutionExplorer SolutionExplorer;
        public Console ConsoleControl;
        public MainForm MainForm;
        
        //setting
        internal IDESettings Settings;

        //plugins
        private List<IIDEPlugin> IdePlugins=new List<IIDEPlugin>();
        private List<IShell> Shells = new List<IShell>();

        public static IDEApplication Instance;
        #endregion
    }
}