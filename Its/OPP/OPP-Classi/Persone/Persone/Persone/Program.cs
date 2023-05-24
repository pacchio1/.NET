namespace Persone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Persone!");

            //Nome e cognome, data nascita luogo nascita, Sesso, Età
            var p = new Persona
            {
                Nome = "Pino",
                Cognome = "Delillo",
                DataNascita = new DateTime(2000, 5, 25),
                LuogoNascita = "Torino",
                Sesso = Sesso.M
            };
            Console.WriteLine(p);
        }
    }
}