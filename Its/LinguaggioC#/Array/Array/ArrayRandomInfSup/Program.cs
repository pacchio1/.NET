/*
Generare un array di numeri random appartenenti 
all'intervallo [inf,sup] con dimensione[1,100]

Visualizzare i numeri generati
*/

Random random = new Random();
int dimensione=random.Next(1, 100+1);
int[] numeri = new int[dimensione];

Console.Write("Inf: ");
int inf = int.Parse(Console.ReadLine());

Console.Write("Sup: ");
int sup = int.Parse(Console.ReadLine());

for (int i = 0; i < numeri.Length; i++)
    numeri[i] = random.Next(inf,sup+1);

Console.WriteLine(string.Join("\n", numeri));