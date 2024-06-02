using System.Configuration.Assemblies;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // with newline characters where appropriate)
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool isUsa()
    {
       if (_country == "USA")
       {
            return true;
       } 
       else
       {
            return false;
       }
    }
    public string Display()
    {
        string address = $"{_streetAddress}\n{_city}, {_state}\n{_country}" ;
        return address;

    }
}

