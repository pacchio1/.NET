using System;
using System.Linq;
namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esempio LInQ!");
            string[] nomi = {"pietro","mario","giulia","Francesca","laura","pietro","Antonio","Vito","giada","Rossella",
            "Simone","Rosa","Andrea","Mattia","ilaria","alessandro","Vanessa","Antonella","robero","Leonardo"};
            Console.WriteLine("Eleco completo");
            var query =from tutti in nomi select tutti;
            Console.WriteLine(string.Join(", ",query));
            Console.WriteLine('\n');

            //elenco dei nomi che iniziano con la letteraa 
            var query2 = from iniziaA in nomi //where iniziaA.StartsWith("A")
                         where iniziaA.Substring(0,1).ToUpper().Equals("A")
                         select iniziaA;
            Console.WriteLine(string.Join(", ",query2));
            Console.WriteLine('\n');

            //elenco dei nomi ordinato cres
            var query3 = from ordinaAsc in nomi orderby ordinaAsc ascending select ordinaAsc;
            Console.WriteLine(string.Join(", ", query3));
            Console.WriteLine('\n');

            //elencon dei nomi che hanno lunghezza 7 char decrescenti
            var query4 = from lung7 in nomi
                         where lung7.Length == 7
                         orderby lung7 descending
                         select lung7;
            Console.WriteLine(string.Join(", ", query4));
            Console.WriteLine('\n');


            //alone, stampa elenco numeri 
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -1, -2, -3 };
            var q1=from numeri in ints
                   select numeri;
            Console.WriteLine(string.Join(", ", q1));
            Console.WriteLine('\n');

            //funzioni lambda 
            Console.WriteLine($"Max:{ints.Max()}");
            Console.WriteLine($"Max:{ints.Min()}");
            Console.WriteLine($"count:{ints.Count()}");
            Console.WriteLine($"Sum:{ints.Sum()}");
            Console.WriteLine('\n');

            // somma dei numeri positivi
            var q2 =from n in ints
                   where n>0
                   select n;
            Console.WriteLine( q2.Sum());
            Console.WriteLine('\n');

            // elenco numeri dispari
            var q3 = from n in ints
                     where n % 2!=0
                     select n;
            Console.WriteLine(string.Join(", ", q3));
            Console.WriteLine('\n');

            //elenco numeri pari appartenenti al intervallo [0,5] ordinati in senso decrescente
            var q4=from n in ints
                   where n% 2==0 && n>0 && n<5
                   orderby n descending
                   select n;
            Console.WriteLine(string.Join(", ", q4));
            Console.WriteLine('\n');


            Console.ReadLine();
        }
    }
}
