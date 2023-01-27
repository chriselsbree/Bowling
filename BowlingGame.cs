using ApprovalUtilities.Utilities;

namespace Bowling;

public class BowlingGame
{
    private List<Frame> _frames = new List<Frame>();

    public void Roll(params int[] rolls)
    {
        var previousScore = 0;
        var rollIndex = 0;

        for (int i = 0; i < 8; i++)
        {
            _frames.Add(new Frame(i+1, previousScore, rolls[rollIndex], rolls[rollIndex + 1]));
            if (_frames.Last().IsSpare)
            {
                _frames.Last().AddRoll(rolls[rollIndex + 2]);
            }
            //is it a strike
            if (_frames.Last().IsStrike)
            {
                _frames.Last().AddRoll(rolls[rollIndex + 2]);
                rollIndex += 1;
            }
            else
            {
                rollIndex += 2;
            }
            //add next two rolls
            //only uses one roll in entire frame

            previousScore = _frames.Last().TotalScore;
        }

    }

    public override string ToString()
    {
        return _frames.JoinWith("\n");
    }
}