using System.Xml.Serialization;
namespace ArrayRandomInfSup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dimensione = random.Next(0,100+1);
            int[] numeri= new int[dimensione];
            Console.Write("Inf:");
            int inf=int.Parse(Console.ReadLine());
            Console.Write("Sup:");
            int sup = int.Parse(Console.ReadLine());
            for (int i=0;i<numeri.Length;i++)
            {
                numeri[i]=random.Next(inf,sup+1);
            }
            Console.WriteLine(string.Join("\n",numeri));
        }
    }
}