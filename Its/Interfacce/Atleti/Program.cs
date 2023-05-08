namespace Atleti
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atleti!");
            try
            {
                var a1 = new Atleta { Nominativo = "Luis Alberto", Disciplina = "Nuoto", Pettorina = 3 };
                Console.WriteLine(a1);
                Console.WriteLine(a1.Corro());
                //Console.WriteLine(a1.Rovescio());

                var c1 = new Calciatore
                {
                    Nominativo = "Ciro Del Pino",
                    Disciplina = "Calcio",
                    Pettorina = 42,
                    Club = "Fiorenzuola",
                    GoalSegnati = 12,
                    PartiteGiocate = 8
                };
                Console.WriteLine(c1);

                Calciatore c2 = (Calciatore)c1.Clone();
                c2.Nominativo = "Roberto Cau";
                c2.GoalSegnati = 3;
                c2.PartiteGiocate = 6;

                var c3 = c1.Clone() as Calciatore;

                if(c1.Equals(c3))
                    Console.WriteLine($"{c1.Nominativo} è uguale a {c3.Nominativo}");

                if(c1.CompareTo(c2)==1)
                    Console.WriteLine($"{c1.Nominativo} ha media goal segnati superiore {c2.Nominativo}");

            }
            catch (NotImplementedException e) {
                Console.WriteLine("Errore!");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}