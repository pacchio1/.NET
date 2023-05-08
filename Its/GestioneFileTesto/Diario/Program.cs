using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Files\Diario.txt";
            /*
             * stampare 
             * data e ora 
             * frase del giorno
             */
            if(!File.Exists(path))
            
                File.Create(path);
            
            Console.WriteLine("Frase dell giorno?");
            string fr=Console.ReadLine();
            try
            {
                string t = MyLibrary.Lettura(path);
                fr = DateTime.Now.ToString() + "\n" + fr;
            }
            catch (Exception)
            {

                throw;
            }
             MyLibrary.Scrittura(path, fr);
            Console.ReadLine();


        }
    }
}
