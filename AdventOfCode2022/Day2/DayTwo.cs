using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AdventOfCode2022.DayTwo {
    public class DayTwo
    {
        private readonly string[] _inputLines;

        public DayTwo(string actionList) {
            _inputLines = actionList.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        }

        public int GetScoreAsActions() {
            var accumulatedScore = 0;

            foreach (var line in _inputLines) {
                var args = line.Split();

                var opponent = DayTwoInputHelper.ActionFrom(args[0]);
                var self = DayTwoInputHelper.ActionFrom(args[1]);

                accumulatedScore += self.FightScore(opponent);
            }

            return accumulatedScore;
        }

        public int GetScoreAsOutcomes() {
            var accumulatedScore = 0;
            foreach (var line in _inputLines) {
                var args = line.Split();

                var opponent = DayTwoInputHelper.ActionFrom(args[0]);
                var outcome = DayTwoInputHelper.OutcomeFrom(args[1]);
                var self = opponent.OpponentActionForOutcome(outcome);

                accumulatedScore += self.FightScore(opponent);
            }

            return accumulatedScore;
        }
    }
}
