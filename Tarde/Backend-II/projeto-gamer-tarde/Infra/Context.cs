using Microsoft.EntityFrameworkCore;
using projeto_gamer_tarde.Models;

namespace projeto_gamer_tarde.Infra
{
    public class Context : DbContext
    {
        public Context()
        {            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-1DQ8V99\\ROQUE; initial catalog = gamerTarde; Integrated Security = true; TrustServerCertificate = true ");
            }
        }

        public DbSet<Jogador> Jogador {get;set;} 
        public DbSet<Equipe> Equipe {get;set;}
    }
}