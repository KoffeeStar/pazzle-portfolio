public abstract class Transport
{
    public void Drive() => Console.WriteLine("Транспорт движется");
}

public class Car : Transport
{
    protected override void Drive() => Console.WriteLine("Машина едет по дороге.");
}

public class ElectricCar : Transport
{
    protected override void Drive() => Console.WriteLine("Электромобиль тихо едет на батарее");
}