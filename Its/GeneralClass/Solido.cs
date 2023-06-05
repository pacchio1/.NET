using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    public abstract class Solido
    {
        public TipoMateriale Materiale { get; set; }

        public double Peso()
        {
            return Materiale.PesoSpecifico * Volume();
        }
        public abstract double Volume();

        public override string ToString()
        {
            return $"{Materiale}" +
                $", Peso={Peso()}" +
                $", Volume={Volume()}";
        }
    }
}
