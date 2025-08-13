using System;

class Logger
{
    private Logger()
    {
    }

    public static void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main()
    {
        Logger.Log("Application started.");
    }
}
