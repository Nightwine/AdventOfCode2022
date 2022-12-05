using System;

namespace AdventOfCode2022.DayFour {
    public class WorkPair {
        private readonly SectionAssignment _sectionA;
        private readonly SectionAssignment _sectionB;

        public WorkPair(string pairAssignment) {
            var assignments = pairAssignment.Split(',');
            _sectionA = new SectionAssignment(assignments[0]);
            _sectionB = new SectionAssignment(assignments[1]);
        }

        public bool FullyContainedPair() {
            return _sectionA.ContainsSection(_sectionB) || _sectionB.ContainsSection(_sectionA);
        }

        public bool OverlappingPair() {
            return _sectionA.OverlapsWithSection(_sectionB);
        }
    }
}
