using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{

    public class TipoMateriale
    {
        public Materiale Materiale { get; set; }
        public double PesoSpecifico { get; set; }

        public override string ToString()
        {
            return $"Materiale={Materiale}, {nameof(PesoSpecifico)}={PesoSpecifico.ToString()}";
        }
    }
}
