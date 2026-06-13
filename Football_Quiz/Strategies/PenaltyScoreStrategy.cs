using Football_Quiz.Interfaces;

namespace Football_Quiz.Strategies
{
    public class PenaltyScoreStrategy : IScoreStrategy
    {
        public int CalculateScore(int correctCount, int wrongCount)
        {
            return correctCount - wrongCount;
        }
    }
}
