using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Animale
    {
        public string Nome { get; set; }
        public string Zampe { get; set; }
        public string Anni { get; set; }

        public string GetAnimaleTot()
        {
            return Nome + " " + Zampe + "  " + Anni;
        }
        public void GetAnimaleTotProc()
        {
            Console.WriteLine(GetAnimaleTot());
        }
    }
}
