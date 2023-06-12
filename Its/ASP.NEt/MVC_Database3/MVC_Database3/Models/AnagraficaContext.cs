using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVC_Database3.Models
{
    public partial class AnagraficaContext : DbContext
    {
        public AnagraficaContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Studenti> Studenti { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
