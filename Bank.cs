using System;

class BankAccount
{
    public string accountNumber;
    public decimal balance;

    public BankAccount(string accNum, decimal bal)
    {
        accountNumber = accNum;
        balance = bal;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
        Console.WriteLine("Balance: " + balance);
    }

    public void Withdraw(decimal amount)
    {
        balance -= amount;
        Console.WriteLine("Withdrawn: " + amount);
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : BankAccount
{
    public decimal interestRate;

    public SavingsAccount(string accNum, decimal bal, decimal rate) : base(accNum, bal)
    {
        interestRate = rate;
    }

    public void AddInterest()
    {
        decimal interest = balance * interestRate;
        balance += interest;
        Console.WriteLine("Interest Added: " + interest);
        Console.WriteLine("Balance: " + balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SavingsAccount s = new SavingsAccount("12345", 1000, 0.05m);
        s.Deposit(500);
        s.Withdraw(200);
        s.AddInterest();
    }
}
