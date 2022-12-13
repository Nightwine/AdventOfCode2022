namespace AdventOfCode2022.Day9 {
    public class Coordinate {
        public Coordinate() {
            X = 0;
            Y = 0;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public string Location() {
            return $"{X},{Y}";
        }
    }
}
