using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Analisi_del_testo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Assumendo che tu abbia scelto di realizzare un programma di analisi del testo come progetto in C# utilizzando la console application, ecco alcune funzionalità che potresti implementare per il tuo programma:

                Frequenza delle parole: Il tuo programma potrebbe analizzare il testo inserito dall'utente e conteggiare la frequenza di ogni parola presente. In questo modo, l'utente potrebbe capire quali parole sono utilizzate più frequentemente nel testo.

                Lunghezza delle parole: Potresti implementare una funzione che conta la lunghezza di ogni parola presente nel testo e calcola la media delle lunghezze delle parole. Questa funzionalità potrebbe essere utile per valutare il livello di complessità del testo.

                Lunghezza delle frasi: Il tuo programma potrebbe analizzare il testo inserito dall'utente e conteggiare il numero di parole in ogni frase, calcolare la lunghezza media delle frasi e determinare la complessità del testo in base alla lunghezza delle frasi.

                Analisi del tono: Potresti utilizzare una libreria di analisi del tono per valutare l'umore generale del testo. In questo modo, l'utente potrebbe avere un'idea dell'emozione che il testo trasmette.

                Ricerca di parole chiave: Il tuo programma potrebbe cercare parole chiave specifiche all'interno del testo. In questo modo, l'utente potrebbe trovare informazioni specifiche nel testo in modo più efficiente.

                Per implementare queste funzionalità, potresti utilizzare le stringhe in C# per manipolare il testo inserito dall'utente e le strutture dati come gli array e le liste per memorizzare le informazioni estratte dal testo. Inoltre, potresti utilizzare librerie esterne per l'analisi del tono o per l'estrazione di parole chiave.

                Spero che queste informazioni ti siano utili per il tuo progetto di analisi del testo in C#.
             */
            string path = @"..\..\Files\Text.txt";
            string line;
            StreamReader reader = new StreamReader(path);
            
            Dictionary<string, int> wordFreq = new Dictionary<string, int>();
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                // Rimuovi la punteggiatura e converti il testo in minuscolo
                line = new string(line.Where(c => !char.IsPunctuation(c)).ToArray()).ToLower();

                // Dividi il testo in parole
                string[] words = line.Split(' ');

                // Aggiungi le parole al dizionario o incrementa il loro valore
                foreach (string word in words)
                {
                    if (wordFreq.ContainsKey(word))
                    {
                        wordFreq[word]++;
                    }
                    else
                    {
                        wordFreq[word] = 1;
                    }
                }
            }

            reader.Close();

            // Stampa la frequenza delle parole
            foreach (KeyValuePair<string, int> pair in wordFreq.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }




            //fine
            Console.ReadLine();
        }
    }
}
