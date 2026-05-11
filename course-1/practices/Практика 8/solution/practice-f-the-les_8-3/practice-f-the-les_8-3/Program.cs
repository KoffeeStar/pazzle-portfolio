using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] numbers2 = new int[8];
        for (int i = 0; i < numbers2.Length; i++)
        {
            numbers2[i] = rand.Next(1, 101);
            Console.Write(numbers2[i] + " ");
        }
        Console.WriteLine();
        int max = numbers2[0];
        for (int i = 1; i < numbers2.Length; i++)
        {
            if (numbers2[i] > max)
                max = numbers2[i];
        }
        Console.WriteLine($"Максимальное число: {max}");
    }
}