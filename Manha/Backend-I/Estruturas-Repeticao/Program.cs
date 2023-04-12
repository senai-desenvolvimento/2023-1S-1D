//*********WHILE exemplos**********

// Console.WriteLine($"1");
// Console.WriteLine($"2");
// Console.WriteLine($"3");
// Console.WriteLine($"4");
// Console.WriteLine($"5");
// Console.WriteLine($"6");
// Console.WriteLine($"7");
// Console.WriteLine($"8");
// Console.WriteLine($"9");
// Console.WriteLine($"10");

// int batatinhaFrita123 = 1;

// while(batatinhaFrita123 <=10)
// {
//     Console.WriteLine(batatinhaFrita123);
//     batatinhaFrita123++;
// }

// bool idadeCerta = false;


// while (idadeCerta == false)
// {
//     Console.WriteLine($"Qual a idade do Péricles ?");
//     int idade = int.Parse(Console.ReadLine());

//     if (idade == 53)
//     {
//         idadeCerta = true;
//     }
// }


// //um programa que receba o nome do usuario e a senha ok
// //a senha deve ter 6 caracteres ex: "admin@" ok 
// //validar a senha
// //enquanto a senha nao estiver com regra pedida, preciso que 
//     //o programa nao se encerra e que solicite que seja digitado
//     //uma senha no padrao requerido
// //caso a senha informada esteja com 6 caracteres, exiba uma mensagem de ok

// Console.WriteLine($"digite o seu nome: ");
// string nome = Console.ReadLine();

// Console.WriteLine($"digite a sua senha (tem que ter 6 caracteres)");
// string senha = Console.ReadLine();

// while (senha.Length != 6)
// {
//     Console.WriteLine($"Digite uma senha no padrão requerido (com 6 caracteres): ");
//     senha = Console.ReadLine();     
// }
// Console.WriteLine($"Usuário e senha recebidas com sucesso!");


//*********DO - WHILE exemplos**********

// int i = 6;
// do 
// {
//   Console.WriteLine(i);//exibir o valor de i = 6
//   i++;//vai incrementar
//   Console.WriteLine(i); 
// }
// while (i < 5);//parar


//*********FOR exemplos**********

//exibir numeros de 0 até 50 - inteiros (que mostre de 1 em 1)

for (int t = 200; t>=0; t-=2)   
{
    //bloco de códigos
    Console.WriteLine(t);    
}

// t = t+2;
// t += 2;
