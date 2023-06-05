using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    internal class Alimentare:Prodotto
    {
        public DateTime DataScadenza { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(DataScadenza)}={DataScadenza.ToString()}, {nameof(Coice)}={Coice.ToString()}, {nameof(Nome)}={Nome}, {nameof(Prezzo)}={Prezzo.ToString()}, {nameof(DataProduzione)}={DataProduzione.ToString()}}}";
        }
    }
}
