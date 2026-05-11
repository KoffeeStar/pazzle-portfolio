using System;

class Program
{
    static void Main()
    {
        Console.Write("Введи оценку (от 1 до 5): ");
        int grade = int.Parse(Console.ReadLine());
        if (grade < 3)
        {
            Console.WriteLine("Неудволетворительно");
        }
        else if (grade == 3)
        {
            Console.WriteLine("Удовлетворительно");
        }
        else if (grade == 4)
        {
            Console.WriteLine("Хорошо");
        }
        else if (grade == 5)
        {
            Console.WriteLine("Отлично");
        }
        else
        {
            Console.WriteLine("Некорректная оценка");
        }
    }
}