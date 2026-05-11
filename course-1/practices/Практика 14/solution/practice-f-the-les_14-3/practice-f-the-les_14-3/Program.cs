using System;

class Program
{
    static void Main()
    {
        var clients = new Queue<string>();

        clients.Enqueue("Анна");
        clients.Enqueue("Иван");
        clients.Enqueue("Мария");
        clients.Enqueue("Олег");

        Console.WriteLine($"Первый в очереди: {clients.Peek()}");

        while (clients.Count > 0)
        {
            string c = clients.Dequeue();
            Console.WriteLine($"Обслужен клиент: {c}");
        }
        Console.WriteLine("Очередь пуста");
    }
}