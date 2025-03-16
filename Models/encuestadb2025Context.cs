using Microsoft.EntityFrameworkCore;

namespace encuesta2025.Models
{
    public class encuestadb2025Context : DbContext
    {
        public encuestadb2025Context(DbContextOptions<encuestadb2025Context> options): base(options) 
        {

        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}
