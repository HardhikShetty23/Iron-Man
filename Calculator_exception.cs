using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            if (operation == '+')
                result = num1 + num2;
            else if (operation == '-')
                result = num1 - num2;
            else if (operation == '*')
                result = num1 * num2;
            else if (operation == '/')
            {
                if (num2 == 0)
                    throw new DivideByZeroException();
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid operation.");
                return;
            }

            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Calculation complete.");
        }
    }
}
