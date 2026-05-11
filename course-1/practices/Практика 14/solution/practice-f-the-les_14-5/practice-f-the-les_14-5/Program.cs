using System;

class Program
{
    static void Main()
    {
        var prices = new Dictionary<string, int>
        {
            { "Кофе", 150 },
            { "Чай", 100 },
            { "Сэндвич", 250 }
        };

        var customers = new Queue<string>();
        customers.Enqueue("Анна");
        customers.Enqueue("Иван");

        var orderItems = new List<string> { "Кофе", "Сэндвич" };

        Console.WriteLine("Обслуживание клиентов:");
        while (customers.Count > 0)
        {
            var client = customers.Dequeue();
            Console.WriteLine($"\nКлиент {client}:");

            int total = 0;
            foreach (var item in orderItems)
            {
                int price = prices[item];
                total += price;
                Console.WriteLine($"  {item} -- {price} руб.");
            }
            Console.WriteLine($"Итого: {total} руб.");
        }
    }
}