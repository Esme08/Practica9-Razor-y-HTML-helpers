using Microsoft.EntityFrameworkCore;

namespace PracticaMVC.Models
{
    public class equiposDbContext: DbContext
    {
        public equiposDbContext(DbContextOptions<equiposDbContext> options) : base(options)
        { }

        public DbSet<marcas> marcas { get; set; }
        public DbSet<equipos> equipos { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
        public DbSet<estados_equipos> estados_equipos { get; set; }
    }
}
