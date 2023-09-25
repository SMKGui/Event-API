using Microsoft.EntityFrameworkCore;
using webapi.event_.tarde.Domains;

namespace webapi.event_.tarde.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<TipoUsuarioDomain> TipoUsuarioDomain { get; set; }
        public DbSet<UsuarioDomain> UsuarioDomain { get; set; }
        public DbSet<TipoEventoDomain> TipoEventoDomain { get; set; }
        public DbSet<EventoDomain> EventoDomain { get; set; }
        public DbSet<ComentarioEventoDomain> ComentarioEventoDomain { get; set; }
        public DbSet<InstituicaoDomain> InstituicaoDomain { get; set; }
        public DbSet<PresencaEventoDomain> PresencaEventoDomain { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-8UO2UT6; Database = Event+_API_Gui; User Id = sa; Password = Senai@134; TrustServerCertificate = True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
