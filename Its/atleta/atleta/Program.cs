using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Atleta { Nome = "Aaa", Disciplina = "aa", Pettorina = 22 };
            Console.WriteLine(a1.Stile()); 
            Console.ReadLine();
            var c1 = new Calciatore { Nome = "Ciro", Disciplina = "Calciatore", Pettorina = 22, Club = "Napoli", PartiteGiocate = 8, GoalSegnati = 12 };
            Console.WriteLine(c1.ToString());
            Calciatore c2 = (Calciatore)c1.Clone();
            var c3= c1.Clone()   as Calciatore;
        }
    }
}
