using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string LuogoNascita { get; set; }
        public Sesso Sesso { get; set; }

        public int Eta() { 
            int eta = DateTime.Now.Year-DataNascita.Year;

            if (DateTime.Now.Month < DataNascita.Month) 
                eta--;
            else if (DateTime.Now.Month == DataNascita.Month && DateTime.Now.Day < DataNascita.Day)
                eta--;

            return eta;
        }

        public override string ToString()
        {
            return $"{{{nameof(Nome)}={Nome}" +
                $", {nameof(Cognome)}={Cognome}" +
                $", {nameof(DataNascita)}={DataNascita.ToShortDateString()}" +
                $", {nameof(LuogoNascita)}={LuogoNascita}" +
                $", {nameof(Sesso)}={Sesso.ToString()}" +
                $", Età: {Eta()}}}";
        }
    }
}
