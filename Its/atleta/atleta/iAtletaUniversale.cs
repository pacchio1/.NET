using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atleta
{
    internal interface iAtletaUniversale:iNuotatore,iAtleta
    {
        string Mangio();
        string Bevo();
    }
}
