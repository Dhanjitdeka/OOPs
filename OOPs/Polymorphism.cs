
using System;

// Abstract base class
abstract class Shape
{
    // Abstract method (must be overridden)
    public abstract double Area();

    // Virtual method (can be overridden, but not required)
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape.");
    }
}

// Derived class
class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    // Must override abstract method
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
    // Optionally override virtual method
    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}.");
    }
}

// Another derived class
class Square : Shape
{
    public double Side { get; set; }
    public Square(double side)
    {
        Side = side;
    }
    public override double Area()
    {
        return Side * Side;
    }
    // Does not override Draw(), uses base implementation
}

// Abstract derived class that does NOT override Area()
abstract class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    // Area() is NOT overridden, so Rectangle remains abstract
    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle {Width} x {Height}.");
    }
}


class PolymorphismDemo
{
    public static void Run()
    {
        Shape circle = new Circle(5);
        Shape square = new Square(4);
        // Shape filledRectangle = new FilledRectangle(3, 6);

        circle.Draw(); // Calls Circle's override
        Console.WriteLine($"Area: {circle.Area()}");

        square.Draw(); // Calls base implementation (not overridden)
        Console.WriteLine($"Area: {square.Area()}");
        //Rectangle rectangle = new Rectangle(); Will give error
       
    }
}
