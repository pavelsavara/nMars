namespace nMars.RedCode
{
    public interface IExtendedWarrior : IWarrior
    {
        string GetLabels(int instructionOffset);
        string GetComment(int instructionOffset);
        string GetOriginalInstruction(int instructionOffset);
        string GetExtendedLine(int instructionOffset, DumpOptions options);
    }
}