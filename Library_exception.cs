using System;
using System.Collections.Generic;

class BookNotFoundException : Exception
{
    public BookNotFoundException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        List<int> bookIds = new List<int> { 101, 102, 103, 104, 105 };

        try
        {
            Console.Write("Enter the book ID you want to borrow: ");
            int bookId = Convert.ToInt32(Console.ReadLine());

            if (!bookIds.Contains(bookId))
            {
                throw new BookNotFoundException("Book not found in the library.");
            }

            Console.WriteLine("You have borrowed the book with ID: " + bookId);
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid book ID.");
        }
        finally
        {
            Console.WriteLine("Library system operation complete.");
        }
    }
}
