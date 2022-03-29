using System;
using System.Collections.Generic;

public class Book
{
    private string _title;
    private string _author;
    private double _amount;
    private int _noOfPages;

    public Book(string _title, string _author, double _amount, int _noOfPages)
    {
        this._title = _title;
        this._author = _author;
        this._amount = _amount;
        this._noOfPages = _noOfPages;
    }
    public string Title
    {
        get
        {
            return this._title;
        }
        set
        {
            this._title = value;
        }
    }

    public string Author
    {
        get
        {
            return this._author;
        }
        set
        {
            this._author = value;
        }
    }

    public double Amount
    {
        get
        {
            return this._amount;
        }
        set
        {
            this._amount = value;
        }
    }

    public int NoOfPages
    {
        get
        {
            return this._noOfPages;
        }
        set
        {
            this._noOfPages = value;
        }
    }

    public static int CompareBook(Book book1, Book book2)
    {
        //Fill your code here
        if((book1.Title.CompareTo(book2.Title) == 0) &&
           (book1.Amount.CompareTo(book2.Amount) == 0) &&
            (book1.Author.CompareTo(book2.Author) == 0) &&
            (book1.NoOfPages.CompareTo(book2.NoOfPages) == 0)){
            return 0;
        }

        else
        {
            return -1;
        }
    }
}