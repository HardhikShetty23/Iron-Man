using System;

class AppConfig
{
    public static string configName;

    static AppConfig()
    {
        configName = "Release";
    }

    public static void ShowConfig()
    {
        Console.WriteLine("Config: " + configName);
    }
}

class Program
{
    static void Main()
    {
        AppConfig.ShowConfig();
    }
}
