// //Fibonacci com do-while
// int a = 1;
// int b = 1;
// do
// {
//     Console.WriteLine($"{a} ainda e menor que 500");
//     Console.WriteLine($"{b} ainda e menor que 500");
//     a = a + b;
//     b = b + a;
// } while (a < 500);
// Console.WriteLine($"");

// Console.WriteLine($"{a}");
// Console.WriteLine($"{b}");


// //Fibonacci com while
// int n1 = 0;
// int n2 = 1;
// int res = 0;

// bool concluido = false;

// while (concluido = false)
// {
//     Console.WriteLine($"{res}");
//     n1 = n2;
//     n2 = res;
//     res = n1 + n2;

//     if (res > 500)
//     {
//         Console.WriteLine($"{res} Passou de 500!!");
//         concluido = true;
//     }
//     else
//     {
//         concluido = false;
//     }
// }

// //Fibonacci com FOR
// Console.WriteLine($"Série de Fibonacci");

// int num1 = 0;
// int num2 = 1;
// int auxiliar;

// for (var i = 0; i < 15; i++)
// {
//     auxiliar = num1;
//     num1 = num2;
//     num2 = num1 + auxiliar;

//     Console.WriteLine(num2);

//     if(num2 > 500)
//     {
//         break;
//     }    
// }

//função de Somar
static float Somar(float primeiroNumero, float segundoNumero)
{
    return primeiroNumero + segundoNumero;
}

//função de Saudação
static void Saudacao()
{
    Console.WriteLine($"Informe o seu nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine($"Informe o sobrenome: ");
    string sobrenome = Console.ReadLine();

    Console.WriteLine($"Bom dia {nome} {sobrenome}");
}

//função de Mostrar Hora
static int MostrarHora()
{
    return DateTime.Now.Hour;
}

//Chamada das funções
Console.WriteLine($"Digite o primeiro número: ");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número: ");
float n2 = float.Parse(Console.ReadLine());

//chamada da função de Saudação
Saudacao();

Console.WriteLine(@$"
O resultado da soma é: {Somar(n1, n2)} e a hora são: {MostrarHora()} ");


static void BarraCarregamento(string texto, int tempo, int quantidade)
{
    Console.BackgroundColor = ConsoleColor.Yellow;

    Console.Write(texto);

    for (var contador = 0; contador < quantidade; contador++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}

BarraCarregamento("Olá!", 500, 5);