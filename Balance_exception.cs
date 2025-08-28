using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        double balance = 5000;

        try
        {
            Console.Write("Enter the withdrawal amount: ");
            double withdrawalAmount = Convert.ToDouble(Console.ReadLine());

            if (withdrawalAmount > balance)
            {
                throw new InsufficientFundsException("Not enough balance for this withdrawal.");
            }

            balance -= withdrawalAmount;
            Console.WriteLine("New balance: " + balance);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("Transaction complete.");
        }
    }
}
