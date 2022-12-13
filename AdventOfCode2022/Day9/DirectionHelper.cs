using System;

namespace AdventOfCode2022.Day9 {
    public static class DirectionHelper {
        public static Direction From(string d) {
            switch (d) {
                case "R":
                    return Direction.Right;
                case "L":
                    return Direction.Left;
                case "U":
                    return Direction.Up;
                case "D":
                    return Direction.Down;
                default:
                    throw new Exception($"Surprise string {d}");
            }
        }
    }
}
