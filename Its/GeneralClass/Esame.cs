using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibrettoStudenti
{
    [Serializable]
    public class Esame
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Materia { get; set;}
        public DateTime Data { get; set; }
        public int Voto { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Cognome)}={Cognome}, {nameof(Nome)}={Nome}, {nameof(Materia)}={Materia}, {nameof(Data)}={Data.ToShortDateString()}, {nameof(Voto)}={Voto.ToString()}}}";
        }
    }
}
