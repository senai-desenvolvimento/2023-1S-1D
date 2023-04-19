// // Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// // Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.

// // O sistema deve exibir um menu com as seguintes opções:

// // 1- Cadastrar passagem
// // 2- Listar Passagens
// // 0- Sair


// // Ao cadastrar uma passagem ao final, o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


// //Algoritmo
// //lista para armazenar nomes,origens,destinos e datas ok 
// //validação de senha ok
// entrada da senha pelo usuário ok
// //menu de opções
// //opção de cadastrar novas passagens

//criando as funções


//estrutura de uma função

//tipo tipoDado nomeFuncao(parâmetros ou argumentos)
{
    //Corpo da função
}

//função para verificar senha
static bool Login(string senha)
{
    if (senha == "123456")
    {
        return true;
    }
    else
    {
        Console.WriteLine($"Senha incorreta!");
        return false;
    }
}

//declarar as variáveis
string[] nomes = new string[2];
string[] origens = new string[2];
string[] destinos = new string[2];
string[] datas = new string[2];

bool senhaValida;

do
{
    Console.WriteLine($"Informe a sua senha: ");
    string senha = Console.ReadLine();

    senhaValida = Login(senha);

} while (senhaValida != true);

string opcao;

do
{
    //criar menu de opções
    Console.WriteLine($"Menu de opções");

    Console.WriteLine(@$"
Selecione um das opções
[1] - Cadastrar
[2] - Listar
[0] - Sair
");

    opcao = Console.ReadLine();

    string resposta;

    switch (opcao)
    {
        case "1":
            do
            {
                for (var i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Informe o nome: ");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine($"Informe a origem: ");
                    origens[i] = Console.ReadLine();

                    Console.WriteLine($"Informe o destino: ");
                    destinos[i] = Console.ReadLine();

                    Console.WriteLine($"Informe a data: ");
                    datas[i] = Console.ReadLine();
                }

                Console.WriteLine($"Quer cadastrar mais passagens: s/n");
                resposta = Console.ReadLine().ToLower();

            } while (resposta == "s");
            break;
        case "2":
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine(@$"
                *******************
                Passagens - Bilhete

                Nome: {nomes[i]}
                Origem: {origens[i]}
                Destino: {destinos[i]}
                Data: {datas[i]}
                ");
            }
            break;
        case "0":
            Console.WriteLine($"Fim do programa");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (opcao != "0");