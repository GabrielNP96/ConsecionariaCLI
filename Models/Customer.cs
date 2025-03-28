using ConcessionariaCLI.Enums;
using ConcessionariaCLI.Models;

class Customer:User
{
    public Customer(string name, string userName, string password, Position position):base (name, userName, password, position)
    {
    }
}