using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}