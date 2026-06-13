using System.Collections.Generic;
using Football_Quiz.Models;

namespace Football_Quiz.Interfaces
{
    public interface IQuizLoader
    {
        List<QuizQuestion> LoadQuestions(string fileName);
    }
}
