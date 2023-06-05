using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class OperaioSpecializzato:Operaio
    {
        public int NumeroMissioni { get; set; }
        public double IndennitaMissione { get; set; }

        public override double Stipendio()
        {            
            return base.Stipendio() + NumeroMissioni*IndennitaMissione;
        }

        public override string ToString()
        {
            return base.ToString() +
                $", Numero di missioni={NumeroMissioni}" +
                $", Indennità di missione: {IndennitaMissione} euro";
        }
    }
}
