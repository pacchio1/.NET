using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace atleta
{
    internal class Atleta:iAtleta,iNuotatore,iAtletaUniversale
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public int Pettorina { get; set; }

        public string Bevo()
        {
            throw new NotImplementedException();
        }

        public string Corro() => "C";

        public string Mangio()
        {
            throw new NotImplementedException();
        }

        public string Salto() => "S";
        public string Stile() => "R/D/S";
        public override string ToString()
        {
            return $"{{{nameof(Nome)}={Nome}, {nameof(Disciplina)}={Disciplina}, {nameof(Pettorina)}={Pettorina.ToString()}}}";
        }
    }
}
