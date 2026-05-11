using System;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 12, 5, 8, 19, 3 };
        Console.WriteLine("Исходный список: " + string.Join(" ", numbers));
        numbers.Sort();
        Console.WriteLine("Отсортированный: " + string.Join(" ", numbers));
        int min = numbers[0];
        int max = numbers[^1];
        Console.WriteLine($"Минимум: {min}, Максимум: {max}");
        numbers.Reverse();
        Console.WriteLine("После Reverse: " + string.Join(" ", numbers));
    }
}