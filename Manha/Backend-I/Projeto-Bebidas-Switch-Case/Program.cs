//mensagem de exibição no console
Console.WriteLine($"Menu de opções de bebidas: ");

//mensagem de exibição no console = MENU
Console.WriteLine($"Escolha uma bebida abaixo: ");
Console.WriteLine($"1 - Coca cola");
Console.WriteLine($"2 - Pepsi");
Console.WriteLine($"3 - Fanta Laranja");
Console.WriteLine($"4 - Guaraná Zero");

//agora precisamos da entrada de dados do usuário
//Console.ReadLine() - entrada da opçao escolhida pelo usuário , exemplo : 1 - para Coca Cola
int opcao = int.Parse(Console.ReadLine());

char resposta;

//agora precisamos realizar o processamento
//comparar a opção informada pelo usuário e executar alguma coisa
//que coisa ? a pergunta se a bebida terá adicional de gelo ou não

switch (opcao)
{
    case 1:
        //pergunta para o usuário se gostaria de adicionar gelo
        Console.WriteLine($"Gostaria de adicionar gelo ? s/n");

        //obtem a resposta e armazena na variável resposta
        resposta = char.Parse(Console.ReadLine().ToLower());

        //verificar a resposta, SE for sim : mensagem, SENAO : mensagem
        if (resposta == 's')
        {
            Console.WriteLine($"Sua Coca cola será com adicional de gelo, já tá chegando...");
        }
        else
        {
            Console.WriteLine($"Sua Coca cola será sem adicional de gelo, já tá chegando...");
        }
        break;
    case 2:
        //pergunta para o usuário se gostaria de adicionar gelo
        Console.WriteLine($"Gostaria de adicionar gelo ? s/n");

        //obtem a resposta e armazena na variável resposta
        resposta = char.Parse(Console.ReadLine().ToLower());

        //verificar a resposta, SE for sim : mensagem, SENAO : mensagem
        if (resposta == 's')
        {
            Console.WriteLine($"Sua Pepsi será com adicional de gelo, já tá chegando...");
        }
        else
        {
            Console.WriteLine($"Sua Pepsi será sem adicional de gelo, já tá chegando...");
        }
        break;
    case 3:
        break;
    case 4:
        break;
    default:
        Console.WriteLine($"Opção inválida, tente novamente");
        break;
}
