using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino27
{
    public class Prodotto
    {
        public string Codice { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public int Giacenza { get; set; }

        public Prodotto(string codice, string nome, string descrizione, decimal prezzo, int giacenza)
        {
            Codice = codice;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Giacenza = giacenza;
        }
    }

}
