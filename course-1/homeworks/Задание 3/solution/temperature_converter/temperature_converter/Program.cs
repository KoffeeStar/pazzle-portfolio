using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите температуру: ");
        int temp = int.Parse(Console.ReadLine());
        int sum_temp = temp * 9 / 5 + 32;
        Console.Write("Температура по Фаренгейту: " + sum_temp);
    }
}