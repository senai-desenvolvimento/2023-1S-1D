using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Debito : Cartao
    {
        //Polimorfismo : Sobrescrita
        public override void Pagar()
        {
            //se o saldo é suficiente para o pagamento

            //caso nao seja exibir mensagem, caso esteja correto, imprimir o valor a ser pago
        }
    }
}