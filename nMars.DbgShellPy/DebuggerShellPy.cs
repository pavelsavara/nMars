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
            pythonEngine.Execute("def clear() : prompt.Clear();");
            pythonEngine.Execute("def list(addressFrom, lenght = 10) : debugger.List(addressFrom, lenght);");
            pythonEngine.Execute("def step(count = 1) : debugger.Step(count);");
            pythonEngine.Execute("def stepback(count = 1) : debugger.StepBack(count);");
            pythonEngine.Execute("def back(count = 1) : debugger.StepBack(count);");
            pythonEngine.Execute("def cont() : debugger.Continue();");
            pythonEngine.Execute("def restart() : debugger.Restart();");
            pythonEngine.Execute("def quit() : debugger.Quit();");
            pythonEngine.Execute("def exit() : debugger.Quit();");
            pythonEngine.Execute("def echo(e = True) : debugger.Echo = e;");
            pythonEngine.SetStandardError(prompt.ErrorStream);
            pythonEngine.SetStandardOutput(prompt.OutStream);
            pythonEngine.SetStandardInput(prompt.InputStream);
        }

        public bool ProcessCommand(ref string command)
        {
            bool res = true;
            try
            {
                if (!basicShell.ProcessCommand(ref command))
                {// is not short command, pass it to python
                    pythonEngine.ExecuteToConsole(command);
                }
            }
            catch(PythonSyntaxErrorException e)
            {
                Console.Error.WriteLine("^".PadLeft(e.Column+2));
                Console.Error.WriteLine(e.Message);
                res = false;
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e.Message);
                res = false;
            }
            return res;
        }
        
        PythonEngine pythonEngine;
        private IDebugger debugger;
        private IDebuggerEngine engine;
        private IDebuggerPrompt prompt;
        private DebuggerShell basicShell;
    }
}
