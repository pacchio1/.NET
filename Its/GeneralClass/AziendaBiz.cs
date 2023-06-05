using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class AziendaBiz
    {
        private Dipendente[] dipendenti;

        public AziendaBiz(Dipendente[] dipendenti)
        {
            this.dipendenti = dipendenti;
        }

        //stampa elenco dipendenti
        public string StampaDipendenti() {
            string txt = string.Empty;
            foreach (var d in dipendenti)               
                    txt += "\n" + d;
            return txt;
        }
        public string StampaAmministrativi()
        {
            string txt = string.Empty;
            foreach (var d in dipendenti)
                if (d is Amministrativo)
                    txt += "\n"+d;
            return txt;
        }
    }
}
