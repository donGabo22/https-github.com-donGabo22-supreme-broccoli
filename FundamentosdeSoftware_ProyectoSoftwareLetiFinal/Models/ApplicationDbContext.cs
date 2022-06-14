using Microsoft.EntityFrameworkCore;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BasedeDatosLety; Integrated Security=true")
                .EnableSensitiveDataLogging(true);
        }
        public DbSet<Registros> Registros { get; set; }

        public DbSet<Empleados> Empleados { get; set; }

        public DbSet<Menuu> Menuu { get; set; }

        public DbSet<MeserOrd> MeserOrd { get; set; }

        public DbSet<Registradora> Registradora { get; set; }

    }
}