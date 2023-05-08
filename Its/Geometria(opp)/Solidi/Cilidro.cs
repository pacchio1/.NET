using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Cilidro : Solido
    {
        public double Raggio { get; set; }
        public double Altezza { get; set; }
        public override string ToString()
        {
            return "Raggio= "+Raggio+ " Altezza= " + Altezza + base.ToString();
        }

        public override double Volume()
        {
            return Math.PI * Math.Pow(Raggio, 2)*Altezza;
        }
    }
}
