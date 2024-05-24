
//square class inherits the base class of shape
public class Square : Shape
{
    //created an attribute as a private member variable
    private double _side;


    //created a constructor that accepts the color and the side, and then call the base constructor with the color
    public Square(string color, double side) : base (color)
    {
        _side = side;

    }
    //a override the method from the base class to return the area
    public override double GetArea()
    {
        return _side * _side;
    }
}