using Football_Quiz.Interfaces;
using Football_Quiz.Models;
using System;
using System.Collections.Generic;

namespace Football_Quiz.Managers
{
    public class QuizManager
    {
        private readonly List<QuizQuestion> _questions;
        private readonly IScoreStrategy _scoreStrategy;
        private int _correctAnswers;
        private int _wrongAnswers;

        public QuizManager(List<QuizQuestion> questions, IScoreStrategy scoreStrategy)
        {
            _questions = questions ?? throw new ArgumentNullException(nameof(questions));
            _scoreStrategy = scoreStrategy ?? throw new ArgumentNullException(nameof(scoreStrategy));
            _correctAnswers = 0;
            _wrongAnswers = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("== Football Quiz ==");
            Console.WriteLine();

            for (int i = 0; i < _questions.Count; i++)
            {
                var q = _questions[i];
                Console.WriteLine($"{i + 1}. {q.intrebare}");
                for (int j = 0; j < q.optiuni.Count; j++)
                {
                    Console.WriteLine($"   {j + 1}. {q.optiuni[j]}");
                }

                int choice = PromptForChoice(q.optiuni.Count);
                string selected = q.optiuni[choice];

                if (selected == q.raspunsCorect)
                {
                    _correctAnswers++;
                    Console.WriteLine("Corect!");
                }
                else
                {
                    _wrongAnswers++;
                    Console.WriteLine($"Gresit! Răspuns corect: {q.raspunsCorect}");
                }

                Console.WriteLine();
            }

            int finalScore = _scoreStrategy.CalculateScore(_correctAnswers, _wrongAnswers);
            Console.WriteLine($"Quiz terminat. Scor final: {finalScore} (Corecte: {_correctAnswers}, Greșite: {_wrongAnswers})");
        }

        private int PromptForChoice(int maxOptions)
        {
            int choice;
            while (true)
            {
                Console.Write($"Alege un număr (1-{maxOptions}): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int num) && num >= 1 && num <= maxOptions)
                {
                    choice = num - 1;
                    break;
                }
                Console.WriteLine($"Te rog să introduci un număr valid între 1 și {maxOptions}.");
            }
            return choice;
        }
    }
}
