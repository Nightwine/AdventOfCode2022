using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day5 {
    public static class CraneParser {
        public static Tuple<Crane,List<string>> Parse(string craneState) {
            var stacks = new Dictionary<int, List<string>>();
            var directions = new List<string>();
            var inDirections = false;

            foreach (var line in craneState.SplitOnNewline()) {
                if (string.IsNullOrWhiteSpace(line)) {
                    inDirections = true;
                    continue;
                } else if (inDirections) {
                    directions.Add(line);
                } else {
                    var regex = new Regex(@"\[([A-Z])\]+");
                    var match = regex.Match(line);
                    while (match.Success) {
                        var index = (match.Index / 4) + 1;
                        if (stacks.ContainsKey(index) == false) {
                            stacks.Add(index, new List<string>());
                        }

                        stacks[index].Add(match.Groups[1].Value);
                        match = match.NextMatch();
                    }
                }
            }

            foreach (var stack in stacks) {
                stack.Value.Reverse();
            }

            return new Tuple<Crane, List<string>>(new Crane(stacks), directions);
        }
    }
}
