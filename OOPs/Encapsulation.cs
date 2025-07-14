using System;

class Person
{
    // private: accessible only within this class
    private string ssn;

    // public: accessible from anywhere
    public string Name { get; set; }

    // protected: accessible in this class and derived classes
    protected int age;

    // internal: accessible within the same assembly(same .dll or .exe)
    internal string Address { get; set; }

    // protected internal: accessible in derived classes or same assembly
    protected internal string Phone { get; set; }

    // private protected: accessible in derived classes within the same assembly
    private protected string Email { get; set; }

    public Person(string name, string ssn)
    {
        Name = name;
        this.ssn = ssn;
        age = 0;
        Address = "Unknown";
        Phone = "Unknown";
        Email = "Unknown";
    }

    // public method to access private field
    public string GetSSN()
    {
        return ssn;
    }
}

class Employee : Person
{
    public Employee(string name, string ssn) : base(name, ssn) { }

    public void SetAge(int value)
    {
        age = value; // protected field accessible in derived class
    }

    public void SetEmail(string email)
    {
        Email = email; // private protected field accessible in derived class (same assembly)
    }
}

class EncapsulationDemo
{
    public static void Run()
    {
        Person p = new Person("Alice", "123-45-6789");
        Employee e = new Employee("Bob", "987-65-4321");

        p.Name = "Alice Smith"; // public
        p.Address = "Wonderland"; // internal
        p.Phone = "555-1234"; // protected internal

        Console.WriteLine($"Name: {p.Name}");
        Console.WriteLine($"SSN: {p.GetSSN()}");
        Console.WriteLine($"Address: {p.Address}");
        Console.WriteLine($"Phone: {p.Phone}");

        e.SetAge(30); // protected
        e.SetEmail("bob@email.com"); // private protected
    }
}
