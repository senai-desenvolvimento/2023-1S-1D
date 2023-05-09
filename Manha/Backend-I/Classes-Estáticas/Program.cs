using Classes_Estáticas;

Console.WriteLine(ConversorTemperatura.CelsiusParaFahrenheit(30));

Console.WriteLine(ConversorTemperatura.FahreinheitParaCelsius(100));

//para invocar o método estático aqui na program.cs precisamos apenas 
//chamar o nome da classe e a função, não sendo necessário instanciar objetos
//ConversorTemperatura.FahreinheitParaCelsius(100);
//ConversorTemperatura.CelsiusParaFahrenheit(30);