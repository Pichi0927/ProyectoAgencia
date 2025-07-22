using Microsoft.EntityFrameworkCore;
using SistemaAgenciaTours.Models;

namespace SistemaAgencia.Models
{
    public class AgenciaDbContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Tu conexión local a SQL Server
                optionsBuilder.UseSqlServer("Server=DESKTOP-D4PU7MP;Database=AgenciaDB;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }
        public DbSet<SistemaAgenciaTours.Models.Destino> Destino { get; set; } = default!;
    }
}
