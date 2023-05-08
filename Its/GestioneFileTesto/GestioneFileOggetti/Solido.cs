using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    [Serializable]
    internal abstract class Solido
    {
        public double PesoSpecifico { get; set; }
        public abstract double Volume();
        public double Peso()
        {
            return 1 * Volume();
        }

        public override string ToString()
        {
            return $"{{{nameof(PesoSpecifico)}={PesoSpecifico.ToString()}}}"+" {Volume= "+Volume()+"}" + " {Peso= " + Peso() + "}";
        }
    }
}
