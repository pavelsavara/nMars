// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using IronPython.Hosting;
using IronPython.Runtime.Exceptions;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.ShellPy
{
    public class ShellPy : BaseComponent, IShell
    {
        public ShellPy()
        {
            pythonEngine = new PythonEngine();
            pythonEngine.AddToPath(ModuleRegister.BasePath);
            pythonEngine.Execute("import System");
            pythonEngine.Execute("def clear() : console.Clear();");
            pythonEngine.Execute("def list(addressFrom, lenght = 10) : debugger.List(addressFrom, lenght);");
            pythonEngine.Execute("def step(count = 1) : debugger.Step(count);");
            pythonEngine.Execute("def back(count = 1) : debugger.Back(count);");
            pythonEngine.Execute("def cont() : debugger.Continue();");
            pythonEngine.Execute("def restart() : debugger.Restart();");
            pythonEngine.Execute("def quit() : shell.quit=True; debugger.Stop();");
            pythonEngine.Execute("def exit() : quit();");
        }

        public void Attach(IConsole aConsole, IList<IShell> allShells)
        {
            console = aConsole;
            pythonEngine.Globals["console"] = console;
            pythonEngine.Globals["shell"] = this;
            pythonEngine.SetStandardError(console.ErrorStream);
            pythonEngine.SetStandardOutput(console.OutStream);

            console.CommandEntered += new ConsoleCommandEntered(ProcessCommand);
            quit = false;
        }

        public void Register(object aplication, string name)
        {
            pythonEngine.Globals[name] = aplication;
        }

        public IProject Project
        {
            get { return project; }
            set
            {
                Register(value, "Project");
                project = value;
            }
        }

        public ComponentLoader Components
        {
            get { return components; }
            set
            {
                Register(value, "Components");
                components = value;
            }
        }

        public IAsyncEngine Engine
        {
            set
            {
                //engine = value;
            }
        }

        public bool PrintErrors
        {
            set { printErrors = value; }
        }

        public void Detach()
        {
            console.CommandEntered -= new ConsoleCommandEntered(ProcessCommand);
        }

        private void ProcessCommand(string command, ref bool processed, ref bool aQuit)
        {
            if (processed)
                return;

            try
            {
                // is not short command, pass it to python
                pythonEngine.ExecuteToConsole(command);
                processed = true;
                aQuit = quit;
            }
            catch (PythonSyntaxErrorException e)
            {
                if (printErrors)
                {
                    console.ErrorWriteLine("^".PadLeft(e.Column + 2));
                    console.ErrorWriteLine(e.Message);
                }
            }
            catch (PythonNameErrorException e)
            {
                if (printErrors)
                {
                    console.ErrorWriteLine(e.Message);
                }
            }
            catch (Exception e)
            {
                if (printErrors)
                {
                    console.ErrorWriteLine(e.Message);
                }
            }
        }

        public bool quit;

        private PythonEngine pythonEngine;
        private bool printErrors=false;
        private IConsole console;
        private IProject project;
        private ComponentLoader components;
        //private IAsyncEngine engine;
    }
}