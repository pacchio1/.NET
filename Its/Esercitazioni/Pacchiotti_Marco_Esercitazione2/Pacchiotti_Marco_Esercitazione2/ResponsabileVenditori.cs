using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchiotti_Marco_Esercitazione2
{
    internal class ResponsabileVenditori:Venditore
    {
       

        public List<Venditore> Venditori { get; set; }


        public void AggiungiVenditore(Venditore venditore)
        {
            Venditori.Add(venditore);
        }

        public Venditore RestituisciVenditore(int index)
        {
            return Venditori[index];
        }

        public void CancellaVenditore(int index)
        {
            Venditori.RemoveAt(index);
        }



        public override string ToString()
        {
            string venditori = "";
            foreach (Venditore venditore in Venditori)
            {
                venditori += venditore.ToString() + "\n";
            }
            return $"Responsabile Venditori: {Nome} {Cognome}\nStipendio: {Stipendio}\nVenditori:\n{venditori}";
        }

        public override double Tredicesima()
        {
            double giorni_lavorativi = 27;
            double tredicesima = Stipendio * 2;
            foreach (Venditore venditore in Venditori)
            {
                tredicesima += venditore.Stipendio/giorni_lavorativi * 0.15;
            }
            return tredicesima;
        }

    }
}
