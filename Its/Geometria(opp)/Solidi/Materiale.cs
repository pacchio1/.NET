﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Materiale
    {
        public string Denominazione { get; set; }
        public double PesoSpecifico { get; set; }

        public override string ToString()
        {
            return $"{{Materiale={Denominazione}, {nameof(PesoSpecifico)}={PesoSpecifico.ToString()}}}";
        }
    }
}
