using System;
using System.ComponentModel.DataAnnotations;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; private set; }

    private int _pagesRead;

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
        _pagesRead = 0;
    }

    public void Read(int pages)
    {
        if (_pagesRead + pages > Pages)
        {
            pages = Pages - _pagesRead;
        }

        _pagesRead += pages;

        Console.WriteLine($"Вы прочитали {_pagesRead} из {Pages}");
    }
}
public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Книга \"{book.Title}\" добавлена в библиотеку");

    }

    public void PrintAllBooks()
    {
        Console.WriteLine("Список книг в библиотеке:");

        if (books.Count == 0)
        {
            Console.WriteLine("Библиотека пуста.");
            return;
        }
    }
}