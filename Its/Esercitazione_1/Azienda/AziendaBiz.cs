using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class AziendaBiz
    {
        public Dipendente[] dipendenti { get; set; }

        public AziendaBiz(Dipendente[] dipendenti)
        {
            this.dipendenti = dipendenti;
        }
        public string StampaAmministrativi()
        {
            string txt = string.Empty;
            foreach (var d in dipendenti)
            
                if (d is Amministrativo)
                    txt += "\n" + d;
            return txt;
            
        }
        public string StampaDipendenti()
        {
            string txt = string.Empty;
            foreach (var d in dipendenti)

                
                    txt += "\n" + d;
            return txt;

        }
        public string StampaOperai()
        {
            string txt = string.Empty;
            foreach (var d in dipendenti)

                if (d is Operaio)
                    txt += "\n" + d;
            return txt;

        }
        public string StampaOperaiSpecializati()
        {
            string txt = string.Empty;
            foreach (var d in dipendenti)

                if (d is OperaioSpecializato)
                    txt += "\n" + d;
            return txt;

        }
        public double TotStipendi()
        {
            double a = 0;
            foreach (var d in dipendenti)
                a += d.CalcoloDelloStipendio();
            return a;
        }
        public int TotOreLavorate()
        {
            int a = 0;
            foreach (var d in dipendenti)
                a += d.OreLavorate;
            return a;
        }
        public int TotDipendenti()
        {
            return dipendenti.Length;
        }
        public int TotOperaioSpecializato() {
            int i=0;
            foreach (var d in dipendenti) 
                if(d is OperaioSpecializato)
                    i++;
            return i;
        }
        public double PagaOrariaMediaOperai()
        {
            double a = 0;
            foreach (var d in dipendenti)
                if (d is Operaio)
                a += d.CalcoloDelloStipendio();
            return a/ TotOperaioSpecializato();
        }
        public int NumeroMissioni()
        {
            int i = 0;
            foreach (var d in dipendenti) {
                OperaioSpecializato os = null;
                if (d is OperaioSpecializato)
                {
                    os=(OperaioSpecializato)d;
                    i += os.NueroMissioni;
                }
            }
            return i;
        }

        public override string ToString()
        {
            return StampaDipendenti();
        }
    }
}
