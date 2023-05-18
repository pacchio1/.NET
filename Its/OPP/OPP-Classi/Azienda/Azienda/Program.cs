using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Amministrativo { Cognome = "Scardoni", Nome = "Leonardo", Mansione = Mansione.Contabile, OreLavorate = 100, PagaOraria = 20 };
            var a2 = new Amministrativo { Cognome = "Rossi", Nome = "Mario", Mansione = Mansione.Direttore, OreLavorate = 150, PagaOraria = 30 };
            var a3 = new Amministrativo { Cognome = "verdi", Nome = "Giuseppe", Mansione = Mansione.RisorseUmane, OreLavorate = 200, PagaOraria = 10 };

            var o1 = new Operaio { Cognome = "Mare", Nome = "Marco", Settore = Settore.Installatore, OreLavorate = 120, PagaOraria = 20 };
            var o2 = new Operaio { Cognome = "Roberti", Nome = "Federico", Settore = Settore.Manutentore, OreLavorate = 130, PagaOraria = 20 };

            var os1 = new OperaioSpecializato { Cognome = "Aligatore", Nome = "Roberto", Settore = Settore.Installatore, OreLavorate = 120, PagaOraria = 20, IndennitaMissione = 300,NueroMissioni=3 };
            var os2 = new OperaioSpecializato { Cognome = "Simone", Nome = "Lucaa", Settore = Settore.Manutentore, OreLavorate = 130, PagaOraria = 20 ,IndennitaMissione = 300, NueroMissioni = 3 };

            var a4 = new Amministrativo { Cognome = "hhhhhadhshhhhhhher", Nome = "Leonardo", Mansione = Mansione.Contabile, OreLavorate = 100, PagaOraria = 20 };
            var a5 = new Amministrativo { Cognome = "jhrehjue", Nome = "Mario", Mansione = Mansione.Direttore, OreLavorate = 150, PagaOraria = 30 };
            var a6 = new Amministrativo { Cognome = "agdgdhhq", Nome = "Giuseppe", Mansione = Mansione.RisorseUmane, OreLavorate = 200, PagaOraria = 10 };

            var o3 = new Operaio { Cognome = "jdfdfjjdfdhb ", Nome = "Marco", Settore = Settore.Installatore, OreLavorate = 120, PagaOraria = 20 };
            var o4 = new Operaio { Cognome = "ghasfhgdh", Nome = "Federico", Settore = Settore.Manutentore, OreLavorate = 130, PagaOraria = 20 };

            var os3 = new OperaioSpecializato { Cognome = "afdd", Nome = "Roberto", Settore = Settore.Installatore, OreLavorate = 120, PagaOraria = 20, IndennitaMissione = 300, NueroMissioni = 3 };
            var os4 = new OperaioSpecializato { Cognome = "afdfdadfa", Nome = "Lucaa", Settore = Settore.Manutentore, OreLavorate = 130, PagaOraria = 20, IndennitaMissione = 300, NueroMissioni = 3 };
            Dipendente[] dipendenti = { a1, a2, a3, a4, a5, a6, o1, o2, o3,o4, os1, os2, os3, os4 };
            var biz = new AziendaBiz(dipendenti);
            Console.WriteLine("Elenco dipendenti");
            Console.WriteLine(biz.StampaDipendenti());
            Console.WriteLine("Stampa Nome cognome e ruolo :Amministrativi");
            Console.WriteLine(biz.StampaAmministrativi());
            Console.WriteLine("Stampa Nome cognome e ruolo :Operai");
            Console.WriteLine(biz.StampaOperai());
            Console.WriteLine("Stampa Nome cognome e ruolo :Operai Specializati");
            Console.WriteLine(biz.StampaOperaiSpecializati());
            Console.WriteLine("Stampa Nome cognome e ruolo :Operai Specializati");
            Console.WriteLine(biz.TotDipendenti());






            Console.ReadLine();
        }
    }
}
