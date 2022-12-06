using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.DayFour {
    public class DayFour {
        private readonly List<WorkPair> _elfPairs;

        public DayFour(string sectionAssignmentList) {
            _elfPairs = new List<WorkPair>();
            foreach (var pairAssignment in sectionAssignmentList.Split(new[] { Environment.NewLine }, StringSplitOptions.None)) {
                _elfPairs.Add(new WorkPair(pairAssignment));
            }
        }

        public int DuplicatedEffortCount() {
            return _elfPairs.Count(x => x.FullyContainedPair() == true);
        }

        public int OverlappingEffortCount() {
            return _elfPairs.Count(x => x.OverlappingPair() == true);
        }
    }
}
