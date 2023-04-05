//calculadora

//Algoritmo

//1. informar a operacao 
//2. informar o primeiro numero
//3. informar o segundo numero
//4. processar os dados
//5. exibir o resultado


//entrada 

Console.WriteLine(@$"
---------------------------
| Programa de calculadora |   
|                         | 
|   Informe a operação    |
|                         |
|    (+) soma             |
|    (-) subtração        |
|    (*) multiplicação    |
|    (/) divisão          |
---------------------------
");

char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

double resultado = 0;

//processamento
//saida

switch (operacao)
{
    case '+':
        resultado = (num1 + num2);
        Console.WriteLine($"O resultado da conta é igual á : {resultado}");
        break;
    case '-':
        resultado = (num1 - num2);
        Console.WriteLine($"O resultado da conta é igual á : {resultado}");
        break;
    case '*':
        resultado = (num1 * num2);
        Console.WriteLine($"O resultado da conta é igual á : {resultado}");
        break;
    case '/':
        resultado = (num1 / num2);
        Console.WriteLine($"O resultado da conta é igual á : {resultado}");
        break;
    default:
        Console.WriteLine($"Operação inválida, repita o processo!");        
        break;
}


//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional
