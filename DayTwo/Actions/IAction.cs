namespace AdventOfCode2022.DayTwo.Actions
{
    public interface IAction
    {
        int FightScore(IAction opponentAction);
        IAction OpponentActionForOutcome(Outcome oppenentOutcome);
    }
}
