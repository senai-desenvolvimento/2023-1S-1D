//Crie um programa para calcular o IMC de uma pessoa

//Algoritmo
//entrada: nome, idade, peso, altura
//processamento: peso dividido por altura ao quadrado

//entrada

Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine(@$"
----------------------
|  Programa para     |
|   calcular IMC     |
----------------------
");
Console.ResetColor();

Console.WriteLine($"Digite o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso sistema {nome} ;)");

Console.WriteLine($"Informe o peso do paciente: ");
float peso = float.Parse(Console.ReadLine());

//só exemplo
// Console.WriteLine($"Informe a altura do paciente: ");
// double altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

float imc = (peso / ((float)Math.Pow(altura,2)));

Console.WriteLine($"O paciente {nome} tem imc igual á : {imc}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema !");
Console.ResetColor();