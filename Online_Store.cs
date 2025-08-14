using System;

class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void ShowProductInfo()
    {
        Console.WriteLine("Product Name: " + Name);
        Console.WriteLine("Price: " + Price);
    }
}

class ElectronicProduct : Product
{
    public string Brand;
    public int Warranty; // in months

    public ElectronicProduct(string name, double price, string brand, int warranty) : base(name, price)
    {
        Brand = brand;
        Warranty = warranty;
    }

    public void ShowElectronicInfo()
    {
        ShowProductInfo();
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Warranty: " + Warranty + " months");
    }
}

class Smartphone : ElectronicProduct
{
    public string OS;
    public int StorageCapacity; // in GB

    public Smartphone(string name, double price, string brand, int warranty, string os, int storage)
        : base(name, price, brand, warranty)
    {
        OS = os;
        StorageCapacity = storage;
    }

    public void ShowSmartphoneInfo()
    {
        ShowElectronicInfo();
        Console.WriteLine("Operating System: " + OS);
        Console.WriteLine("Storage Capacity: " + StorageCapacity + " GB");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Smartphone phone = new Smartphone("Galaxy S21", 79999, "Samsung", 24, "Android", 128);
        phone.ShowSmartphoneInfo();
    }
}
