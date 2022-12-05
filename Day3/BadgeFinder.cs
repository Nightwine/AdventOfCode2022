using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.DayThree {
    public static class BadgeFinder {
        public static int GetBadgeValueFromPacks(List<Pack> packs) {
            List<char> contentsCheck = null;
            foreach (var pack in packs) {
                if (contentsCheck == null) {
                    contentsCheck = pack.GetContents();
                } else {
                    contentsCheck = contentsCheck.Intersect(pack.GetContents()).ToList();
                }
            }

            var badge = contentsCheck.Distinct().Single();
            return ItemValueChecker.For(badge);
        }
    }
}
