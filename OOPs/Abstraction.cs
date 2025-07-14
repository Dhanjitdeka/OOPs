using System;

// Pure abstraction using interface
interface IVehicle
{
    void Drive(); // No implementation, must be implemented by derived classes
}

class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

// Partial abstraction using abstract class
abstract class Appliance
{
    public abstract void TurnOn(); // Must be implemented by derived classes

    public void ShowBrand()
    {
        Console.WriteLine("Brand: Generic"); // Concrete method
    }
}

class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Washing machine is now on.");
    }
}

class AbstractionDemo
{
    public static void Run()
    {
        IVehicle vehicle = new Car();
        vehicle.Drive(); // Pure abstraction: must implement Drive()

        Appliance appliance = new WashingMachine();
        appliance.TurnOn(); // Partial abstraction: must implement TurnOn()
        appliance.ShowBrand(); // Partial abstraction: uses concrete method from abstract class
    }
}
