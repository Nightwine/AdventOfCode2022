using AdventOfCode2022.Day10.Instructions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AdventOfCode2022.Day10 {
    public class Cpu {
        private int _register;
        private int _cycle;
        private readonly Dictionary<int, int> _cycleHistory;
        
        public Cpu() {
            _register = 1;
            _cycle = 1;
            _cycleHistory= new Dictionary<int, int> { [_cycle] = _register };
        }

        public void ProcessInstruction(IInstruction instruction) {
            for (int i = 0; i < instruction.CycleCost - 1; i++) {
                RegisterCycle();
            }

            if (instruction.Value.HasValue) {
                _register += instruction.Value.Value;
            }

            RegisterCycle();
        }

        public int GetSignalStrengthAt(int cyclePoint) {
            if (_cycleHistory.TryGetValue(cyclePoint, out int value)) {
                return cyclePoint * value;
            }

            throw new KeyNotFoundException($"Could not find entry for {cyclePoint}");
        }

        public int GetRegisterAt(int cyclePoint) {
            if (_cycleHistory.TryGetValue(cyclePoint, out int value)) {
                return value;
            }

            throw new KeyNotFoundException($"Could not find entry for {cyclePoint}");
        }

        private void RegisterCycle() {
            _cycle++;
            _cycleHistory[_cycle] = _register;
        }
    }

    public class Crt {
        
        public List<string> Draw(Cpu cpu) {
            var pixel = 0;
            var rows = new List<string>();
            var row = string.Empty;

            for (int cycle = 1; cycle < 241; cycle++) {
                var sprite = cpu.GetRegisterAt(cycle);

                var thing = Math.Abs(pixel - sprite) < 2 ? "#" : ".";
                row += thing;
                pixel++;

                if (pixel % 40 == 0) {
                    rows.Add(row);
                    row = string.Empty;
                    pixel = 0;
                }

            }

            return rows;
        }
    }
}
