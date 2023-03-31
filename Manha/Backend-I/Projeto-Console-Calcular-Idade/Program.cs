// EXERCÍCIO

// FAÇA UM PROGRAMA PARA CALCULAR A IDADE DE UMA PESSOA EM:

// - MESES
// - DIAS
// - HORAS
// - MINUTOS

// *RECEBER E IMPRIMIR OS DADOS NO CONSOLE

// ***DICA : FAÇA O SEU ALGORITMO ESCRITO ANTES DE INICIAR A CRIAÇÃO DO PROGRAMA

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

int meses = idade * 12;
int dias = idade * 365;
int horas = dias * 24;
int minutos = horas * 60;

Console.WriteLine($"Sua idade corresponde à: {idade} anos, ou {meses} meses, ou {dias} dias, ou {horas} horas, ou {minutos} minutos!");