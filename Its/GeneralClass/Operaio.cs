using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class Operaio:Dipendente
    {
        public Settore Settore { get; set; }

        public override double Stipendio()
        {
            var bonus = 0.0;
            switch (Settore)
            {
                case Settore.Installatore: bonus = 175.25; break;
                case Settore.Manutentore: bonus = 250.75; break;
                default: break;

            }
            return base.Stipendio() + bonus;
        }

        public override string ToString()
        {
            return base.ToString() + $", Settore={Settore}";
        }
    }
}
