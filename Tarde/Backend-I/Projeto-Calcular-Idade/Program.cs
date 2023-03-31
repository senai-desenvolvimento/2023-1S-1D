// Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos.
// Imprima o resultado no console.

Console.WriteLine($"Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

int meses = idade * 12;
int dias = idade * 365;
int horas = dias * 24;
int minutos = horas * 60;

Console.WriteLine($"Voce tem {idade} anos, {meses} meses, {dias} dias, {horas}  horas e {minutos} minutos.");

