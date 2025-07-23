using Microsoft.EntityFrameworkCore;

namespace SistemaAgencia.Models
{
    public class AgenciaDbContext : DbContext
    {
        public AgenciaDbContext(DbContextOptions<AgenciaDbContext> options)
            : base(options)
        {
        }

        public DbSet<PaisViewModel> Paises { get; set; }
        public DbSet<TourViewModel> Tours { get; set; }
        public DbSet<DestinoViewModel> Destinos { get; set; }
    }
}
