using System.Linq;

namespace VenditaProdotti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            NonAlimentare p1 = new NonAlimentare { Nome = "a", Coice = 0201, Prezzo = 10.00, DataProduzione = new DateTime(2000, 10, 10),Materiale="Accaio",MaterialePrincipalePercentuario=95.32 };
            Alimentare p2 = new Alimentare { Nome = "b", Coice = 1201, Prezzo = 2.00, DataProduzione = new DateTime(2000, 10, 10), DataScadenza = new DateTime(2010,10,10)};
            Alimentare p3 = new Alimentare { Nome = "c", Coice = 2222, Prezzo = 1.50, DataProduzione = new DateTime(2023, 10, 10), DataScadenza = new DateTime(2023, 04, 28)};
            Prodotto[] prodotti = {p1,p2,p3 };

            var biz = new ProdottiBiz(prodotti);
            Console.WriteLine("elenco prodotti");
            Console.WriteLine(biz.StampaProdotti());
            Console.WriteLine("elenco prodotti in scadenza");
            Console.WriteLine(biz.StampaProdottiInScadenza());
            Console.WriteLine("elenco materie prime");
            Console.WriteLine(biz.StampaMateriale());

        }
    }
}