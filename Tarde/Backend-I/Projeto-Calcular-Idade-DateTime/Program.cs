// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
// e semanas e imprima o resultado no console.

// Observação: obter a data atual do sistema (Pesquisar na documentação)

Console.Write($"Digite o ano de nascimento da pessoa: ");
int anoNascimento = int.Parse(Console.ReadLine()!);

// Módulo para receber a data atual
int anoAtual = DateTime.Now.Year;

// Calcular a idade da pessoa
int idade = anoAtual - anoNascimento;
int idadeSemanas = idade * 52; // 52 == número de semanas em um ano

Console.WriteLine(@$"
Idade: {idade} anos
Idade em semanas: {idadeSemanas} semanas
");
