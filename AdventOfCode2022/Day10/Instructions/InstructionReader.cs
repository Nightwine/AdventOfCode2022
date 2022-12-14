using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day10.Instructions
{
    public static class InstructionReader
    {
        private static readonly Regex _regex = new Regex("([a-z]*) (-*\\d*)");
        public static IInstruction For(string instruction)
        {
            if (instruction.StartsWith(InstructionKeys.NOOP))
            {
                return new NoopInstruction();
            }

            if (instruction.StartsWith(InstructionKeys.ADDX))
            {
                var match = _regex.Match(instruction);
                return new AddXInstruction(int.Parse(match.Groups[2].Value));
            }

            throw new NotImplementedException($"Unknown instruction {instruction}");
        }
    }
}
