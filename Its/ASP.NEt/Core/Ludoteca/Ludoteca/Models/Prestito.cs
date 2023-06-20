using System;
using System.Collections.Generic;

namespace Ludoteca.Models
{
    public partial class Prestito
    {
        public DateTime DataPrestito { get; set; }
        public DateTime? DataRestituzione { get; set; }
        public string Note { get; set; } = null!;
        public int IdPrestito { get; set; }
        public int IdGioco { get; set; }
        public string CfUtente { get; set; } = null!;

        public virtual Utente CfUtenteNavigation { get; set; } = null!;
        public virtual Gioco IdGiocoNavigation { get; set; } = null!;
    }
}
