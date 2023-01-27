namespace Bowling;

public class Frame
{
    private int roll1;
    private int roll2;
    private int frameIndex;
    private int PreviousScore;

    public Frame(int frameIndex, int previousScore, int roll1, int roll2)
    {
        this.roll1 = roll1;
        this.roll2 = roll2;
        this.frameIndex = frameIndex;
        this.PreviousScore = previousScore;
    }

    public int TotalScore => FrameScore + PreviousScore;
    public int FrameScore => roll1 + roll2;

    public override string ToString()
    {
        return $"Frame {frameIndex}: {roll1}, {roll2} ; FrameScore: {FrameScore} ; TotalScore: {TotalScore}";
    }
}