using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Anni { get; set; }

        public string GetDipendenteTot()
        {
            return Nome + " " + Cognome + "  " + Anni;
        }
        public void GetDipendenteTotProc()
        {
            Console.WriteLine(GetDipendenteTot());
        }
    }
}
