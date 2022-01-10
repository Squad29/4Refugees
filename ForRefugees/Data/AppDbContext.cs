using ForRefugees.Models;
using Microsoft.EntityFrameworkCore;

namespace ForRefugees.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Contratante> Contratante { get; set; }
        public DbSet<Refugiado> Refugiado{ get; set; }
        public DbSet<Suporte> Suporte { get; set; }
        public DbSet<Vaga> Vaga{ get; set; }
    }
}
