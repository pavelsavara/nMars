namespace nMars.RedCode
{
    public interface ICoreView
    {
        Instruction this[int address] { get; }
        int CoreSize { get; }
        int LiveWarriorsCount { get; }
    }
}