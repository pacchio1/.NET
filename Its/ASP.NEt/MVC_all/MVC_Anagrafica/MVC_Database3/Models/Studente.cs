using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToXml
{
    public class Studente
    {
        public int Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Email { get; set; }
        public string Classe { get; set; }

        public override string ToString()
        {
            return $"{nameof(Matricola)}={Matricola.ToString()}, {nameof(Cognome)}={Cognome}, {nameof(Nome)}={Nome}, {nameof(Classe)}={Classe},{nameof(Email)}={Email}";
        }
    }
}
