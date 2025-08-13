using System;

class Program
{
    static void Main()
    {
        int number = 12345;
        int sum = 0;
        int temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        Console.WriteLine("Sum of digits of " + number + " is " + sum);
    }
}
