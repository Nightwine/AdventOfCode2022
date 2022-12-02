using System;

namespace AdventOfCode2022.DayTwo.Actions
{
    public class Rock : IAction {
        private readonly int _actionValue = 1;

        public int FightScore(IAction opponentAction) {
            var outcome = 0;
            if (opponentAction is Rock)
            {
                outcome = 3;
            }
            else if (opponentAction is Scissors)
            {
                outcome = 6;
            }
            return outcome + _actionValue;
        }

        public IAction OpponentActionForOutcome(Outcome oppenentOutcome) {
            return oppenentOutcome switch {
                Outcome.Lose => new Scissors(),
                Outcome.Draw => new Rock(),
                Outcome.Win => new Paper(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
