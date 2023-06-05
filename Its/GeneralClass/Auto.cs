using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAuto
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Cilindrata { get; set; }
        public Carburante Carburante { get; set; }
        public string Colore { get; set; }
        public int Velocita { get; set; } = 50;

        public double VelocitaMax()
        {
            double velocita = (double)Cilindrata / 10;
            switch (Carburante)
            {
                case Carburante.BENZINA: velocita += 30; break;
                case Carburante.DIESEL: velocita += 10; break;
                case Carburante.GPL: velocita -= 10; break;
                case Carburante.METANO: velocita -= 30; break;
                default: velocita += 0; break;
            }
            return velocita;
        }

        public void Accelera()
        {
            if (VelocitaMax() <= Velocita + 10)
                Velocita = (int)VelocitaMax();
            else
                Velocita += 10;
        }

        public void Frena() { 
            Velocita -= 5;

            if(Velocita<0)
                Velocita = 0;
        }

        public override string ToString()
        {
            return $"{{{nameof(Marca)}={Marca}" +
                $", {nameof(Modello)}={Modello}" +
                $", {nameof(Cilindrata)}={Cilindrata.ToString()}" +
                $", {nameof(Carburante)}={Carburante.ToString()}" +
                $", {nameof(Colore)}={Colore}" +
                $", Velocità Max: {VelocitaMax()}}}";
        }
    }
}
