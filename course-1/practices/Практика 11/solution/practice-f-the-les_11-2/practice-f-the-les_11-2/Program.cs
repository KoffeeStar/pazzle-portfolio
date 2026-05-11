using System;

public class Car
{
    public string Brand { get; }
    public string Model { get; }
    public int Speed { get; private set; }

    public Car() : this("Неизвестно", "Неизвестно") { }

    public Car(string brand) : this(brand, "Неизвестно") { }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        Speed = 0;
    }

    public void Accelerate()
    {
        Speed += 10;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Brand} {Model}, скорость: {Speed} км/ч");
    }
}