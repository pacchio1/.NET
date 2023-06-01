using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq to xml");
            //string path = @"XML_Risultato.xml";
            string path2= @"Istat.xml";
            //XElement root = XElement.Load(path2);
            XElement root2 = XElement.Load(path2);
            //var studenti = root2.Elements();//return tutti i record
            var Istat = root2.Elements();//return tutti i record



            /*var lista = root.Elements().Select(s =>new Studente
            {
                Matricola=int.Parse(s.Element("Matricola").Value),
                Cognome = s.Element("Cognome").Value,
                Nome = s.Element("Nome").Value,
                Classe = s.Element("Classe").Value,
            }
            );
            // Console.WriteLine(string.Join("\n", lista));

            var elenco = from a in Istat.Elements()
                         
                         select a;
            Console.WriteLine(string.Join("\n", elenco));*/









            Console.ReadLine();
        }
    }
}
