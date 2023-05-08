namespace PrezzoQuantitaSconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operazioni
            Console.WriteLine("inserisci il costo: ");
            decimal imponibile, costo=int.Parse(Console.ReadLine());
            costo = costo + costo * 0.04m;
            imponibile = costo;
            costo = costo + costo * 0.22m;
            decimal ritenuta = imponibile * 0.2m;
            costo = costo - ritenuta;
            // output
            string msg = $"Costo: {costo} \nimponibile: {imponibile} \nritenuta: {ritenuta}";
            Console.WriteLine(msg);
        }
    }
}