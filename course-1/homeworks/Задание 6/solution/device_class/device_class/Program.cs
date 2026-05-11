using System;

class Device
{
    public string Name { get; set; }

    public void TurnOn()
    {
        Console.WriteLine("Устройство включено.");
    }
    public virtual void Beep()
    {
        Console.WriteLine("Устройство подаёт сигнал.");
    }
}

class Kettle : Device
{
    public void Boil()
    {
        Console.WriteLine("Чайник кипятит воду.");
    }
    public override void Beep()
    {
        Console.WriteLine("Чайник пикнул: пи-пи!");
    }
}

class Toaster : Device
{
    public void Toast()
    {
        Console.WriteLine("Тостер поджаривает хлеб.");
    }

    public override void Beep()
    {
        Console.WriteLine("Тостер пикнул: динь!");
    }
}

class Program
{
    static void Main()
    {
        var kettle = new Kettle();
        kettle.Name = "Redmond";
        kettle.TurnOn();
        kettle.Boil();
        kettle.Beep();

        var toaster = new Toaster();
        toaster.Name = "Philips";
        toaster.TurnOn();
        toaster.Toast();

        var k = new Kettle();
        var t = new Toaster();

        k.Beep();
        t.Beep();
    }
}