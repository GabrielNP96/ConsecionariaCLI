namespace ConcessionariaCLI.Models;
using ConcessionariaCLI.Enums;

abstract class User
{
    private static int _idCounter = 0;
    public User(string name, string userName, string password, Position position)
    {
        Id = _idCounter ++;
        Name = name;
        UserName = userName;
        Password = password;
        Position = position;
    }

    public int Id { get; }
    public string Name { get; }
    public string UserName { get; }
    public string Password { get; }
    public Position Position { get; }

}