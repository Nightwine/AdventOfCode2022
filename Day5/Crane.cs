using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day5 {
    public class Crane {
        private Dictionary<int, List<string>> _stacks;
        private readonly Regex _regex;

        public Crane(Dictionary<int, List<string>> stacks) {
            _stacks = stacks;
            _regex = new Regex("move ([\\d]+) from ([\\d]+) to ([\\d]+)");
        }

        public string ReportStackTops() {
            return _stacks.OrderBy(x => x.Key).Aggregate("", (output, x) => output + x.Value.Last());
        }

        public void PerformBasicMove(string movement) {
            var match = _regex.Match(movement);
            var itemsToMove = int.Parse(match.Groups[1].Value);
            var fromStackId = int.Parse(match.Groups[2].Value);
            var toStackId = int.Parse(match.Groups[3].Value);
            var fromStack = _stacks[fromStackId];
            var toStack = _stacks[toStackId];

            for (int i = 0; i < itemsToMove; i++) {
                toStack.Add(fromStack.Last());
                fromStack.RemoveAt(fromStack.Count - 1);
            }
        }

        public void Perform9001Move(string movement) {
            var match = _regex.Match(movement);
            var itemsToMove = int.Parse(match.Groups[1].Value);
            var fromStackId = int.Parse(match.Groups[2].Value);
            var toStackId = int.Parse(match.Groups[3].Value);
            var fromStack = _stacks[fromStackId];
            var toStack = _stacks[toStackId];

            toStack.AddRange(fromStack.TakeLast(itemsToMove));
            fromStack.RemoveRange(fromStack.Count - itemsToMove, itemsToMove);
        }
    }
}
