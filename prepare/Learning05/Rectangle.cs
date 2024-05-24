using System.Runtime.CompilerServices;

//Rectangle class inherits the base class of shape
public class Rectangle : Shape
{

   //created attributes as a private member variable
    protected double _length;
    protected double _width;


    //created a constructor that accepts the color, length and width, and then call the base constructor with the color
    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;

    }
    //a override the method from the base class to return the area
    public override double GetArea()
    {
        return _length * _width;
    }

}
