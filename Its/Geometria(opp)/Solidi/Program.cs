using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materiale Alumignio = new Materiale { Denominazione = "Aluminio", PesoSpecifico = 2.6 };
            Materiale Acciaio = new Materiale { Denominazione = "Acciaio", PesoSpecifico = 7.85 };

            var s1 = new Cubo { Lato = 1, PesoSpecifico = Acciaio };
            var s2 = new Cubo { Lato = 1, PesoSpecifico = Alumignio };
            var s3 = new Sfera { raggio = 1, PesoSpecifico = Acciaio };
            var s4 = new Sfera { raggio = 1, PesoSpecifico = Alumignio };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Solido[] solidi = { s1, s2, s3, s4 };
            Console.ReadLine();
            foreach(var s in solidi)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
