using System.Collections.Generic;
using System.Windows.Forms;
using nMars.IDE.Controls;
using nMars.IDE.Forms;
using nMars.IDE.Core;
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
            NewSolution();

            System.Windows.Forms.Application.Run(mainForm);
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
            return SaveSolution();
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
        }

        public static void OpenNewWarrior()
        {
            WarriorDocument warrior = WarriorDocument.New();
            warrior.Open();
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
        }

        public static void ActivateDocument(ProjectDocument document)
        {
            document.Open();
        }
        
        public static void OpenExistingWarrior(string filename)
        {
            WarriorDocument.Load(filename).Open();
        }

        public static bool SaveDocument(Document doc)
        {
            return doc.Save();
        }

        public static void CloseDocument(Document doc)
        {
            
            if (doc.Closing())
            {
                doc.Close();
            }
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
        }

        public static void AddNewWarrior(RedCodeProject project)
        {
            WarriorDocument.New(project).Open();
        }

        public static void RemoveWarrior(WarriorDocument warrior, bool delete)
        {
            if (warrior.Closing())
            {
                warrior.Close();
                if (warrior.Project!=null)
                {
                    warrior.Project.Remove(warrior, delete);
                }
            }
        }


        public static void AddIntoProject(ProjectDocument document)
        {
            ActiveSolution.ActiveProject.Add(document);
        }

        public static void RemoveFromProject(ProjectDocument document)
        {
            document.Project.Remove(document, false);
        }

        public static void Compile(WarriorDocument warrior)
        {
            if (warrior==null)
                return;
            warrior.Save();
            string[] files=new string[1];
            files[0] = warrior.FileName;
            ParserBase.RunParser(files, ActiveSolution.ComponentSetup.Parser, Rules.DefaultRules, ParserOptions.Engine, Console);
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
            string[] a =new string[project.Documents.Keys.Count];
            project.Documents.Keys.CopyTo(a, 0);
            ParserBase.RunParser(a, ActiveSolution.ComponentSetup.Parser, ActiveSolution.ActiveProject.Rules, ActiveSolution.ActiveProject.ParserOptions, Console);
        }

        #endregion

        #region Projects

        public static void AddNewProject()
        {
            RedCodeProject.New(ActiveSolution);
        }

        public static void RemoveProject(RedCodeProject project, bool delete)
        {
            ActiveSolution.Remove(project,delete);
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
        }

        public static bool SaveProject(RedCodeProject project)
        {
            return project.Save();
        }

        public static void SetProjectActive(RedCodeProject project)
        {
            ActiveSolution.ActiveProject = project;
        }
        

        public static bool SaveSolution()
        {
            return ActiveSolution.Save();
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
                    ActiveSolution = RedCodeSolution.Load(mainForm.openDialog.FileName);
                    SolutionExplorer.ReloadSolution();
                }
            }
        }

        public static void CloseSolution()
        {
            if (ActiveSolution.Closing())
            {
                ActiveSolution.Close();
                NewSolution();
            }
        }

        private static void NewSolution()
        {
            ActiveSolution = RedCodeSolution.New();
            AddNewProject();
            ActiveSolution.IsModified = false;
            SolutionExplorer.ReloadSolution();
        }

        public static void RefreshUI()
        {
            mainForm.RefreshUI();
            SolutionExplorer.ReloadSolution();
        }
        
        #endregion
        
        #region Variables

        public static RedCodeSolution ActiveSolution;
        public static Application ApplicationInstance;

        //editors
        public static List<IEditor> Editors = new List<IEditor>();
        public static IEditor ActiveEditor;

        //UI
        public static SolutionExplorer SolutionExplorer;
        public static Console Console;
        public static MainForm mainForm;

        #endregion
    }
}
