using System;

class Program
{
    static void Main()
    {
        void Greet(string name)
        {
            Console.WriteLine("Привет, " + name + "!");
        }

        Greet("Саша");
        Greet("Ярослав");
        Greet("Анна");
    }
}