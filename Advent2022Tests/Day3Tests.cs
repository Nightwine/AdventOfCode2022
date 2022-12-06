using AdventOfCode2022.DayThree;
using NUnit.Framework;
using System.Collections.Generic;

namespace Advent2022Tests {
    public class Day3Tests {
        [TestCase("vJrwpWtwJgWrhcsFMMfFFhFp", 16)]
        [TestCase("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", 38)]
        [TestCase("PmmdzqPrVvPwwTWBwg", 42)]
        [TestCase("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", 22)]
        [TestCase("ttgJtRGJQctTZtZT", 20)]
        [TestCase("CrZsJsPPZsGzwwsLwLmpwMDw", 19)]
        public void ThenThePackReturnsTheValueOfTheMispackedItem(string contents, int expectedValue) {
            var pack = new Pack(contents);
            Assert.That(pack.GetMispackedItemValue(), Is.EqualTo(expectedValue));
        }

        [Test]
        public void ThenWeGetTheSumOfAllThePacks() {
            var dayThree = new DayThree(TestData());
            Assert.That(dayThree.GetValueOfAllMispacks(), Is.EqualTo(157));
        }

        [TestCase("vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg", 18)]
        [TestCase("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw", 52)]
        public void ThenWeGetTheValueOfTheBadge(string contentsA, string contentsB, string contentsC, int expectedValue) {
            var badgeValue = BadgeFinder.GetBadgeValueFromPacks(new List<Pack> { new Pack(contentsA), new Pack(contentsB), new Pack(contentsC)});
            Assert.That(badgeValue, Is.EqualTo(expectedValue));
        }

        [Test]
        public void ThenWeGetAllTheBadgeValues() {
            var dayThree = new DayThree(TestData());
            Assert.That(dayThree.GetValueOfAllBadges(), Is.EqualTo(70));
        }

        private string TestData() {
            return "vJrwpWtwJgWrhcsFMMfFFhFp\r\njqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL\r\nPmmdzqPrVvPwwTWBwg\r\nwMqvLMZHhHMvwLHjbvcjnnSBnvTQFn\r\nttgJtRGJQctTZtZT\r\nCrZsJsPPZsGzwwsLwLmpwMDw";
        }
    }
}
