using System;

class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public double Rating { get; set; }

    public Movie(string title, string genre, int rating)
    {
        Title = title;
        Genre = genre;
        Rating = rating;
    }

    public Movie(string title) : this(title, "Неизвестен", 0) { }
    public Movie() : this("Без названия", "Неизвестен", 0) { }
    public void PrintInfo()
    {
        Console.WriteLine($"Название: {Title}, жанр: {Genre}, рейтинг: {Rating}");
    }
}

class Program
{
    static void Main()
    {
        var m1 = new Movie();
        var m2 = new Movie("Матрица");
        var m3 = new Movie("Начало", "Фантастика", 9);

        Console.WriteLine("Информация о фильмах:");
        m1.PrintInfo();
        m2.PrintInfo();
        m3.PrintInfo();
    }
}