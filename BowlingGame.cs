namespace Bowling;

public class BowlingGame
{
    private List<Frame> _frames = new List<Frame>();

    public void Roll(params int[] rolls)
    {
        _frames.Add(new Frame(rolls[0], rolls[1]));

    }

    public override string ToString()
    {
        return _frames.First().ToString();
    }
}