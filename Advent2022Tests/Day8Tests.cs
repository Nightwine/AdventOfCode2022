using AdventOfCode2022.Day8;
using NUnit.Framework;

namespace Advent2022Tests {
    public class Day8Tests {

        [Test]
        public void ThenTheVisibleTreesAreExpected() {
            var trees = new TreeGrid(TestData());
            Assert.That(trees.VisibleTrees(), Is.EqualTo(21));
        }

        [Test]
        public void ThenTheScenicScoreIsExpected() {
            var trees = new TreeGrid(TestData());
            Assert.That(trees.ScenicScore(), Is.EqualTo(8));
        }

        private string TestData() {
            return "30373\r\n25512\r\n65332\r\n33549\r\n35390";
        }
    }
}
