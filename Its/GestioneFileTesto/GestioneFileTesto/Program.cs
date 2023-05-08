using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestioneFileTesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione file di testo");
            string path = @"C:\Files\testo.txt";
            //scrittura
            StreamWriter SW = new StreamWriter(path);
            Console.WriteLine("Inserisci testo");
            SW.WriteLine(Console.ReadLine());
            SW.Flush();
            SW.Close();
            Console.WriteLine("i dati inseriti sono stati salvati sul disco fisso");
            try {
                //lettura 
                StreamReader streamReader = new StreamReader(path);

                string t = string.Empty;
                t = streamReader.ReadToEnd();
                streamReader.Close();
                Console.WriteLine($"Testo inserito:\n{t}");
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);

            }
            finally
            {
                
            }

            

        }

    }
}
