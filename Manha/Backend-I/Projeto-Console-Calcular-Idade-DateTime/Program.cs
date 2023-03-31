// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
// e semanas e imprima o resultado no console.

// Observação: obter a data atual do sistema (Pesquisar na documentação)

int anoNascimento;
int idade;
int idadeEmSemanas;
int anoAtual = DateTime.Now.Year;

Console.Write($"Informe o ano do nascimento: ");
anoNascimento = int.Parse(Console.ReadLine());

idade = (anoAtual - anoNascimento);
idadeEmSemanas = (idade * 52);

Console.WriteLine($"A idade em ano(s) é {idade} ano(s) e a idade em semanas é {idadeEmSemanas} semanas");