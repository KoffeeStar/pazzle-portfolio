using System;

class Program
{
    static void Main()
    {
        void PrintPerson(string name, int age, string city)
        {
            Console.WriteLine($"Имя: {name} Возраст: {age} Город: {city}");
        }
        PrintPerson("Катя", 17, "Новгород");
        PrintPerson("Елена", 48, "Омск");
    }
}