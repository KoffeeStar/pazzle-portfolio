using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        int counter = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = counter++;
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
