using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Persona
            {
                Nome = "Pino",
                Cognome = "Rossi",
                dob = new DateTime(2000, 5, 25),
                sesso = Sesso.POCO
            };
            Console.WriteLine(p);
            Console.ReadLine();
        }
        
    }
}
