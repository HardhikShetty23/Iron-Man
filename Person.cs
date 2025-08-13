using System;

class Person
{
    
    public string Name;
    public int Age;

    
    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        Console.Write("Enter name: ");
        person.Name = Console.ReadLine();

        Console.Write("Enter age: ");
        person.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nPerson Details:");
        person.Display();
    }
}
