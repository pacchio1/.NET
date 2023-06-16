namespace MVC_PrestitiBiblioteca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Libro")]
    public partial class Libro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Libro()
        {
            Prestito = new HashSet<Prestito>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codice { get; set; }

        [Required]
        [StringLength(50)]
        public string Autore { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Titolo libro")]
        public string Titolo { get; set; }

        [Required]
        [StringLength(50)]
        public string Editore { get; set; }

        public int? Anno { get; set; }

        [StringLength(50)]
        public string Luogo { get; set; }

        [Required]
        [StringLength(50)]
        public string Pagine { get; set; }

        [Required]
        [StringLength(50)]
        public string Classificazione { get; set; }

        [Required]
        [StringLength(50)]
        public string Collocazione { get; set; }

        public int? Copie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prestito> Prestito { get; set; }
    }
}
