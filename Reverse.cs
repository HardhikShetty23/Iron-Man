using System;

class Program
{
    static void Main()
    {
        int number = 123;
        int reversed = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number = number / 10;
        }

        Console.WriteLine("Reversed number is " + reversed);
    }
}
