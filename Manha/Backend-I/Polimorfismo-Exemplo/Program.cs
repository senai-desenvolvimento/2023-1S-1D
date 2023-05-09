// using System.Globalization;

// float valor = 499.985748f;
// Console.WriteLine($"{valor:C}");

// DateTime data = DateTime.Now;
// Console.WriteLine($"{data:f}");

// Console.WriteLine(25253.552663.ToString("C",
//                   CultureInfo.CreateSpecificCulture("en-US")));
                  
// Console.WriteLine($"{DateTime.Now.ToString("d",
//                   CultureInfo.CreateSpecificCulture("en-US"))}");


Console.Write($"Cadastrando Produto!");

for (var i = 0; i < 5; i++)
{
    Console.Write(".");
    Console.Beep();
    Thread.Sleep(150);
}

Console.WriteLine();
Console.Beep(500,1000);
Console.WriteLine($"Produto cadastrado !");
Console.WriteLine($"Aperte qualquer tecla para finalizar ...");
Console.Read();
Console.Clear();
Console.WriteLine($";)");

Console.SetWindowSize(20,20);