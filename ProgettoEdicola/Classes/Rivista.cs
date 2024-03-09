using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoEdicola.Classes
{
    public class Rivista : Pubblicazione
    {
        public static int ContatoreRivista { get; private set; } = 0;
        public Rivista(string? titolo, DateTime datadipubblicazione, string? categoria) : base(titolo, datadipubblicazione, categoria)
        {
            Titolo = titolo;
            DatadiPubblicazione = datadipubblicazione;
            Categoria = categoria;
        }





        public override void stampaDettaglio()
        {
            Console.WriteLine($"[Giornale] {Titolo}{DatadiPubblicazione}{Categoria}");
        }


    }



}

