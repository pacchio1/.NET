using PaacchiottiMarco_Esercitazione1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacchiottiMarco_Esercitazione1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Bancomat(10, 5, 3);
            b1 = new Bancomat(20);
            Console.Write(b1.InterrogazioneBancomat());
            Console.WriteLine("\nNumero di pezzi da 50 euro da togliere");
            int n_50=int.Parse(Console.ReadLine());
            if (b1.Togli50(n_50)) { Console.WriteLine("operazione riuscita"); Console.Write(b1.InterrogazioneBancomat()); }
            else { Console.WriteLine("\noperazione fallita"); }
            Console.WriteLine("\nInserire cifra da prelevare");
            double p = double.Parse(Console.ReadLine());
            foreach (var x in b1.Prelievo(p))
                Console.WriteLine(x);
            Console.Write(b1.InterrogazioneBancomat());
            Console.ReadLine();
            
        }
    }
}
