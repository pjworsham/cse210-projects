
//circle class inherits the base class of shape

public class Circle : Shape
{

    //created an attribute as a private member variable
    protected double _radius;

    //created a constructor that accepts the color, length and width, and then call the base constructor with the color
    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;

    }


    //a override the method from the base class to return the area
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}