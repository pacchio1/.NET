namespace Divisione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            if (b==0)
            {
                Console.WriteLine("impossibile dividere per zero");
            }
            else
            {
                float Divisione = (float)a / b;
                float resto = a % b;
                Console.WriteLine("divisione= "+Divisione+" resto= "+resto);
            }
        }
    }
}