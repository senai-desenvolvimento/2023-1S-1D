using gamer.Models;
using Microsoft.EntityFrameworkCore;

namespace gamer.Infra
{
    //Classe Context responsável pela conexão com o banco de dados
    //Herança com a Classe DbContext
    public class Context : DbContext
    {
        //Construtor
        public Context()
        {
        }

        //Construtor
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        
        //Configurar a string de conexão do projeto com o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-B541VSR; initial catalog = gamer; Integrated Security = true; TrustServerCertificate=True");
            }
        }

        //Referenciar as tabelas do banco
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }

    }
}