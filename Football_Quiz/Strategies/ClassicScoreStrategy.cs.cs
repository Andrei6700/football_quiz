using Football_Quiz.Interfaces;

namespace Football_Quiz.Strategies
{
    public class ClassicScoreStrategy : IScoreStrategy
    {
        public int CalculateScore(int correctCount, int wrongCount)
        {
            return correctCount;
        }
    }
}
