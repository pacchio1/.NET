﻿using System;
using System.Collections.Generic;

namespace Core_PrestitiVideoteca.Models
{
    public partial class Prestito
    {
        public int Id { get; set; }
        public int IdFilm { get; set; }
        public int Matricola { get; set; }
        public DateTime DataPrestito { get; set; }
        public DateTime? DataRestituzione { get; set; }

        public virtual Film IdFilmNavigation { get; set; } = null!;
        public virtual Studente MatricolaNavigation { get; set; } = null!;
    }
}
