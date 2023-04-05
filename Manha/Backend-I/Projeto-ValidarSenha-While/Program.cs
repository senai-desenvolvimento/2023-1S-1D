//um programa que receba o nome do usuario e a senha ok
//a senha deve ter 6 caracteres ex: "admin@" ok 
//validar a senha
//enquanto a senha nao estiver com regra pedida, preciso que 
    //o programa nao se encerra e que solicite que seja digitado
    //uma senha no padrao requerido
//caso a senha informada esteja com 6 caracteres, exiba uma mensagem de ok

Console.WriteLine($"digite o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"digite a sua senha (tem que ter 6 caracteres)");
string senha = Console.ReadLine();

while (senha.Length != 6)
{
    Console.WriteLine($"Digite uma senha no padrão requerido (com 6 caracteres): ");
    senha = Console.ReadLine();     
}
Console.WriteLine($"Usuário e senha recebidas com sucesso!");