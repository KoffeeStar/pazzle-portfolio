using System;

class Program
{
    static void Main()
    {
        string passwordTrue = "1234";
        string password;
        do
        {
            Console.Write("Введите пароль: ");
            password = Console.ReadLine();
        } while (password != passwordTrue);
    }
}