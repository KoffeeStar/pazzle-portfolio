public class Phone
{
    public string Model { get; set; }
    public int Battery { get; private set; } = 0;

    public void Charge(int amount)
    {
        if (amount > 0)
        {
            Battery += amount;
            if (Battery > 100)
                Battery = 100;
        }
    }

    public void Use(int amount)
    {
        if (amount > 0)
        {
            Battery -= amount;
            if (Battery < 0)
                Battery = 0;
        }
    }
}

class Program
{
    static void Main()
    {
        var phone = new Phone { Model = "Samsung Galaxy" };

        phone.Charge(30);
        Console.WriteLine($"Заряд: {phone.Battery}");

        phone.Use(10);
        Console.WriteLine($"Заряд: {phone.Battery}");
    }
}