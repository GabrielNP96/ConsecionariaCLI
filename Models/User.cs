namespace ConcessionariaCLI.Models;
using ConcessionariaCLI.Enums;

abstract class User
{
    private static int _idCounter = 0;
    public User(string name, int cpf, Position position)
    {
        Id = _idCounter ++;
        Name = name;
        Cpf = cpf;
        Position = position;
    }

    public int Id { get; }
    public string Name { get; }
    public int Cpf { get; }
    public Position Position { get; }

}