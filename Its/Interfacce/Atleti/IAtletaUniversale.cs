using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleti
{
    public interface IAtletaUniversale:IAtleta,INuotatore,ITennista
    {
        public string Mangio();
        public string Bevo();
    }
}
