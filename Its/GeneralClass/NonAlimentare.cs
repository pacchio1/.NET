using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    internal class NonAlimentare:Prodotto    {
        public double MaterialePrincipalePercentuario { get; set; }
        public string Materiale { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(MaterialePrincipalePercentuario)}={MaterialePrincipalePercentuario.ToString()}, {nameof(Coice)}={Coice.ToString()}, {nameof(Nome)}={Nome}, {nameof(Prezzo)}={Prezzo.ToString()}, {nameof(DataProduzione)}={DataProduzione.ToString()}}}";
        }
    }

}
