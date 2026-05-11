using System;

class Program
{
    static void Main()
    {
        void PrintPerson(string name, int age = 18, string hobby = "Не указано")
        {
            Console.WriteLine($"Имя: {name} Возраст: {age} Хобби: {hobby}");
        }

        PrintPerson("Анна", 19, "Бисероплетение");
        PrintPerson("Ольга");
    }
}