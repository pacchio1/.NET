using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    public class Sfera:Solido
    {
        public double Raggio { get; set; }

        public override double Volume()
        {
            return 4 * Math.PI * Math.Pow(Raggio, 3) / 3;
        }

        public override string ToString()
        {
            return $"Raggio={Raggio}, "+base.ToString();
        }
    }
}
