using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleti
{
    public class Atleta:IAtleta,INuotatore,ITennista,IAtletaUniversale
    {
        public string Nominativo { get; set; }
        public string Disciplina { get; set; }
        public int Pettorina { get; set; }

        public string Bevo()
        {
            throw new NotImplementedException();
        }

        public string Corro()
        {
            return "Sto correndo...";
        }

        public string Dorso()
        {
            return "Sto nuotando con stile dorso...";
        }

        public string Dritto()
        {
            return "Sto tirando di dritto...";
        }

        public string Mangio()
        {
            throw new NotImplementedException();
        }

        public string Rana()
        {
            return "Sto nuotando con stile rana...";
        }

        public string Rovescio()
        {
            throw new NotImplementedException();
        }

        public string Salto()
        {
            return "Sto saltando...";
        }

        public override string ToString()
        {
            return $"{nameof(Nominativo)}={Nominativo}" +
                $", {nameof(Disciplina)}={Disciplina}" +
                $", {nameof(Pettorina)}={Pettorina.ToString()}";
        }
    }
}
