using Microsoft.EntityFrameworkCore;
using projeto_gamer_manha.Models;

namespace projeto_gamer_manha.Infra
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
                //string de conexão com o banco
                //Data Source : o nome do servidor do gerenciador do banco
                //initial catalog : nome do banco de dados

                //Autenticação pelo Windows
                //Integrated Security : Autenticação pelo Windows
                //TrustServerCertificate : Autenticação pelo Windows

                //Autenticação pelo SqlServer
                //user Id = "nome do seu usuario de login"
                //pwd = "senha do seu usuario"

                optionsBuilder.UseSqlServer("Data Source = DESKTOP-1DQ8V99\\ROQUE; Initial Catalog = gamerManha; Integrated Security=true; TrustServerCertificate = true");
            }
        }

        //refência de classes e tabelas
        public DbSet<Jogador> Jogador {get;set;}
        public DbSet<Equipe> Equipe {get; set;}
    }
}