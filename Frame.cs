namespace Bowling;

public class Frame
{
    private int roll1;
    private int roll2;

    public Frame(int roll1, int roll2)
    {
        this.roll1 = roll1;
        this.roll2 = roll2;
    }

    public int TotalScore => FrameScore;
    public int FrameScore => roll1 + roll2;

    public string ToString()
    {
        return $"Frame 1: {roll1}, {roll2} ; FrameScore: {FrameScore} ; TotalScore: {TotalScore}";
    }
}