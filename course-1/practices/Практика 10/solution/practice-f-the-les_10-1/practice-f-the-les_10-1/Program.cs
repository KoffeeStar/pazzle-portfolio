using System;

class Program
{
    public class Car
    {
        public string Brand { get; set; }
        public int Speed { get; private set; }

        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Accelerate()
        {
            Speed += 10;
        }
    }

    static void Main()
    {
        var car = new Car("BMW", 10);
        car.Accelerate();
        Console.WriteLine($"{car.Brand} едет со скоростью {car.Speed} км/ч");
    }
}