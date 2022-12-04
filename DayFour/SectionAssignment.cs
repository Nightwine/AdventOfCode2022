namespace AdventOfCode2022.DayFour {
    public class SectionAssignment {
        private readonly int _minRange;
        private readonly int _maxRange;

        public SectionAssignment(string sectionAssignment) {
            var range = sectionAssignment.Split('-');
            _minRange = int.Parse(range[0]);
            _maxRange = int.Parse(range[1]);
        }


        public bool ContainsSection(SectionAssignment otherSection) {
            return _minRange <= otherSection._minRange && _maxRange >= otherSection._maxRange;
        }

        public bool OverlapsWithSection(SectionAssignment otherSection) {
            return !(_maxRange < otherSection.MinRange() || otherSection.MaxRange() < _minRange);
        }
        
        protected int MinRange() { return _minRange; }
        protected int MaxRange() { return _maxRange; }
    }
}
