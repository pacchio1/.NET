using Magazzino27;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GuiCatalogo
{
    public class MyLibrary
    {
        public static List<Prodotto> LeggifileOggetti(string path)
        {
            
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            var elenco = binaryFormatter.Deserialize(fs) as List<Prodotto>;
            fs.Close();
            return elenco;
        }
        public static void ScriviFileOggetti(string path,List<Prodotto> elenco)
        {
            FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);

           
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, elenco);

            fs.Close();
        }
    }
}
