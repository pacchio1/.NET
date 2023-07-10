using System;
using System.Collections.Generic;

namespace Core_PrestitiVideoteca.Models
{
    public partial class Studente
    {
        public Studente()
        {
            Prestiti = new HashSet<Prestito>();
        }

        public int Matricola { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Classe { get; set; } = null!;

        public virtual ICollection<Prestito> Prestiti { get; set; }
    }
}
