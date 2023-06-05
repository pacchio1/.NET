using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal abstract class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int OreLavorate { get; set; }
        public double PagaOraria { get; set; }

        public virtual double Stipendio() {
            return PagaOraria * OreLavorate;
        }

        public override string ToString()
        {
            return $"{nameof(Nome)}={Nome}" +
                $", {nameof(Cognome)}={Cognome}" +
                $", {nameof(OreLavorate)}={OreLavorate.ToString()}" +
                $", {nameof(PagaOraria)}={PagaOraria.ToString()} euro" +
                $", Stipendio={Stipendio().ToString()} euro";
        }
    }
}
