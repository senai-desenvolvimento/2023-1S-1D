// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 

// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e(&&) média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

//instanciar um objeto
using Projeto_Alunos_POO;

Aluno novoAluno = new Aluno();

Console.WriteLine($"Informe o nome do aluno: ");
novoAluno.Nome = Console.ReadLine();

Console.WriteLine($"Informe o curso do aluno: ");
novoAluno.Curso = Console.ReadLine();

Console.WriteLine($"Informe a idade do aluno: ");
novoAluno.Idade = Console.ReadLine();

Console.WriteLine($"Informe o RG do aluno: ");
novoAluno.Rg = Console.ReadLine();

Console.WriteLine($"Informe a média das notas do aluno: ");
novoAluno.MediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o valor bruto da mensalidade: ");
novoAluno.ValorMensalidade = float.Parse(Console.ReadLine());

string resposta;

do
{
    Console.WriteLine($"O aluno é bolsista ? (s/n) : ");
    resposta = Console.ReadLine().ToLower();

} while (resposta != "s" && resposta != "n");

//operador ternário
novoAluno.Bolsista = resposta == "s" ? true : false;

//novoAluno.Bolsista = resposta == "s";

// //if composto
// if (resposta == "s")
// {
//     novoAluno.Bolsista = true;
// }
// else
// {
//     novoAluno.Bolsista = false;
// }

string opcao;
do
{
    Console.WriteLine($"---Menu---");
    Console.WriteLine(@$"
[1] - Média do Aluno
[2] - Valor da mensalidade
[0] - Sair
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine($"A média do aluno {novoAluno.Nome} é : {novoAluno.VerMediaFinal()}");
            break;
        case "2":
            Console.WriteLine($"O valor da mensalidade é : {novoAluno.VerMensalidade()}");
            break;
        case "0":
            Console.WriteLine($"Fim");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (opcao != "0");














