using System;
using IronPython.Hosting;
using IronPython.Runtime.Exceptions;
using nMars.Debugger;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.DbgShellPy
{
    class DebuggerShellPy : IDebuggerShell
    {
        public void Init(IDebugger aDebugger, IDebuggerEngine aEngine, IDebuggerPrompt aPrompt)
        {
            debugger = aDebugger;
            engine = aEngine;
            prompt = aPrompt;
            basicShell = new DebuggerShell();
            basicShell.Init(aDebugger, aEngine, aPrompt);
            pythonEngine = new PythonEngine();
            pythonEngine.AddToPath(ModuleRegister.BasePath);
            pythonEngine.Globals["prompt"] = prompt;
            pythonEngine.Globals["engine"] = engine;
            pythonEngine.Globals["debugger"] = debugger;
            pythonEngine.Execute("import System");
            pythonEngine.Execute("def clear() : prompt.Clear();");
            pythonEngine.Execute("def list(addressFrom, lenght = 10) : debugger.List(addressFrom, lenght);");
            pythonEngine.Execute("def step(count = 1) : debugger.NextStep(count);");
            pythonEngine.Execute("def back(count = 1) : debugger.PrevStep(count);");
            pythonEngine.Execute("def cont() : debugger.Continue();");
            pythonEngine.Execute("def restart() : debugger.Restart();");
            pythonEngine.Execute("def quit() : debugger.Quit();");
            pythonEngine.Execute("def exit() : debugger.Quit();");
            pythonEngine.Execute("def echo(e = True) : debugger.Echo = e;");
            pythonEngine.Execute("def promptString() : return '>';");
            pythonEngine.Execute(
                "def echoString() : return System.String.Format('{0,20} ({1,3}): {2}', engine.NextWarrior.Name, engine.NextWarrior.TasksCount, engine.NextInstruction.ToString());");
            pythonEngine.SetStandardError(prompt.ErrorStream);
            pythonEngine.SetStandardOutput(prompt.OutStream);
            pythonEngine.SetStandardInput(prompt.InputStream);
        }

        public bool ProcessCommand(ref string command, bool printErrors)
        {
            bool res = true;
            try
            {
                if (!basicShell.ProcessCommand(ref command, false))
                {
// is not short command, pass it to python
                    pythonEngine.ExecuteToConsole(command);
                }
            }
            catch (PythonSyntaxErrorException e)
            {
                if (printErrors)
                {
                    Console.Error.WriteLine("^".PadLeft(e.Column + 2));
                    Console.Error.WriteLine(e.Message);
                }
                res = false;
            }
            catch (Exception e)
            {
                if (printErrors)
                {
                    Console.Error.WriteLine(e.Message);
                }
                res = false;
            }
            return res;
        }

        public string EchoString
        {
            get { return pythonEngine.Evaluate("echoString()") as string; }
        }

        public string PromptString
        {
            get { return pythonEngine.Evaluate("promptString()") as string; }
        }

        PythonEngine pythonEngine;
        private IDebugger debugger;
        private IDebuggerEngine engine;
        private IDebuggerPrompt prompt;
        private DebuggerShell basicShell;
    }
}