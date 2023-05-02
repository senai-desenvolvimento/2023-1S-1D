namespace Polimorfismo_POO
{
    public class Credito : Cartao
    {
        //Polimorfismo : Sobrescrita (override)
        public override void Pagar()
        {
            //verificar se o limite atende 
            //quantidade de parcelas
            //a depender da quantidade de parcelas, temos um cálculo do valor a ser pago
            //exibir o valor
        }

        //Polimorfismo : Sobrecarga (overload)
        public float DescontoCredito(float valor)
        {
            return (valor * 0.9f);
        }

        public float DescontoCredito(float valor, string bandeira)
        {
            valor = (45.99f * 0.90f);
            bandeira = "Master";
            Console.WriteLine($"{bandeira}, {valor}");            
            return valor; 
        }
    }
}