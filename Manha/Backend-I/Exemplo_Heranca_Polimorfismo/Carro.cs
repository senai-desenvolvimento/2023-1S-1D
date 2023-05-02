namespace Carlos
{
    //classe concreta herda da classe abstrata = simbologia de herança = ":"
    public class Carro : Veiculo
    {
        //propriedades somente da classe carro
        public string NumeroChassis { get; set; }
        public string Proprietario { get; set; }

        //método abstrato herdado
        //aqui acontece a sobrescrita do pilar Polimorfismo
        //a palavra override significa sobrepor
        //aqui de fato vc vai criar a sua lógica no corpo do método 
        public override void Ligar()
        {
            Console.WriteLine($"Ligando o carro.....");
        }
    }
}