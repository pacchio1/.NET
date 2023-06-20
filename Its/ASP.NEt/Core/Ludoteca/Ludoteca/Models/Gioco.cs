using System;
using System.Collections.Generic;

namespace Ludoteca.Models
{
    public partial class Gioco
    {
        public Gioco()
        {
            Prestiti = new HashSet<Prestito>();
        }

        public string Denominazione { get; set; } = null!;
        public string Descrizione { get; set; } = null!;
        public string Tipologia { get; set; } = null!;
        public string EtaDeiGiocatori { get; set; } = null!;
        public string NumeroDiGiocatori { get; set; } = null!;
        public string DurataPartita { get; set; } = null!;
        public int NumeroDiPezzi { get; set; }
        public int IdGioco { get; set; }
        public string url_img { get; set; }

        public virtual ICollection<Prestito> Prestiti { get; set; }
    }
}
