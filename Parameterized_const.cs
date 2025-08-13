using System;

class Person
{
    public string name;

    public Person(string personName)
    {
        name = personName;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Alice");
        p.Display();
    }
}
