using AdventOfCode2022.Day10;
using AdventOfCode2022.Day10.Instructions;
using NUnit.Framework;

namespace Advent2022Tests
{
    public class Day10Tests {

        [Test]
        public void ThenTheSignalStrengthIsAsExpected() {
            var day = new DayTen(RealData());
            Assert.That(day.SignalStrength(), Is.EqualTo(13140));
        }

        [Test]
        public void ThenFoo() {
            var day = new DayTen(RealData());
            Assert.That(day.DrawCrt(), Is.EqualTo("foo"));
        }

        [Test]
        public void ThenTheNoopInstructionsGetReadCorrectly() {
            var instruction = InstructionReader.For("noop");
            Assert.That(instruction, Is.TypeOf<NoopInstruction>());
            Assert.That(instruction.CycleCost, Is.EqualTo(1));
            Assert.That(instruction.Value, Is.Null);
        }

        [TestCase("addx -21", -21)]
        [TestCase("addx 15", 15)]
        public void ThenTheAddInstructionsGetReadCorrectly(string instructionString, int expectedValue) {
            var instruction = InstructionReader.For(instructionString);
            Assert.That(instruction, Is.TypeOf<AddXInstruction>());
            Assert.That(instruction.CycleCost, Is.EqualTo(2));
            Assert.That(instruction.Value, Is.EqualTo(expectedValue));
        }

        [Test]
        public void ThenTheCyclesAreLoggedCorrectly() {
            var cpu = new Cpu();
            cpu.ProcessInstruction(InstructionReader.For("noop"));
            cpu.ProcessInstruction(InstructionReader.For("addx 3"));
            cpu.ProcessInstruction(InstructionReader.For("addx -5"));

            Assert.That(cpu.GetSignalStrengthAt(1), Is.EqualTo(1));
            Assert.That(cpu.GetSignalStrengthAt(2), Is.EqualTo(1));
            Assert.That(cpu.GetSignalStrengthAt(3), Is.EqualTo(1));
            Assert.That(cpu.GetSignalStrengthAt(4), Is.EqualTo(4));
            Assert.That(cpu.GetSignalStrengthAt(5), Is.EqualTo(4));
            Assert.That(cpu.GetSignalStrengthAt(6), Is.EqualTo(-1));
        }

        private string TestData() {
            return "addx 15\r\naddx -11\r\naddx 6\r\naddx -3\r\naddx 5\r\naddx -1\r\naddx -8\r\naddx 13\r\naddx 4\r\nnoop\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx -35\r\naddx 1\r\naddx 24\r\naddx -19\r\naddx 1\r\naddx 16\r\naddx -11\r\nnoop\r\nnoop\r\naddx 21\r\naddx -15\r\nnoop\r\nnoop\r\naddx -3\r\naddx 9\r\naddx 1\r\naddx -3\r\naddx 8\r\naddx 1\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx -36\r\nnoop\r\naddx 1\r\naddx 7\r\nnoop\r\nnoop\r\nnoop\r\naddx 2\r\naddx 6\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\nnoop\r\naddx 7\r\naddx 1\r\nnoop\r\naddx -13\r\naddx 13\r\naddx 7\r\nnoop\r\naddx 1\r\naddx -33\r\nnoop\r\nnoop\r\nnoop\r\naddx 2\r\nnoop\r\nnoop\r\nnoop\r\naddx 8\r\nnoop\r\naddx -1\r\naddx 2\r\naddx 1\r\nnoop\r\naddx 17\r\naddx -9\r\naddx 1\r\naddx 1\r\naddx -3\r\naddx 11\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\naddx 1\r\nnoop\r\nnoop\r\naddx -13\r\naddx -19\r\naddx 1\r\naddx 3\r\naddx 26\r\naddx -30\r\naddx 12\r\naddx -1\r\naddx 3\r\naddx 1\r\nnoop\r\nnoop\r\nnoop\r\naddx -9\r\naddx 18\r\naddx 1\r\naddx 2\r\nnoop\r\nnoop\r\naddx 9\r\nnoop\r\nnoop\r\nnoop\r\naddx -1\r\naddx 2\r\naddx -37\r\naddx 1\r\naddx 3\r\nnoop\r\naddx 15\r\naddx -21\r\naddx 22\r\naddx -6\r\naddx 1\r\nnoop\r\naddx 2\r\naddx 1\r\nnoop\r\naddx -10\r\nnoop\r\nnoop\r\naddx 20\r\naddx 1\r\naddx 2\r\naddx 2\r\naddx -6\r\naddx -11\r\nnoop\r\nnoop\r\nnoop";
        }

        private string RealData() {
            return "addx 1\r\naddx 4\r\naddx 1\r\nnoop\r\nnoop\r\naddx 4\r\naddx 1\r\naddx 4\r\nnoop\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx -3\r\naddx 9\r\naddx -1\r\naddx 5\r\naddx -28\r\naddx 29\r\naddx 2\r\naddx -28\r\naddx -7\r\naddx 10\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx -2\r\naddx 2\r\naddx 25\r\naddx -18\r\naddx 3\r\naddx -2\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 2\r\naddx 5\r\naddx 2\r\naddx 2\r\naddx 3\r\nnoop\r\naddx -15\r\naddx 8\r\naddx -28\r\nnoop\r\nnoop\r\nnoop\r\naddx 7\r\naddx -2\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx 3\r\nnoop\r\naddx 3\r\naddx 2\r\naddx 5\r\naddx 2\r\naddx 3\r\naddx -2\r\naddx 3\r\naddx -31\r\naddx 37\r\naddx -28\r\naddx -9\r\nnoop\r\nnoop\r\nnoop\r\naddx 37\r\naddx -29\r\naddx 4\r\nnoop\r\naddx -2\r\nnoop\r\nnoop\r\nnoop\r\naddx 7\r\nnoop\r\nnoop\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx 4\r\naddx 2\r\naddx 4\r\naddx 2\r\naddx 3\r\naddx -2\r\nnoop\r\nnoop\r\naddx -34\r\naddx 6\r\nnoop\r\nnoop\r\nnoop\r\naddx -4\r\naddx 9\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\naddx -2\r\nnoop\r\naddx 7\r\nnoop\r\naddx 2\r\naddx 15\r\naddx -14\r\naddx 5\r\naddx 2\r\naddx 2\r\naddx -32\r\naddx 33\r\naddx -31\r\naddx -2\r\nnoop\r\nnoop\r\naddx 1\r\naddx 3\r\naddx 2\r\nnoop\r\naddx 2\r\nnoop\r\naddx 7\r\nnoop\r\naddx 5\r\naddx -6\r\naddx 4\r\naddx 5\r\naddx 2\r\naddx -14\r\naddx 15\r\naddx 2\r\nnoop\r\naddx 3\r\naddx 4\r\nnoop\r\naddx 1\r\nnoop\r\nnoop";
        }

    }
}
