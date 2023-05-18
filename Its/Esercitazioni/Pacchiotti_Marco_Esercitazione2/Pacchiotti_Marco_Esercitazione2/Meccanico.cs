using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchiotti_Marco_Esercitazione2
{
    internal class Meccanico : Persona
    {
        public Tipologia Tipologia { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Meccanico meccanico &&
                   Nome == meccanico.Nome &&
                   Cognome == meccanico.Cognome &&
                   Stipendio == meccanico.Stipendio &&
                   Tipologia == meccanico.Tipologia;
        }

        public override string? ToString()
        {
            return base.ToString()+" Settore = "+Tipologia;
        }

        public override double Tredicesima()
        {
            
            return  Stipendio + Stipendio * 0.93;
        }

        

    }
}
