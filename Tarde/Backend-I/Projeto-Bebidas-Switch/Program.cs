// Crie um menu de opções de bebidas e peça para o usuário escolher uma das opções.
// A depender da opção, exiba uma mensagem se gostaria de acrescentar gelo.
// Se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo, caso contrário, a bebida é sem gelo adicional.

//entrada

//exibição no console
Console.WriteLine($"Escolha uma opção de bebida: ");
Console.WriteLine($"1 - Redbull");
Console.WriteLine($"2 - Suco de uva");
Console.WriteLine($"3 - Água com gás");
Console.WriteLine($"4 - Caldo de cana");

//armazena a opcao escolhida
int opcao = int.Parse(Console.ReadLine());

//processamento
switch (opcao)
{
    case 1:
        Console.WriteLine($"A bebida escolhida foi Redbull");

        Console.WriteLine($"A bebida terá gelo adicional? s/n");
        char gelo = char.Parse(Console.ReadLine().ToLower());

        if (gelo == 's')
        {
            Console.WriteLine($"Seu Redbull será batizado com gelo!");            
        }
        else if(gelo == 'n')
        {
            Console.WriteLine($"Agora sim, Redbull sem gelo!");            
        }
        else
        {
            Console.WriteLine($"Opção inválida !");            
        }             
        break;
    default:
        break;
}
