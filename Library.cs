using System;

class Book
{
    public string title;
    public string author;

    public Book(string t, string a)
    {
        title = t;
        author = a;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
}

class Ebook : Book
{
    public double fileSize;
    public string format;

    public Ebook(string t, string a, double size, string f) : base(t, a)
    {
        fileSize = size;
        format = f;
    }

    public void ShowEbookInfo()
    {
        ShowInfo();
        Console.WriteLine("File Size: " + fileSize + " MB");
        Console.WriteLine("Format: " + format);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ebook eb = new Ebook("C# Basics", "John Doe", 2.5, "PDF");
        eb.ShowEbookInfo();
    }
}
