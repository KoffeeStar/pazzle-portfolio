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

        while (true)
        {
            Console.Write("Введите выражение (или exit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Программа завершена");
                break;
            }

            string[] parts = input.Split(' ');

            if (parts.Length != 3)
            {
                Console.WriteLine("Ошибка: Неверный формат ввода! Используйте формат: число операция число");
                continue;
            }

            try
            {
                int a = Convert.ToInt32(parts[0]);
                string operation = parts[1];
                int b = Convert.ToInt32(parts[2]);

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
                    Console.WriteLine("Ошибка: Неверная операция! Используйте +, -, *, /");
                }

                if (validOperation)
                {
                    Console.WriteLine($"Результат: {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректные числа!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}