using AdventOfCode2022.Day9;
using NUnit.Framework;

namespace Advent2022Tests {
    public class Day9Tests {

        [Test]
        public void ThenTheTailLocationsAreExpected() {
            var thing = new DayNine(TestDataA());
            Assert.That(thing.DoFirstPuzzle(), Is.EqualTo(13));
        }

        [Test]
        public void ThenTheSecondPuzzleIsCorrect() {
            var thing = new DayNine(TestDataB());
            Assert.That(thing.DoSecondPuzzle(), Is.EqualTo(36));
        }

        private string TestDataA() {
            return "R 4\r\nU 4\r\nL 3\r\nD 1\r\nR 4\r\nD 1\r\nL 5\r\nR 2";
        }

        private string TestDataB() {
            return "R 5\r\nU 8\r\nL 8\r\nD 3\r\nR 17\r\nD 10\r\nL 25\r\nU 20";
        }
    }
}
