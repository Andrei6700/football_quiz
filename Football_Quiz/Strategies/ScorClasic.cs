using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Quiz
{
    public class ScorClasic : IScorStrategy
    {
        public int CalculeazaScor(int raspunsuriCorecte, int raspunsuriGresite)
        {
            return raspunsuriCorecte; // +1 pct pe fiecare raspuns corect
        }
    }
}