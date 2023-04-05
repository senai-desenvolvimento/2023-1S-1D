//variáveis e constantes

// //declarando uma variável
// //tipo nome = valor
// string nome = "Carlos";
// const int idade = 36;

// Console.WriteLine("A idade do " + nome + " é " + idade + " anos");

// //tipos de dados
// int quantidade = 10;
// double preco = 4.99d;
// float altura = 1.84545565946254849284150181654684681351f;
// bool careca = true;
// string texto = "Olá, mundo";
// char letra = 'C';

// //operador de atribuicao
// int idade = 36;

// //operadores aritméticos

// //soma
// Console.WriteLine(4 + 4);
// Console.WriteLine(4 + "4");

// //subtracao
// Console.WriteLine(10 - 8);

// //multiplicacao
// Console.WriteLine(5 * 9);

// //divisao
// Console.WriteLine(10 / 2);

// //modular
// Console.WriteLine(5 % 2);

// //operadores de comparação - resposta true ou false

// //igual a
// Console.WriteLine(5 == 6);

// //maior ou igual a
// Console.WriteLine(5 >= 4);

// //menor ou igual a
// Console.WriteLine(4 <= 4);

// //maior que
// Console.WriteLine(5 > 1);

// //menor que
// Console.WriteLine(5 < 2);

// //diferente de 
// Console.WriteLine(5 != 8);

//operadores lógicos e tabela verdade

// //&& : e
// //|| : ou
// // ! : negação
//                                       //tabela verdade
// Console.WriteLine(5 == 5 && 8 == 8);//TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 9);//TRUE && FALSE = FALSE
// Console.WriteLine(5 == 6 && 8 == 8);//FALSE && TRUE = FALSE
// Console.WriteLine(5 == 6 && 8 == 9);//FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 || 3 == 3);//TRUE || TRUE = TRUE 
// Console.WriteLine(2 == 2 || 3 == 4);//TRUE || FALSE = TRUE
// Console.WriteLine(2 == 3 || 3 == 3);//FALSE || TRUE = TRUE
// Console.WriteLine(1 == 2 || 3 == 5);//FALSE || FALSE = FALSE

// Console.WriteLine(!(2 == 4 || 3 == 8));

//Crie um programa para calcular o IMC de uma pessoa

// //entradas
// string nome = "Carlos";
// float peso = 89.9f;
// float altura = 1.80f;

// //processamento
// float imc = peso / (altura * altura);

// Console.WriteLine($"O IMC do " + nome + " é de : " + Math.Round(imc,2));


//operador de incremento e decremento

int contador = 10;

//contador = contador +15;

contador += 15;

Console.WriteLine(contador);

//método que retorna valor de PI
Console.WriteLine(Math.PI);

//método que retorna o maior valor de 2
Console.WriteLine(Math.Max(2,60));

//método que retorna o menor valor de 2
Console.WriteLine(Math.Min(2,60));

