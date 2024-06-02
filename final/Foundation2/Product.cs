using System.Security.Cryptography.X509Certificates;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private double _quantity;

    public Product(string name, int productId, double price, double quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    // need getters for name and product Id
    public string GetName()
    {
        return _name;
    }
    public double GetProductId()
    {
        return _productId;
    }
    // total cost of this product is computed by multiplying the price per unit and the quantity
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}