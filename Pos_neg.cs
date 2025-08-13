using System;

class Program
{
    static void Main()
    {
        int number = 0;

        if (number > 0)
        {
            Console.WriteLine(number + " is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine(number + " is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
