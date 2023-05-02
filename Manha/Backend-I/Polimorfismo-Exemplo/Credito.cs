namespace Polimorfismo
{
    //classe concreta herda da classe abstrata
    public class Credito : Cartao
    {

        //Polimorfismo : Sobrescrita
        public override void Pagar()
        {
            //verificacao se o valor da compra é maior do que o limite do cartao

            //quantidade de parcelas que o usuario quer pagar

            //a depender da quantidade de parcelas, calcular o valor a ser pago

            //exibir o valor a ser pago
        }

        
        //Polimorfismo : Sobrecarga
        public float DescontoCredito(float parcelas)
        {
            return (parcelas * 0.9f);
        }

        public float DescontoCredito(float parcelas, string bandeiraCartao)
        {
            bandeiraCartao = "Master";
            Console.WriteLine($"{bandeiraCartao}");
            return parcelas * 0.9f;            
        }
    }
}