// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

//Algoritmo

//entrada do sexo da pessoa
//se ela gostou do produto

//saber a quantidade de pessoas que responderam sim OK
//saber o quantidade de pessoas que responderam não OK

//saber a quantidade de mulheres que responderam sim OK

//saber a quantidade total de mulheres que responderam OK
//saber a quantidade total de homens que responderam OK

//saber a porcentagem de homens que responderam não

//declarar as variáveis

char sexo;
char gostouDoProduto;

int totalSim = 0;
int totalNao = 0;

int totalMulherSim = 0;
int totalHomemNao = 0;

int totalMulher = 0;
int totalHomem = 0;

double porcentagemHomemNao = 0;


//Estrura do FOR
//var i =1; inicializador
//i <= 3; condicional
//i++ iterador(incremento)

for (var i = 1; i <= 3; i++)
{
    //entrada de dados
    Console.WriteLine(@$"
    Digite o sexo da pessoa:
    (m) - Masculino
    (f) - Feminino    
    ");   

    sexo = char.Parse(Console.ReadLine().ToLower());

    //processamento
    if (sexo == 'f')
    {
        totalMulher++;
    }
    else
    {
        totalHomem++;
    }

    //entrada de dados
    Console.WriteLine(@$"
    A pessoa gostou do produto lançado?
    (s) - Sim
    (n) - Não
    ");
    
    gostouDoProduto = char.Parse(Console.ReadLine().ToLower());

    //processamento
    if (gostouDoProduto  == 's')
    {
        totalSim++;

        if (sexo == 'f')
        {
            totalMulherSim++;
        }
    }
    else
    {
        totalNao++;

        if (sexo == 'm')
        {
            totalHomemNao++;
        }
    }
}

//processamento
porcentagemHomemNao = Math.Round(((double)totalHomemNao/(double)totalHomem)*100,2);

//saída
Console.WriteLine($"O total de pessoas que responderam sim foi de : {totalSim}");
Console.WriteLine($"O total de pessoas que responderam não foi de : {totalNao}");

Console.WriteLine($"O total de mulheres que responderam sim foi de : {totalMulherSim}");

Console.WriteLine($"A porcentagem de homens que responderam não foi de : {porcentagemHomemNao}%");

//100 %
// 3 pessoas = 33.33...% para cada pessoa