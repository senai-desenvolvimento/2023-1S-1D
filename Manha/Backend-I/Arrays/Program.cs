// string carro = "Opala";

// Console.WriteLine($"Cadastre o nome do carro: ");
// carro = Console.ReadLine();

// Console.WriteLine($"O carro é {carro}");

// carro = "Fusca";

// Console.WriteLine($"O carro agora é {carro}");


/*******************************/

// //criamos um array (lista) que vai armazenar até 3 elementos
// string[] carros = new string[3];

// //atribuimos para cada posição um valor
// carros[0] = "Tesla";
// carros[1] = "Maverick";
// carros[2] = "Celta 94";

// // carros[3] = "Ferrari";

// Console.WriteLine($"Os carros cadastrados são: {carros[0]}, {carros[1]}, {carros[2]}");

//criar um array de strings para armazenar 3 carros
// string[] carros = new string[3];

// for (int i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Informe o nome do carro: ");    
//     carros[i] = Console.ReadLine();    
// }

// Console.WriteLine($"Lista dos carros cadastrados: ");

// for (var i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Nome do carro: {carros[i]}");    
// }

// foreach (var item in carros)
// {
//     Console.WriteLine(item);    
// }



// // Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro

// // Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura for para a leitura dos números e a estrutura foreach para exibí-los

// // entrada
//     // criar o array tamanho 5
//     int[] arrayNumeros = new int[5];
// // processamento
//     // recebeber os números (for)
//     for (int indice = 0; indice < 5; indice++)
//     {

//         Console.WriteLine($"Digite o {indice + 1}º número");
//         arrayNumeros[indice] = int.Parse(Console.ReadLine());
        
        
//     }
 
// // saída  
//     // exibir os números com (foreach) 
//     foreach (var numero in arrayNumeros)
//     {
//         Console.WriteLine($"O dobro de {numero} é {numero * 2}");
        
//     }

 //Exercício de fixação
 
 //escreva um programa que receba e imprima o nome e idade de 5 pessoas

 //personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor da fonte)

//declarando as variáveis
string[] nomes = new string[5];//collection
int[] idades = new int[5];//collection

//recebe e armazena os nomes e idades nos arrays
for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine();

    Console.WriteLine($"Informe a {i + 1}º idade: ");
    idades[i] = int.Parse(Console.ReadLine());         
}

//exibe o nome e a idade correspondente
for (var posicao = 0; posicao < 5; posicao++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{posicao + 1}) nome: {nomes[posicao]}  ");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"  idade: {idades[posicao]} anos");
    Console.ResetColor();

    Console.WriteLine($"");    
}

//exemplo de exibição: 

// 1) nome: Carlos
//    idade: 36 anos

//2) nome: Eduardo
//idade: 40 anos

//3) nome: Allan
//idade: 30 anos

//4) nome: Julia
//idade: 18 anos

//5) nome: Gustavo
//idade: 16 anos