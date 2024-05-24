using System;


class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("Red", 5);
        Circle circle = new Circle("Red", 10);
        Rectangle rectangle = new Rectangle("Red", 5, 10);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}