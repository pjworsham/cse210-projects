using System.Security.Cryptography.X509Certificates;

public class Product
{
    private string _name;
    private string _productId;
    private double _pricePreUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePreUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePreUnit = pricePreUnit;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        return 0;
    }
}