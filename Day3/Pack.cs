using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.DayThree {
    public class Pack {
        private readonly List<char> _compartmentOne;
        private readonly List<char> _compartmentTwo;

        public Pack(string contents) {
            var half = contents.Length / 2;

            _compartmentOne = contents.Take(half).ToList();
            _compartmentTwo = contents.TakeLast(half).ToList();
        }

        public int GetMispackedItemValue() {
            var inBoth = _compartmentOne.Intersect(_compartmentTwo).Distinct().Single();
            return ItemValueChecker.For(inBoth);
        }

        public List<char> GetContents() {
            return _compartmentOne.Union(_compartmentTwo).ToList();
        }
    }
}
