using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Football_Quiz.Interfaces;
using Football_Quiz.Models;
using Newtonsoft.Json;

namespace Football_Quiz.Loaders
{
    public class JsonQuizLoader : IQuizLoader
    {
        public List<QuizQuestion> LoadQuestions(string fileName)
        {
            try
            {
                string basePath = Application.StartupPath;
                string fullPath = Path.Combine(basePath, fileName);

                if (!File.Exists(fullPath))
                    throw new FileNotFoundException($"File {fileName} not found in {basePath}.");

                string json = File.ReadAllText(fullPath);
                var list = JsonConvert.DeserializeObject<List<QuizQuestion>>(json);
                return list ?? new List<QuizQuestion>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quiz questions: {ex.Message}", "Loader Error");
                return new List<QuizQuestion>();
            }
        }
    }
}
