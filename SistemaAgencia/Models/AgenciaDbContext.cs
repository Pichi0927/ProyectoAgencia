using Microsoft.EntityFrameworkCore;

namespace SistemaAgencia.Models
{
    public class AgenciaDbContext : DbContext
    {
        public AgenciaDbContext(DbContextOptions<AgenciaDbContext> options)
            : base(options)
        {
        }

     
        public DbSet<PaisViewModel> Pais { get; set; }
        public DbSet<TourViewModel> Tour { get; set; }
        public DbSet<DestinoViewModel> Destino  { get; set; }
    }
}
