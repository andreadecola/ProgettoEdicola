using ProgettoEdicola.Classes;

namespace ProgettoEdicola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pubblicazione giornale1 = new Giornale("Corriere dello Sport", new DateTime(2024,02,10), "Sportiva");
            Pubblicazione giornale2 = new Giornale("Messagero", new DateTime(2024, 03, 07), "Economia");
            Pubblicazione rivista = new Rivista("Vogue Italia", new DateTime(2024, 03, 06), "Gossip");
            Pubblicazione rivista2 = new Rivista("Vanity Fair", new DateTime(2024, 03, 05), "Gossip");

            Edicola edicola = new Edicola("Da Ciccio", "Via Santo esebio 20");
            edicola.aggiungi(giornale1);
            edicola.aggiungi(giornale2);
            edicola.aggiungi(rivista);
            edicola.aggiungi(rivista2);

            edicola.stampaElenco();
        }
    }
}
