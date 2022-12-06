using AdventOfCode2022.DayTwo;
using NUnit.Framework;

namespace Advent2022Tests
{
    [TestFixture]
    public class DayTwoTests {
        [Test]
        public void WhenSolvingTheFirstStar() {
            var day = new DayTwo(TestData());

            Assert.That(day.GetScoreAsActions(), Is.EqualTo(15));
        }

        [Test]
        public void WhenSolvingTheSecondStar() {
            var day = new DayTwo(TestData());

            Assert.That(day.GetScoreAsOutcomes(), Is.EqualTo(12));
        }

        private static string TestData() {
            return "A Y\r\nB X\r\nC Z";
        }
    }
}
