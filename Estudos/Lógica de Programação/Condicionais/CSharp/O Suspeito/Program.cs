// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

// "Telefonou para a vítima?"

// "Esteve no local do crime?"

// "Mora perto da vítima?"

// "Devia para a vítima?"

// "Já trabalhou com a vítima?"

// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.


//entrada

Console.WriteLine($"Telefonou para a vítima? sim ou não");
string telefonou = Console.ReadLine()!.ToLower();

Console.WriteLine($"Esteve no local do crime? sim ou não");
string local = Console.ReadLine()!.ToLower();

Console.WriteLine($"Mora perto da vítima? sim ou não");
string moraPerto = Console.ReadLine()!.ToLower();

Console.WriteLine($"Devia para a vítima? sim ou não");
string devia = Console.ReadLine()!.ToLower();

Console.WriteLine($"Já trabalhou com a vítima? sim ou não");
string jaTrabalhou = Console.ReadLine()!.ToLower();

int contSim = 0;

//processamento
if( telefonou == "sim" ) 
{
    contSim = contSim + 1;
    // contSim += 1;
    // contSim++ ;
}

if (local == "sim") 
{
    contSim = contSim + 1;
}

if (moraPerto == "sim") 
{
    contSim = contSim + 1;
}

if (devia == "sim") 
{
    contSim = contSim + 1;
}

if (jaTrabalhou == "sim") 
{
    contSim = contSim + 1;
}

//saída

if (contSim == 2)
{
    Console.WriteLine($"Suspeito");
    
}
else if(contSim == 3 || contSim == 4)
{
    Console.WriteLine($"Cúmplice");
} 
else if (contSim >= 5)
{
    Console.WriteLine($"Culpado");
} 
else 
{
    Console.WriteLine($"Inocente");
}