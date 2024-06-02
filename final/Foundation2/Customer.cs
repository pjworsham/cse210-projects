using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

public class Customer
{
    private string _name;
    private Address _address; 

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.Display();
    }
    public bool isUsa()
    {
        return _address.isUsa();
    }
}

