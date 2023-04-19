// static void BomDia(){
//     Console.WriteLine($"Bom dia!");    
// }

// static void BoaTarde(){
//     Console.WriteLine($"Boa tarde!");    
// }

// static string[] BoaNoite()
// {    
//     string[] saudacao = new string[2];
//     saudacao[0] = "Boa";
//     saudacao[1] = "Noite !";

//     return saudacao;       
// }

// BomDia();
// BoaTarde();

// string texto = ($"{BoaNoite()[0]} {BoaNoite()[1]}");
// Console.WriteLine(texto);


// Console.WriteLine(BoaNoite());

// string batatinha = BoaNoite();
// Console.WriteLine(batatinha);

//criar método para somar 2 números

// static float Soma(float n1, float n2){
//     float r = n1 + n2;
//     return r;
// }

// float batatinha = Soma(16, 123);

// Console.WriteLine($"Resultado: {batatinha}");

// //criar método para multiplicar 2 números
// //criar método para dividir 2 números
// //criar método para subtrair 2 números


// static float Somar(float n1, float n2)
// {
//     return (n1+n2);
// }

// //Chamada das funções
// Console.WriteLine($"Digite o primeiro número: ");
// float chaves = float.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o segundo número: ");
// float seuMadruga = float.Parse(Console.ReadLine());

// Console.WriteLine(@$"
// O resultado da soma é: {Somar(chaves,seuMadruga)}");


// //faça um método para calcular imposto sobre a renda

// //regras de negócio
// //tabela de imposto vs renda
// //até $1500 - isento
// //de $1501 até $3500 - 20% de imposto
// //de $3501 até $6000 - 25% de imposto
// //acima de $6000 - 35% de imposto


// //receber o renda via console
// //chamar o método passando a renda como parâmetro
// //exibir o valor do imposto referente á renda

// //obter o rendimento


// using System.Globalization;

// Console.WriteLine($"Informe a sua renda: ");
// float renda = float.Parse(Console.ReadLine());

// static float LeaoFaminto (float n1) 
// {
//     if(n1 <= 1500){
//         return 0;
//     }
//     else if (n1 > 1500 && n1 <= 3500){
//         return n1*20/100;
//     }
//     else if (n1 > 3500 && n1 <= 6000){
//         return n1*25/100;
//     }
//     else {
//         return n1*35/100;
//     }
// }

// float resultado = LeaoFaminto(renda);

// Console.WriteLine($"Você vai pagar {resultado.ToString("C", new CultureInfo("pt-BR"))} de imposto!");
//variáveis

// Um posto está vendendo combustíveis com a seguinte tabela de descontos:

// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro

// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.


//criar os métodos para calcular o valor do abastecimento

static float Alcool(float quantidade, float preco)
{
    if (quantidade <= 20)
    {
        return (quantidade * preco) * 0.97f;
    }
    else
    {
        return (quantidade * preco) * 0.95f;
    }
}

static float Gasolina(float quantidade, float preco)
{
    if (quantidade <= 20)
    {
        return (quantidade * preco) * 0.97f;
    }
    else
    {
        return (quantidade * preco) * 0.94f;
    }
}

//iniciar o programa

Console.WriteLine($"Boas vindas ao posto 2 carecas!");

//declarar as variáveis

float quantidadeAlcool;
float quantidadeGasolina;

const float precoAlcool = 4.90f;
const float precoGasolina = 5.30f;

float valorAbastecimento;

char opcao;

do
{
    //menu de opções
    Console.WriteLine(@$"
informe o combustível:
(A) - Álcool
(G) - Gasolina
");

    opcao = char.Parse(Console.ReadLine().ToUpper());

    switch (opcao)
    {
        case 'A':
            Console.WriteLine($"Informe a quantidade de Álcool: ");
            quantidadeAlcool = float.Parse(Console.ReadLine());

            valorAbastecimento = Alcool(quantidadeAlcool, precoAlcool);
            Console.WriteLine($"O valor do abastecimento ficou {valorAbastecimento}");
            break;
        case 'G':
            Console.WriteLine($"Informe a quantidade de Gasolina: ");
            quantidadeGasolina = float.Parse(Console.ReadLine());

            valorAbastecimento = Gasolina(quantidadeGasolina, precoGasolina);
            Console.WriteLine($"O valor do abastecimento ficou {valorAbastecimento}");
            break;
        default:
            Console.WriteLine($"Opção inválida...só Álcool e Gasolina!");
            break;
    }
} while (opcao != 'A' && opcao != 'G');




























// int[] numeros = new int[] {999,2,1,458,54};
//                         //  0  1 2  3   4

// Array.Sort(numeros);
// Console.WriteLine($"menor: {numeros[0]} maior: {numeros[4]}");


// Console.WriteLine($"{numeros.Contains(458)}");
// Console.WriteLine($"{numeros.Max()}");
// Console.WriteLine($"{numeros.Min()}");
// Console.WriteLine($"{numeros.GetValue(3)}");

// string[] nomes = new string[] {"Carlos", "Edu"};
// Console.WriteLine($"{nomes.Contains("Edu")}");



