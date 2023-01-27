using ApprovalUtilities.Utilities;

namespace Bowling;

public class BowlingGame
{
    private List<Frame> _frames = new List<Frame>();

    public void Roll(params int[] rolls)
    {
        _frames.Add(new Frame(1, 0, rolls[0], rolls[1]));
        _frames.Add(new Frame(2, _frames.Last().TotalScore, rolls[2], rolls[3]));
    }

    public override string ToString()
    {
        return _frames.JoinWith("\n");
    }
}