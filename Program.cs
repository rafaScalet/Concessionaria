using consecionaria.models;

Carro carro = new(200, "Ubuntu", "BYD");
Moto moto = new(3000, "Roma", "IDE");

Console.WriteLine("Carro - ");
Console.WriteLine("Modelo: " + carro.Modelo);
Console.WriteLine("Ano: " + carro.Ano);
Console.WriteLine("\nMoto - ");
Console.WriteLine("Modelo: " + moto.Modelo);
Console.WriteLine("Ano: " + moto.Ano);