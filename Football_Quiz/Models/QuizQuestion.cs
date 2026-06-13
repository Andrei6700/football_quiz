using System.Collections.Generic;

namespace Football_Quiz.Models
{
    public class QuizQuestion
    {
        public string intrebare { get; set; }
        public List<string> optiuni { get; set; }
        public string raspunsCorect { get; set; }
    }
}
