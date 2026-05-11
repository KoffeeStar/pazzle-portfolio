using System;
using System.IO;

string path = "notes.txt";

File.WriteAllLines(path, new[]
{
    "Заметка 1",
    "Заметка 2",
    "Заметка 3"
});

File.AppendAllText(path, Environment.NewLine + "Заметка 4");

Console.WriteLine("Содержимое файла:");
Console.WriteLine(File.ReadAllText(path));

Console.Write("Удалить файл? (y/n): ");
if (Console.ReadLine()?.Trim().ToLowerInvariant() == "y")
{
    File.Delete(path);
    Console.WriteLine("Файл удалён.");
}