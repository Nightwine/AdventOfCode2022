using System;
using AdventOfCode2022.DayTwo.Actions;

namespace AdventOfCode2022.DayTwo
{
    public static class DayTwoInputHelper {
        public static IAction ActionFrom(string entry)
        {
            switch (entry)
            {
                case "A":
                case "X":
                    return new Rock();
                case "B":
                case "Y":
                    return new Paper();
                case "C":
                case "Z":
                    return new Scissors();
                default:
                    throw new NotImplementedException($"Got {entry}");
            }
        }

        public static Outcome OutcomeFrom(string entry)
        {
            switch (entry)
            {
                case "X":
                    return Outcome.Lose;
                case "Y":
                    return Outcome.Draw;
                case "Z":
                    return Outcome.Win;
                default:
                    throw new NotImplementedException($"Got {entry}");
            }
        }
    }
}
