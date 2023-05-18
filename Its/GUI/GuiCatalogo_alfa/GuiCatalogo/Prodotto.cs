using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino27
{
    [Serializable]
    public class Prodotto
    {
        public int Codice { get; set; }
        public string Nome { get; set; }
        public string Denominazione { get; set; }
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }
        public bool IsInscorta() => Giacenza > 0 && Giacenza < 10;
        public bool IsEsaurito() => Giacenza == 0;

        

        public override string ToString()
        {
            return $"{{{nameof(Codice)}={Codice.ToString()}, " +
                $"{nameof(Nome)}={Nome}," +
                $"{nameof(Prezzo)}={Prezzo.ToString()}, " +
                $"{nameof(Giacenza)}={Giacenza.ToString()}}}";

        }
    }

}
