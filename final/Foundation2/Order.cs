using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _product;
    private Customer _customer;

    public Order(List<Product> product, Customer customer)
    {
          _customer = customer;
          _product = product;
    }
    // should list the name and product id for each product in order
    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _product)
        {
            packingLabel = packingLabel + $"Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLabel;
     }
    //should list the name and address of the customer
    public string GetShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddress()}";

        return shippingLabel;
    }
    //If shipping in USA $5, if not $35
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _product)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.isUsa())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
}