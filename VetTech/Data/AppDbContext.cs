
using Microsoft.EntityFrameworkCore;
using VetTechApi.Models;

namespace VetTechApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}