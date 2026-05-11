using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        int counter = 0;
        int Increment()
        {
            counter++;
            return counter;
        }
        Increment();
        Console.WriteLine(counter);
        Increment();
        Console.WriteLine(counter);
        Increment();
        Console.WriteLine(counter);
    }
}