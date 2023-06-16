using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC_PrestitiBiblioteca.Models
{
    public partial class PrestitiBibliotecaContext : DbContext
    {
        public PrestitiBibliotecaContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Libro> Libri { get; set; }
        public virtual DbSet<Prestito> Prestiti { get; set; }
        public virtual DbSet<Studente> Studenti { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>()
                .HasMany(e => e.Prestito)
                .WithRequired(e => e.Libro)
                .HasForeignKey(e => e.IdLibro);

            modelBuilder.Entity<Studente>()
                .HasMany(e => e.Prestito)
                .WithRequired(e => e.Studente)
                .WillCascadeOnDelete(false);
        }
    }
}
