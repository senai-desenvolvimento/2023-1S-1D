// Faça um programa que receba um número inteiro e exiba sua tabuada


// entrada
Console.WriteLine($"Qual tabuada você quer saber?");
int tabuada = int.Parse(Console.ReadLine());

// processamento 
for (int i = 1; i <= 10; i++)
{
    // saída
    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
}


// Console.WriteLine($"3 x 1 = 3");
// Console.WriteLine($"3 x 2 = 6");
// Console.WriteLine($"3 x 3 = 9");
// Console.WriteLine($"3 x 3 = 9");
// Console.WriteLine($"3 x 3 = 9");

// saída