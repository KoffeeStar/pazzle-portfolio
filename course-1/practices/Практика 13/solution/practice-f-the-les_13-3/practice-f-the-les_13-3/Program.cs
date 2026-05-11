public interface Iplayable
{
    void Play();
}

public class Gitar : Iplayable
{
    public void Play()
    {
        Console.WriteLine("Гитара играет аккорды.");
    }
}

public class Piano : Iplayable
{
    public void Play()
    {
        Console.WriteLine("Пианино играет мелодию.");
    }
}

public class Drums : Iplayable
{
    public void Play()
    {
        Console.WriteLine("Барабаны отбивают ритм.");
    }
}

class Program
{
    static void Main()
    {
        Iplayable[] interuments =
        {
            new Gitar(),
            new Piano(),
            new Drums()
        };

        foreach (var i in interuments)
            i.Play();
    }
}