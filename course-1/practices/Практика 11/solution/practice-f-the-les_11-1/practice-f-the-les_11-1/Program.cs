using System;

public class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Pages { get; }

    public Book()
    {
        Title = "Неизвестно";
        Author = "Неизвестен";
        Pages = 0;
    }

    public Book(string title)
    {
        Title = "Название книги";
        Author = "Неизвестен";
        Pages = 0;
    }
    public Book(string title, string author)
    {
        Title = "Название книги";
        Author = "Автор";
        Pages = 0;
    }
    public Book(string title, string author, int pages)
    {
        Title = "Название книги";
        Author = "Автор";
        Pages = 20;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {Pages}");
    }
}