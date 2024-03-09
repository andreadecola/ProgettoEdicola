using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    internal class Edicola 
    {
       public string? Nome { get; set; }
       public string? Indirizzo { get; set; }

       public List<Pubblicazione> magazzino { get; set; } = new List<Pubblicazione>();

         public Edicola(string? nome, string? indirizzo)
         {
            Nome=nome;
            Indirizzo=indirizzo;
         }

         public void aggiungi(Pubblicazione pub){
            magazzino.Add(pub);
         }

         public void stampaElenco() {
            foreach(Pubblicazione pub in magazzino)
            {
                pub.stampaDettaglio();
            }
        }
    }
}
