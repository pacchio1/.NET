namespace enalotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int e1, e2, e3, e4, e5;
            e1 = random.Next(1, 90 + 1);
            do
            {
                e2 = random.Next(1, 90 + 1);
            } while (e1 == e2);
            do
            {
                e3 = random.Next(1, 90 + 1);
            } while (e1 == e2 || e2== e3);
            do
            {
                e4 = random.Next(1, 90 + 1);
            } while (e1 == e2 || e2 == e3|| e3==e4);
            do
            {
                e5 = random.Next(1, 90 + 1);
            } while (e1 == e2 || e2 == e3 || e3 == e4||e4==e5);
            Console.WriteLine($"{e1},{e2},{e3},{e4},{e5}");
        }
    }
}