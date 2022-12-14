namespace AdventOfCode2022.Day10.Instructions
{
    public class NoopInstruction : IInstruction
    {
        public int CycleCost => 1;

        public int? Value => null;
    }
}
