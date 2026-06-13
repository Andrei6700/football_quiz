using System;
using System.Collections.Generic;
using NUnit.Framework;
using Football_Quiz.Models;
using Football_Quiz.Strategies;
using Football_Quiz.Managers;
using Football_Quiz.Interfaces;

namespace Football_Quiz.Tests
{
    [TestFixture]
    public class QuizTests
    {
        [Test]
        public void ClassicScoreStrategy_CalculateScore_ReturnsCorrectCountOnly()
        {
            // Arrange
            IScoreStrategy strategy = new ClassicScoreStrategy();
            int correct = 8;
            int wrong = 3;

            // Act
            int score = strategy.CalculateScore(correct, wrong);

            // Assert
            Assert.AreEqual(8, score);
        }

        [Test]
        public void PenaltyScoreStrategy_CalculateScore_ReturnsCorrectMinusWrong()
        {
            // Arrange
            IScoreStrategy strategy = new PenaltyScoreStrategy();
            int correct = 7;
            int wrong = 3;

            // Act
            int score = strategy.CalculateScore(correct, wrong);

            // Assert
            Assert.AreEqual(4, score);
        }

        [Test]
        public void PenaltyScoreStrategy_CalculateScore_CanReturnNegativeScore()
        {
            // Arrange
            IScoreStrategy strategy = new PenaltyScoreStrategy();
            int correct = 2;
            int wrong = 5;

            // Act
            int score = strategy.CalculateScore(correct, wrong);

            // Assert
            Assert.AreEqual(-3, score);
        }

        [Test]
        public void QuizQuestion_Properties_CanBeSetAndRetrieved()
        {
            // Arrange
            var question = new QuizQuestion();
            var options = new List<string> { "Real Madrid", "Barcelona", "Liverpool", "Milan" };

            // Act
            question.intrebare = "Cine a castigat UCL in 2022?";
            question.optiuni = options;
            question.raspunsCorect = "Real Madrid";

            // Assert
            Assert.AreEqual("Cine a castigat UCL in 2022?", question.intrebare);
            Assert.AreEqual("Real Madrid", question.raspunsCorect);
            Assert.AreEqual(4, question.optiuni.Count);
            Assert.AreEqual("Barcelona", question.optiuni[1]);
        }

        [Test]
        public void QuizManager_Constructor_ThrowsArgumentNullException_WhenQuestionsIsNull()
        {
            // Arrange
            IScoreStrategy strategy = new ClassicScoreStrategy();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                var manager = new QuizManager(null, strategy);
            });
        }

        [Test]
        public void QuizManager_Constructor_ThrowsArgumentNullException_WhenStrategyIsNull()
        {
            // Arrange
            var questions = new List<QuizQuestion>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                var manager = new QuizManager(questions, null);
            });
        }
    }
}
