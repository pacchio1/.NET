using System;
using System.Collections.Generic;

namespace Ludoteca.Models
{
    public partial class Utente
    {
        public Utente()
        {
            Prestiti = new HashSet<Prestito>();
        }

        public string Codicefiscale { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public DateTime DataNascita { get; set; }
        public string LuogoNascita { get; set; } = null!;
        public string Indirizzo { get; set; } = null!;
        public string Cap { get; set; } = null!;
        public string Citta { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Prestito> Prestiti { get; set; }
    }
}
