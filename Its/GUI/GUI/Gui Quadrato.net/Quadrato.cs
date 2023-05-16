using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gui_Quadrato.net
{
    internal class Quadrato
    {
        public double Lato { get; set; }



        public double Perimetro() => Lato * 4;
        public double Area()
        {
            return Lato*Lato;
        }
        public override string ToString()
        {
            return "Lato= " + Lato.ToString() +
                " Perimetro= " + Perimetro() +
                " Area= " + Area();
                

        }
    }
}
