//Marco Pacchiotti
namespace Pacchiotti_Marco_Esercitazione2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //venditori
            Console.WriteLine("Venditori");
            List<Venditore> venditori = new List<Venditore>();
            Venditore venditore = new Venditore { Cognome = "Rossi",Nome = "Mario",Stipendio = 1500.00, Settore = Settore.Auto};
            Venditore venditore2 = new Venditore { Cognome = "Rossi", Nome = "Claudio", Stipendio = 1550.00, Settore = Settore.Auto };
            venditori.Add(venditore);
            venditori.Add(venditore2);

            foreach (Venditore v in venditori)
            {
                Console.WriteLine(v.ToString());
            }
            //meccanici
            Console.WriteLine("Meccanici");

            List<Meccanico> meccanici = new List<Meccanico>();
            Meccanico m1 = new Meccanico { Cognome = "Rossi", Nome = "Mario", Stipendio = 1500.00, Tipologia = Tipologia.Carrozzeria };
            Meccanico m2 = new Meccanico { Cognome = "Rossi", Nome = "Claudio", Stipendio = 1500.00, Tipologia = Tipologia.Meccanica };
            meccanici.Add(m1);
            meccanici.Add(m2);


            foreach (Meccanico meccanico in meccanici)
            {
                Console.WriteLine(meccanico.Nome + " " + meccanico.Cognome);
            }
            //Stampa di un certo ordine
            Console.WriteLine("Stampa di un certo ordine");

            List<Prodotto>prodotti= new List<Prodotto>();
            Prodotto prodotto = new Prodotto { Codice=1,NomeProdotto="Cera",Descrizione="Cera",Prezzo=5.00};
            Prodotto prodotto2 = new Prodotto { Codice = 2, NomeProdotto = "candela", Descrizione = "candela", Prezzo = 100.00 };
            DateTime ora= DateTime.Now;
            prodotti.Add(prodotto);
            List<Ordine> ordini = new List<Ordine>();
            Ordine o1 = new Ordine { ElencoProdotti = prodotti, Venditore = venditore2 ,Data=ora,IdOrdine=01};
            
            foreach (Ordine o in ordini)
            {
                Console.WriteLine(o.IdOrdine);
            }
            Console.WriteLine("Inserire il numero del ordine");
            int s=int.Parse(Console.ReadLine());
            Console.WriteLine(ordini[s].ToString()); 


            //Stampa dei dati del responsabile venditori
            Console.WriteLine("Stampa dei dati del responsabile venditori");

            List<ResponsabileVenditori> responsabili = new List<ResponsabileVenditori>();
            ResponsabileVenditori a = new ResponsabileVenditori { Cognome = "aa", Nome = "pippo", Settore = Settore.Moto, Stipendio = 1900.00, Venditori = venditori };
            responsabili.Add(a);
            foreach (var i in responsabili)
            {
                Console.WriteLine(i.ToString());
            }
            //Stampa dei dati del capo officina
            Console.WriteLine("Stampa dei dati del capo officina");
            List<CapoOfficina> CapiOficine=new List<CapoOfficina>();
            CapoOfficina co1 = new CapoOfficina { Cognome = "P", Nome = "M", Ordini = ordini, Stipendio = 1000, Tipologia = Tipologia.Carrozzeria };
            CapiOficine.Add(co1);
            foreach(CapoOfficina cap in CapiOficine)
            {
                Console.WriteLine(cap.ToString()); 
            }

        }



    }
}