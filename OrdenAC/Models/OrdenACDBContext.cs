using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace OrdenAC.Models
{
    /// <summary>  
    /// DbContext: Contexto de la base de datos de la solución.  
    /// </summary>
    public class OrdenACDBContext : DbContext
    {

        public DbSet<OrdenModel> Ordenes { get; set; }

        public OrdenACDBContext()
        {
        }

        public OrdenACDBContext(DbContextOptions<OrdenACDBContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=ordenacdb;user=root;password=mysqlAdmin");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<OrdenModel>().ToTable("OrdenModel", "ordenacdb");

            modelBuilder.Entity<OrdenModel>()
                .Property(p => p.OrdenModelId).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }

    }
}
