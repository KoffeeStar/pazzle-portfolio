using System;

class Program
{
    static void Main()
    {
        int a = 5, b = -2;
        if (a > 0 && b > 0)
        {
            Console.WriteLine("Оба числа положительные");
        }
        if (a > 0 || b > 0)
        {
            Console.WriteLine("Хотя бы одно число положительное");
        }
        if (a <= 0)
        {
            Console.WriteLine("a не положительное");
        }
    }
}