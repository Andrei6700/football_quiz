using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Football_Quiz.Factories;
using Football_Quiz.Interfaces;
using Football_Quiz.Models;
using Football_Quiz.Strategies;

namespace Football_Quiz
{
    public partial class Form1 : Form
    {
        private List<QuizQuestion> _questions;
        private int _currentIndex = 0;
        private int _correctCount = 0;
        private int _wrongCount = 0;
        private string _lastWrongText = "-";
        private IScoreStrategy _scoreStrategy;

        public Form1()
        {
            InitializeComponent();

            LoadQuiz();
            InitializeScoreStrategy();
            UpdateStatusBar();
            DisplayCurrentQuestion();

            cmbScoreStrategy.Items.Add("Classic (1 point per correct answer)");
            cmbScoreStrategy.Items.Add("Penalty (-1 per wrong answer)");
            cmbScoreStrategy.SelectedIndex = 0;
        }


        private void InitializeScoreStrategy()
        {
            if (cmbScoreStrategy.SelectedIndex == 1)
                _scoreStrategy = new PenaltyScoreStrategy();
            else
                _scoreStrategy = new ClassicScoreStrategy();
        }

        private void LoadQuiz()
        {
            try
            {
                IQuizLoader loader = QuizLoaderFactory.CreateLoader();
                _questions = loader.LoadQuestions("quiz.json");
                var rnd = new Random();
                _questions = _questions
                    .OrderBy(q => rnd.Next())
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quiz: {ex.Message}", "Error");
                _questions = new List<QuizQuestion>();
            }

            if (_questions == null)
                _questions = new List<QuizQuestion>();
        }

        private void DisplayCurrentQuestion()
        {
            if (_currentIndex >= _questions.Count)
            {
                ShowFinalResult();
                return;
            }

            var q = _questions[_currentIndex];
            lblQuestion.Text = q.intrebare;
            rdbOption1.Text = q.optiuni[0];
            rdbOption2.Text = q.optiuni[1];
            rdbOption3.Text = q.optiuni[2];
            rdbOption4.Text = q.optiuni[3];

            rdbOption1.Checked = false;
            rdbOption2.Checked = false;
            rdbOption3.Checked = false;
            rdbOption4.Checked = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateAnswer()) return;

            var q = _questions[_currentIndex];
            string selected = GetSelectedOption();

            if (selected == q.raspunsCorect)
            {
                _correctCount++;
                _lastWrongText = "-";
            }
            else
            {
                _wrongCount++;
                _lastWrongText = $"Wrong: {selected} (Correct: {q.raspunsCorect})";
            }

            _currentIndex++;
            UpdateStatusBar();
            DisplayCurrentQuestion();
        }

        private bool ValidateAnswer()
        {
            if (!rdbOption1.Checked && !rdbOption2.Checked && !rdbOption3.Checked && !rdbOption4.Checked)
            {
                MessageBox.Show("Please select an answer!", "Attention");
                return false;
            }
            return true;
        }

        private string GetSelectedOption()
        {
            if (rdbOption1.Checked) return rdbOption1.Text;
            if (rdbOption2.Checked) return rdbOption2.Text;
            if (rdbOption3.Checked) return rdbOption3.Text;
            return rdbOption4.Text;
        }

        private void UpdateStatusBar()
        {
            int currentScore = _scoreStrategy.CalculateScore(_correctCount, _wrongCount);
            lblScore.Text = $"Score: {currentScore}";
            lblRemaining.Text = $"Remaining: {_questions.Count - _currentIndex}";
            lblLastWrong.Text = _lastWrongText;

            progressBar.Value = _questions.Count > 0
                ? (int)((_currentIndex / (double)_questions.Count) * 100)
                : 0;
        }

        private void ShowFinalResult()
        {
            int finalScore = _scoreStrategy.CalculateScore(_correctCount, _wrongCount);
            string message = $"Final Score: {finalScore}\nCorrect: {_correctCount}\nWrong: {_wrongCount}";
            MessageBox.Show(message, "Quiz Completed");
            this.Close();
        }

        private void CmbScoreStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeScoreStrategy();
            UpdateStatusBar();
        }
    }
}