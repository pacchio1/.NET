using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class OperaioSpecializato:Operaio
    {
        public int NueroMissioni { get; set; }
        public double IndennitaMissione { get; set; }
        public override double CalcoloDelloStipendio()
        {
            return base.CalcoloDelloStipendio() + NueroMissioni*IndennitaMissione;

        }
        public override string ToString()
        {
            return base.ToString() + " Numero di missioni= " + NueroMissioni + " Indennita di missione= "+IndennitaMissione;
        }
    }
}
