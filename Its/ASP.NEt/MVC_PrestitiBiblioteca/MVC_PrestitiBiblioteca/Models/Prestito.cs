namespace MVC_PrestitiBiblioteca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prestito")]
    public partial class Prestito
    {
        public int Id { get; set; }

        [DisplayName("Libro")]
        public int IdLibro { get; set; }

        [DisplayName("Studente")]
        public int Matricola { get; set; }

        [DisplayName("Data Prestito")]
        public DateTime DataPrestito { get; set; }

        [DisplayName("Data Restituzione")]
        public DateTime? DataRestituzione { get; set; }

        
        public virtual Libro Libro { get; set; }

        
        public virtual Studente Studente { get; set; }
    }
}
