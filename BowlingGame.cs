using ApprovalUtilities.Utilities;

namespace Bowling;

public class BowlingGame
{
    private List<Frame> _frames = new List<Frame>();

    public void Roll(params int[] rolls)
    {
        var previousScore = 0;
        var rollIndex = 0;

        for (int i = 0; i < 3; i++)
        {
            _frames.Add(new Frame(i+1, previousScore, rolls[rollIndex], rolls[rollIndex + 1]));
            rollIndex += 2;
            previousScore = _frames.Last().TotalScore;
        }

    }

    public override string ToString()
    {
        return _frames.JoinWith("\n");
    }
}