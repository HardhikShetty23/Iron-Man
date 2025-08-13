using System;

class Person
{
    public string name;

    public Person(string personName)
    {
        name = personName;
    }

    public Person(Person other)
    {
        name = other.name;
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
        Person p1 = new Person("Bob");
        Person p2 = new Person(p1);
        p2.Display();
    }
}
