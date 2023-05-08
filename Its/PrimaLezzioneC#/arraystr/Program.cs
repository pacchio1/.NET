namespace arraystr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomi = { "Piero", "Giulia", "Ilaria", "Monica", "Andrea" };
            foreach (string nom in nomi)
            {
                Console.WriteLine(nom);
            }
        }
    }
}