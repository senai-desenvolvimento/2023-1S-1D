using System.ComponentModel.DataAnnotations;

namespace projeto_gamer_tarde.Models
{
    public class Equipe
    {
        [Key]
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        public ICollection<Jogador> Jogador {get;set;}       
    }
}