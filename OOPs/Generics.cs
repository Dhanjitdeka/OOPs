
using System;

// Generic class
class Box<T>
{
    public T Value { get; set; }
    public Box(T value)
    {
        Value = value;
    }
    public void Display()
    {
        Console.WriteLine($"Box contains: {Value}");
    }
}
// Simple class for demonstration
class Luffy
{
    public string Nickname { get; set; }
    public Luffy()
    {
        Nickname = "rubberman";
    }
}
// Generic method
class GenericDemo
{
    public static void ShowType<T>(T item)
    {
        Console.WriteLine($"Type: {typeof(T)}, Value: {item}");
    }

    public static void RunGeneric()
    {
        Box<int> intBox = new Box<int>(42);
        intBox.Display();

        Box<string> strBox = new Box<string>("Hello Generics");
        strBox.Display();

        ShowType<double>(3.14);
        ShowType<string>("Generic Method");

        Box<Luffy> luffyBox = new Box<Luffy>(new Luffy());
        luffyBox.Display();

        ShowType<Luffy>(new Luffy());
    }
}
