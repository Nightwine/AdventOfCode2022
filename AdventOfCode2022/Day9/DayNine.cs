using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day9 {
    public class DayNine {
        private List<string> _directions;

        public DayNine(string input) {
            _directions = input.SplitOnNewline().ToList();
        }

        public int DoFirstPuzzle() {
            var ropeHead = new Head(1);

            DoMoves(ropeHead);

            return ropeHead.UniqueTailLocations();
        }

        public int DoSecondPuzzle() {
            var ropeHead = new Head(9);

            DoMoves(ropeHead);

            return ropeHead.UniqueTailLocations();
        }

        private void DoMoves(Head head) {
            foreach (var direction in _directions) {
                var dirSplit = direction.Split(" ");
                var dir = DirectionHelper.From(dirSplit[0]);
                var move = int.Parse(dirSplit[1]);

                for (int i = 0; i < move; i++) {
                    head.Move(dir);
                }
            }
        }

    }
}
