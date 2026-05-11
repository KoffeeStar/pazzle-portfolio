using System;

class Program
{
    static void Main()
    {
        int Square(int x)
        {
            int square = x * x;
            return square;
        }

        int result = Square(12);
        Console.WriteLine("Квадрат числа: " + result);
    }
}