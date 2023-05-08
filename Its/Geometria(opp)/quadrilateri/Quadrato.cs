using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrilateri
{
    internal class Quadrato : Rettangolo
    {
        public Quadrato(double Lato) 
            : base(Lato, Lato)
        {
        }
        public override string ToString()
        {
            return "Lato= " + Lato1.ToString() +
                " Perimetro= " + Perimetro() +
                " Area= " + Area() +
                " Diagonale= " + Diagonale();

        }
    }
}
