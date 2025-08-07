using System;

class Person3
{
    public string Name;
    public int Age;

    // Default Constructor
    public Person3()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized Constructor
    public Person3(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy Constructor
    public Person3(Person3 other)
    {
        Name = other.Name;
        Age = other.Age;
    }

    // Static Constructor
    static Person3()
    {
        Console.WriteLine("Static Constructor Called");
    }

    // Display Method to show object data
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Default Constructor
        Person3 person1 = new Person3(); // No arguments
        Console.WriteLine("Person 1 (using default constructor):");
        person1.Display();

        // Parameterized Constructor
        Person3 person2 = new Person3("Alice", 25); // With arguments
        Console.WriteLine("\nPerson 2 (using parameterized constructor):");
        person2.Display();

        // Copy Constructor
        Person3 person3 = new Person3(person2); // Creating a copy of person2
        Console.WriteLine("\nPerson 3 (using copy constructor):");
        person3.Display();

        // Static Constructor is called automatically the first time a static member is accessed.
        Console.WriteLine("\nAccessing static constructor:");
        Person3 person4 = new Person3(); // Static constructor is called before this point
    }
}
