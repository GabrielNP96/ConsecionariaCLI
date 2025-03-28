using ConcessionariaCLI.Enums;
using ConcessionariaCLI.Models;
class Manager : User
{

    public Manager(string name, string userName, string password, Position position):base (name, userName, password, position)
    {}

}