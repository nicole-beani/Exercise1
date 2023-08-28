using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto = new Prodotto();
            prodotto.Nome = "Mario";
            prodotto.Prezzo = "100";
            prodotto.Quantità = "7";
            prodotto.GetCalcoloTotaleProc();
            

            Atleta atleta = new Atleta();
            atleta.Nome = "Maurizio";
            atleta.Cognome = "Tognetti";
            atleta.Nazionalità = "Italy";
            atleta.GetAtletaTotProc();
            

            Studente studente = new Studente();
            studente.Nome = "Nicole";
            studente.Cognome = "Beani";
            studente.MateriaPreferita = "Matematica";
            studente.GetStudenteTotProc();

            Animale animale = new Animale();
            animale.Nome = "Emily";
            animale.Zampe = "4";
            animale.Anni = "10";
            animale.GetAnimaleTotProc();

            Dipendente dipendente = new Dipendente();
            dipendente.Nome = "Massimo";
            dipendente.Cognome = "Ciavaglia";
            dipendente.Anni = "67";
            dipendente.GetDipendenteTotProc();

            Film film = new Film();
            film.Nome = "La vera storia di Jack lo squartatore";
            film.Genere = "Thriller";
            animale.Anni = "2001";
            animale.GetFilmTotProc();
        }

    }
}
