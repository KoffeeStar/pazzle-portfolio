using System;

class Program
{
    static void Main()
    {
        Console.Write("Введи возраст: ");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("Вы совершеннолетний");
        }
        else
        {
            Console.WriteLine("Вы несовершеннолетний");
        }
    }
}