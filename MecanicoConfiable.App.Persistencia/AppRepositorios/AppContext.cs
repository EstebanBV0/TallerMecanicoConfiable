using Microsoft.EntityFrameworkCore;
using MecanicoConfiable.App.Dominio;

namespace MecanicoConfiable.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Repuesto> Repuestos { get; set; }
        public DbSet<CambioRepuesto> CambioRepuestos { get; set; }
        public DbSet<Dueño> Dueños { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Auxiliar> Auxiliares { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<RevisionNiveles> RevisionNiveles { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder
                .UseSqlServer("Data Source =  (localdb)\\MSSQLLocalDB ; Initial Catalog = MecanicoConfiable.Data");
            }

        }

    }
}