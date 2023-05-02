namespace Polimorfismo_POO
{
    public abstract class Cartao
    {
        //propriedades
        public string Bandeira { get; set; }      


        //criar um método abstrato
        public abstract void Pagar();

        //criar um método comum(concreto)
        public string SalvarCartao()
        {
            Console.WriteLine($"Informe a bandeira do cartão: ");
            this.Bandeira = Console.ReadLine();
            
            return $"A bandeira do cartão é {this.Bandeira}";
        }
    }
}