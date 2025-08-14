using System;

class Vehicle
{
    public string model;
    public double rentalPricePerDay;

    public Vehicle(string m, double price)
    {
        model = m;
        rentalPricePerDay = price;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Rental Price per Day: " + rentalPricePerDay);
    }
}

class Car : Vehicle
{
    public int numberOfSeats;
    public string fuelType;

    public Car(string m, double price, int seats, string fuel) : base(m, price)
    {
        numberOfSeats = seats;
        fuelType = fuel;
    }

    public void ShowCarInfo()
    {
        ShowInfo();
        Console.WriteLine("Number of Seats: " + numberOfSeats);
        Console.WriteLine("Fuel Type: " + fuelType);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car c = new Car("Toyota Corolla", 1500, 5, "Petrol");
        c.ShowCarInfo();
    }
}
