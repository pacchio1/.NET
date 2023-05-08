using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class Amministrativo:Dipendente
    {
        public Mansione Mansione { get; set; }
        public override double CalcoloDelloStipendio()
        {
            var bonus = 0.0;
            switch (Mansione){
                case Mansione.Contabile:bonus = 150.00;break;
                case Mansione.RisorseUmane: bonus = 50.00; break;
                case Mansione.Direttore: bonus = 300.00; break;
                default:break;

            }
            return base.CalcoloDelloStipendio()+bonus;

        }

        public override string ToString()
        {
            return base.ToString()+" Mansione= "+Mansione;
        }
    }
}
