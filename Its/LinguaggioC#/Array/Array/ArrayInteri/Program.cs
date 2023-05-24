//dichiarazione di un array

int[] numeri = new int[3];
numeri[0] = 10;
numeri[1] = -10;
numeri[2] = 101;

for(int i = 0; i < numeri.Length; i++)
    Console.WriteLine(numeri[i]);

foreach(int n in numeri)
    Console.WriteLine(n);
