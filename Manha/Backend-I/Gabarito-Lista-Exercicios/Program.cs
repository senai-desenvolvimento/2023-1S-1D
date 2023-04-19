// //GABARITO - Exercícios

// // 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

// Console.WriteLine($"Programa Eleitoral");
// Console.WriteLine($"Seja bem vindo!");

// Console.WriteLine($"Informe o ano de nascimento da pessoa para verificar se é um eleitor: ");
// int anoNascimento = int.Parse(Console.ReadLine());

// int idade = DateTime.Now.Year - anoNascimento;

// if (idade >= 16)
// {
//     Console.WriteLine($"A pessoa é um eleitor(a), pode votar!");
// }
// else
// {
//     Console.WriteLine($"A pessoa ainda não tem idade para votar!");
// }

// // 2 -  Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// // Álcool:
// // . até 20 litros, desconto de 3% por litro Álcool
// // . acima de 20 litros, desconto de 5% por litro
// // Gasolina:
// // . até 20 litros, desconto de 4% por litro Gasolina
// // . acima de 20 litros, desconto de 6% por litro

// // Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// // da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// // sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// // Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


// //Criação dos métodos

// static float Alcool(float quantidade, float preco)
// {
//     if (quantidade <= 20)
//     {
//         return (quantidade * preco) * 0.97f;
//     }
//     else
//     {
//         return (quantidade * preco) * 0.95f;
//     }
// }

// static float Gasolina(float quantidade, float preco)
// {
//     if (quantidade <= 20)
//     {
//         return (quantidade * preco) * 0.96f;
//     }
//     else
//     {
//         return (quantidade * preco) * 0.94f;
//     }
// }

// //início do programa

// Console.Clear();
// Console.WriteLine($"Bem vindo ao Posto de Combustível!");

// float precoLitroAlcool = 4.90f;
// float precoLitroGasolina = 5.30f;

// float quantidadeLitroAlcool;
// float quantidadeLitroGasolina;

// float valorAbastecimento;

// char opcao;

// do
// {
//     Console.WriteLine(@$"
// -------------------------
// |Informe o combustível: |
// |                       |
// | (a) - álcool          |
// | (g) - gasolina        |
// |                       |
// -------------------------
// ");
//     opcao = char.Parse(Console.ReadLine());

//     switch (opcao)
//     {
//         case 'a':
//             Console.WriteLine($"Informe a quantidade de álcool em litros: ");
//             quantidadeLitroAlcool = float.Parse(Console.ReadLine());

//             valorAbastecimento = Alcool(quantidadeLitroAlcool, precoLitroAlcool);

//             Console.WriteLine($"O valor do abastecimento é : {valorAbastecimento} ");

//             break;
//         case 'g':
//             Console.WriteLine($"Informe a quantidade de gasolina em litros: ");
//             quantidadeLitroGasolina = float.Parse(Console.ReadLine());

//             valorAbastecimento = Alcool(quantidadeLitroGasolina, precoLitroGasolina);

//             Console.WriteLine($"O valor do abastecimento é : {valorAbastecimento} ");
//             break;
//         default:
//             Console.WriteLine($"Opção inválida, informe uma opção válida!");
//             break;
//     }
// } while (opcao != 'a' && opcao != 'g');

// // 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// // preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// // desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// // - Se quantidade &lt;= 5 o desconto será de 2%
// // - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// // - Se quantidade &gt; 10 o desconto será de 5%
// // Dica: utilize if / else if / else


// Console.Write($"Informe a descrição do produto: ");
// string descricaoProduto = Console.ReadLine()!;

// Console.Write($"Informe a quantidade adquirida: ");
// int qdtProduto = int.Parse(Console.ReadLine()!);

// Console.Write($"Informe o preço do produto: ");
// float precoProduto = float.Parse(Console.ReadLine()!);

// float novoPreco = CalculaPrecoProduto(qdtProduto, precoProduto);
// Console.WriteLine($"Produto: {descricaoProduto}");
// Console.WriteLine($"Quantidade: {qdtProduto}");
// Console.WriteLine($"Preco Cheio: {precoProduto}");
// Console.WriteLine($"Preco com Desconto: {novoPreco}");

// static float CalculaPrecoProduto(int qtd, float preco)
// {

//     if (qtd <= 5)
//     {
//         return preco -= ((preco / 100) * 2);
//     }
//     else if (qtd < 10)
//     {
//         return preco -= ((preco / 100) * 3);
//     }

//     // return padrão no lugar do else
//     return preco -= ((preco / 100) * 5);
// }

// // 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// // menor valor lido.

// int[] valores = new int[10];

// for (var i = 0; i < valores.Length; i++)
// {
//     Console.WriteLine($"Informe o valor: ");
//     valores[i] = int.Parse(Console.ReadLine());
// }

// int menor = 0;
// int maior = 0;

// for (var i = 0; i < valores.Length; i++)
// {
//     if (i == 0)
//     {
//         menor = valores[0];
//         maior = valores[0];
//     }
//     if (valores[i] < menor)
//     {
//         menor = valores[i];
//     }
//     if (valores[i] > maior)
//     {
//         maior = valores[i];
//     }
// }

// Console.WriteLine($"O menor número é {menor}");
// Console.WriteLine($"O maior número é {maior}");

// //5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// //Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
// Console.WriteLine("Tabuada de 1 até 10 !");//exibição da mensagem

// for (var e = 0; e <= 10; e++)//laço de repetição do tipo for para o número à esquerda   
// {
//     for (var d = 0; d <= 10; d++)//laço de repetição para o número da direita
//     {
//         Console.WriteLine(+e + " x " + d + " = " + e * d);//exibição do número da esquerda x número da direita                    
//     }
//     Console.WriteLine();//pular linha
// }

// Console.WriteLine("----- Fim da tabuada -----");//exibição da mensagem

// //6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// //lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// //pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// //entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

// // string[] nomes = { "Eduardo", "Joyce", "Thaís", "Lucas", "Rafael", "Carlos" };
// // string pesquisa = "Thaís";

// // Entrada
// string[] nomes = new string[10];
// bool encontrado = false;

// for (int i = 0; i < nomes.Length; i++)
// {
//     Console.WriteLine($"Digite o {i + 1}º Nome");
//     nomes[i] = Console.ReadLine()!;
// }

// Console.Write($"Digite um nome para pesquisar no cadastro: ");
// string pesquisa = Console.ReadLine()!;

// // Processamento
// foreach (string nome in nomes)
// {
//     if (nome == pesquisa)
//     {
//         encontrado = true;
//         break;
//     }
// }

// // Saída
// string resultadoPesquisa = encontrado ? $"{pesquisa} Está na lista: ACHEI" : $"{pesquisa} Não está na lista: NÃO ACHEI";
// Console.WriteLine(resultadoPesquisa);

//Console.WriteLine(encontrado == true ? "ACHEI" : "NÃO ACHEI");


// // 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// // declarado.

// int[] numeros = { 10, 12, 7, 1, 4 };

// Array.Sort(numeros);

// foreach (var n in numeros)
// {
//     Console.Write($"{n} ");
// }
