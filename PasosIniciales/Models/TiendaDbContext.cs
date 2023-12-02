using Microsoft.EntityFrameworkCore;

namespace PasosIniciales.Models
{
    public class TiendaDbContext : DbContext
    {
        public virtual DbSet<Producto3> Productos { get; set; }
        public TiendaDbContext()
        {
            
        }
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options) : base(options)
        {
            
        }
    }
}
