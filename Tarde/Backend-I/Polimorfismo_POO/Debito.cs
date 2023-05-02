namespace Polimorfismo_POO
{
    public class Debito : Cartao
    {
        //Polimorfismo : Sobrescrita
        public override void Pagar()
        {
            //verificar se o saldo da conta é suficiente 
            //caso não seja, informar(exibir uma mensagem)
            //caso seja suficiente, exiba o valor a ser pago 
        }
    }
}