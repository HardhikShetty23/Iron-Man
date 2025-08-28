using System;

class InvalidMarksException : Exception
{
    public int InvalidMarks { get; private set; }

    public InvalidMarksException(int marks) : base("invalid Marks")
    {
        InvalidMarks = marks;
    }

    public string GetErrorDetails()
    {
        return $"Error: {Message}. You entered: {InvalidMarks}";
    }

    public void AutoCorrectMarks()
    {
        if (InvalidMarks < 0) InvalidMarks = 0;
        else if (InvalidMarks > 100) InvalidMarks = 100;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter student marks (0-100): ");
            int marks = int.Parse(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                throw new InvalidMarksException(marks);
            }

            Console.WriteLine($"Marks entered: {marks}");
        }
        catch (InvalidMarksException ex)
        {
            Console.WriteLine(ex.GetErrorDetails());

            ex.AutoCorrectMarks();
            Console.WriteLine($"Auto corrected marks: {ex.InvalidMarks}");
        }
    }
}
