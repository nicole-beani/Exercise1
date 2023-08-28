using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Prodotto
    { 
        public string Nome { get; set; }
        public string Prezzo { get; set; }
        public string Quantità { get; set; }
      
        public string GetCalcoloTotale()
        {
            return Nome + " " + Prezzo + " " + Quantità;
        }
        public void GetCalcoloTotaleProc()
        {
            Console.WriteLine(GetCalcoloTotale());
        }
    }   
}
