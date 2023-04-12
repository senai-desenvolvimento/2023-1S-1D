// //SEM ARRAY

// string carro1;
// string carro2;
// string carro3;

// Console.WriteLine($"Digite o nome do carro: ");
// carro1 = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro: ");
// carro2 = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro: ");
// carro3 = Console.ReadLine();

// Console.WriteLine(@$"
// {carro1}
// {carro2}
// {carro3}
// ");

//COM ARRAY

// //criamos uma variável do tipo array de strings com capacidade de armazenar 3 carros
// string[] carros = new string[3];

// Console.WriteLine($"Digite o nome do carro: ");
// carros[0] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro: ");
// carros[1] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro: ");
// carros[2] = Console.ReadLine();

// Console.WriteLine($"Primeiro carro da lista : {carros[0]}");
// Console.WriteLine($"Segundo carro da lista : {carros[1]}");
// Console.WriteLine($"Terceiro carro da lista : {carros[2]}");

// string[]carros = new string[3];

// for (int i = 0; i < 3; i++)
// {
//     //bloco de código a ser executado
//     Console.WriteLine($"Digite o nome do carro: ");
//     carros[i] = Console.ReadLine();    
// }

// for (int i = 0; i < 300; i++)      //alt+167 = º
// {
//     Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");    
// }
// // foreach (var item in carros)
// // {
// //     Console.WriteLine($"Nome do carro: {item}");    
// // }

// // // Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro

// // // Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura for para a leitura dos números e a estrutura foreach para exibí-los

// int[] arrayNumeros = new int[5];

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Digite o {i + 1}º número: ");

//     arrayNumeros[i] = int.Parse(Console.ReadLine());     
// }

// foreach (int numero in arrayNumeros)
// {
//     Console.WriteLine($"O dobro de {numero} é :  {numero * 2}");     
// }

//exercício de fixação 

//escreva um programa que receba e imprima o nome e idade de 5 pessoas

 //personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

//exemplo de exibição: 

//1) nome: Carlos
//idade: 36 anos

//2) nome: Eduardo
//idade: 40 anos

//3) nome: Allan
//idade: 30 anos

//4) nome: Julia
//idade: 18 anos

//5) nome: Gustavo
//idade: 16 anos
//DESAFIOS

//Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.