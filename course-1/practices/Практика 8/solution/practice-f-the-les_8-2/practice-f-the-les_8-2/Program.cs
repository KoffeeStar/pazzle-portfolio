using System;

class Program
{
    static void Main()
    {
        int[] grades = { 5, 4, 3, 5, 2, 4 };
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double average = (double)sum / grades.Length;
        Console.WriteLine($"Среднее значение: {average:F2}");
    }
}