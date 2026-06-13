namespace Football_Quiz.Interfaces
{
    public interface IScoreStrategy
    {
        int CalculateScore(int correctCount, int wrongCount);
    }
}
