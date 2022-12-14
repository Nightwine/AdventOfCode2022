using AdventOfCode2022.Day10.Instructions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day10 {
    public class DayTen {
        private List<IInstruction> _instructions;
        private Cpu _cpu;

        public DayTen(string input) {
            var instructionStrings = input.SplitOnNewline();

            _instructions = new List<IInstruction>();

            foreach (var instruction in instructionStrings) {
                _instructions.Add(InstructionReader.For(instruction));
            }

            _cpu = new Cpu();

            foreach (var instruction in _instructions) {
                _cpu.ProcessInstruction(instruction);
            }
        }

        public int SignalStrength() {
            

            var cycle20 = _cpu.GetSignalStrengthAt(20);
            var cycle60 = _cpu.GetSignalStrengthAt(60);
            var cycle100 = _cpu.GetSignalStrengthAt(100);
            var cycle140 = _cpu.GetSignalStrengthAt(140);
            var cycle180 = _cpu.GetSignalStrengthAt(180);
            var cycle220 = _cpu.GetSignalStrengthAt(220);

            return cycle20 + cycle60 + cycle100 + cycle140 + cycle180 + cycle220;
        }

        public List<string> DrawCrt() {
            var crt = new Crt();
            var response = crt.Draw(_cpu);
            foreach (var row in response) {
                Console.WriteLine(row);
            }

            return response;
        }
    }
}
