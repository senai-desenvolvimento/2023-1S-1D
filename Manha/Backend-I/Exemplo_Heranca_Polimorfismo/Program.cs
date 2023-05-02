using Carlos;

//instanciado objeto da classe "Carro"
Carro car = new Carro();

//acesso aos atributos da superclasse que foi herdada
car.Modelo = "celta 94";
car.Cor = "prata"; 

//acesso aos atributos da própria classe
car.NumeroChassis = "48592939529";
car.Proprietario = "Carlos";

Console.WriteLine(@$"
{car.Modelo}
{car.Cor}
{car.NumeroChassis}
{car.Proprietario}
");

car.Ligar();
car.Desligar();

//criando um código de barras

Random codigoBarras = new Random();

Console.WriteLine($" 237.00005636.{codigoBarras.Next(900000000).ToString()}.00052636001");

Console.WriteLine($"{codigoBarras.Next(30000000)}.{codigoBarras.Next(30000000)}");

