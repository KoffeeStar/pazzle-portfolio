using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ширину прямоугольника: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину прямоугольника: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine($"Площадь прямоугольника: {width * height}");
    }
}