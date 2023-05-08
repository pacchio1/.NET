using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Persone
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime dob { get; set; }
        public string LuogoNascita { get; set; }
        public Sesso sesso { get; set; }
        public int Eta()
        {
            int eta = DateTime.Now.Year-dob.Year;
            if (DateTime.Now.Month < dob.Month)
                eta--;
            else if (DateTime.Now.Month < dob.Month && DateTime.Now.Day < dob.Day)
                eta--;
            return eta;

        }

        public override string ToString()
        {
            return $"{{{nameof(Nome)}={Nome}, {nameof(Cognome)}={Cognome}, {nameof(dob)}={dob.ToShortDateString()}, {nameof(LuogoNascita)}={LuogoNascita}, {nameof(sesso)}={sesso.ToString()},Età: {Eta()}}}";
        }
    }

    enum Sesso
    {
        Maschio,Femmina,ALTRO,POCO

    }
}
