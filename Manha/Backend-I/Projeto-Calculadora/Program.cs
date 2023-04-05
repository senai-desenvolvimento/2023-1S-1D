//vamos criar uma calculadora usando switch case

//lógica - Algoritmo

//1. definir operação
//2. informar o primeiro número
//3. informar o segundo número
//4. processar os dados inseridos
//5. exibir o resultado

//entrada

Console.WriteLine(@$"
---------------------------------------------------
|               Programa Calculadora              |  
|Informe a operação matemática que deseja efetuar:|
|'+' para somar                                   |
|'*' para multiplicar                             |
|'-' para subtrair                                |
|'/' para dividir                                 |
---------------------------------------------------
 ");

//recebe a operação escolhida
char operacao = char.Parse(Console.ReadLine());

//entrada do primeiro número
Console.WriteLine($"Digite o primeiro número: ");
float numero1 = float.Parse(Console.ReadLine());

//entrada do segundo número
Console.WriteLine($"Digite o segundo número: ");
float numero2 = float.Parse(Console.ReadLine());

//declarado a variável que receberá o resultado
float resultado = 0;

//processamento

switch (operacao)
{
    case '+':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da soma é {resultado}");        
        break;
    case '*':
        resultado = (numero1 * numero2);
        Console.WriteLine($"O resultado da multiplicação é {resultado}");
        break;
    case '-':
        resultado = (numero1 - numero2);
        Console.WriteLine($"O resultado da subtração é {resultado}");
        break;
    case '/':
        resultado = (numero1 / numero2);
        Console.WriteLine($"O resultado da divisão é {resultado}");
        break;
    default:
        Console.WriteLine($"A operação informada não é suportada pela nossa calculadora!");        
        break;
}
