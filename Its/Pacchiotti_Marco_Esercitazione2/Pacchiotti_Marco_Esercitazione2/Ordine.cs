using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchiotti_Marco_Esercitazione2
{
    internal class Ordine
    {
        public int IdOrdine { get; set; }
        public DateTime Data { get; set; }
        public List<Prodotto> ElencoProdotti { get; set; }
        public Venditore Venditore { get; set; }

        

        public int NoProdotti()
        {
            int i=0;
            return i;
        }

        public double Totale() => ElencoProdotti.Sum(p => p.Prezzo * NoProdotti());

        

        public void Scontrino()
        {
            Console.WriteLine($"{"Codice",-10}{"Prodotto",-20}{"Quantità",-10}{"Prezzo unitario",-20}{"Subtotale",-20}");
            foreach (var prodotto in ElencoProdotti)
            {
                Console.WriteLine($"{prodotto.Codice,-10}{prodotto.NomeProdotto,-20}{NoProdotti(),-10}{prodotto.Prezzo,-20:C}{NoProdotti() * prodotto.Prezzo,-20:C}");
            }
            Console.WriteLine($"{"",-60}{"TOTALE:",-20:C}{Totale,-20:C}");
        }

        public override string ToString()
        {
            return $"{{{nameof(IdOrdine)}={IdOrdine.ToString()}, {nameof(Data)}={Data.ToString()}, {nameof(ElencoProdotti)}={ElencoProdotti}, {nameof(Venditore)}={Venditore}}}";
        }
    }
}
