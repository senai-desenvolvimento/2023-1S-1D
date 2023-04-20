using POO;

//instanciamos um objeto da classe Personagem
Personagem p1 = new Personagem();

Console.WriteLine($"Digite o nome do seu personagem: ");
p1.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade do seu personagem: ");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o nome da armadura do personagem: ");
p1.armadura = Console.ReadLine();

Console.WriteLine($"Informe a I.A que o personagem utiliza: ");
p1.ia = Console.ReadLine();


Console.WriteLine(@$"
    {p1.nome},
    {p1.idade},
    {p1.armadura},
    {p1.ia}
");

p1.Atacar();
p1.RestaurarArmadura();
Console.WriteLine(p1.Defender());