using System;

class Program
{
    static void Main()
    {
        int a = 12;
        int b = 5;

        int sum = a + b;
        Console.WriteLine($"Сумма: {a} + {b} = {sum}");

        int difference = a - b;
        Console.WriteLine($"Разность: {a} - {b} = {difference}");

        int product = a * b;
        Console.WriteLine($"Произведение: {a} * {b} = {product}");

        int quotient = a / b;
        Console.WriteLine($"Частное (целочисленное): {a} / {b} = {quotient}");

        double exactQuotient = (double)a / b;
        Console.WriteLine($"Частное (вещественное): {a} / {b} = {exactQuotient:F2}");

        int remainder = a % b;
        Console.WriteLine($"Остаток от деления: {a} % {b} = {remainder}");
    }
}