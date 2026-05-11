# Практика №14
Уровень 1
Задание 1. Работа со списками
1. Создайте список чисел.
```
var numbers = new List<int> { 12, 5, 8, 19, 3 };
```
2. Выведите исходный список.
```
Console.WriteLine("Исходный список: " + string.Join(" ", numbers));
```
3. Отсортируйте.
```
numbers.Sort();
Console.WriteLine("Отсортированный: " + string.Join(" ", numbers));
```
4. Найдите минимум и максимум.
```
int min = numbers[0];
int max = numbers[^1]; // последний элемент
Console.WriteLine($"Минимум: {min}, Максимум: {max}");
```
5. Переверните порядок.
```
numbers.Reverse();
Console.WriteLine("После Reverse: " + string.Join(" ", numbers));
```

Задание 2. Работа со словарем
1. Создайте словарь.
```
var phoneBook = new Dictionary<string, string>();
```
2. Добавьте записи.
```
phoneBook.Add("Анна", "8921-123-45-67");
phoneBook.Add("Иван", "8931-555-77-88");
phoneBook.Add("Ольга", "8905-111-22-33");
```
3. Получите телефон существующего контакта.
```
string name = "Иван";
if (phoneBook.ContainsKey(name))
    Console.WriteLine($"Телефон {name}: {phoneBook[name]}");
```
4. Безопасно обратитесь к несуществующему контакту.
```
name = "Пётр";
if (phoneBook.TryGetValue(name, out var phone))
    Console.WriteLine($"Телефон {name}: {phone}");
else
    Console.WriteLine($"Контакт {name} не найден");
```

Задание 3. Работа с очередью
1. Создайте очередь.
```
var clients = new Queue<string>();
```
2. Поставьте в очередь имена.
```
clients.Enqueue("Анна");
clients.Enqueue("Иван");
clients.Enqueue("Мария");
clients.Enqueue("Олег");
```
3. Посмотрите, кто первый.
```
Console.WriteLine($"Первый в очереди: {clients.Peek()}");
```
4. Обслужите всех по порядку.
```
while (clients.Count > 0)
{
    string c = clients.Dequeue();
    Console.WriteLine($"Обслужен клиент: {c}");
}
Console.WriteLine("Очередь пуста");
```

Задание 4. Работа со стеком
1. Создайте стек.
```
var actions = new Stack<string>();
```
2. Добавьте действия.
```
actions.Push("Открыт документ");
actions.Push("Написан текст");
actions.Push("Удалён абзац");
```
3. Посмотрите верхнее действие.
```
Console.WriteLine($"Верхнее действие: {actions.Peek()}");
```
4. Делайте отмену по одному действию.
```
while (actions.Count > 0)
{
    string act = actions.Pop();
    Console.WriteLine($"Отмена действия: {act}");
    Console.WriteLine($"Осталось действий: {actions.Count}");
}
```

Уровень 2
Задание 5. List + Queue + Dictionary
1. Создайте меню с ценами.
```
var prices = new Dictionary<string, int>
{
    { "Кофе", 150 },
    { "Чай", 100 },
    { "Сэндвич", 250 }
};
```
2. Создайте очередь клиентов.
```
var customers = new Queue<string>();
customers.Enqueue("Анна");
customers.Enqueue("Иван");
```
3. Определите список заказа (для примера одинаковый для всех).
```
var orderItems = new List<string> { "Кофе", "Сэндвич" };
```
4. Обслужите каждого клиента и посчитайте сумму.
```
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
```