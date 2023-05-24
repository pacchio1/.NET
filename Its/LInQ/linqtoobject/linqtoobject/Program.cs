using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtoobject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elenco = new List<Cliente>() {
                new Cliente() {CodiceFiscale = "FRRGNN99A01H501D",Nome="gianni",Cognome="FRR" },
                new Cliente() {CodiceFiscale = "LKRPTR98B23F205E",Nome="ptr",Cognome="lkr"},
                new Cliente() {CodiceFiscale = "BRCMRC97C12G301F",Nome="marco",Cognome="brc"},
                new Cliente() {CodiceFiscale = "PRLGNN96D09L401G",Nome="gianni",Cognome="pirlo" },
                new Cliente() {CodiceFiscale = "VNNMRC95E08M501H",Nome="marco",Cognome="vnn"},
                new Cliente() {CodiceFiscale = "GLLPTR94F07N601I",Nome="ptr",Cognome="gll"},
                new Cliente() {CodiceFiscale = "LKRPTR10B23F205E",Nome="ptr",Cognome="lkr"},
                new Cliente() {CodiceFiscale = "LKRPTR20B23F205E",Nome="ptr",Cognome="lkr"},
                new Cliente() {CodiceFiscale = "LKRPTR05B23F205E",Nome="ptr",Cognome="lkr"},



            };
            //richieste 
            //Console.WriteLine(string.Join("\n", elenco));
            //stampa codici fiscali
            var q = from a in elenco
                    select a.CodiceFiscale;
            Console.WriteLine(string.Join(", ",q));
            Console.WriteLine('\n');
            //stampa di cognome e nome
            q = from a in elenco
                select a.Cognome +" "+ a.Nome;
            Console.WriteLine(string.Join(", ", q));
            Console.WriteLine('\n');

            //stampa minorenni
            q = from a in elenco
                where a.RecuperoEta()<18
                select a.ToString();
            Console.WriteLine(string.Join(", ", q));




            Console.ReadLine();
        }
    }
}
