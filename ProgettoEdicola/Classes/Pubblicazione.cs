using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    public abstract class Pubblicazione
    {
        public string?  Titolo { get; set; }

        public DateTime DatadiPubblicazione { get; set; }

        public string? Categoria  { get; set; }

        public int? Contatore { get; private set; } = 0;

        public Pubblicazione(string? titolo, DateTime datadipubblicazione, string? categoria)
        {
            Titolo = titolo;
            DatadiPubblicazione= datadipubblicazione;
            Categoria= categoria;

            Contatore++;
        }

        public abstract void stampaDettaglio();

        public override string ToString()
        {
            return $" {Titolo} {Categoria} {DatadiPubblicazione.ToString("dd/MM/yyyy")}";
        }

        public void StampaContatore()
        {
            Console.WriteLine($"Il Numero di pubblicazioni è: {Contatore}");

        }
    }
}
