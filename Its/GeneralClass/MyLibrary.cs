using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibrettoStudenti
{
    public class MyLibrary
    {
        //lettura da file di testo
        public static string LeggiFileTesto(string path)
        {
            try {
                StreamReader sr = new StreamReader(path);
                string testo = sr.ReadToEnd();
                sr.Close();
                return testo;
            }
            catch (FileNotFoundException e) {
                throw new FileNotFoundException();
            }
        }

        //scrittura su file di testo
        public static void ScriviFileTesto(string path, string testo)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(testo);
            sw.Flush();
            sw.Close();
        }
        /*
        public static List LeggiFileOggetti(string path)
        {

        }
        */
    }
}
