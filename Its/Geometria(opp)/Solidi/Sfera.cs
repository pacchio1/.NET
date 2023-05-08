using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Sfera : Solido
    {

        public double raggio { get; set; }
        public override string ToString()
        {
            return $"raggio={raggio},"+base.ToString();
        }

        public override double Volume() => 4 / 3 * Math.PI * Math.Pow(raggio,3);

    }
}
