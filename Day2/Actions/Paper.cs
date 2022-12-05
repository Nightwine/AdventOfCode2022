using System;

namespace AdventOfCode2022.DayTwo.Actions
{
    public class Paper : IAction
    {
        private readonly int _actionValue = 2;

        public int FightScore(IAction opponentAction) {
            var outcome = 0;
            if (opponentAction is Paper)
            {
                outcome = 3;
            }
            else if (opponentAction is Rock)
            {
                outcome = 6;
            }
            return outcome + _actionValue;
        }

        public IAction OpponentActionForOutcome(Outcome oppenentOutcome) {
            return oppenentOutcome switch {
                Outcome.Lose => new Rock(),
                Outcome.Draw => new Paper(),
                Outcome.Win => new Scissors(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
