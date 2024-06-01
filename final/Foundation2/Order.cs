using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _product = [];
    private string _customer;

    public Order(string product, string customer)
    {
          _customer = customer;
    }
    public string GetPackingLabel()
    {
        return "";
    }
    public string GetShippingLabel()
    {
        return "";
    }
    public double CalculatetotalCost()
    {
        return 0;
    }
}