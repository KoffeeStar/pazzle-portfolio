using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Multiply(2, 3));
        Console.WriteLine(Multiply(2.5, 4.0));
        Console.WriteLine(Multiply(2, 3, 4));

    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
}