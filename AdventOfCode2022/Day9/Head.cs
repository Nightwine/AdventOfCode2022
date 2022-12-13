namespace AdventOfCode2022.Day9 {
    public class Head {
        private readonly Coordinate _location;
        private readonly Knot _nextKnot;

        public Head(int knotCount) {
            _location= new Coordinate();
            Knot knot = null;
            
            for (int i = 0; i < knotCount; i++) {
                if (knot == null) {
                    knot = new Knot();
                } else {
                    knot = new Knot(knot);
                }
            }
            
            _nextKnot = knot;
        }

        public void Move(Direction direction) {
            switch (direction) {
                case Direction.Right:
                    _location.X++;
                    break;
                case Direction.Left:
                    _location.X--;
                    break;
                case Direction.Up:
                    _location.Y++;
                    break;
                case Direction.Down:
                    _location.Y--;
                    break;
                default:
                    break;
            }

            _nextKnot.Follow(_location);
        }

        public int UniqueTailLocations() {
            return _nextKnot.UniqueLocations();
        }
    }
}
