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
                //Autenticação pelo SqlServer
                //user Id = "nome do seu usuario de login"
                //pwd = "senha do seu usuario"

                optionsBuilder.UseSqlServer("Data Source = DESKTOP-1DQ8V99\\ROQUE; Initial Catalog = gamerManha; Integrated Security=true; TrustServerCertificate = true");
            }
        }

        public DbSet<Jogador> Jogador {get;set;} 
        public DbSet<Equipe> Equipe {get;set;}
    }
}