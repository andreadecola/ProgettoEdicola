using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
 
    public class Giornale : Pubblicazione
    {
          public static int ContatoreGiornale { get; private set; } = 0;
        public Giornale(string? titolo, DateTime datadipubblicazione, string? categoria) : base(titolo, datadipubblicazione, categoria)
        {
            Titolo = titolo;
            DatadiPubblicazione = datadipubblicazione;
            Categoria = categoria;
           

        }
        public override void stampaDettaglio()
        {
            Console.WriteLine($"[Rivista] {Titolo}{DatadiPubblicazione}{Categoria}");
        }
    }
}
