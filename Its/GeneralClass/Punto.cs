using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        //metodo
        //distanza tra due punti
        public double Distanza(Punto punto)
        {
            return Math.Sqrt(Math.Pow(this.X - punto.X, 2) + Math.Pow(this.Y - punto.Y, 2));
        }

        //distanza di un punto dall'origine degli assi
        //overloading di Distanza(Punto punto)
        public double Distanza()
        {
            var o = new Punto { X = 0, Y = 0 };
            return Distanza(o);
        }

        public override string ToString()
        {
            return $"{{{nameof(X)}={X.ToString()}, {nameof(Y)}={Y.ToString()}}}";
        }
    }
}
