namespace Bowling;

public class Frame
{
    private int roll1;
    private int roll2;
    private int frameIndex;
    private int PreviousScore;
    private int roll3;

    public Frame(int frameIndex, int previousScore, int roll1, int roll2)
    {
        this.roll1 = roll1;
        this.roll2 = roll2;
        this.frameIndex = frameIndex;
        this.PreviousScore = previousScore;
    }

    public int TotalScore => FrameScore + PreviousScore;
    public int FrameScore => roll1 + roll2 + roll3;
    public bool IsSpare => roll1 + roll2 == 10;
    public bool IsStrike => 10 == roll1;

    public override string ToString()
    {
        return $"Frame {frameIndex}: {PrintFrameScore} ; FrameScore: {FrameScore} ; TotalScore: {TotalScore}";
    }

    public string PrintFrameScore
    {
        //if last frame and a strike of a spare
        //return all rolls
        get
        {
            if(frameIndex == 10 && (IsStrike || IsSpare))
            {
                return $"{roll1}, {roll2}, {roll3}";
            }
            return IsStrike ? "10" : $"{roll1}, {roll2}";
        }
    }

    public void AddRoll(int roll3)
    {
        this.roll3 = roll3;
    }
}