using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day9 {
    public class Knot {
        private readonly Coordinate _location;
        private readonly List<string> _visitedLocations;
        private readonly Knot _nextKnot;

        public Knot() {
            _location = new Coordinate();
            _visitedLocations = new List<string> { _location.Location() };
        }

        public Knot(Knot nextKnot) : this() {
            _nextKnot = nextKnot;
        }

        public void Follow(Coordinate otherLocation) {
            FollowPattern(otherLocation);
            _visitedLocations.Add(_location.Location());

            if (_nextKnot != null) {
                _nextKnot.Follow(_location);
            }
        }

        private void FollowPattern(Coordinate otherLocation) {
            var absDistX = Math.Abs(_location.X - otherLocation.X);
            var absDistY = Math.Abs(_location.Y - otherLocation.Y);

            var overlap = absDistX == 0 && absDistY == 0;
            var neighbor = absDistX <= 1 && absDistY <= 1;

            if (overlap || neighbor) {
                return;
            }

            var isDiagnal = absDistX != 0 && absDistY != 0;

            if (absDistX == 0 || isDiagnal) {
                _location.Y += otherLocation.Y > _location.Y ? 1 : -1;
            }  
            
            if (absDistY == 0 || isDiagnal) {
                _location.X += otherLocation.X > _location.X ? 1 : -1;
            }
        }

        public int UniqueLocations() {
            if (_nextKnot != null) {
                return _nextKnot.UniqueLocations();
            }

            return _visitedLocations.ToHashSet().Count();
        }
    }
}
