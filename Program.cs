namespace ConcessionariCLI.Models;

abstract class user
{
    private static int _idCounter = 0;
    public user(string name, int cpf, string position)
    {
        Id = _idCounter ++;
        Name = name;
        Cpf = cpf;
        Position = position;
    }

    public int Id { get; }
    public string Name { get; }
    public int Cpf { get; }
    public string Position { get; }

}