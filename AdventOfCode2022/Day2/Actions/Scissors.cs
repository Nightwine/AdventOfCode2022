using System;

namespace AdventOfCode2022.DayTwo.Actions
{
    public class Scissors : IAction {
        private readonly int _actionValue = 3;

        public int FightScore(IAction opponentAction) {
            var outcome = 0;
            if (opponentAction is Scissors)
            {
                outcome = 3;
            }
            else if (opponentAction is Paper)
            {
                outcome = 6;
            }
            return _actionValue + outcome;
        }

        public IAction OpponentActionForOutcome(Outcome oppenentOutcome) {
            return oppenentOutcome switch {
                Outcome.Lose => new Paper(),
                Outcome.Draw => new Scissors(),
                Outcome.Win => new Rock(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
