namespace Bowling;

public class BowlingGame
{
    private int roll1;
    private int roll2;

    public void Roll(params int[] rolls)
    {
        roll1 = rolls[0];
        roll2 = rolls[1];
    }

    public override string ToString()
    {
        return $"Frame 1: {roll1}, {roll2}";
    }
}