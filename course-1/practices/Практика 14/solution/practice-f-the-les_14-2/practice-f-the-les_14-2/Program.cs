using System;

class Program
{
    static void Main()
    {
        var phoneBook = new Dictionary<string, string>();
        phoneBook.Add("Анна", "8921-123-45-67");
        phoneBook.Add("Иван", "8931-555-77-88");
        phoneBook.Add("Ольга", "8905-111-22-33");
        string name = "Иван";
        if (phoneBook.ContainsKey(name))
            Console.WriteLine($"Телефон {name}: {phoneBook[name]}");
        name = "Пётр";
        if (phoneBook.TryGetValue(name, out var phone))
            Console.WriteLine($"Телефон {name}: {phone}");
        else
            Console.WriteLine($"Контакт {name} не найден");
    }
}