using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num_1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num_2 = int.Parse(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int num_3 = int.Parse(Console.ReadLine());
        int sum_num = (num_1 + num_2 + num_3) / 3;
        Console.Write("Среднее арифметическое всех чисел: " + sum_num);
    }
}