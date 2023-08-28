using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nazionalità { get; set; }
       
        public string GetAtletaTot()
        {
            return Nome + " " + Cognome + "  " + Nazionalità;
        }
        public void GetAtletaTotProc()
        {
            Console.WriteLine(GetAtletaTot());
        }
    }
}
