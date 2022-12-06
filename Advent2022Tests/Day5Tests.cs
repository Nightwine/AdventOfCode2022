using AdventOfCode2022.Day5;
using NUnit.Framework;
using System.Collections.Generic;

namespace Advent2022Tests {
    [TestFixture]
    public class DayFiveTests {

        [Test]
        public void WhenReportingOnTheStackTops() {
            var crane = new Crane(new Dictionary<int, List<string>> { { 2, new List<string> { "B", "Z" } }, { 1, new List<string> { "P", "A", "R" } } });

            Assert.That(crane.ReportStackTops, Is.EqualTo("RZ"));
        }

        [Test]
        public void WhenParsingTheDataThenTheOriginalStackTopsAreReported() {
            var crane = CraneParser.Parse(TestData()).Item1;

            Assert.That(crane.ReportStackTops, Is.EqualTo("NDP"));
        }

        [Test]
        public void WhenReportingOnTheStackTopsAfterABasicMove() {
            var crane = new Crane(new Dictionary<int, List<string>> { { 2, new List<string> { "B", "Z" } }, { 1, new List<string> { "P", "A", "R" } } });
            crane.PerformBasicMove("move 2 from 1 to 2");
            Assert.That(crane.ReportStackTops, Is.EqualTo("PA"));
        }

        [Test]
        public void WhenProcessingTheSampleDataWithBasicMoves() {
            var day = new DayFive(TestData());
            Assert.That(day.GetBasicStateAfterDirections(), Is.EqualTo("CMZ"));
        }

        [Test]
        public void WhenReportingOnTheStackTopsAfterAnAdvancedMove() {
            var crane = new Crane(new Dictionary<int, List<string>> { { 2, new List<string> { "B", "Z" } }, { 1, new List<string> { "P", "A", "R" } } });
            crane.Perform9001Move("move 2 from 1 to 2");
            Assert.That(crane.ReportStackTops, Is.EqualTo("PR"));
        }

        [Test]
        public void WhenProcessingTheSampleDataWithAdvancedMoves() {
            var day = new DayFive(TestData());
            Assert.That(day.Get9001StateAfterDirections(), Is.EqualTo("MCD"));
        }

        private static string TestData() {
            return "    [D]    \r\n[N] [C]    \r\n[Z] [M] [P]\r\n 1   2   3 \r\n\r\nmove 1 from 2 to 1\r\nmove 3 from 1 to 3\r\nmove 2 from 2 to 1\r\nmove 1 from 1 to 2";
        }
    }
}
