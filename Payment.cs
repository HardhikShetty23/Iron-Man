using System;

class Payment
{
    public double amount;
    public string date;

    public Payment(double amt, string dt)
    {
        amount = amt;
        date = dt;
    }

    public void ShowPaymentInfo()
    {
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Date: " + date);
    }
}

class CreditCardPayment : Payment
{
    public string cardNumber;
    public string holder;

    public CreditCardPayment(double amt, string dt, string cardNum, string name) : base(amt, dt)
    {
        cardNumber = cardNum;
        holder = name;
    }

    public void ProcessCreditCard()
    {
        ShowPaymentInfo();
        Console.WriteLine("Card Number: " + cardNumber);
        Console.WriteLine("Card Holder: " + holder);
        Console.WriteLine("Credit Card Payment Successful!");
    }
}

class UpiPayment : Payment
{
    public string upiId;
    public string bankName;

    public UpiPayment(double amt, string dt, string id, string bank) : base(amt, dt)
    {
        upiId = id;
        bankName = bank;
    }

    public void ProcessUpi()
    {
        ShowPaymentInfo();
        Console.WriteLine("UPI ID: " + upiId);
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("UPI Payment Successful!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CreditCardPayment ccp = new CreditCardPayment(2500, "14-08-2025", "1234-5678-9012-3456", "John Doe");
        ccp.ProcessCreditCard();

        Console.WriteLine();

        UpiPayment upi = new UpiPayment(1500, "14-08-2025", "john@upi", "HDFC Bank");
        upi.ProcessUpi();
    }
}
