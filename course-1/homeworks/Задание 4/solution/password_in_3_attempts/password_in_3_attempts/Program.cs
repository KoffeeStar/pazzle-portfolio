using System;

class Program
{
    static void Main()
    {
        int password = 1234;
        int i = 0;
        while (i != 3)
        {
            Console.Write("Введите пароль: ");
            int us_password = int.Parse(Console.ReadLine());
            if (us_password != password)
            {
                i++;
            }
            else if (us_password == password)
            {
                Console.WriteLine("Доступ разрешён");
                break;
            }
        }
        if (i == 3)
            Console.WriteLine("Доступ запрещён");
    }
}