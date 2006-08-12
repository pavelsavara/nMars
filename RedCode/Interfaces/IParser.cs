namespace nMars.RedCode
{
    public interface IParser
    {
        IWarrior Parse(string source, string implicitName);
        IWarrior Load(string fileName);
    }
}