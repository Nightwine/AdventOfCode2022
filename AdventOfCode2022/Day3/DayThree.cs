using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.DayThree {
    public class DayThree {
        private List<Pack> _packs;

        public DayThree(string packList) {
            _packs = new List<Pack>();
            foreach (var packContents in packList.SplitOnNewline()) {
                _packs.Add(new Pack(packContents));
            }
        }

        public int GetValueOfAllMispacks() {
            return _packs.Sum(x => x.GetMispackedItemValue());
        }

        public int GetValueOfAllBadges() {
            var groupSize = 3;
            var badgeSum = 0;

            for (int i = 0; i < _packs.Count; i+=groupSize) {
                badgeSum += BadgeFinder.GetBadgeValueFromPacks(_packs.GetRange(i, groupSize));
            }

            return badgeSum;
        }

    }
}
