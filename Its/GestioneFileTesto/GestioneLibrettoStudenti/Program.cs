namespace GestioneLibrettoStudenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GestioneLibrettoStudenti\r\n");
            var biz =new EsameBiz();
            Console.WriteLine(biz.Stampa());
            Console.WriteLine(biz.MediaEsami().ToString());
            Console.Write("inserisci cognome: ");
            string cognome=Console.ReadLine();
            Console.WriteLine(string.Join("\n",biz.EsamiStudente(cognome)));
            Console.Write("inserisci materia: ");
            string materia = Console.ReadLine();
            Console.WriteLine(string.Join("\n",(cognome)));
        }
    }
}