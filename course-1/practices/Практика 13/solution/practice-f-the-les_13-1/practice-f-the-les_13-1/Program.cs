public abstract class Shape
{
    public abstract string Name { get; }
    public abstract double GetArea();

    public void Print()
    {
        Console.WriteLine("${Name}: площадь = {GetArea():F2} ");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius) => Radius = radius;

    public override string Name => "Круг";
    public override double GetArea() => Math.PI * Radius * Radius;
}

public class Rectangle : Shape
{
    public double Widht { get; set; }
    public double Height { get; set; }
    public Rectangle(double widht, double height)
    {
        Widht = widht;
        Height = height;
    }

    public override string Name => "Прямоугольник";
    public override double GetArea() => Widht * Height;
}