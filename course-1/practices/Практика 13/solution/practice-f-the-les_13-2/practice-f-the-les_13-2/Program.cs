public abstract class Animal
{
    public string Name { get; }

    protected Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Создано животное по имени {Name}");
    }
    public void Eat() => Console.WriteLine($"{Name} ест.");
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void MakeSound() => Console.WriteLine($"{Name}: Гав-гав!");
}
public class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void MakeSound() => Console.WriteLine($"{Name}: Мяу!");
}