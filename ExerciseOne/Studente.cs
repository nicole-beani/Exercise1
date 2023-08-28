using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string MateriaPreferita { get; set; }

        public string GetStudenteTot()
        {
            return Nome + " " + Cognome + "  " + MateriaPreferita;
        }
        public void GetStudenteTotProc()
        {
            Console.WriteLine(GetStudenteTot());
        }
    }
}
