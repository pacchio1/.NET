using Microsoft.EntityFrameworkCore;

namespace Core_EF_codeFirst.Models
{
    public class Storage27Context:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\MSSQLSERVER01;Database=Storage27;Trusted_Connection=true;Encrypt=false;");
        }
    }
}
