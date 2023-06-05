using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibrettoStudenti
{
    public class EsameBiz
    {
        private List<Esame> elenco;
        private string path = @"..\..\..\files\Esami.csv";

        public EsameBiz()
        {
            elenco = new List<Esame>();
            CaricaDati();
        }

        private void CaricaDati()
        {

            string dati = MyLibrary.LeggiFileTesto(path);

            string[] righe = dati.Split('\n');

            for (int i = 0; i < righe.Length; i++)
            {
                string[] contenuti = righe[i].Split(',');
                elenco.Add(
                    new Esame
                    {
                        Cognome = contenuti[0]
                    ,
                        Nome = contenuti[1]
                    ,
                        Materia = contenuti[2]
                    ,
                        Data = DateTime.Parse(contenuti[3])
                    ,
                        Voto = int.Parse(contenuti[4])
                    });
            }
        }

        public string Stampa()
        {
            return string.Join("\n", elenco);
        }

        //media globale degli esami sostenuti
        public double MediaEsami()
        {

            int somma = 0;
            foreach (var e in elenco)
                somma += e.Voto;

            return (double)somma / elenco.Count;
        }

        public List<Esame> EsamiPerStudente(string cognome)
        {

            var lista = new List<Esame>();
            foreach (var e in elenco)
                if (e.Cognome == cognome)
                    lista.Add(e);
            return lista;
        }

        public List<Esame> EsamiPerMateria(string materia)
        {

            var lista = new List<Esame>();
            foreach (var e in elenco)
                if (e.Materia == materia)
                    lista.Add(e);
            return lista;
        }

        public int NumeroEsamiPerStudente(string cognome)
        {
            return EsamiPerStudente(cognome).Count;
        }

        public override string? ToString()
        {
            return Stampa();
        }
    }
}
