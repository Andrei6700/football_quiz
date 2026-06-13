using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Quiz
{
    public class ScorPenalizare : IScorStrategy
    {
        public int CalculeazaScor(int raspunsuriCorecte, int raspunsuriGresite)
        {
            return raspunsuriCorecte - raspunsuriGresite; // -1 punct pe fiecare greseala
        }
    }
}