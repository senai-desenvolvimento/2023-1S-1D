Console.WriteLine($"Informe o número correspondente ao dia da semana:");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        Console.WriteLine($"Domingou !!!");
        break;
    case 2:
        Console.WriteLine($"Segundou !!!");
        break;
    case 3:
        Console.WriteLine($"Terçou !!!");
        break;
    case 4:
        Console.WriteLine($"Quartou !!!");
        break;
    case 5:
        Console.WriteLine($"Quintou !!!");
        break;
    case 6:
        Console.WriteLine($"O Famoso SEXTOU !");
        break;
    case 7:
        Console.WriteLine($"SABADÃO!");
        break;
    default:
        Console.WriteLine($"Olha, número informado não é válido amigão!");
        break;
}



