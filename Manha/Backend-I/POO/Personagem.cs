namespace POO
{
    public class Personagem
    {
        //declarar as propriedades
        // assinatura tipo nome = valor
        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        //declarar os métodos
        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou !");            
        }
        public string Defender()
        {
            return "O personagem defendeu !";            
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem restaurou a armadura !");            
        }
    }
}