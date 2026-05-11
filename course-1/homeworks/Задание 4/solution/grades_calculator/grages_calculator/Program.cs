using System;

class Program
{
    static void Main()
    {
        int[] grades = { 2, 5, 3, 3, 4, 2, 5 };
        int sum_gr = 0;
        foreach (int grade in grades)
        {
            sum_gr += grade;
        }
        double average_gr = sum_gr / 7;
        Console.WriteLine("Средний балл: " + average_gr);
        int tot_two = 0;
        foreach (int two in grades)
        {
            if (two == 2)
            {
                tot_two++; 
            }
        }
        Console.WriteLine("Кол-во двоек: " + tot_two);
        int tot_five = 0;
        foreach (int five in grades)
        {
            if (five == 2)
            {
                tot_five++;
            }
        }
        Console.WriteLine("Кол-во пятёрок: " + tot_five);
    }
}