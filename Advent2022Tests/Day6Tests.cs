using AdventOfCode2022.Day6;
using NUnit.Framework;

namespace Advent2022Tests {
    public class Day6Tests {
        
        [TestCase("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
        [TestCase("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
        [TestCase("nppdvjthqldpwncqszvftbrmjlhg", 6)]
        [TestCase("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
        [TestCase("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
        public void ThenTheCharactersToStartOfPacketReturnsCorrectly(string input, int expectedResult) {
            var day = new DaySix(input);
            Assert.That(day.DoFirstPuzzle(), Is.EqualTo(expectedResult));
        }

        [TestCase("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
        [TestCase("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
        [TestCase("nppdvjthqldpwncqszvftbrmjlhg", 23)]
        [TestCase("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
        [TestCase("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
        public void ThenTheCharactersToStartOfMessageReturnsCorrectly(string input, int expectedResult) {
            var day = new DaySix(input);
            Assert.That(day.DoSecondPuzzle(), Is.EqualTo(expectedResult));
        }
    }
}
