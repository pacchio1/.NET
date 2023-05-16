using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchiotti_Marco_Esercitazione2
{
    internal class Venditore : Persona,ICloneable
    {
       

        public Settore Settore { get; set; }
        public (string Nome, string Cognome, double Stipendio, Settore Settore) Value { get; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString()+" Settore = "+Settore;
        }

        public override double Tredicesima()
        {
            return Stipendio + Stipendio * 0.91;
        }
        
    }
}
