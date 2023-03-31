//Condicional Simples

// bool sol = false;

// if (sol)
// {
//     Console.WriteLine($"Vou para a praia !");        
// }

// Condicional Composta
// Console.WriteLine($"O dia está ensolarado ? Escreva SIM para caso esteja sol");
// string sol = Console.ReadLine().ToUpper();

// Console.WriteLine($"O Edu está de folga ?");
// string folga = Console.ReadLine().ToUpper();

// if ((sol == "SIM") && (folga == "SIM"))
// {
//     Console.WriteLine($"Vou para a praia!");    
// }
// else
// {
//     Console.WriteLine($"Eu vou é trabalhar!");    
// }


// string nome1 = "catarina";
// string nome2 = "Catarina";

// if (nome1 == nome2)
// {
//     Console.WriteLine($"Nomes iguais");    
// }
// else
// {
//     Console.WriteLine($"Nomes Diferentes");    
// }

// //operador ternário
// string nomeIgual = (nome1 == nome2) ? "Nomes iguais" : "Nomes Diferentes";
// Console.WriteLine(nomeIgual);

//Condicional Encadeada(aninhada ou encaixada)

// int idade = 18;

// if (idade >= 18)
// {
//     Console.WriteLine($"Pode entrar na festa, beba com moderação!");    
// }
// else if (idade >= 16 && idade <18)
// {
//     Console.WriteLine($"Pode entrar na festa com a Mamãe !");    
// }
// else
// {
//     Console.WriteLine($"Vai brincar de carrinho ou boneca!");    
// }


float lado1;
float lado2;
float lado3;

Console.WriteLine($"Entre com o valor do lado 1");
lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Entre com o valor do lado 2");
lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Entre com o valor do lado 3");
lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"O triângulo é equilátero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine($"O triângulo é Isócele");
}
else
{
    Console.WriteLine($"O triângulo é escaleno");
}