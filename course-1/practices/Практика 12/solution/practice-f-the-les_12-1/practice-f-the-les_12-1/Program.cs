// Задания 1, 2, 3, 4
public class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Создано животное: {Name}");
    }
    public void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }
    public virtual void Speak()
    {
        Console.WriteLine($"{Name} издаёт звук");
    }
    public virtual void Move() => Console.WriteLine("Животное двигается");
}
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        Console.WriteLine($"Создана собака по имени {Name}");
    }


    public void Bark()
    {
        Console.WriteLine($"{Name} лает.");
    }
    public override void Speak()
    {
        Console.WriteLine("Собака говорит: Гав-гав!");
    }
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Собака бежит по дороге.");
    }

}
public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        Console.WriteLine($"Создана кошка по имени {Name}");
    }
    public void Meow()
    {
        Console.WriteLine($"{Name} мяукает.");
    }
    public override void Speak()
    {
        Console.WriteLine("Кошка говорит: Мяу!");
    }
}