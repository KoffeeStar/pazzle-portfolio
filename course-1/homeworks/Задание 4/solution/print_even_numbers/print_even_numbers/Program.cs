using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 21; i++)
        {
            Console.WriteLine(i);
        }
        for (int i = 0; i < 21; i++)
        {
            if (!(i % 2 == 0))
                continue;
            Console.WriteLine(i);
        }
    }
}