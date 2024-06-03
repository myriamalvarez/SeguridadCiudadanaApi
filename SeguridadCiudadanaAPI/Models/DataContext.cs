using Microsoft.EntityFrameworkCore;

namespace SeguridadCiudadanaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<ContactoEmergencia> ContactosEmergencia { get; set; }
        public DbSet<Incidente> Incidentes { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
    }
}
