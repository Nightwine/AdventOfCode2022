using AdventOfCode2022.DayFour;
using NUnit.Framework;

namespace Advent2022Tests {
    public class DayFourTests {
        [TestCase("2-4,6-8", false)]
        [TestCase("2-6,4-8", false)]
        [TestCase("2-8,3-7", true)]
        [TestCase("6-6,4-6", true)]
        public void ThenTheWorkPairReportsIfASectionContainsTheOther(string pairAssignment, bool expectedOutcome) {
            var workPair = new WorkPair(pairAssignment);
            Assert.That(workPair.FullyContainedPair(), Is.EqualTo(expectedOutcome));
        }

        [Test]
        public void ThenTheDuplicatedListReportsAccurately() {
            var dayFour = new DayFour(TestData());
            Assert.That(dayFour.DuplicatedEffortCount(), Is.EqualTo(2));
        }

        [TestCase("2-4,6-8", false)]
        [TestCase("2-6,4-8", true)]
        [TestCase("2-8,3-7", true)]
        [TestCase("6-6,4-6", true)]
        public void ThenTheWorkPairReportsIfTheSectionsOverlap(string pairAssignment, bool expectedOutcome) {
            var workPair = new WorkPair(pairAssignment);
            Assert.That(workPair.OverlappingPair(), Is.EqualTo(expectedOutcome));
        }

        [Test]
        public void ThenTheOverlappingListReportsAccurately() {
            var dayFour = new DayFour(TestData());
            Assert.That(dayFour.OverlappingEffortCount(), Is.EqualTo(4));
        }

        private string TestData() {
            return "2-4,6-8\r\n2-3,4-5\r\n5-7,7-9\r\n2-8,3-7\r\n6-6,4-6\r\n2-6,4-8";
        }
    }
}
