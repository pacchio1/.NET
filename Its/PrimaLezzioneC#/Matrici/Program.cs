namespace Matrici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            int righe = 10, colonne = 7;
            int[,] matrice = new int[righe, colonne];
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    matrice[i, j] = random.Next(100) + 1;
                }
            }
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    Console.Write(matrice[i, j]);
                }
                Console.WriteLine('\n');
            }
        }
    }
}