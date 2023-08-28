using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Film
    {
        public string Nome { get; set; }
        public string Genere { get; set; }
        public string Anni { get; set; }

        public string GetFilmTot()
        {
            return Nome + " " + Genere + "  " + Anni;
        }
        public void GetFilmTotProc()
        {
            Console.WriteLine(GetFilmTot());
        }
    }
}
