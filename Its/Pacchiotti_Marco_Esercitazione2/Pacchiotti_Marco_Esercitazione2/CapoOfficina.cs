using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchiotti_Marco_Esercitazione2
{
    internal class CapoOfficina:Meccanico
    {
        public List<Ordine> Ordini { get; set; }
        public void AggiungiOrdine(Ordine ordine, int index)
        {

        }
        public int NoOrdini()
        {
            int i = 0;
            foreach (var o in Ordini)
            {
                i++;
            }
            return i;
        }
        public override string? ToString()
        {
            return base.ToString();
        }

        public override double Tredicesima()
        {
            double tredicesima = Stipendio * 2;
            return base.Tredicesima();
        }
    }
}
