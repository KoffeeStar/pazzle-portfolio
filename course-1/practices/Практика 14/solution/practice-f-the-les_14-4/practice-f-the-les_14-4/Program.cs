using System;

class Program
{
    static void Main()
    {
        var actions = new Stack<string>();

        actions.Push("Открыт документ");
        actions.Push("Написан текст");
        actions.Push("Удалён абзац");

        Console.WriteLine($"Верхнее действие: {actions.Peek()}");

        while (actions.Count > 0)
        {
            string act = actions.Pop();
            Console.WriteLine($"Отмена действия: {act}");
            Console.WriteLine($"Осталось действий: {actions.Count}");
        }
    }
}