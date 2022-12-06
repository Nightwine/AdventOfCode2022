using AdventOfCode2022.DayOne;
using NUnit.Framework;

namespace Advent2022Tests {
    [TestFixture]
    public class DayOneTests {

        [Test]
        public void WhenSolvingTheFirstStar() {
            var day = new DayOne(TestData());

            Assert.That(day.CaloriesInLargestBag, Is.EqualTo(24000));
        }

        [Test]
        public void WhenSolvingTheSecondStar() {
            var day = new DayOne(TestData());

            Assert.That(day.CaloriesInTopLargestBags(3), Is.EqualTo(45000));
        }

        private static string TestData() {
            return "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000";
        }
    }
}
