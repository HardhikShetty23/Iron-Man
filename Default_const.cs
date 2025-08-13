using System;

class Person
{
    public string name;

    public Person()
    {
        name = "Default Name";
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
        Person p = new Person();
        p.Display();
    }
}
