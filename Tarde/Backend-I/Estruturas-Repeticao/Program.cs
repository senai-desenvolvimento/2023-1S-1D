// //*********LAÇO WHILE

// //SEM LAÇO - EXEMPLO
// // Console.WriteLine($"1");
// // Console.WriteLine($"2");
// // Console.WriteLine($"3");
// // Console.WriteLine($"4");
// // Console.WriteLine($"5");
// // Console.WriteLine($"6");
// // Console.WriteLine($"7");
// // Console.WriteLine($"8");
// // Console.WriteLine($"9");
// // Console.WriteLine($"10");

// //COM LAÇO WHILE - EXEMPLO

// //valor inicial
// int x = 1;

// //laço de repetição
// while (x <= 10)//enquanto x for menor ou igual á 10
// {
//     Console.WriteLine(x);//imprima o valor de x
//     x+= 2;//depois incrementa +1 ao valor de x
// }


// //EXEMPLO WHILE
// Console.WriteLine($"Informe o nome do usuário: ");
// string nome = Console.ReadLine();

// Console.WriteLine($"Informe a senha com 6 caracteres: ");
// string senha = Console.ReadLine();

// while (senha.Length != 6)
// {
//     Console.WriteLine($"Infome a senha novamente, tem que ter 6 caracteres");
//     senha = Console.ReadLine();   
// }
// Console.WriteLine($"Usuário e senha recebidos com sucesso!");

// // // //EXEMPLO WHILE
// bool idadeCerta = false;

// while (idadeCerta == false)
// {
//     Console.WriteLine($"Qual a idade do CR7 ?");
//     int idade = int.Parse(Console.ReadLine());

//     if (idade == 38)
//     {
//         idadeCerta = true;
//     }    
// }

// //*********LAÇO DO-WHILE
// bool idadeCerta = false;

// do
// {
//     Console.WriteLine($"Qual a idade do CR7 ?");
//     int idade = int.Parse(Console.ReadLine());

//     if(idade == 38)
//     {
//         Console.WriteLine($"Acertou!!");
//         idadeCerta = true;        
//     }
//     else
//     {
//         Console.WriteLine($"Errou feio, tente novamente!");        
//     }
    
// } while (idadeCerta == false);

//*********LAÇO DO-WHILE

// for (inicializador; condição; iterador)
// {
//     //bloco de código
// }

for(int x = 1;  x <= 100; x+=3)
{
    Console.WriteLine(x);    
}

//programa para imprimir valores de 500 até 0, decrementar de 5 em 5

//operador de incremento
//de 1 em 1
//x = x+1;
//x++;
//x+=1;

//acima de 1
//x = x+3;
//x += 3;