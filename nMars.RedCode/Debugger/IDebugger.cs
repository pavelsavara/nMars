// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara


namespace nMars.RedCode
{
    public interface IDebugger
    {
        void Attach(IStepEngine engine);
        void ProcessCommand(string command);
        void Step();
        void Continue();
        void Break();
        int Speed { get; set;}
    }
}
