using Solidi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GestioneFileOggetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione fille di Ogetti!");
            string path = @"C:\Files\Dati.dat";
            var q = new Cubo { Lato = 1, PesoSpecifico = 1 };
            if(File.Exists(path)) { File.Delete(path); }
            //scrittura opp
            //accesso al file in modalita scrittura
            FileStream fw = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
            //serializazione dati disco
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fw, q);
            fw.Close();
            Console.WriteLine("Operazione Conclusa");
            //lettura OPP
            //accesso al file in modalita lettura
            FileStream fr = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter br=new BinaryFormatter();
            var q1=br.Deserialize(fr) as Cubo;
            fr.Close();
            Console.WriteLine("Dati recuperati:");
            Console.WriteLine(q1);
            Console.ReadLine();
        }
    }
}
