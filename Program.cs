using ConcessionariaCLI.Enums;
//using ConcessionariaCLI.Models;

Manager one = new("Romualdo", 123456789, Position.Gerente);

Console.WriteLine(one.Id);
Manager two = new("Vasco", 1457, Position.Gerente);
Console.WriteLine(two.Position);