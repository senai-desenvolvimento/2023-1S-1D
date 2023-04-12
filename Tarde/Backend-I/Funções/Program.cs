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

static float Soma(float n1, float n2){
    float r = n1 + n2;
    return r;
}

float batatinha = Soma(16, 123);

Console.WriteLine($"Resultado: {batatinha}");

//criar método para multiplicar 2 números
//criar método para dividir 2 números
//criar método para subtrair 2 números


static float Somar(float n1, float n2)
{
    return (n1+n2);
}

//Chamada das funções
Console.WriteLine($"Digite o primeiro número: ");
float chaves = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número: ");
float seuMadruga = float.Parse(Console.ReadLine());

Console.WriteLine(@$"
O resultado da soma é: {Somar(chaves,seuMadruga)}");