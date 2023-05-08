using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal abstract class Solido
    {
        public Materiale PesoSpecifico { get; set; }
        public abstract double Volume();
        public double Peso()
        {
            return PesoSpecifico.PesoSpecifico * Volume();
        }

        public override string ToString()
        {
            return $"{{{nameof(PesoSpecifico)}={PesoSpecifico.ToString()}}}"+" {Volume= "+Volume()+"}" + " {Peso= " + Peso() + "}";
        }
    }
}
