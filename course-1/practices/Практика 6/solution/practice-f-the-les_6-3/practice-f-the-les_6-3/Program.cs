using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два числа: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма: {a + b}");
    }
}