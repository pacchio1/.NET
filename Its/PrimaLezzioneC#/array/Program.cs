namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numeri= new int[10];
            int a = 0;
            Numeri.Append(a);
            for(int i=0; a<Numeri.Length; a++)
            {
                Console.WriteLine(Numeri[i]);
            }
            foreach(var n in Numeri)
            { 
                Console.WriteLine(n); 
            }
        }
    }
}