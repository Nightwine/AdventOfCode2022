namespace AdventOfCode2022.Day10.Instructions
{
    public class AddXInstruction : IInstruction
    {
        public int CycleCost => 2;

        public int? Value { get; }

        public AddXInstruction(int value)
        {
            Value = value;
        }
    }
}
