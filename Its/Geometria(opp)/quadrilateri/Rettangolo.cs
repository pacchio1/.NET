using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrilateri
{
    public class Rettangolo : quadrilatero
    {
        public Rettangolo(double @base, double altezza) 
            : base(@base, altezza, @base, altezza)//base esiste gia come nome @ -> fa over raid
        {}
        public double Area() => Lato1 * Lato2;
        public double Diagonale() => Math.Sqrt(Lato1 * Lato1 + Lato2 * Lato2);

        public override string ToString()
        {
            return "Base= "+Lato1.ToString()+ 
                " Alteza= " + Lato2.ToString()+
                " Perimetro= "+Perimetro()+
                " Area= "+Area()+
                " Diagonale= "+Diagonale();
                
        }
    }
}
