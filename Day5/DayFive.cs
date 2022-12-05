using System.Collections.Generic;

namespace AdventOfCode2022.Day5 {
    public class DayFive {
        private readonly Crane _crane;
        private readonly List<string> _directions;

        public DayFive(string craneDirections) {
            var parsedData = CraneParser.Parse(craneDirections);
            _crane = parsedData.Item1;
            _directions = parsedData.Item2;
        }

        public string GetBasicStateAfterDirections() {
            foreach (var direction in _directions) {
                _crane.PerformBasicMove(direction);
            }

            return _crane.ReportStackTops();
        }

        public string Get9001StateAfterDirections() {
            foreach (var direction in _directions) {
                _crane.Perform9001Move(direction);
            }

            return _crane.ReportStackTops();
        }
    }
}
