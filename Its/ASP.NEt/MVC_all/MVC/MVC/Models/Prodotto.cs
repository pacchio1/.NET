using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    public class Prodotto
    {
        public int Coice { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }

        public override string ToString()
        {
            return $"{nameof(Coice)}={Coice.ToString()}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Descrizione)}={Descrizione}," +
                $" {nameof(Prezzo)}={Prezzo.ToString()}," +
                $" {nameof(Giacenza)}={Giacenza.ToString()}";
        }
    }
}
