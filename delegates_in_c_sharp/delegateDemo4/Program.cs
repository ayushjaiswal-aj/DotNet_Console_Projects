using System;
using System.Collections.Generic;

class Program
{
    public delegate int CompareBookDelegate(Book b1, Book b2);
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the book 1 details");
        Console.WriteLine("Enter the title");
        string title1 = Console.ReadLine();
        Console.WriteLine("Enter the author");
        string author1 = Console.ReadLine();
        Console.WriteLine("Enter the price");
        double price1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the noOfPages");
        int noOfPages1 = Convert.ToInt32(Console.ReadLine());
        Book b1 = new Book(title1, author1, price1, noOfPages1);

        Console.WriteLine("Enter the book 2 details");
        Console.WriteLine("Enter the title");
        string title2 = Console.ReadLine();
        Console.WriteLine("Enter the author");
        string author2 = Console.ReadLine();
        Console.WriteLine("Enter the price");
        double price2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the noOfPages");
        int noOfPages2 = Convert.ToInt32(Console.ReadLine());
        Book b2 = new Book(title2, author2, price2, noOfPages2);

        //Fill your code here
        CompareBookDelegate compareBookDelegeate = new CompareBookDelegate(Book.CompareBook);
        if(compareBookDelegeate(b1, b2) == 0)
        {
            Console.WriteLine("Books are equal");
        }
        else
        {
            Console.WriteLine("Books are not equal");
        }
    }
}
