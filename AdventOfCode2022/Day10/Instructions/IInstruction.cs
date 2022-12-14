namespace AdventOfCode2022.Day10.Instructions
{
    public interface IInstruction
    {
        int CycleCost { get; }
        int? Value { get; }
    }
}
