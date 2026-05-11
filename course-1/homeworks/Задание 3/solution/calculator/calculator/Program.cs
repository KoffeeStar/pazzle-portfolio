using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num_1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num_2 = int.Parse(Console.ReadLine());
        int sum_num = num_1 + num_2;
        int dif_num = num_1 - num_2;
        int mul_num = num_1 * num_2;
        int div_num = num_1 / num_2;
        Console.Write("Сумма: " + sum_num);
        Console.Write(" разность: " + dif_num);
        Console.Write(" произведение: " + mul_num);
        Console.Write(" частное: " + div_num);
    }
}