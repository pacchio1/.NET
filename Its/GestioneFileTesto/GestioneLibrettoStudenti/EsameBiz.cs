using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibrettoStudenti
{
    internal class EsameBiz
    {
        string path=@"C:\Files\Esami.csv";
        private List<Esame> elenco;
        public EsameBiz()
        {
            elenco = new List<Esame>();
            CaricaDati();
        }
        private void CaricaDati()
        {
            string dati=MyLibrary.Lettura(path);
            string[] righe=dati.Split('\n');
            for (int i = 0; i < righe.Length; i++)
            {
                string[] contenuti = righe[i].Split(',');
                elenco.Add (new Esame { Cognome = contenuti[0].Trim(),
                    Nome = contenuti[1], Materia = contenuti[2],
                    Data = DateTime.Parse(contenuti[3]),
                    Voto = int.Parse(contenuti[4]) 
                });
            }
        }
        public string Stampa()
        {
            return string.Join('\n', elenco);
        }
        public double MediaEsami()
        {
            string dati = MyLibrary.Lettura(path);
            string[] righe = dati.Split('\n');
            double avg = 0.0;
            for (int i = 0; i < righe.Length; i++)
            {
                string[] contenuti = righe[i].Split(',');
                avg = avg + double.Parse(contenuti[4]);
                
            }
            return avg / righe.Length;
            
        }
        public List<Esame> EsamiStudente(string cognome)
        {
            var lista = new List<Esame>();
            foreach (var e in elenco)
               if(e.Cognome == cognome)
                    lista.Add(e);
            return lista;

            
        }
        public int NumeroEsamiStudenti(string cognome) => EsamiStudente(cognome).Count;

        public override string? ToString()
        {
            return Stampa();
        }
    }
}
