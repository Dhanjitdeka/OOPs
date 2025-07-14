// This code demonstrates the concepts of inheritance and polymorphism in C#.
// Why do we need virtual keyword in c#?
// This is because method dispatch in C# is determined statically (at compile time) unless the method is marked as virtual and the override is explicit.

// If the base method is not virtual, then the compiler binds the call to Animal.Speak() at compile time, even if the actual object is a Dog.

// When you use virtual + override, C# uses a virtual method table (vtable) under the hood. At runtime, it checks the actual object’s type and calls the correct override dynamically.
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
public class Alien
{
    public void Speak()
    {
        Console.WriteLine("Alien makes a sound");
    }
}
public class Goku:Alien
{
    public void Speak()
    {
        Console.WriteLine("Goku makes a sound");
    }
}
public class Inheritance
{
    public static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.Speak(); // Output: Animal makes a sound

        Dog myDog = new Dog();
        myDog.Speak(); // Output: Dog barks

        Animal anotherDog = new Dog();
        anotherDog.Speak(); // Output: Dog barks (polymorphism)

        Alien myAlien = new Alien();
        myAlien.Speak(); // Output: Alien makes a sound

        Goku myGoku = new Goku();
        myGoku.Speak(); // Output: Goku makes a sound

        Alien anotherGoku = new Goku();
        anotherGoku.Speak(); // Output: Goku makes a sound (not polymorphism, as Goku does not override Alien's Speak method)
        PolymorphismDemo.Run();
    }
}