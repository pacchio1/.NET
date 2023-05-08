namespace somma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("inserisci 2 numeri interi \n 1:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("2:");
            b =int.Parse(Console.ReadLine());
            int somma = a + b;
            Console.WriteLine("somma: "+somma);
            
        }
    }
}