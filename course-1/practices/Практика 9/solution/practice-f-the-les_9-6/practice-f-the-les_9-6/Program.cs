using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;

        static double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль запрещено.");
            return (double)a / b;
        }

        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        string operation = Console.ReadLine();

        int result = 0;
        bool validOperation = true;

        if (operation == "+")
        {
            result = Add(a, b);
        }
        else if (operation == "-")
        {
            result = Subtract(a, b);
        }
        else if (operation == "*")
        {
            result = Multiply(a, b);
        }
        else if (operation == "/")
        {
            result = (int)Divide(a, b);
        }
        else
        {
            validOperation = false;
            Console.WriteLine("Ошибка: Неверная операция!");
        }

        if (validOperation)
        {
            Console.WriteLine($"Результат: {a} {operation} {b} = {result}");
        }
    }
}