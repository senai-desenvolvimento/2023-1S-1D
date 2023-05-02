namespace Polimorfismo
{
    public abstract class Cartao
    {
        //propriedade
        public string Bandeira { get; set; }
        
        //método abstrato
        public abstract void Pagar();

        //método normal
        public string SalvarCartao()
        {
            Console.WriteLine($"Informe a bandeira do cartao: ");
            this.Bandeira = Console.ReadLine(); 
            
            return $"A bandeira do cartão é {this.Bandeira} !";
        }
    }
}