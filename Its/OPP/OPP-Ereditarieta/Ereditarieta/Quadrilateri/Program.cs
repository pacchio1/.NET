namespace Quadrilateri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I Quadrilateri!");

            var q1 = new Quadrilatero(1.25,2.5,1.75,3);
            Console.WriteLine(q1);

            var q2 = new Rettangolo(1.95, 2.05);
            Console.WriteLine(q2);

            var q3 = new Quadrato(1.35);
            Console.WriteLine(q3);

            Quadrilatero[] quadrilateri = { q1, q2, q3 };

            foreach (var q in quadrilateri)                            
                if (q is Rettangolo r)
                    Console.WriteLine(r.Area());
                
            
        }
    }
}