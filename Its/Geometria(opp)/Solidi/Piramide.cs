using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Piramide : Solido
    {
        public double LatoBase { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }

        public override double Volume()
        {
            throw new NotImplementedException();
        }
    }
}
