using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtoobject
{
    internal class Cliente
    {
        public string CodiceFiscale { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        
        public Sesso RSesso()
        {
            //XXXXXX00X00X000X
            int giorno = int.Parse(CodiceFiscale.Substring(9,2))-40;
            return giorno>=0?linqtoobject.Sesso.Femmina:linqtoobject.Sesso.Maschio;
        }
        public DateTime DataNascita()
        {
            char[] mesicodicefiscale = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'L', 'M', 'P', 'R', 'S', 'T' };
            int giorno = int.Parse(CodiceFiscale.Substring(9, 2)) + (RSesso() == Sesso.Femmina ? -40 : 0);
            int mese = Array.IndexOf(mesicodicefiscale, CodiceFiscale[8])+1;
            int anno = int.Parse(CodiceFiscale.Substring(6, 2));
            anno+=(anno>=0 && anno<=DateTime.Now.Year-2000)?2000:1900;
            return new DateTime(anno, mese, giorno);
        }

        public int RecuperoEta()
        {
            return DateTime.Now.Year - DataNascita().Year;
        }
        public override string ToString()
        {
            return $"{nameof(CodiceFiscale)}={CodiceFiscale}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Cognome)}={Cognome}," +
                $"{nameof(RSesso)}={RSesso()}," +
                $"{nameof(DataNascita)}={DataNascita()},";
        }
    }
}
