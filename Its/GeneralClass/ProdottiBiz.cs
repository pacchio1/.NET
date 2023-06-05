using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    internal class ProdottiBiz
    {
        public Prodotto[] prodotti;

        public ProdottiBiz(Prodotto[] prodotti)
        {
            this.prodotti = prodotti;
        }

        public string StampaProdotti()
        {
            string txt = string.Empty;
            foreach (var p in prodotti)
                txt += "\n" + p;
            return txt;
        }
        public string StampaProdottiInScadenza()
        {

            string txt = string.Empty;
            foreach (var p in prodotti)
                if (p is Alimentare prod)
                    if(prod.DataScadenza.AddDays(10)> DateTime.Now)
                            
                    txt += "\n" + p.Nome + " " +p.Coice;
            return txt;
        }
        public string StampaMateriale()
        {
            string txt = string.Empty;
            foreach (var p in prodotti)
                if (p is NonAlimentare prod)
                        txt += "\n" +p.Nome + " costituito in "+ prod.Materiale;
            return txt;
        }
    }
}
