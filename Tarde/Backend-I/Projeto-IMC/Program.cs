//Programa IMC

//Faça um programa que calcule o imc de uma pessoa recebendo os dados
//no console,ao final imprima o resultado no console

Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine(@$"
------------------
|  Programa para |
|  calcular IMC  |
------------------
");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso atual do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

Console.ResetColor();

float imc = peso / ((float)Math.Pow(altura,2));

// //concatenação
// Console.WriteLine("O paciente " + nome + " tem o imc igual a : " + imc );

Console.ForegroundColor = ConsoleColor.Magenta;
//interpolação
Console.WriteLine($"O paciente {nome} tem o imc igual á {imc}");
Console.ResetColor();


