using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateri
{
    public class Quadrato:Rettangolo
    {
        public Quadrato(double lato) : base(lato, lato) { }
        public override string ToString() =>
            $"{{Lato={Lato1.ToString()}" +
            $", Perimetro={Perimetro()}" +
            $", Area={Area()}" +
            $", Diagonale={Diagonale()}}}";
    }
}
