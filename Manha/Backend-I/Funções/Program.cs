//funções

//criando um método

//static = pq o método está dentro da classe Program.cs
//void = tipo de retorno( nesse caso sem retorno)
//MyMethod() = nome do método (usar PascalCase)

// static void MyMethod()
// {
//     //bloco de código
// } 


// //criar um método para exibir o nome de uma pessoa,sobrenome e exibir "Bom dia "Fulano de tal"

// static void Saudacao()
// {
//     Console.WriteLine($"Informe o nome da pessoa: ");
//     string nome = Console.ReadLine();

//     Console.WriteLine($"Informe o sobrenome da pessoa: ");
//     string sobrenome = Console.ReadLine();

//     Console.WriteLine($"Bom dia {nome} {sobrenome}");  
// }

// Saudacao();

// //criar um método para somar 2 números

// static float Somar(float n1, float n2)
// {
//     return (n1 + n2);
// }

// Console.WriteLine($"Informe o primeiro número: ");
// float primeiroNumero = float.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// float segundoNumero = float.Parse(Console.ReadLine());

// Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} é : {Somar(primeiroNumero,segundoNumero)}");

// //Somar(primeiroNumero, segundoNumero)

// //criar os métodos para as demais operações matemáticas (-, * , /)
//     //receber os números e exibir os resultados


// //método para trazer a hora do sistema
// static int MostrarHora()
// {
//     return DateTime.Now.Hour;
// }

// Console.WriteLine(MostrarHora());

//método para criar uma barra de carregamento
//Console.WriteLine($"Carregando...................");

// static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
// {
//     Console.BackgroundColor = ConsoleColor.Red;
//     Console.Write(texto);

//     for (var i = 0; i < quantidadePontinhos; i++)
//     {
//         Console.Write($".");
//         Thread.Sleep(tempo);        
//     }  
//     Console.ResetColor();  
// }

// BarraCarregamento("Testando",15,700);

// BarraCarregamento("Finalizando",20,400);

// BarraCarregamento("Aguarde",3,2000);

// BarraCarregamento("Cadastrando",90,100);

// BarraCarregamento("logando",25,200);


//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda 

using System.Globalization;

static float LeaoFaminto( float a )
{//aqui o parâmetro a sera o nosso salario
    if( a <= 1500 )
    {
        return 0;
    } 
    else if( a >1500 && a <= 3500 )
    {
        return (a / 100) * 20; 
    } 
    else if( a >= 3501 && a <= 6000 ) 
    {
        return (a / 100) * 25;
    } 
    else 
    {
        return (a / 100) * 35;
    }
    
}

Console.WriteLine($"Olá, informe o salário");
float salario = float.Parse(Console.ReadLine() ) ;

float impostoDevido = LeaoFaminto(salario);

Console.WriteLine(@$"
Salário: {Math.Round(salario, 2).ToString("C", new CultureInfo("pt-BR"))}
Valor do Imposto: R$ {Math.Round(impostoDevido, 2)}");