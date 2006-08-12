namespace nMars.RedCode
{
    public interface IExtendedWarrior : IWarrior
    {
        string GetLabel(int instructionOffset);
        string GetComment(int instructionOffset);
        string GetOriginalInstruction(int instructionOffset);
        string GetOriginalLine(int instructionOffset);
    }
}